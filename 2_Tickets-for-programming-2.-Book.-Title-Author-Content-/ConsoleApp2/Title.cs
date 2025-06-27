using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Title
    {
        private string title; // Приватное поле для хранения названия

        // Конструктор для инициализации поля
        public Title(string title)
        {
            this.title = title;
        }
       
        public void Show()  // Выводит название книги с цветом
        {
            Console.ForegroundColor = ConsoleColor.Green; // Зеленый цвет текста
            Console.WriteLine("Название книги: " + title);
            Console.ResetColor(); // Сброс цвета обратно
        }
    }
}
