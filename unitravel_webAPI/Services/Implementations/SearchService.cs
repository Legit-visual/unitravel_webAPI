using System.Text;
using Microsoft.Extensions.Options;
using Sprache;
using unitravel_webAPI.Helpers;
using unitravel_webAPI.Models.Requests;
using unitravel_webAPI.Models.Responses;
using unitravel_webAPI.Services.Interfaces;

namespace unitravel_webAPI.Services.Implementations
{
    public class SearchService : ISearchService
    {
        private readonly HttpClient _httpClient;
        private readonly ApiCredentials _credentials;

        public SearchService(HttpClient httpClient, IOptions<ApiCredentials> credentials)
        {
            _httpClient = httpClient;
            _credentials = credentials.Value;
        }

        public async Task<SearchResult?> SearchAsync(SearchRequest request)
        {
            var authBytes = Encoding.ASCII.GetBytes($"{_credentials.Username}:{_credentials.Password}");
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(authBytes));

            var response = await _httpClient.PostAsJsonAsync($"{_credentials.BaseUrl}/Search", request);
            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException($"Error {response.StatusCode}\n{response.Content}");

            SearchResult? result = await response.Content.ReadFromJsonAsync<SearchResult>();
            if (result == null)
            {
                throw new Exception($"API Error: {result?.Status.Description ?? "Unknown error"}");
            }
            
            return result;
        }
    }
}
