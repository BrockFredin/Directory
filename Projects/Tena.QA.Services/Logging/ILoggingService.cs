using System;
using System.IO;

namespace Accenture.DirectoryStatistics.Service.Logging
{
    public interface ILoggingService
    {
        /// <summary>
        ///  Create a logging service which delivers meaningful data I/O style
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        void Log();
    }

    public class LoggingService : ILoggingService
    {
        /// <summary>
        ///     Logging service for adding individual new users and times to log
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public void Log()
        {
            using (var writer = new StreamWriter("C:\\log.txt", true))
            {
                writer.WriteLineAsync("++++++++++");
                writer.WriteLineAsync("DEFECT");
                writer.WriteAsync("test");
                writer.WriteLineAsync(Environment.NewLine + "========");
            }
        }
    }
}