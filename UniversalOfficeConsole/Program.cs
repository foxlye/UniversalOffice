using System;
using UniversalOfficeLibrary;

namespace UniversalOfficeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "UniversalOffice";
            CLogger logger = new CLogger("log.txt");
            Console.ReadKey();
        }
    }
}
