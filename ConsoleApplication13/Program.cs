using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{

    public enum Temperature
    {
        Freeze,
        Low,
        Warm,
        Boil
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Enumerated
            Temperature micTemp = Temperature.Low;

            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;
                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;
                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;
                case Temperature.Boil:
                    Console.WriteLine("Temp on Boil");
                    break;
            }
            Console.Read();
        }
    }
}
