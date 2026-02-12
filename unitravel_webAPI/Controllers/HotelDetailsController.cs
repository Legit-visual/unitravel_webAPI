using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using unitravel_webAPI.Models.Requests;
using unitravel_webAPI.Models.Responses.HotelDetails;
using unitravel_webAPI.Services.Implementations;
using unitravel_webAPI.Services.Interfaces;

namespace unitravel_webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelDetailsController : ControllerBase
    {
        private readonly IHotelDetailsService _hotelDetailsService;

        public HotelDetailsController(IHotelDetailsService hotelDetailsService)
        {
            _hotelDetailsService = hotelDetailsService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] HotelDetailsRequest request)
        {
            Console.WriteLine(JsonConvert.SerializeObject(request, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
            }));
            var result = await _hotelDetailsService.HotelDetailsAsync(request);

            if (result == null)
            {
                return BadRequest(new { error = "Service returned null (API Error or Deserialization failed)" });
            }

            if (result.HotelDetails == null || result.HotelDetails.Count == 0)
            {
                return Ok(result);
            }

            return Ok(result);
        }
    }
}
