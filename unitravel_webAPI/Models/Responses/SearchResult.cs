namespace unitravel_webAPI.Models.Responses
{
    public class SearchResult
    {
        public StatusObject Status { get; set; }
        public List<HotelResult>? HotelResults { get; set; }

        public SearchResult()
        {
            Status = new StatusObject();
            HotelResults = null;
        }
    }


}
