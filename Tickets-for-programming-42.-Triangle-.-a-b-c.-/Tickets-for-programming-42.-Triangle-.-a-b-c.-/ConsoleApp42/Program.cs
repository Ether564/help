using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // С типом int
                var triangleInt = new Triangle<int>(3, 4, 5);
                triangleInt.Display();
                Console.WriteLine($"Площадь: {triangleInt.GetArea():F2}\n");

                // С типом uint
                var triangleUint = new Triangle<uint>(6, 8, 10);
                triangleUint.Display();
                Console.WriteLine($"Площадь: {triangleUint.GetArea():F2}\n");

                // С типом double
                var triangleDouble = new Triangle<double>(7.5, 7.5, 7.5);
                triangleDouble.Display();
                Console.WriteLine($"Площадь: {triangleDouble.GetArea():F2}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}