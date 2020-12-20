using System;
using System.Threading.Tasks;

namespace Task4
{
    public class Tester4
    {
        public void Test()
        {
            var fileLogOutput = new FileLogOutput("D:\\log.txt");
            var logger = new JsonLogger(fileLogOutput);
            logger.Log(new LogEntry() { Message = "test", Tags = new[] { "t1", "t2" }, Timestamp = DateTime.UtcNow });

            var consoleLogOutput = new ConsoleLogOutput();
            var logger2 = new XmlLogger(consoleLogOutput);
            logger2.Log(new LogEntry() { Message = "test", Tags = new[] { "t1", "t2" }, Timestamp = DateTime.UtcNow });
        }
    }
}
