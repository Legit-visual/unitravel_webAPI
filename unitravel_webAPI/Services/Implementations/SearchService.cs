using System.Text;
using Microsoft.Extensions.Caching.Memory;
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
        private readonly IMemoryCache _cache;

        public SearchService(HttpClient httpClient, IOptions<ApiCredentials> credentials, IMemoryCache cache)
        {
            _httpClient = httpClient;
            _credentials = credentials.Value;
            _cache = cache;
        }

        public async Task<SearchResult?> SearchAsync(SearchRequest request)
        {
            if(request == null) return null;

            string cacheKey = $"Search_{request.CheckIn}_{request.CheckOut}_{request.GuestNationality}_{JsonConvert.SerializeObject(request.PaxRooms)}";

            var result = await _cache.GetOrCreateAsync(cacheKey, async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(15);
                entry.Priority = CacheItemPriority.Normal;

                Console.WriteLine($"[CACHE MISS] Stahuji data z TBO pro: {cacheKey}");


                var authBytes = Encoding.ASCII.GetBytes($"{_credentials.Username}:{_credentials.Password}");
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(authBytes));

                if (!_httpClient.DefaultRequestHeaders.Contains("Accept-Encoding"))
                {
                    _httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
                }

                if (request.Filters != null && request.Filters.MealType != null)
                    Validate.MealType(request.Filters.MealType);

                var json = JsonConvert.SerializeObject(request, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Formatting.None,
                });

                var content = new StringContent(json, Encoding.UTF8, "application/json");;

                var response = await _httpClient.PostAsync($"{_credentials.BaseUrl}/Search", content);

                if (!response.IsSuccessStatusCode)
                    throw new HttpRequestException($"Error {response.StatusCode}\n{await response.Content.ReadAsStringAsync()}");

                var raw = await response.Content.ReadAsStringAsync();

                var bytes = await response.Content.ReadAsByteArrayAsync();
                string rawString = "";

                if (bytes.Length > 2 && bytes[0] == 0x1f && bytes[1] == 0x8b)
                {
                    Console.WriteLine("[VAROVÁNÍ] Odpověď je GZIP komprimovaná, ale HttpClient ji nerozbalil automaticky!");
                    // Zde bychom to mohli manuálně rozbalit, ale lepší je nastavit správně HttpClient (viz Krok 2)
                }

                rawString = System.Text.Encoding.UTF8.GetString(bytes);

                try
                {
                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };

                    var apiResult = JsonConvert.DeserializeObject<SearchResult>(rawString, settings);

                    if (apiResult == null) return null;

                    return apiResult;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[CRITICAL SEARCH ERROR]: {ex.Message}");

                    int len = Math.Min(rawString.Length, 200);
                    Console.WriteLine($"[RAW RESPONSE START]: {rawString.Substring(0, len)}");

                    return null;
                }
            });

            Console.WriteLine($"[CACHE SERVED] Vracím výsledek pro: {cacheKey}");
            return result;
        }
    }
}
