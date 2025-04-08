using System;
using System.IO;
using System.Text.RegularExpressions;

namespace KPZ_lab3._4Proxy
{
    public class SmartTextReaderLocker : ITextReader
    {
        private SmartTextChecker _checker;
        private Regex _denyPattern;

        public SmartTextReaderLocker(string pattern)
        {
            _checker = new SmartTextChecker();
            _denyPattern = new Regex(pattern);
        }

        public char[][] ReadFile(string filePath)
        {
            string fileName = Path.GetFileName(filePath);

            Console.WriteLine($"[Locker] Trying to open file: {fileName}");

            if (_denyPattern.IsMatch(fileName))
            {
                Console.WriteLine("Access denied!");
                return null;
            }

            Console.WriteLine($"[Locker] File allowed: {fileName}");
            return _checker.ReadFile(filePath);
        }
    }
}


