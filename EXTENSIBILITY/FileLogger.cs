using System.IO;

namespace EXTENSIBILITY
{
    public class FileLogger : ILogger
    {
        private readonly string path;

        //
        public FileLogger(string path)
        {
            this.path = path;
        }

        public void logError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            // utilisation de using = try  Catch  fanally
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(messageType +" :" + message);
            }
        }
    }
}
