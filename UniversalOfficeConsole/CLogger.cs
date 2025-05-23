using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalOfficeConsole
{
    internal class CLogger
    {
        private string _FilePath;
        public CLogger(string FilePath)
        {
            _FilePath = FilePath;
        }

        public void Log(string text, bool LogToConsole, bool LogToFile)
        {
            const string log_prefix = "[github.com/foxlye] ";
            if (LogToConsole)
                Console.WriteLine($"{log_prefix}{text}");

            if (LogToFile)
                using (StreamWriter sw = new StreamWriter(_FilePath, true))
                    sw.WriteLine($"{log_prefix}{text}");
        }
    }
}
