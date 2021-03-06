﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canVote = true;

            char grade = 'A';

            //Integer with a max number of 2,147,487,647
            int maxInt = int.MaxValue;

            //Long with a max number of 9,223,372,036,854,775,807
            long maxLong = long.MaxValue;

            //Decimal has a maximum value of 79,228,162,514,264,337,593,543,950,335
            //If you need something bigger look up BigInteger
            decimal maxDec = decimal.MaxValue;

            //A float is a 32 bit number with a maxValue of 3.402823E+38 with 7 decimals of precision
            float maxFloat = float.MaxValue;

            //maxValue of 1.797693143E+308 with 15 decimals of precision
            double maxDouble = double.MaxValue;

            Console.WriteLine("Max Int: " + maxInt);
            Console.WriteLine("Max Long: " + maxLong);
            Console.WriteLine("Max Dec: " + maxDec);
            Console.WriteLine("Max Float: " + maxFloat);
            Console.WriteLine("Max Double: " + maxDouble);

            var anotherName = "Tom";

            //anotherName = 2;

            Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());
            Console.Read();
        }
    }
}
