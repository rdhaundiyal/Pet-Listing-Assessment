using System.Threading.Tasks;


namespace AGL.Components.Providers.Inteface
{
    public interface IProvider
    {
        T Get<T>(string resourcel) where T : class, new();

        Task<T> GetAsync<T>(string resource) where T : class, new();


    }
}
