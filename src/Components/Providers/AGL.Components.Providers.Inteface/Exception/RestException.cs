namespace AGL.Components.Providers.Inteface.Exception
{
    /// <summary>
    /// Custom exception class to encapsulate any error occuring 
    /// while retreiving data from rest service
    /// </summary>
   public class RestException:System.Exception
    {
        public RestException(string url, string message):base( string.Format("Url: {0} - Message:{1} ",url,message))
        {

        }
    }
}
