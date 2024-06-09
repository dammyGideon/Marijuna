using Herbzhub.Infrastructure.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Herbzhub.Api.Controllers
{

    public class CountiesController : BaseController
    {
        private readonly ICountiesService _countiesService;
        public CountiesController(ICountiesService countiesService) {
            _countiesService = countiesService;
        }

        [HttpGet("get-counties")]
        public async Task<IActionResult> GetCountries()
        {
            var response = await _countiesService.GetCounties();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-states")]
        public async Task<IActionResult> GetStates()
        {
            var response = await _countiesService.State();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-organization")]
        public async Task<IActionResult> GetManufacturer()
        {
            var response = await _countiesService.RoleType();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-cities")]
        public async Task<IActionResult> GetCities()
        {
            var response = await _countiesService.City();
            return StatusCode((int)response.StatusCode, response);
        }
    }
}
