using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conditionals

            //Relational Operators: > < >= <= == !=
            //Logical Operators: && || ^ !

            int age = 17;
            if ((age >= 15) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("Go to high school");
            }

            Console.WriteLine("! true" + (!true));

            bool canDrive = age >= 18 ? true : false;
            int canDrink = age >= 18 ? 1 : 0;

            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");
                    goto Cute;
                default:
                    Console.WriteLine("Child");
                    break;
            }

            Cute:
                Console.WriteLine("Toddlers are Cute");
            Console.Read();


        }
    }
}
