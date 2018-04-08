using System.Collections.Generic;

namespace AGL.Assessment.Domain.Dto
{
  public  class Person
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public List<Pet> pets { get; set; }
    }

  

    
}
