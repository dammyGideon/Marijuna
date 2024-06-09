using Herbzhub.Data;
using Herbzhub.Data.Models;
using Herbzhub.Infrastructure.Helper;
using Herbzhub.Infrastructure.Interface;
using Herbzhub.Models.Request;
using Herbzhub.Models.Response;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Security.Cryptography;
using ForgotPasswordRequest = Herbzhub.Models.Request.ForgotPasswordRequest;


namespace Herbzhub.Infrastructure.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly DbApplicationContext _context;
        private readonly ILoggerManager _loggerManager;
        private readonly CreateTokenService _createTokenService;
        private readonly EmailService _emailService;


        public AuthenticationService(DbApplicationContext context,ILoggerManager loggerManager, 
            CreateTokenService createTokenService, EmailService emailService)
        {
            _context = context;
            _loggerManager = loggerManager;
            _createTokenService = createTokenService;
            _emailService = emailService;
        }

        public async Task<BaseResponse<GenericNameResponse>> ForgotPassword(ForgotPasswordRequest request)
        {
            if (string.IsNullOrEmpty(request.Email))
            {
                _loggerManager.LogError("Invalid Email");
                return new BaseResponse<GenericNameResponse>
                {
                    Success = false,
                    Message = "Invalid Email",
                    StatusCode = HttpStatusCode.NotFound
                };
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
            {
                _loggerManager.LogError("This Email Address has not been registered yet");
                return new BaseResponse<GenericNameResponse>
                {
                    Success = false,
                    Message = "This Email Address has not been registered yet",
                    StatusCode = HttpStatusCode.BadRequest
                };
            }

            var resetToken = Guid.NewGuid().ToString();
            user.PasswordResetToken = resetToken;
            user.ResetTokenExpiry = DateTime.UtcNow.AddMinutes(15); 
            await _context.SaveChangesAsync();

         
            var tokenUrl = $"https://dev.herbzhub.com/reset-password?token={resetToken}";
            var appUrl = "HERBZHUB";

            var logoPath = Path.Combine(Directory.GetCurrentDirectory(),"Resource", "logo192.png");
            try
            {
                await _emailService.SendForgotPasswordEmailAsync(user.Email, tokenUrl, appUrl, resetToken,logoPath);
                return new BaseResponse<GenericNameResponse>
                {
                    Success = true,
                    Message = "Password reset email sent successfully.",
                    StatusCode= HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Failed to send password reset email: {ex.Message}");
                return new BaseResponse<GenericNameResponse>
                {
                    Success = false,
                    Message = $"Failed to send password reset email.{ex.Message}",
                    StatusCode = HttpStatusCode.InternalServerError
                };
            }

        }

        public async Task<BaseResponse<GenericNameResponse>> ResetPassword(ResentPasswordRequest request)
        {
            if (string.IsNullOrEmpty(request.Token))
            {
                return new BaseResponse<GenericNameResponse>
                {
                    Success = false,
                    Message = "Token is required",
                    StatusCode = HttpStatusCode.NotFound
                };
            }

            var user = await _context.Users.FirstOrDefaultAsync(d => d.PasswordResetToken == request.Token);

            if (user == null)
            {
                return new BaseResponse<GenericNameResponse>
                {
                    Success = false,
                    Message = "Invalid token",
                    StatusCode = HttpStatusCode.BadRequest
                };
            }

            if (user.ResetTokenExpiry < DateTime.UtcNow)
            {
                return new BaseResponse<GenericNameResponse>
                {
                    Success = false,
                    Message = "Token has expired",
                    StatusCode = HttpStatusCode.BadRequest
                    
                };
            }

            // Proceed with updating the password
            user.HashPassword = PasswordHandler.EncryptPassword(request.Password);
            user.PasswordResetToken = null; // Invalidate the token
            user.ResetTokenExpiry = null;

            await _context.SaveChangesAsync();

            return new BaseResponse<GenericNameResponse>
            {
                Success = true,
                Message = "Password has been reset successfully",
                StatusCode = HttpStatusCode.OK
            };
        }

        public async Task<BaseResponse<AuthResponses>> Login(AuthenticationRequest request)
        {
            var userExist = await _context.Users
                .Include(u => u.UserRole)
                .ThenInclude(u => u.Role)
                .FirstOrDefaultAsync(d => d.Email == request.Email);

            if (userExist == null)
            {
                return new BaseResponse<AuthResponses>
                {
                    Success = false,
                    Message = "This User Does Not Exist",
                    StatusCode = HttpStatusCode.NotFound
                };
            }

            var passwordMatch = PasswordHandler.VerifyPassword(request.Password, userExist.HashPassword);
            if (!passwordMatch)
            {
                _loggerManager.LogError("Password And UserName Wrong");
                return new BaseResponse<AuthResponses>
                {
                    Success = false,
                    Message = "Invalid username or password",
                    StatusCode = HttpStatusCode.BadRequest
                };
            }

            var roles = userExist.UserRole.Select(ur => ur.Role.RoleName);
            var tokenResponse = await _createTokenService.CreateToken(userExist.Id.ToString(), userExist.Email, roles);

            // Generate refresh token
            var refreshToken = GenerateRefreshToken();
            userExist.RefreshToken = refreshToken.Token;
            userExist.RefreshTokenExpiryTime = refreshToken.ExpiryTime;
            await _context.SaveChangesAsync();

            AuthResponses response = new()
            {
                Token = tokenResponse,
                RefreshToken = refreshToken.Token,
                
            };

            return new BaseResponse<AuthResponses>
            {
                Success = true,
                Message = "Login Successful",
                Data = response,
                StatusCode = HttpStatusCode.OK
            };
        }

        private (string Token, DateTime ExpiryTime) GenerateRefreshToken()
        {
            var refreshToken = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
            var expiryTime = DateTime.UtcNow.AddDays(7); // Refresh token valid for 7 days
            return (refreshToken, expiryTime);
        }

        public async Task<BaseResponse<AuthResponses>> RefreshTokenService(UserRefreshTokenRequest request)
        {
            try
            {
                // Find the user by refresh token
                var user = await _context.Users.FirstOrDefaultAsync(d => d.RefreshToken == request.RefreshToken);

                // Check if user is found and if the refresh token is still valid
                if (user == null || user.RefreshTokenExpiryTime <= DateTime.UtcNow)
                {
                    return new BaseResponse<AuthResponses>
                    {
                        Success = false,
                        Message = "Invalid or expired refresh token",
                        StatusCode = HttpStatusCode.Unauthorized
                    };
                }

                // Fetch user roles
                var userRoleIds = await _context.UserRoles
                                                 .Where(d => d.UserId == user.Id)
                                                 .Select(d => d.RoleId)
                                                 .ToListAsync();

                var roles = await _context.Roles
                                          .Where(d => userRoleIds.Contains(d.Id))
                                          .Select(d => d.RoleName)
                                          .ToListAsync();

                // Create new JWT token
                var tokenResponse = await _createTokenService.CreateToken(user.Id.ToString(), user.Email, roles);

                // Generate new refresh token
                var refreshToken = GenerateRefreshToken();
                user.RefreshToken = refreshToken.Token;
                user.RefreshTokenExpiryTime = refreshToken.ExpiryTime;

                // Save changes to the database
                await _context.SaveChangesAsync();

                // Prepare response
                AuthResponses response = new()
                {
                    Token = tokenResponse,
                    RefreshToken = refreshToken.Token,
                };

                return new BaseResponse<AuthResponses>
                {
                    Success = true,
                    Message = "Token refreshed successfully",
                    Data = response,
                    StatusCode = HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                // Log the exception
                // _logger.LogError(ex, "Error occurred while refreshing token");

                return new BaseResponse<AuthResponses>
                {
                    Success = false,
                    Message = "An error occurred while refreshing the token",
                    StatusCode = HttpStatusCode.InternalServerError
                };
            }
        }

    }
}
