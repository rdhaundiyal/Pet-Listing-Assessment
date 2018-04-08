using AGL.Assessment.Domain.Dto;
using AGL.Assessment.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AGL.Assessment.Domain.Helpers;

namespace AGL.Assessment.Domain
{
    public class PeopleDomain : IPeopleDomain
    {
        private readonly IPeopleRepository _peopleRepository;
        public PeopleDomain(IPeopleRepository peopleRepository)
        {

            _peopleRepository = peopleRepository;
        }
     

        public IList<Person> GetPeople()
        {
            return _peopleRepository.GetAll(ConfigSettings.PeopleServiceUri);
        }

        public IList<Person> GetOwnersByPetType(string petType)
        {
            var result = _peopleRepository.GetAll(ConfigSettings.PeopleServiceUri);

            return result.Where(person => person.pets != null && person.pets.Any(p => p.type.Equals(petType, StringComparison.InvariantCultureIgnoreCase))).ToList();
        }

      




    }
}
