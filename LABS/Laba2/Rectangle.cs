using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Rectangle : GeomFig, IPrint
    {
        double width;
        double hight;
        public Rectangle(double w, double h)
        {
            this.hight = h;
            this.width = w;
            this.Type = "Прямоугольник";
        }
        public override double Area()
        {
            return this.hight * this.width;
        }
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(this.ToString());
            Console.ResetColor();
        }
        public override string ToString()
        {
            return this.Type + " имеет площадь = " + this.Area();
        }
    }
}
