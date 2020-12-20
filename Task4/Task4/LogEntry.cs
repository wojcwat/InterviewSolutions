using System;

namespace Task4
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
        public string[] Tags { get; set; }
    }
}
