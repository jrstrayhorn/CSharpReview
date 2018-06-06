using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, nameof(MessageType.ERROR));
        }

        public void LogInfo(string message)
        {
            Log(message, nameof(MessageType.INFO));
        }

        private void Log(string message, string messageType)
        {
            // compiler includes a call to dispose method to release 
            // external resources not managed by CLR
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"{messageType}: {message}");
            }
        }

        
    }
}
