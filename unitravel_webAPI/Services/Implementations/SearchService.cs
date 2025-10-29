using Microsoft.OpenApi.Services;
using System.Text;
using unitravel_webAPI.Helpers;
using unitravel_webAPI.Models.Requests;
using unitravel_webAPI.Services.Interfaces;

namespace unitravel_webAPI.Services.Implementations
{
    public class SearchService : ISearchService
    {
        public readonly HttpClient _httpClient;
        private readonly ApiCredentials _credentials;

        public SearchService(HttpClient httpClient, ApiCredentials credentials)
        {
            _httpClient = httpClient;
            _credentials = credentials;
        }

        public async Task<SearchResult?> SearchAsync(SearchRequest request)
        {
            var authBytes = Encoding.ASCII.GetBytes($"{_credentials.Username}:{_credentials.Password}");
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(authBytes));

            var response = await _httpClient.PostAsJsonAsync($"{_credentials.BaseUrl}/Search", request);
            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException($"Error {response.StatusCode}\n{response.Content}");

            return await response.Content.ReadFromJsonAsync<SearchResult>();
        }
    }
}
