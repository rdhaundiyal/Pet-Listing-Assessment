
namespace AGL.Components.Providers.Inteface
{
    /// <summary>
    /// Interface used by repositories to get data from rest services, any provider need to implement IProvider interface
    /// </summary>
    public interface IProvider
    {
        T Get<T>(string resourcel) where T : class, new();
 
    }
}
