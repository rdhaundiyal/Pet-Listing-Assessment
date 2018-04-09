using System;

namespace AGL.Components.Logger
{
    /// <summary>
    /// Empty Logger doesn't log anything
    /// </summary>
    public class EmptyLogger : ILogger
    {
        public void LogDebug(string message)
        {
            
        }

        public void LogError(string message)
        {
            
        }

        public void LogException(string message, Exception exception)
        {
            
        }

        public void LogInfo(string message)
        {
           
        }

        public void LogWarning(string message)
        {
           
        }
    }
}
