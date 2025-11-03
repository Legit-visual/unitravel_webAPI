using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using unitravel_webAPI.Models.Requests;
using unitravel_webAPI.Services.Interfaces;

namespace unitravel_webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BookRequest request)
        {
            Console.WriteLine(JsonConvert.SerializeObject(request, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
            }));
            var result = await _bookService.BookAsync(request);
            return Ok(result);
        }
    }
}
