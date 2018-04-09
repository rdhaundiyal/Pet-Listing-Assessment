using System;

namespace AGL.Components.Logger
{
    public interface ILogger
    {
        void LogException(string message, Exception exception);
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
        void LogDebug(string message);


    }
}