using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите тип документа (xml, txt, doc): ");
            string type = Console.ReadLine();

            AbstractHandler handler;

            if (type == "xml")
            {
                handler = new XMLHandler();
            }
            else if (type == "txt")
            {
                handler = new TXTHandler();
            }
            else if (type == "doc")
            {
                handler = new DOCHandler();
            }
            else
            {
                Console.WriteLine("Неизвестный формат");
                return;
            }

            handler.Open();
            handler.Create();
            handler.Chenge();
            handler.Save();

            Console.ReadKey();
        }
    }
}
