using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Requests
{
    public class SearchFilters
    {
        [JsonProperty("Refundable")]
        public bool Refundable { get; set; }
        [JsonProperty("NoOfRooms")]
        public int NumberOfRooms { get; set; }
        [JsonProperty("MealType")]
        public string MealType { get; set; }

        public SearchFilters()
        {
            Refundable = false;
            NumberOfRooms = 0;
            MealType = string.Empty;
        }
    }
}
