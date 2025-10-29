namespace unitravel_webAPI.Models.Requests
{
    public class SearchRequest
    {
        public string CheckIn { get; set; } // using YYYY-MM-DD format for the dates
        public string CheckOut { get; set; } // using YYYY-MM-DD format for the dates
        public List<string> HotelCodes { get; set; } // recommended of 100 codes per list
        public string GuestNationality { get; set; } // using ISO 3166 format (2 letter country codes, for example for Czech nationality - "CZ")
        public List<RoomGuest> PaxRooms { get; set; }
        public int ResponseTime { get; set; } // recommended time is 5-23s for the Search request. After that, give the user timeout
        public bool IsDetailedResponse { get; set; }
        public SearchFilters? SearchFilters { get; set; }

        public SearchRequest(string checkIn, string checkOut, List<string> hotelCodes, string guestNationality, List<RoomGuest> paxRooms, int responseTime, bool isDetailedResponse, SearchFilters? searchFilters)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
            HotelCodes = hotelCodes;
            GuestNationality = guestNationality;
            PaxRooms = paxRooms;
            ResponseTime = responseTime;
            IsDetailedResponse = isDetailedResponse;
            SearchFilters = searchFilters;
        }

        public SearchRequest()
        {
            CheckIn = "1900-01-01";
            CheckOut = "1900-01-02";
            HotelCodes = new List<string>();
            GuestNationality = string.Empty;
            PaxRooms = new List<RoomGuest>();
            ResponseTime = 23;
            IsDetailedResponse = false;
            SearchFilters = null;

        }
    }
}
