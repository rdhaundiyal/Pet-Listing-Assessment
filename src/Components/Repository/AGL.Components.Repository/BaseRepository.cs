using System.Collections.Generic;
using System.Threading.Tasks;
using AGL.Components.Providers.Inteface;
using AGL.Components.Providers.Inteface.Exception;

namespace AGL.Components.Repository
{
    public abstract class BaseRepository<T> where T : class
    {
        private readonly IProvider _serviceProvider;

        protected BaseRepository(IProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public virtual IList<T> GetAll(string resource)
        {
           
                return _serviceProvider.Get<List<T>>(resource);
       
        }
     
        public virtual Task<IList<T>> GetAllAsync(string resource)
        {
      var result=  _serviceProvider.GetAsync<List<T>>(resource);

            return null;
        }


    }
}
