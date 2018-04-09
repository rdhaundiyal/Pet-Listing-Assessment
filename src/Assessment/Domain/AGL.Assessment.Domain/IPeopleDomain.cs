using AGL.Assessment.Domain.Dto;
using System.Collections.Generic;

namespace AGL.Assessment.Domain
{
    public interface IPeopleDomain
    {
      IList<Person> GetOwnersByPetType(string petType);
    }
}
