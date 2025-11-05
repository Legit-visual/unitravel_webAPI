using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class HotelDetailsObject
    {
        [JsonProperty("HotelName")]
        public string HotelName { get; set; }
        [JsonProperty("Rating")]
        public string Rating { get; set; } // check documentation - should be enums
        [JsonProperty("AddressLine1")]
        public string AddressLine1 { get; set; }
        [JsonProperty("AddressLine2")]
        public string AddressLine2 { get; set; }
        [JsonProperty("Map")]
        public string Map {  get; set; }
        [JsonProperty("City")]
        public string City { get; set; }

        public HotelDetailsObject()
        {
            HotelName = string.Empty;
            Rating = string.Empty;
            AddressLine1 = string.Empty;
            AddressLine2 = string.Empty;
            Map = string.Empty;
            City = string.Empty;
        }

        public HotelDetailsObject(string hotelName, string rating, string addressLine1, string addressLine2, string map, string city)
        {
            HotelName = hotelName;
            Rating = rating;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            Map = map;
            City = city;
        }
    }
}
