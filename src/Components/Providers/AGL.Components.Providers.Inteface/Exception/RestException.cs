namespace AGL.Components.Providers.Inteface.Exception
{
   public class RestException:System.Exception
    {
        public RestException(string url, string message):base( string.Format("Url: {0} , Message:{1} ",url,message))
        {

        }
    }
}
