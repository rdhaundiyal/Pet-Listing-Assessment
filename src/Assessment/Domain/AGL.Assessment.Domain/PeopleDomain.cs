using AGL.Assessment.Domain.Dto;
using AGL.Assessment.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AGL.Assessment.Domain.Exceptions;
using AGL.Assessment.Domain.Helpers;
using AGL.Components.Providers.Inteface.Exception;

namespace AGL.Assessment.Domain
{
    public class PeopleDomain : IPeopleDomain
    {
        private readonly IPeopleRepository _peopleRepository;
        public PeopleDomain(IPeopleRepository peopleRepository)
        {

            _peopleRepository = peopleRepository;
        }
     
   

        public IList<Person> GetOwnersByPetType(string petType)
        {
            try
            {
                var result = _peopleRepository.GetAll(ConfigSettings.PeopleServiceUri);
                if (result== null) return null;
                return
                    result.Where(
                        person =>
                            person.Pets != null &&
                            person.Pets.Any(p => p.Type.Equals(petType, StringComparison.InvariantCultureIgnoreCase)))
                        .ToList();
            }
            catch (RestException ex)
            {
                throw new AssessmentException();
            }
            catch (Exception ex)
            {
                throw new AssessmentException();
            }
        }

      
    }
}
