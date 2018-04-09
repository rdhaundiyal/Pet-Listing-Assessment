using System.Collections.Generic;

namespace AGL.Components.Repository
{
    public interface IRepository<T> where T : class
    {
        IList<T> GetAll(string resource);

    }
}
