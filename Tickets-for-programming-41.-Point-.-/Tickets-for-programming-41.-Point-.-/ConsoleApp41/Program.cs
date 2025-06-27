using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            // Тестирование с int
            Point<int> pointInt = new Point<int>(5, 10);
            pointInt.Display();

            // Тестирование с uint
            Point<uint> pointUint = new Point<uint>(15u, 25u);
            pointUint.Display();

            // Тестирование с double
            Point<double> pointDouble = new Point<double>(3.14, 2.71);
            pointDouble.Display();

            Console.ReadKey();
        }
    }
}


