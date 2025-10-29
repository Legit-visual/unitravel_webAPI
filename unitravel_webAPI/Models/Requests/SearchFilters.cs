namespace unitravel_webAPI.Models.Requests
{
    public class SearchFilters
    {
        public bool Refundable { get; set; }
        public int NumberOfRooms { get; set; }
        public string MealType { get; set; }

        public SearchFilters()
        {
            Refundable = false;
            NumberOfRooms = 0;
            MealType = string.Empty;
        }
    }
}
