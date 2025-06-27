using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    public class Point<T>
    {
        // Внутренние поля
        private T x;
        private T y;

        // Конструктор
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        // Свойства доступа
        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        // Метод вывода значений
        public void Display()
        {
            Console.WriteLine($"Точка: X = {x}, Y = {y}");
        }
    }
}
