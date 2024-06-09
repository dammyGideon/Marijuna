using Herbzhub.Data;
using Herbzhub.Data.Models;
using Herbzhub.Infrastructure.Helper;
using Herbzhub.Infrastructure.Interface;
using Herbzhub.Models.Request;
using Microsoft.EntityFrameworkCore;
using System.Net;


namespace Herbzhub.Infrastructure.Services
{
    public class ManufacturerService : IManufacturerService
    {
       
      
        private readonly DbApplicationContext _context;

        public ManufacturerService(DbApplicationContext context) { 
            _context = context;
          
        }
        public async Task<BaseResponse<string>> CreateManufacturer(ManufactureRequest request)
        {
            if (request.Password != request.ConfirmPassword)
            {
                return new BaseResponse<string>
                {
                    Success = false,
                    Message = "Your passwords do not match.",
                    StatusCode = HttpStatusCode.BadRequest
                };
            }

            var password = PasswordHandler.EncryptPassword(request.Password);

            var emailExist = await _context.Users.AnyAsync(u => u.Email == request.Email);
            if (emailExist)
            {
                return new BaseResponse<string>
                {
                    Success = false,
                    Message = "User with this email already exists.",
                    StatusCode = HttpStatusCode.Conflict
                };
            }

            var businessDetailsExist = await _context.ManufacturerDispensaries.AnyAsync(x => x.StateLicenseNumber == request.StateLicense);
            if (businessDetailsExist)
            {
                return new BaseResponse<string>
                {
                    Success = false,
                    Message = "The license number you entered already exists.",
                    StatusCode = HttpStatusCode.Conflict
                };
            }

            var businessNameExist = await _context.ManufacturerDispensaries.AnyAsync(x => x.LegalBusinessName == request.BusinessDetails.BusinessName);
            if (businessNameExist)
            {
                return new BaseResponse<string>
                {
                    Success = false,
                    Message = "A business with this name already exists.",
                    StatusCode = HttpStatusCode.Conflict
                };
            }

            // Check if StateId exists in the States table
            var stateExists = await _context.States.AnyAsync(s => s.Id == request.BusinessDetails.BusinessState);
            if (!stateExists)
            {
                return new BaseResponse<string>
                {
                    Success = false,
                    Message = "The specified state does not exist.",
                    StatusCode = HttpStatusCode.NotFound
                };
            }

            var countyExists = await _context.Counties.AnyAsync(c => c.Id == request.CountiesId);
            if (!countyExists)
            {
                return new BaseResponse<string>
                {
                    Success = false,
                    Message = "The specified county does not exist.",
                    StatusCode = HttpStatusCode.NotFound
                };
            }

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    User userDetails = new()
                    {
                        Email = request.Email,
                        HashPassword = password,
                    };
                    _context.Users.Add(userDetails);
                    await _context.SaveChangesAsync();

                    UserRole userRole = new()
                    {
                        UserId = userDetails.Id,
                        RoleId = request.roleId
                    };
                    _context.UserRoles.Add(userRole);
                    await _context.SaveChangesAsync();

                    PersonalIdentification personalIdentification = new()
                    {
                        FirstName = request.FirstName,
                        LastName = request.LastName,
                        PhoneNumber = request.PhoneNumber,
                        Address = request.AddressRequest.streetAddress,
                        CityId = request.AddressRequest.usersCity,
                        StateId = request.AddressRequest.usersState,
                        ZipCode = request.AddressRequest.userZipCode,
                        userId = userDetails.Id,
                        CountiesId = request.CountiesId
                    };
                    _context.PersonalIdentifications.Add(personalIdentification);
                    await _context.SaveChangesAsync();

                    ManufacturerDispensary dispensary = new()
                    {
                        StateLicenseNumber = request.StateLicense,
                        LegalBusinessName = request.BusinessDetails.BusinessName,
                        BusinessEIN = request.BusinessDetails.BusinessEIN,
                        BusinessEmail = request.BusinessDetails.BusinessEmail,
                        BusinessContact = request.BusinessDetails.BusinessContact,
                        BusinessAddress = request.BusinessDetails.BusinessAddress,
                        BusinessCityId = request.BusinessDetails.BusinessCity,
                        BusinessStateId = request.BusinessDetails.BusinessState, // Make sure this exists
                        BusinessZipCode = request.BusinessDetails.BusinessZipCode,
                        PersonalIdentificationId = personalIdentification.Id,
                        SerialNumber = request.SerialNumber
                    };
                    _context.ManufacturerDispensaries.Add(dispensary);
                    await _context.SaveChangesAsync();

                    await transaction.CommitAsync();

                    return new BaseResponse<string>
                    {
                        Success = true,
                        Message = "User created successfully.",
                        StatusCode = HttpStatusCode.Created,
                        Data = userDetails.Id.ToString()
                    };
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    // Log the detailed exception

                    return new BaseResponse<string>
                    {
                        Success = false,
                        Message = $"An error occurred: {ex.Message} - {ex.InnerException?.Message ?? "No inner exception"}",
                        StatusCode = HttpStatusCode.InternalServerError
                    };
                }
            }
        }

    }
}
