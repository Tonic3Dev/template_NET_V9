using Newtonsoft.Json;

namespace template_net_9.DTOs.Employees
{
    public class AddressDTO
    {
        public string Street { get; set; }

        [JsonProperty("altura")]
        public string Number { get; set; }

        public string Floor { get; set; }

        [JsonProperty("number")]
        public string Department { get; set; }
    }
}
