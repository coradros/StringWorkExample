using System;
using StringWorkLibrary;

namespace StringWorkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ГЛАВ123РЫБА56, 60");
            Console.WriteLine("ГАЗ4ПРОМ5БАНК97, 15");
            Console.WriteLine("ААА123БББ11, 95 pro");

            Console.WriteLine(StringWorker.StringIncrementor("ГЛАВ123РЫБА56", 60));
            Console.WriteLine(StringWorker.StringIncrementor("ГАЗ4ПРОМ5БАНК97", 15));
            Console.WriteLine(StringWorker.StringIncrementor("ААА123БББ11", 95, true));
        }
    }
}
