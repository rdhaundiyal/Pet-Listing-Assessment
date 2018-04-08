using System.Collections.Generic;
using System.Threading.Tasks;

namespace AGL.Components.Repository
{
    public interface IRepository<T> where T : class
    {
    
        Task<IList<T>> GetAllAsync(string resource);
        IList<T> GetAll(string resource);

    }
}
