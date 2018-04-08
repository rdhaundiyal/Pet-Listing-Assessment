using System.Collections.Generic;
using System.Threading.Tasks;
using AGL.Components.Providers.Inteface;
using System;

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

      
    }
}
