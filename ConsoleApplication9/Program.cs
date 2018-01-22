using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            int[] randNumArray;
            int[] randArray = new int[5];

            int[] randArray2 = { 1, 2, 3, 4, 5 };

            int[,] multArray = new int[5, 3];
            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            foreach (int num2 in multArray2)
            {
                Console.WriteLine(num2);
            }

            for (int x = 0; x < multArray2.GetLength(0); x++)
            {
                for (int y = 0; y < multArray2.GetLength(1); y++)
                {
                    Console.WriteLine("{0} | {1} : {2}", x, y, multArray2[x,y]);
                }
            }

            Console.WriteLine("Array Length " + randArray2.Length);

            Console.WriteLine("Item 0 " + randArray2[0]);

            for (int i = 0;  i < randArray2.Length; i++) {
                Console.WriteLine ("{0} : {1}", i, randArray2[i]);
            }

            foreach (int num in randArray2) {
                Console.WriteLine(num);
            }

            Console.WriteLine("Where is 1: " + Array.IndexOf(randArray2, 1));

            string[] names = { "Tom", "Paul", "Sally" };

            string nameStr = string.Join(", ", names);
            Console.WriteLine(nameStr);

            string[] nameArray = nameStr.Split(',');
            

            foreach (string name in nameArray)
            {
                Console.WriteLine(name);
            }
            Console.Read();


        }
    }
}
