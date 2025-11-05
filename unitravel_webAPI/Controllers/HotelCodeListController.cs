using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using unitravel_webAPI.Services.Implementations;
using unitravel_webAPI.Services.Interfaces;

namespace unitravel_webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelCodeListController : ControllerBase
    {
        private readonly IHotelCodeListService _hotelCodeListService;

        public HotelCodeListController(IHotelCodeListService hotelCodeListService)
        {
            _hotelCodeListService = hotelCodeListService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _hotelCodeListService.HotelCodeListAsync();
            return Ok(result);
        }
    }
}
