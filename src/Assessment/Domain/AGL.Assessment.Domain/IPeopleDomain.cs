using AGL.Assessment.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AGL.Assessment.Domain
{
    public interface IPeopleDomain
    {
      
        IList<Person> GetOwnersByPetType(string petType);
    }
}
