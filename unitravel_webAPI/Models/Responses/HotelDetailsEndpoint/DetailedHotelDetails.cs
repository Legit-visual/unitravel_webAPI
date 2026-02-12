using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using unitravel_webAPI.Helpers;
using unitravel_webAPI.Helpers.unitravel_webAPI.Helpers;

namespace unitravel_webAPI.Models.Responses.HotelDetails
{
    public class DetailedHotelDetails
    {
        [JsonProperty("hotelCode")]
        public string HotelCode { get; set; }
        
        [JsonProperty("hotelName")]
        public string HotelName { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }

        // --- IMAGES (Necháme List<string>, v logu vypadá OK) ---
        [JsonProperty("images")]
        public List<string> Images { get; set; }

        [JsonProperty("hotelFacilities")]
        [JsonConverter(typeof(DebugTboConverter))]
        public List<string> HotelFacilities { get; set; } = new List<string>();

        [JsonProperty("attractions")]
        [JsonConverter(typeof(DebugTboConverter))]
        public Dictionary<string, string> Attractions { get; set; } = new Dictionary<string, string>();

        [JsonProperty("address")] public string Address { get; set; }
        [JsonProperty("pinCode")] public string PinCode { get; set; }
        [JsonProperty("cityId")] public string CityId { get; set; }
        [JsonProperty("countryName")] public string CountryName { get; set; }
        [JsonProperty("phoneNumber")] public string PhoneNumber { get; set; }
        [JsonProperty("faxNumber")] public string FaxNumber { get; set; }
        [JsonProperty("map")] public string Map { get; set; }
        
        // ZMĚNA NA STRING (PRO JISTOTU)
        [JsonProperty("hotelRating")] public string HotelRating { get; set; } 
        
        [JsonProperty("cityName")] public string CityName { get; set; }
        [JsonProperty("countryCode")] public string CountryCode { get; set; }
        [JsonProperty("checkInTime")] public string CheckInTime { get; set; }
        [JsonProperty("checkOutTime")] public string CheckOutTime { get; set; }

        public DetailedHotelDetails()
        {
            HotelCode = string.Empty;
            HotelName = string.Empty;
            Description = string.Empty;
            Images = new List<string>();
            Address = string.Empty;
            PinCode = string.Empty;
            CityId = string.Empty;
            CountryName = string.Empty;
            PhoneNumber = string.Empty;
            FaxNumber = string.Empty;
            Map = string.Empty;
            HotelRating = string.Empty;
            CityName = string.Empty;
            CountryCode = string.Empty;
            CheckInTime = string.Empty;
            CheckOutTime = string.Empty;
        }
    }
}
