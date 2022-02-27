using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
   internal class Alarm:ICalculate
    {
        public void Alarms()
        {
            Console.WriteLine("alarm");
        }

        double ICalculate.Calc()
        {
            throw new NotImplementedException();
        }
    }
}
