using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text;
using unitravel_webAPI.Helpers;
using unitravel_webAPI.Models.Requests;
using unitravel_webAPI.Models.Responses;
using unitravel_webAPI.Services.Interfaces;

namespace unitravel_webAPI.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly HttpClient _httpClient;
        private readonly ApiCredentials _credentials;

        public BookService(HttpClient httpClient, IOptions<ApiCredentials> credentials)
        {
            _httpClient = httpClient;
            _credentials = credentials.Value;
        }

        public async Task<BookResult?> BookAsync(BookRequest request)
        {
            var authBytes = Encoding.ASCII.GetBytes($"{_credentials.Username}:{_credentials.Password}");
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(authBytes));

            //var response = await _httpClient.PostAsJsonAsync($"{_credentials.BaseUrl}/Search", request);
            var json = JsonConvert.SerializeObject(request, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
            });
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_credentials.BaseUrl}/Book", content);

            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException($"Error {response.StatusCode}\n{response.Content}");

            /*
            SearchResult? result = await response.Content.ReadFromJsonAsync<SearchResult>();
            if (result == null)
            {
                throw new Exception($"API Error: {result?.Status.Description ?? "Unknown error"}");
            }
            */
            var raw = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<BookResult>(raw);

            return result;
        }
    }
}
