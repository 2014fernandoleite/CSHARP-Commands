using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Casting

            double pi = 31.4;
            int intPi = (int)pi;

            double number1 = 10.5;
            double number2 = 15;

            Console.WriteLine("Math.Abs(number1) " + Math.Abs(number1));
            Console.WriteLine("Math.Ceiling(number1) " + Math.Ceiling(number1));
            Console.WriteLine("Math.Floor(number1) " + Math.Floor(number1));
            Console.WriteLine("Math.Max(number1, number2) " + Math.Max(number1, number2));
            Console.WriteLine("Math.Min(number1, number2) " + Math.Min(number1, number2));
            Console.WriteLine("Math.Pow(number1, 2) " + Math.Pow(number1, 2));
            Console.WriteLine("Math.Round(number1) " + Math.Round(number1));
            Console.WriteLine("Math.Sqrt(number1) " + Math.Sqrt(number1));

            Random rand = new Random();
            Console.WriteLine("Random number between 1 and 10: " + rand.Next(1, 11));
            Console.Read();
        }
    }
}
