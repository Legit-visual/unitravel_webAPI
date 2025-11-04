using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using unitravel_webAPI.Models.Requests;
using unitravel_webAPI.Services.Interfaces;

namespace unitravel_webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CancelController : ControllerBase
    {
        private readonly ICancelService _cancelService;

        public CancelController(ICancelService cancelService)
        {
            _cancelService = cancelService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CancelRequest request)
        {
            Console.WriteLine(JsonConvert.SerializeObject(request, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
            }));
            var result = await _cancelService.CancelAsync(request);
            return Ok(result);
        }
    }
}
