using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Requests
{
    public class SearchRequest
    {
        [JsonProperty("CheckIn")]
        public string CheckIn { get; set; } // using YYYY-MM-DD format for the dates
        [JsonProperty("CheckOut")]
        public string CheckOut { get; set; } // using YYYY-MM-DD format for the dates
        [JsonProperty("HotelCodes")]
        public string HotelCodes { get; set; } // recommended of 100 codes per list
        [JsonProperty("GuestNationality")]
        public string GuestNationality { get; set; } // using ISO 3166 format (2 letter country codes, for example for Czech nationality - "CZ")
        [JsonProperty("PaxRooms")]
        public List<RoomGuest> PaxRooms { get; set; }
        [JsonProperty("ResponseTime")]
        public int ResponseTime { get; set; } // recommended time is 5-23s for the Search request. After that, give the user timeout
        [JsonProperty("IsDetailedResponse")]
        public bool IsDetailedResponse { get; set; }
        [JsonProperty("Filters")]
        public SearchFilters? Filters { get; set; }

        public SearchRequest(string checkIn, string checkOut, string hotelCodes, string guestNationality, List<RoomGuest> paxRooms, int responseTime, bool isDetailedResponse, SearchFilters? searchFilters)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
            HotelCodes = hotelCodes;
            GuestNationality = guestNationality;
            PaxRooms = paxRooms;
            ResponseTime = responseTime;
            IsDetailedResponse = isDetailedResponse;
            Filters = searchFilters;
        }

        public SearchRequest()
        {
            CheckIn = "1900-01-01";
            CheckOut = "1900-01-02";
            HotelCodes = string.Empty;
            GuestNationality = string.Empty;
            PaxRooms = new List<RoomGuest>();
            ResponseTime = 23;
            IsDetailedResponse = false;
            Filters = null;

        }
    }
}
