using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            //String

            string sampString = "A bunch of random words";
            Console.WriteLine("sampString: " + sampString);

            Console.WriteLine("IsNullOrEmpty: " + String.IsNullOrEmpty(sampString));

            Console.WriteLine("IsNullOrWhiteSpace: " + String.IsNullOrWhiteSpace(sampString));

            Console.WriteLine("String length: " + sampString.Length);

            Console.WriteLine("Index of bunch: " + sampString.IndexOf("bunch"));

            Console.WriteLine("2nd word: " + sampString.Substring(2, 6));

            string sampString2 = "More random words";

            Console.WriteLine("Strings Equal: " + sampString.Equals(sampString2));

            Console.WriteLine("Starts with \"A bunch\": " + sampString.StartsWith("A bunch"));

            Console.WriteLine("Ends with words: " + sampString.EndsWith("words"));

            sampString = sampString.Trim();

            sampString = sampString.Replace("words", "characters");

            sampString = sampString.Remove(0, 2);

            Console.WriteLine("sampString: " + sampString);

            string[] names = new string[3] { "Matt", "Joe", "Paul" };

            Console.WriteLine("Name list: " + String.Join(",", names));

            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);

            Console.WriteLine(fmtStr);

            Console.Read();
        }
    }
}
