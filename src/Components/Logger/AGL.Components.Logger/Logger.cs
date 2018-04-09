using System;
using log4net;
namespace AGL.Components.Logger
{
    /// <summary>
    /// ILogger implementation using Log4net library
    /// </summary>
    public class Logger : ILogger
    {
        private readonly ILog _log;

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        public Logger()
        {
            _log = LogManager.GetLogger(string.Empty);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        /// <param name="namedLogger">Logger name</param>
        public Logger(string namedLogger)
        {
            _log = LogManager.GetLogger(namedLogger);
        }


        /// <summary>
        /// The log exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to be logged.</param>
        public void LogException(string message, Exception exception)
        {
            _log.Error(message, exception);
        }

        /// <summary>
        /// The log info.
        /// </summary>
        /// <param name="message">The message.</param>
        public void LogInfo(string message)
        {
            _log.Info(message);
        }

        /// <summary>
        /// The log warning.
        /// </summary>
        /// <param name="message">The message.</param>
        public void LogWarning(string message)
        {
            _log.Warn(message);
        }

        /// <summary>
        /// The log error.
        /// </summary>
        /// <param name="message">The message.</param>
        public void LogError(string message)
        {
            _log.Error(message);
        }

        /// <summary>
        /// Log debug message
        /// </summary>
        /// <param name="message"></param>
        public void LogDebug(string message)
        {
            _log.Debug(message);
        }


    }
}
