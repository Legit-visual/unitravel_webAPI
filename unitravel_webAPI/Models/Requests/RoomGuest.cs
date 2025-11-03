using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Requests
{
    public class RoomGuest
    {
        [JsonProperty("Adults")]
        public int Adults { get; set; }
        [JsonProperty("Children")]
        public int Children { get; set; }
        [JsonProperty("ChildrenAges")]
        public List<int>? ChildrenAges { get; set; }

        public RoomGuest(int numberOfAdults, int numberOfChildren, List<int>? childrenAges)
        {
            Adults = numberOfAdults;
            Children = numberOfChildren;
            ChildrenAges = childrenAges;
        }

        public RoomGuest()
        {
            Adults = 0;
            Children = 0;
            ChildrenAges = null;
        }
    }
}
