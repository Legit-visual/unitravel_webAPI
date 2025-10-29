using Microsoft.AspNetCore.Mvc;
using unitravel_webAPI.Models.Requests;
using unitravel_webAPI.Services.Interfaces;

namespace unitravel_webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SearchRequest request)
        {
            var result = await _searchService.SearchAsync(request);
            return Ok(result);
        }
    }
}
