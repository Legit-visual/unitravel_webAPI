using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text;
using unitravel_webAPI.Helpers;
using unitravel_webAPI.Models.Responses;
using unitravel_webAPI.Services.Interfaces;

namespace unitravel_webAPI.Services.Implementations
{
    public class HotelCodeListService : IHotelCodeListService
    {
        private readonly HttpClient _httpClient;
        private readonly ApiCredentials _credentials;

        public HotelCodeListService(HttpClient httpClient, IOptions<ApiCredentials> credentials)
        {
            _httpClient = httpClient;
            _credentials = credentials.Value;
        }

        public async Task<HotelCodeListResponse?> HotelCodeListAsync()
        {
            var authBytes = Encoding.ASCII.GetBytes($"{_credentials.Username}:{_credentials.Password}");
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(authBytes));

            var response = await _httpClient.GetAsync($"{_credentials.BaseUrl}/hotelcodelist");

            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException($"Error {response.StatusCode}\n{response.Content}");

            var raw = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<HotelCodeListResponse>(raw);

            return result;
        }
    }
}
