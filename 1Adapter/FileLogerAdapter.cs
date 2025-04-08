using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab3._1Adapter
{
    public class FileLoggerAdapter : ILogger
    {
        private FileWriter fileWriter;

        public FileLoggerAdapter(FileWriter writer)
        {
            fileWriter = writer;
        }

        public void Log(string message)
        {
            fileWriter.WriteLine($"[INFO]: {message}");
        }

        public void Error(string message)
        {
            fileWriter.WriteLine($"[ERROR]: {message}");
        }

        public void Warn(string message)
        {
            fileWriter.WriteLine($"[WARNING]: {message}");
        }
    }
}
