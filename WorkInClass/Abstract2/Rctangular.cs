using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2
{
    class Rctangular:Quadrangular
    {
        public double a;
        public double b;
        public double c;
        public double d;
        public double Perimeter()
        {
            int c = a + b + c + d;
        }
    }
}
