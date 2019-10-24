using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0, B = 0, C = 0, x1 = 0, x2 = 0;
            Console.Title = "Калашникова А.В.; ИУ5-34Б";
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Введите первый коэффициент A: ");
            string str = Console.ReadLine();
            bool ConvertResult = double.TryParse(str, out A);
            if (ConvertResult)
            {
                Console.WriteLine("Вы ввели число " + A.ToString("F5"));
                
            }
            else
            {
                bool ConvRes;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите значение коэффициента A заново: ");
                    string str0 = Console.ReadLine();
                    ConvRes = double.TryParse(str0, out A);
                } while (ConvRes == false);
                Console.WriteLine("Вы ввели число " + A.ToString("F5"));
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Введите второй коэффициент B: ");
            string str1 = Console.ReadLine();
            bool ConvRes1 = double.TryParse(str1, out B);
            if (ConvRes1)
            {
                Console.WriteLine("Вы ввели число " + B.ToString("F5"));
            }
            else
            {
                bool ConvRes2;
                do
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите значение коэффициента B заново: ");
                    string str0 = Console.ReadLine();
                    ConvRes2 = double.TryParse(str0, out B);
                } while (ConvRes2 == false);
                Console.WriteLine("Вы ввели число " + B.ToString("F5"));
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Введите третий коэффициент C: ");
            string str2 = Console.ReadLine();
            bool ConvRes3 = double.TryParse(str2, out C);
            if (ConvRes3)
            {
                Console.WriteLine("Вы ввели число " + C.ToString("F5"));
            }
            else
            {
                bool ConvRes4;
                do
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите значение коэффициента C заново: ");
                    string str0 = Console.ReadLine();
                    ConvRes4 = double.TryParse(str0, out C);
                }
                while (ConvRes4 == false);
                Console.WriteLine("Вы ввели число " + C.ToString("F5"));
            }

            if (A == 0) 
            {
                if (B != 0)
                {
                    if (C == 0)
                    {
                        Console.WriteLine("Корень = 0");
                    }
                    else
                    {
                        if (C / B < 0)
                        {
                            double x01 = Math.Sqrt(Math.Abs(C / B));
                            double x02 = -Math.Sqrt(Math.Abs(C / B));
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Первый корень= " + x01);
                            Console.WriteLine("Второй корень= " + x02);

                        }
                        else
                        {
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Корней нет");
                        }
                    }
                }
                else
                {

                    if (C != 0)
                    {
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней в биквадратном уравнении нет");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Корень в биквадратном уравнении - любое число");
                    }
                }
            }

            
            else
            {
                double D = B * B - 4*A*C;
                if (D < 0)
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней в биквадратном уравнении нет");
                }
                else
                {
                    x1 = (-B + Math.Sqrt(D)) / (2 * A);
                    x2 = (-B - Math.Sqrt(D)) / (2 * A);
                    if (x1 > 0)
                    {
                        double x01 = Math.Sqrt(x1);
                        double x02 = - Math.Sqrt(x1);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Первый корень = " + x01);
                        Console.WriteLine("Второй корень = " + x02);
                        if (x2 > 0)
                        {
                            double x03 = Math.Sqrt(x2);
                            double x04 = -Math.Sqrt(x2);
                            Console.WriteLine("Третий корень = " + x03);
                            Console.WriteLine("Четвертый корень = " + x04);
                        }
                    }
                    else
                    if (x2 > 0)
                    {
                        double x03 = Math.Sqrt(x2);
                        double x04 = -Math.Sqrt(x2);
                        Console.WriteLine("Первый корень = " + x03);
                        Console.WriteLine("Второй корень = " + x04);
                    }
                }
            }


        }
        string s = Console.ReadLine();
    }
}

