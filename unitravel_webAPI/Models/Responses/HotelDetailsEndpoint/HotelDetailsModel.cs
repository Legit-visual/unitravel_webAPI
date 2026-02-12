using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace unitravel_webAPI.Models.Responses.HotelDetailsEndpoint
{
    // HLAVNÍ OBÁLKA
    public class HotelDetailsResponse
    {
        [JsonProperty("Status")]
        public StatusObject Status { get; set; } = new StatusObject();

        [JsonProperty("hotelDetails")]
        public List<DetailedHotelDetails> HotelDetails { get; set; } = new List<DetailedHotelDetails>();
    }

    public class StatusObject
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    // DETAIL JEDNOHO HOTELU
    public class DetailedHotelDetails
    {
        [JsonProperty("hotelCode")]
        public string HotelCode { get; set; } = "";

        [JsonProperty("hotelName")]
        public string HotelName { get; set; } = "";

        [JsonProperty("description")]
        public string Description { get; set; } = "";

        [JsonProperty("images")]
        public List<string> Images { get; set; } = new List<string>();

        // --- ŘEŠENÍ PRO ZAŠMODRCHANÁ DATA TBO (JToken) ---

        // 1. FACILITIES
        [JsonProperty("hotelFacilities")]
        public JToken FacilitiesRaw { get; set; } // Přijme cokoliv (pole, objekt, null)

        [JsonIgnore] // Toto neposíláme do JSONu, jen pro vnitřní logiku C#
        public List<string> HotelFacilities
        {
            get
            {
                if (FacilitiesRaw == null || FacilitiesRaw.Type == JTokenType.Null) return new List<string>();
                if (FacilitiesRaw.Type == JTokenType.Array) return FacilitiesRaw.ToObject<List<string>>() ?? new List<string>();
                if (FacilitiesRaw.Type == JTokenType.Object) return FacilitiesRaw.Values<string>().ToList();
                return new List<string>();
            }
        }

        // 2. ATTRACTIONS
        [JsonProperty("attractions")]
        public JToken AttractionsRaw { get; set; }

        [JsonIgnore]
        public Dictionary<string, string> Attractions
        {
            get
            {
                if (AttractionsRaw == null || AttractionsRaw.Type == JTokenType.Null) return new Dictionary<string, string>();

                if (AttractionsRaw.Type == JTokenType.Object)
                    return AttractionsRaw.ToObject<Dictionary<string, string>>() ?? new Dictionary<string, string>();

                if (AttractionsRaw.Type == JTokenType.Array)
                {
                    var dict = new Dictionary<string, string>();
                    int i = 1;
                    foreach (var item in AttractionsRaw)
                    {
                        dict[$"{i})"] = item.ToString();
                        i++;
                    }
                    return dict;
                }
                return new Dictionary<string, string>();
            }
        }

        // --- REST OF PROPERTIES ---
        [JsonProperty("address")] public string Address { get; set; } = "";
        [JsonProperty("pinCode")] public string PinCode { get; set; } = "";
        [JsonProperty("cityId")] public string CityId { get; set; } = "";
        [JsonProperty("countryName")] public string CountryName { get; set; } = "";
        [JsonProperty("phoneNumber")] public string PhoneNumber { get; set; } = "";
        [JsonProperty("faxNumber")] public string FaxNumber { get; set; } = "";
        [JsonProperty("map")] public string Map { get; set; } = "";

        // Změněno na object, aby to sneslo string i int a nepadalo
        [JsonProperty("hotelRating")] public object HotelRating { get; set; }

        [JsonProperty("cityName")] public string CityName { get; set; } = "";
        [JsonProperty("countryCode")] public string CountryCode { get; set; } = "";
        [JsonProperty("checkInTime")] public string CheckInTime { get; set; } = "";
        [JsonProperty("checkOutTime")] public string CheckOutTime { get; set; } = "";
    }
}
