using System.Collections.Generic;
using Newtonsoft.Json;

namespace AGL.Assessment.Domain.Dto
{
  public  class Person
    {
      [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
      [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }
      [JsonProperty(PropertyName = "age")]
        public int Age { get; set; }
      [JsonProperty(PropertyName = "pets")]
        public List<Pet> Pets { get; set; }
    }

  

    
}
