using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text;
using unitravel_webAPI.Helpers;
using unitravel_webAPI.Models.Requests;
using unitravel_webAPI.Models.Responses;
using unitravel_webAPI.Models.Responses.HotelDetails;
using unitravel_webAPI.Services.Interfaces;

namespace unitravel_webAPI.Services.Implementations
{
    public class HotelDetailsService : IHotelDetailsService
    {
        private readonly HttpClient _httpClient;
        private readonly ApiCredentials _credentials;
        private readonly IMemoryCache _cache;

        public HotelDetailsService(HttpClient httpClient, IOptions<ApiCredentials> credentials, IMemoryCache cache)
        {
            _httpClient = httpClient;
            _credentials = credentials.Value;
            _cache = cache;
        }

        public async Task<HotelDetailsResponse?> HotelDetailsAsync(HotelDetailsRequest request)
        {
            if (request == null) return null;
            string cacheKey = $"Details_{request.HotelCodes}_{request.Language}";

            // 1. Zkusíme najít v cache
            if (_cache.TryGetValue(cacheKey, out HotelDetailsResponse? cachedResult))
            {
                if (cachedResult != null)
                {
                    Console.WriteLine($"[CACHE HIT] Vracím data z paměti: {cacheKey}");
                    return cachedResult;
                }
            }

            // 2. Pokud není v cache, stahujeme
            var authBytes = Encoding.ASCII.GetBytes($"{_credentials.Username}:{_credentials.Password}");
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(authBytes));


            var json = JsonConvert.SerializeObject(request, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync($"{_credentials.BaseUrl}/HotelDetails", content);

                // Přečteme odpověď
                var raw = await response.Content.ReadAsStringAsync();

                // 3. Deserializace (s ignorováním chyb)
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                var apiResult = JsonConvert.DeserializeObject<HotelDetailsResponse>(raw, settings);

                // 4. Kontrola výsledku
                if (apiResult == null)
                {
                    Console.WriteLine($"[TBO ERROR] Deserializace vrátila NULL. Raw délka: {raw.Length}");
                    Console.WriteLine($"[JSON START] {raw.Substring(0, Math.Min(raw.Length, 100))}");
                    return null;
                }

                if (apiResult.Status == null)
                {
                    Console.WriteLine($"[TBO ERROR] Status objekt je NULL! (Špatné mapování JSON?)");
                    return null;
                }

                if (apiResult.Status.Code == 500)
                {
                    Console.WriteLine($"[TBO API ERROR] {apiResult.Status.Description}");
                    return null;
                }

                if (apiResult.HotelDetails == null || apiResult.HotelDetails.Count == 0)
                {
                    Console.WriteLine($"[TBO WARNING] HotelDetails seznam je prázdný, ale Status je OK.");
                }

                // 5. Uložení do Cache (JEN POKUD TO NENÍ NULL)
                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromHours(24))
                    .SetPriority(CacheItemPriority.Low);

                _cache.Set(cacheKey, apiResult, cacheOptions);

                Console.WriteLine($"[CACHE SAVE] Uloženo do paměti: {cacheKey}");
                return apiResult;
            }
            catch (JsonSerializationException jsonEx)
            {
                Console.WriteLine($"[JSON ERROR] Path: {jsonEx.Path} | Line: {jsonEx.LineNumber} | Message: {jsonEx.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[FATAL ERROR] {ex.Message}");
                return null;
            }
        }
    }
}
