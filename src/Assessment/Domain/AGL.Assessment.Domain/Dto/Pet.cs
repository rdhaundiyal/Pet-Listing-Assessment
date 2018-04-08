using Newtonsoft.Json;

namespace AGL.Assessment.Domain.Dto
{
    public class Pet
    {
         [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
         [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
