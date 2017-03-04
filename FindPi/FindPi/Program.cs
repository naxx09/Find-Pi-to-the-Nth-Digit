using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPi
{
    class Program
    {
        public static void GetDigit()
        {
            int digit;
            double pi = Math.Atan(1) * 4;
            Console.WriteLine("How many digits of Pi do you want to find out (Max: 15)?");

            if (int.TryParse(Console.ReadLine(), out digit))
            {
                try
                {
                    // also work:
                    // double dPrint = Math.Round(Math.PI, digit);
                    double dPrint = Math.Round(pi, digit);
                Console.WriteLine("\nThe pi in {0} digit(s) is {1}.", digit, dPrint);
                }
                catch
                {
                    Console.Write("Sorry, the maximum digits are 15.");
                }
            }
            else
            {
                Console.WriteLine("\nPlease give me a number!");
            }
                
        }
        static void Main(string[] args)
        {
            do
            {
                GetDigit();
                Console.WriteLine("\nDo you want to find other one? (y/n)");
            } while (Console.ReadLine() != "n");
        }
    }
}
