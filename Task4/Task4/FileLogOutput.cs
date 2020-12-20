using System;
using System.Threading.Tasks;
using System.IO;


namespace Task4
{
    internal class FileLogOutput : ILogOutput
    {
        private readonly string filePath;

        public FileLogOutput(string filePath)
        {
            this.filePath = filePath;
        }

        public void Save(string serializedLogEntry)
        {
            using(var sw = new StreamWriter(filePath))
            {
                sw.Write(serializedLogEntry);
            }
        }
    }
}