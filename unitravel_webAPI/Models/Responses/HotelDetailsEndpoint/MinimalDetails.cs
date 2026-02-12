namespace unitravel_webAPI.Models.Responses.HotelDetailsEndpoint
{
    public class MinimalDetails
    {
        public StatusObject Status { get; set; }
        public List<MinimalHotel> HotelDetails { get; set; }
    }
    public class MinimalHotel
    {
        public string HotelCode { get; set; }
    }
}
