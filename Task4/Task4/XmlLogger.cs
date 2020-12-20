using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Task4
{
    class XmlLogger : ILogger
    {
        private readonly ILogOutput _logOutput;

        public XmlLogger(ILogOutput logOutput)
        {
            _logOutput = logOutput;
        }
        public void Log(LogEntry logEntry)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(LogEntry));
            var serializedLogEntry = "";

            using (var sw = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                using (XmlWriter writer = XmlWriter.Create(sw,settings))
                {
                    
                    xmlSerializer.Serialize(writer, logEntry); 
                    serializedLogEntry = sw.ToString(); 
                }
            }

            _logOutput.Save(serializedLogEntry);
        }
    }
}
