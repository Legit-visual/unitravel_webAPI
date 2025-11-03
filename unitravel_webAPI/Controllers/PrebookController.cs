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
    public class PrebookController : ControllerBase
    {
        private readonly IPrebookService _prebookService;

        public PrebookController(IPrebookService prebookService)
        {
            _prebookService = prebookService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PrebookRequest request)
        {
            Console.WriteLine(JsonConvert.SerializeObject(request, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
            }));
            var result = await _prebookService.PrebookAsync(request);
            return Ok(result);
        }
    }
}
