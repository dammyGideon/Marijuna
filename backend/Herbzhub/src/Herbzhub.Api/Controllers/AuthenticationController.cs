using Herbzhub.Infrastructure.Interface;
using Herbzhub.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using ForgotPasswordRequest = Herbzhub.Models.Request.ForgotPasswordRequest;

namespace Herbzhub.Api.Controllers
{
    
    public class AuthenticationController : BaseController
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService) {
            _authenticationService = authenticationService;
        }

        [HttpPost("user-login")]
        public async Task<IActionResult> Login(AuthenticationRequest request)
        {
            var response = await _authenticationService.Login(request);
            return StatusCode((int)response.StatusCode, response);
        }
        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshLogin(UserRefreshTokenRequest request)
        {
            var response = await _authenticationService.RefreshTokenService(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("forgot-password")]
        
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest request)
        {
            var response = await _authenticationService.ForgotPassword(request);
            return Ok(response);
        }
        [HttpPost("reset-password")]

        public async Task<IActionResult> ResetPassword(ResentPasswordRequest request)
        {
            var response = await _authenticationService.ResetPassword(request);
            return Ok(response);
        }

    }
}
