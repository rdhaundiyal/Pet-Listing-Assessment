using System.Collections.Generic;
using System.Threading.Tasks;

namespace AGL.Components.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get(string resource);
        Task<T> GetAsync(string resource);
        IList<T> GetAll(string resource);

    }
}
