using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Circle : GeomFig, IPrint
    {
        double radius;
        public Circle(double r)
        {
            this.radius = r;
            this.Type = "Круг";
        }
        public override double Area()
        {
            return System.Math.PI * this.radius * this.radius;
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
