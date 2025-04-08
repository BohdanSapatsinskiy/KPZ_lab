using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab3._4Proxy
{
    public class SmartTextChecker : ITextReader
    {
        private SmartTextReader _reader;

        public SmartTextChecker()
        {
            _reader = new SmartTextReader();
        }

        public char[][] ReadFile(string filePath)
        {
            Console.WriteLine($"[Checker] Opening file: {filePath}");

            char[][] result = _reader.ReadFile(filePath);

            Console.WriteLine($"[Checker] File read successfully.");
            Console.WriteLine($"[Checker] Closing file: {filePath}");

            int lineCount = result.Length;
            int charCount = result.Sum(line => line.Length);

            Console.WriteLine($"[Checker] Total lines: {lineCount}");
            Console.WriteLine($"[Checker] Total characters: {charCount}");

            return result;
        }
    }

}
