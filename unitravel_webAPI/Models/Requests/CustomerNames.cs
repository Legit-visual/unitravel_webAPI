using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Requests
{
    public class CustomerNames
    {
        [JsonProperty("Title")]
        public string Title { get; set; }
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }
        [JsonProperty("LastName")]
        public string LastName { get; set; }
        [JsonProperty("Type")]
        public string Type { get; set; }

        public CustomerNames()
        {
            Title = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Type = string.Empty;
        }

        public CustomerNames(string title, string firstName, string lastName, string type)
        {
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            Type = type;
        }
    }
}
