using System;
using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string path;

        public enum MessageType 
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
            Log(message, (MessageType) 0);
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
