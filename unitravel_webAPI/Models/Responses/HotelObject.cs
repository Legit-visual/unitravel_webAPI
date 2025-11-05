using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class HotelObject
    {
        [JsonProperty("HotelCode")]
        public string HotelCode { get; set; }
        [JsonProperty("HotelName")]
        public string HotelName { get; set; }
        [JsonProperty("HotelRating")]
        public string HotelRating { get; set; }
        [JsonProperty("Address")]
        public string Address { get; set; }
        [JsonProperty("Attractions")]
        public List<string> Attractions { get; set; }
        [JsonProperty("CountryName")]
        public string CountryName { get; set; }
        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }
        [JsonProperty("Description")]
        public string Description { get; set; }
        [JsonProperty("FaxNumber")]
        public string FaxNumber { get; set; }
        [JsonProperty("HotelFacilities")]
        public List<string> HotelFacilities { get; set; }
        [JsonProperty("Map")]
        public string Map {  get; set; }
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonProperty("PinCode")]
        public string PinCode { get; set; }
        [JsonProperty("HotelWebsiteUrl")]
        public string HotelWebsiteUrl { get; set; }
        [JsonProperty("CityName")]
        public string CityName { get; set; }

        public HotelObject()
        {
            HotelCode = string.Empty;
            HotelName = string.Empty;
            HotelRating = string.Empty;
            Address = string.Empty;
            Attractions = new List<string>();
            CountryName= string.Empty;
            CountryCode = string.Empty;
            Description = string.Empty;
            FaxNumber = string.Empty;
            HotelFacilities = new List<string>();
            Map = string.Empty;
            PhoneNumber = string.Empty;
            PinCode = string.Empty;
            HotelWebsiteUrl = string.Empty;
            CityName = string.Empty;
        }

        public HotelObject(string hotelCode, string hotelName, string hotelRating, string address, List<string> attractions, string countryName, string countryCode, string description, string faxNumber, List<string> hotelFacilities, string map, string phoneNumber, string pinCode, string hotelWebsiteUrl, string cityName)
        {
            HotelCode = hotelCode;
            HotelName = hotelName;
            HotelRating = hotelRating;
            Address = address;
            Attractions = attractions;
            CountryName = countryName;
            CountryCode = countryCode;
            Description = description;
            FaxNumber = faxNumber;
            HotelFacilities = hotelFacilities;
            Map = map;
            PhoneNumber = phoneNumber;
            PinCode = pinCode;
            HotelWebsiteUrl = hotelWebsiteUrl;
            CityName = cityName;
        }
    }
}
