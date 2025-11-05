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
    public class HotelBookingDetailBasedOnDateController : ControllerBase
    {
        private readonly IHotelBookingDetailsBasedOnDateService _service;

        public HotelBookingDetailBasedOnDateController(IHotelBookingDetailsBasedOnDateService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] HotelBookingDetailBasedOnDateRequest request)
        {
            Console.WriteLine(JsonConvert.SerializeObject(request, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
            }));
            var result = await _service.HotelBookingDetailsAsync(request);
            return Ok(result);
        }
    }
}
