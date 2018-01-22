using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            //String builder

            StringBuilder sb = new StringBuilder();
            
            sb.Append("This is the first sentence");
            
            sb.AppendFormat("My name is {0} and I live in {1}", "Fernando", "Campo Grande");
            
            sb.Replace("a", "e");

            sb.Remove(5, 7);

            Console.WriteLine(sb.ToString());

            Console.Read();
        }
    }
}
