﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellent_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (number >= 5.50)
                Console.WriteLine("Excellent!");
            else
                Console.WriteLine("Not excellent.");
        }
    }
}
