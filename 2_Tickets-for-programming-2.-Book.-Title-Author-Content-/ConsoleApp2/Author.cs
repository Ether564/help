using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Author
    {
        private string author; // Приватное поле для хранения названия

        // Конструктор для инициализации поля
        public Author(string author)
        {
            this.author = author;
        }

        public void Show() 
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Голубой цвет текста
            Console.WriteLine("Автор: " + author);
            Console.ResetColor();
        }
    }
}
