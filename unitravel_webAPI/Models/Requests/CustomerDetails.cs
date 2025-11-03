using Newtonsoft.Json;

namespace unitravel_webAPI.Models.Requests
{
    public class CustomerDetails
    {
        [JsonProperty("CustomerNames")]
        public List<CustomerNames> CustomerNames { get; set; }

        public CustomerDetails()
        {
            CustomerNames = new List<CustomerNames>();
        }

        public CustomerDetails(List<CustomerNames> customerNames)
        {
            CustomerNames = customerNames;
        }
    }
}
