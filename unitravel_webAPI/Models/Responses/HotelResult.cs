namespace unitravel_webAPI.Models.Responses
{
    public class HotelResult
    {
        public string HotelCode { get; set; }
        public string Currency {  get; set; }
        public List<HotelRooms>? HotelRooms { get; set; }

        public HotelResult()
        {
            HotelCode = string.Empty;
            Currency = string.Empty;
            HotelRooms = null;
        }

        public HotelResult(string hotelCode, string currency, List<HotelRooms>? hotelRooms)
        {
            HotelCode = hotelCode;
            Currency = currency;
            HotelRooms = hotelRooms;
        }
    }
}
