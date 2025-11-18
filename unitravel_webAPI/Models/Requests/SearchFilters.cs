using Newtonsoft.Json;
using System.Text.Json.Serialization;
using unitravel_webAPI.Models.Responses;

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
        public string PaxType { get; set; }

        public SearchFilters()
        {
            Refundable = false;
            NumberOfRooms = 0;
            MealType = string.Empty;
            PaxType = string.Empty;
        }
        public SearchFilters(bool refundable, int numberOfRooms, string mealType, string paxType)
        {
            Refundable = refundable;
            NumberOfRooms = numberOfRooms;
            MealType = mealType;
            PaxType = paxType;
        }
    }
}
