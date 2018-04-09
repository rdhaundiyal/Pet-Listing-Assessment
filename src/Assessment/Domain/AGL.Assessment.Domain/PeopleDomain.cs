using AGL.Assessment.Domain.Dto;
using AGL.Assessment.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using AGL.Assessment.Domain.Exceptions;
using AGL.Assessment.Domain.Helpers;
using AGL.Components.Logger;
using AGL.Components.Providers.Inteface.Exception;

namespace AGL.Assessment.Domain
{
    public class PeopleDomain : IPeopleDomain
    {
        private readonly IPeopleRepository _peopleRepository;
        private readonly ILogger _logger;
        public PeopleDomain(IPeopleRepository peopleRepository,ILogger logger)
        {
            _peopleRepository = peopleRepository;
            _logger = logger;
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
                _logger.LogError(ex.Message);
                throw new AssessmentException();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new AssessmentException();
            }
        }

      
    }
}
