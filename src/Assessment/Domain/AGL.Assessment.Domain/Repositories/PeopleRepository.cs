using AGL.Components.Repository;
using AGL.Assessment.Domain.Dto;
using AGL.Components.Providers.Inteface;

namespace AGL.Assessment.Domain.Repositories
{
   public class PeopleRepository: BaseRepository<Person>,IPeopleRepository
    {
        //public PeopleRepository(string baseUrl,IProvider provider):base(baseUrl,provider)
        //{

        //}
        public PeopleRepository(IProvider provider)
            : base(provider)
        {

        }

    }
}
