using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace unitravel_webAPI.Models.Responses
{
    public class StatusObject
    {
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }

        public StatusObject()
        {
            Code = 400;
            Description = "Object created, but not used properly.";
        }

        public StatusObject(int code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}
