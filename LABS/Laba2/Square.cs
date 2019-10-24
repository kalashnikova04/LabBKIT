using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Square : Rectangle
    {
        public Square(double a)
            : base(a, a)
        {
            this.Type = "Квадрат";
        }
        public override string ToString()
        {
            return this.Type + " имеет площадь = " + this.Area();
        }
    }
}
