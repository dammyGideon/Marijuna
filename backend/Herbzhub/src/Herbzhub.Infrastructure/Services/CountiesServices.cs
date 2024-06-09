using Herbzhub.Data;
using Herbzhub.Infrastructure.Helper;
using Herbzhub.Infrastructure.Interface;
using Herbzhub.Models.Response;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Herbzhub.Infrastructure.Services
{
    public class CountiesServices : ICountiesService
    {
        private readonly DbApplicationContext _context;
        public CountiesServices(DbApplicationContext dbApplicationContext) {
            _context = dbApplicationContext;
        }

        public async Task<BaseResponse<List<GenericNameResponse>>> GetCounties()
        {
            var counties = await _context.Counties.ToListAsync();
            var response = counties.Select(c => new GenericNameResponse
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();

            return new BaseResponse<List<GenericNameResponse>>(true, "Counties retrieved successfully", response, HttpStatusCode.OK);
        }

        public async Task<BaseResponse<List<GenericNameResponse>>> State()
        {
            var state = await _context.States.ToListAsync();

            var response = state.Select(s => new GenericNameResponse
            {
                Id = s.Id,
                Name = s.Name,
            }).ToList();
            return new BaseResponse<List<GenericNameResponse>>(true,"State retrieved successfully",response,HttpStatusCode.OK);
        }


        public async Task<BaseResponse<List<GenericNameResponse>>> RoleType()
        {
            var roles = await _context.Roles
                .Where(d => d.RoleName == "Manufacturer" || d.RoleName == "Dispensary" ||d.RoleName=="Transporter")
                .ToListAsync();

            var response = roles.Select(c => new GenericNameResponse
            {
                Id = c.Id,
                Name = c.RoleName
            }).ToList();

            return new BaseResponse<List<GenericNameResponse>>
            {
                Data = response,
                Success = true,
                Message = "Roles retrieved successfully.",
                StatusCode =HttpStatusCode.OK,
            };
        }

        public async Task<BaseResponse<List<GenericNameResponse>>> City()
        {
            var city = await _context.cities.ToListAsync();
            var result = city.Select(c => new GenericNameResponse
            {
                Id = c.Id,
                Name=c.Name,

            }).ToList();
            return new BaseResponse<List<GenericNameResponse>> {
                Data = result,
                Success = true,
                Message = "City retrieved successfully.",
                StatusCode =HttpStatusCode.OK,
            };
        }
    }
}
