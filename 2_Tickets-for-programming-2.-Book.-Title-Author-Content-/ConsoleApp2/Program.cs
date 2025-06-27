using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект книги
            Book book = new Book();
            // Устанавливаем данные
            book.SetTitle("Программирование на C#");
            book.SetAuthor("Иван Петрович");
            book.SetContent("Изучение языка программирования C# для новичков.");
            book.Show();

            Console.ReadKey();
        }
    }
}
