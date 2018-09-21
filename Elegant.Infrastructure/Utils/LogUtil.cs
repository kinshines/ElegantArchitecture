using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElegantArchitecture.Infrastructure.Utils
{
    public class LogUtil
    {
        private static ILogger _logger;
        private static ILoggerFactory _factory;
        public static void UtilConfigure(ILoggerFactory factory)
        {
            _factory = factory;
            _logger = _factory.CreateLogger<LogUtil>();
        }

        public static void Info(string message, params object[] args)
        {
            _logger.LogInformation(message, args);
        }

        public static void Trace(string message, params object[] args)
        {
            _logger.LogTrace(message, args);
        }

        public static void Error(string message, params object[] args)
        {
            _logger.LogError(message, args);
        }

        public static void Error(Exception ex, string message, params object[] args)
        {
            _logger.LogError(ex, message, args);
        }
        public static void Error(Exception ex)
        {
            _logger.LogError(ex, "");
        }
    }
}
