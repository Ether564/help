using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    public class Triangle<T> where T : struct, IConvertible
    {
        // Поля
        private T a;
        private T b;
        private T c;

        // Конструктор
        public Triangle(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Свойства с логикой: нельзя установить отрицательное или нулевое значение
        public T A
        {
            get => a;
            set
            {
                if (IsPositive(value)) a = value;
                else throw new ArgumentException("Сторона должна быть положительной.");
            }
        }

        public T B
        {
            get => b;
            set
            {
                if (IsPositive(value)) b = value;
                else throw new ArgumentException("Сторона должна быть положительной.");
            }
        }

        public T C
        {
            get => c;
            set
            {
                if (IsPositive(value)) c = value;
                else throw new ArgumentException("Сторона должна быть положительной.");
            }
        }

        // Метод проверки положительности
        private bool IsPositive(T value)
        {
            return Convert.ToDouble(value) > 0;
        }

        // Метод: вывод информации
        public void Display()
        {
            Console.WriteLine($"Треугольник со сторонами: a = {a}, b = {b}, c = {c}");
        }

        // Метод: расчёт площади (формула Герона)
        public double GetArea()
        {
            double sideA = Convert.ToDouble(a);
            double sideB = Convert.ToDouble(b);
            double sideC = Convert.ToDouble(c);

            double s = (sideA + sideB + sideC) / 2;
            double areaSquared = s * (s - sideA) * (s - sideB) * (s - sideC);

            if (areaSquared < 0)
            {
                throw new InvalidOperationException("Невозможно вычислить площадь: некорректные стороны.");
            }

            return Math.Sqrt(areaSquared);
        }
    }
}
