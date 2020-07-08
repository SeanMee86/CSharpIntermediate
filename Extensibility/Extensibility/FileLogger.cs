using System;
using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string path;

        private enum MessageType 
        {
            Error,
            Info
        }

        public FileLogger(string path)
        {
            this.path = path;
        }
        public void LogError(string message)
        {
            Log(message, MessageType.Error);
        }

        public void LogInfo(string message)
        {
            Log(message, MessageType.Info);
        }

        private void Log(string message, Enum messageType)
        {
            using (var streamWriter = new StreamWriter(this.path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}
