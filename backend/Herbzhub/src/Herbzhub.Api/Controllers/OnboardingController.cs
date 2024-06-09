using Herbzhub.Infrastructure.Interface;
using Herbzhub.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Herbzhub.Api.Controllers
{
   
    public class OnboardingController : BaseController
    {
        
      
        private readonly IManufacturerService _manufacturerService;
        private readonly ICountiesService _countiesService;
        public OnboardingController(IManufacturerService manufacturerService, ICountiesService countiesService)
        {
            _manufacturerService = manufacturerService;
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


        [HttpPost("onboarding")]
        public async Task<IActionResult> ManufacturerOnboarding(ManufactureRequest request)
        {
            var response = await _manufacturerService.CreateManufacturer(request);
            return StatusCode((int)response.StatusCode, response);
        }


     
    }
}
