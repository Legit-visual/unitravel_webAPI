using System.Text;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
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
            if(request == null) return null;

            var authBytes = Encoding.ASCII.GetBytes($"{_credentials.Username}:{_credentials.Password}");
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(authBytes));

            if(request.Filters != null && request.Filters.MealType != null)
                Validate.MealType(request.Filters.MealType);
            // Validate other request parameters as needed

            /*
            if (request.Filters != null && request.Filters.PaxType != null)
                Validate.PaxType(request.Filters.PaxType);

            if (request.Filters != null && request.Filters.MealPlan != null)
                Validate.MealPlan(request.Filters.MealPlan);

            if (request.Filters != null && request.Filters.StarRating != null)
                Validate.StarRating(request.Filters.StarRating);

            if (request.Filters != null && request.Filters.BookingStatus != null)
                Validate.BookingStatus(request.Filters.BookingStatus);

            if (request.Filters != null && request.Filters.BookingType != null)
                Validate.BookingType(request.Filters.BookingType);          
            */

            //var response = await _httpClient.PostAsJsonAsync($"{_credentials.BaseUrl}/Search", request);
            var json = JsonConvert.SerializeObject(request, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
            });
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_credentials.BaseUrl}/Search", content);

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
            var result = JsonConvert.DeserializeObject<SearchResult>(raw);
            
            return result;
        }
    }
}
