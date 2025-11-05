using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class CityObject
    {
        [JsonProperty("Code")]
        public string Code { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }

        public CityObject()
        {
            Code = string.Empty;
            Name = string.Empty;
        }

        public CityObject(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
