using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Responses
{
    public class CountryObject
    {
        [JsonProperty("Code")]
        public string Code { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }

        public CountryObject()
        {
            Code = string.Empty;
            Name = string.Empty;
        }

        public CountryObject(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
