using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses.HotelDetails
{
    public class Attraction
    {
        [JsonProperty("1) ")]
        public string AttractionId { get; set; }

        public Attraction()
        {
            AttractionId = string.Empty;
        }

        public Attraction(string attractionId)
        {
            AttractionId = attractionId;
        }
    }
}
