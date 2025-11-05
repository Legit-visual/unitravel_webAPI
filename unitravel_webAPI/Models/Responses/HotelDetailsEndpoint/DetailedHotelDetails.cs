using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses.HotelDetails
{
    public class DetailedHotelDetails
    {
        [JsonProperty("HotelCode")]
        public string HotelCode { get; set; }
        [JsonProperty("HotelName")]
        public string HotelName { get; set; }
        [JsonProperty("Description")]
        public string Description { get; set; }
        [JsonProperty("HotelFacilities")]
        public List<string> HotelFacilities { get; set; }
        [JsonProperty("Attractions")]
        public Attraction Attractions { get; set; }
        [JsonProperty("Images")]
        public List<string> Images { get; set; }
        [JsonProperty("Address")]
        public string Address { get; set; }
        [JsonProperty("PinCode")]
        public string PinCode { get; set; }
        [JsonProperty("CityId")]
        public string CityId { get; set; }
        [JsonProperty("CountryName")]
        public string CountryName { get; set; }
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonProperty("FaxNumber")]
        public string FaxNumber { get; set; }
        [JsonProperty("Map")]
        public string Map {  get; set; }
        [JsonProperty("HotelRating")]
        public int HotelRating { get; set; }
        [JsonProperty("CityName")]
        public string CityName { get; set; }
        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }
        [JsonProperty("CheckInTime")]
        public string CheckInTime { get; set; }
        [JsonProperty("CheckOutTime")]
        public string CheckOutTime { get; set; }

        public DetailedHotelDetails()
        {
            HotelCode = string.Empty;
            HotelName = string.Empty;
            Description = string.Empty;
            HotelFacilities = new List<string>();
            Attractions = new Attraction();
            Images = new List<string>();
            Address = string.Empty;
            PinCode = string.Empty;
            CityId = string.Empty;
            CountryName = string.Empty;
            PhoneNumber = string.Empty;
            FaxNumber = string.Empty;
            Map = string.Empty;
            HotelRating = 0;
            CityName = string.Empty;
            CountryCode = string.Empty;
            CheckInTime = string.Empty;
            CheckOutTime = string.Empty;
        }

        public DetailedHotelDetails(string hotelCode, string hotelName, string description, List<string> hotelFacilities, Attraction attractions, List<string> images, string address, string pinCode, string cityId, string countryName, string phoneNumber, string faxNumber, string map, int hotelRating, string cityName, string countryCode, string checkInTime, string checkOutTime)
        {
            HotelCode = hotelCode;
            HotelName = hotelName;
            Description = description;
            HotelFacilities = hotelFacilities;
            Attractions = attractions;
            Images = images;
            Address = address;
            PinCode = pinCode;
            CityId = cityId;
            CountryName = countryName;
            PhoneNumber = phoneNumber;
            FaxNumber = faxNumber;
            Map = map;
            HotelRating = hotelRating;
            CityName = cityName;
            CountryCode = countryCode;
            CheckInTime = checkInTime;
            CheckOutTime = checkOutTime;
        }
    }
}
