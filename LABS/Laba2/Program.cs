using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Program
    {
        static int Menu()
        {
            int a;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Фигуры:");
            Console.WriteLine("1. Прямоугольник");
            Console.WriteLine("2. Квадрат");
            Console.WriteLine("3. Круг");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите фигуру для вычисления площади:");
            string ans = Console.ReadLine();
            Console.ResetColor();
            int.TryParse(ans, out a);
            return a;

        }
        static double Continue(string prov)
        {
            double x = 0;
            do Console.Write(prov);
            while (!double.TryParse(Console.ReadLine(), out x));
            return x;
        }
        static bool NextStep()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nПродолжать? (y/n): ");
            string ans = Console.ReadLine();
            return !(ans == "n");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Калашникова А.В.; ИУ5-34Б");
            Console.ResetColor();
            IPrint obj;
            double h, w;
            do
            {
                switch (Menu())
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        h = Continue("Введите длину прямоугольника: \n");
                        w = Continue("Введите ширину прямоугольника: \n");
                        obj = new Rectangle(h, w);
                        obj.Print();
                        Console.ResetColor();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        h = Continue("Введите сторону квадрата: \n");
                        obj = new Square(h);
                        obj.Print();
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        h = Continue("Введите радиус окружности: \n");
                        obj = new Circle(h);
                        obj.Print();
                        Console.ResetColor();
                        break;
                    case 4:
                        Environment.Exit(0);
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }
            } while (NextStep());

        }
    }
    interface IPrint
    {
        void Print();
    }
}
