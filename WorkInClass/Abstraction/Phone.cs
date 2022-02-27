using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Phone:ICalculate
    {
        public void Call(string phoneNumber)
        {
            Console.WriteLine($"Call to {phoneNumber}");
        }
        public void Start()
        {
            Console.WriteLine($"Call started");
        }
        public void End()
        {
            Console.WriteLine("Ended");
        }

        public double Calc()
        {
            throw new NotImplementedException();
        }
        public void Alarm()
        {
            throw new ArgumentOutOfRangeException();
        }
       
    }
}
