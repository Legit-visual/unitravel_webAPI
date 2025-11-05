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
    public class CitylistController : ControllerBase
    {
        private readonly ICityListService _cityListService;

        public CitylistController(ICityListService cityListService)
        {
            _cityListService = cityListService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CityListRequest request)
        {
            Console.WriteLine(JsonConvert.SerializeObject(request, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
            }));
            var result = await _cityListService.CityListAsync(request);
            return Ok(result);
        }
    }
}
