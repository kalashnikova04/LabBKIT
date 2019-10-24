using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    abstract class GeomFig
    {
        string type;
        public string Type
        {
            protected set
            {
                this.type = value;
            }
            get
            {
                return this.type;
            }
        }

        public abstract double Area();
       
    }
}
