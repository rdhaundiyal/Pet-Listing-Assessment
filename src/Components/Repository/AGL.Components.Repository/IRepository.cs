using System.Collections.Generic;
using System.Threading.Tasks;

namespace AGL.Components.Repository
{
    public interface IRepository<T> where T : class
    {
    
          IList<T> GetAll(string resource);

    }
}
