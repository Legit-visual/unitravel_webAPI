using Microsoft.OpenApi.Services;
using unitravel_webAPI.Models.Requests;

namespace unitravel_webAPI.Services.Interfaces
{
    public interface ISearchService
    {
        Task<SearchResult?> SearchAsync(SearchRequest request);
    }
}
