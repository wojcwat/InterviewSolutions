using System.Text.Json;

namespace Task4
{
    public class JsonLogger : ILogger
    {
        private readonly ILogOutput _logOutput;

        public JsonLogger(ILogOutput logOutput)
        {
            _logOutput = logOutput;
        }

        public void Log(LogEntry logEntry)
        {
            var serializedLogEntry = JsonSerializer.Serialize(logEntry);
            _logOutput.Save(serializedLogEntry);
        }
    }
}
