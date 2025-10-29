using Microsoft.OpenApi.Services;
using unitravel_webAPI.Models.Requests;
using SearchResult = unitravel_webAPI.Models.Responses.SearchResult;

namespace unitravel_webAPI.Services.Interfaces
{
    public interface ISearchService
    {
        Task<SearchResult?> SearchAsync(SearchRequest request);
    }
}
