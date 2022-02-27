using System;

namespace Abstract2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rctangular rectangular = new Rctangular();
            rectangular.a = 5;
            rectangular.b = 4;
            rectangular.c = 3;
            rectangular.d = 2;
            double perimeter = rectangular.Perimeter();
            Console.WriteLine($"{rectangular.GetType()}| Perimeter{perimeter}");
        }
    }
}
