using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using unitravel_webAPI.Models.Requests;
using unitravel_webAPI.Services.Implementations;
using unitravel_webAPI.Services.Interfaces;

namespace unitravel_webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryListController : ControllerBase
    {
        private readonly ICountryListService _countryListService;

        public CountryListController(ICountryListService countryListService)
        {
            _countryListService = countryListService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _countryListService.CountryListAsync();
            return Ok(result);
        }
    }
}
