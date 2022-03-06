using APP.STUDENT_SYSTEM.Infrastructure;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.STUDENT_SYSTEM.Managers
{
    public static class ScanerManager
    {
        public static int ReadInteger(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.Green;
            if (!int.TryParse(Console.ReadLine(), out int value))
            {
                PrintError("duzgun melumat deyil, yeniden cehd edin");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }
        public static double ReadDouble(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.Green;
            if (!double.TryParse(Console.ReadLine(), out double value))
            {
                PrintError("duzgun melumat deyil, yeniden cehd edin");

                goto l1;
            }
            Console.ResetColor();
            return value;
        }
        public static string ReadString(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.Green;
            string value = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(value))
            {
                PrintError("duzgun melumat deyil, yeniden cehd edin");

                goto l1;
            }
            Console.ResetColor();
            return value;
        }
        public static DateTime ReadDate(string caption)
        {
        l1:
            Console.Write($"{caption} [dd.MM.yyyy]");
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.Green;
            if (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, DateTimeStyles.None, out DateTime value))
            {
                PrintError("duzgun melumat deyil, yeniden cehd edin");

                goto l1;
            }
            Console.ResetColor();
            return value;
        }

        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("duzgun melumat deyil, yeniden cehd edin");
            Console.ResetColor();
        }
        public static Menu ReadMenu(string caption)
        {
        l1:
            
            
            Console.ForegroundColor = ConsoleColor.Green;
            if (!Enum.TryParse(Console.ReadLine(), out Menu m))
            {
                PrintError("MENUDAN SECHIN");

                goto l1;
            }
            Console.ResetColor();
            return m;
        }
    }
}
