using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = double.Parse(Console.ReadLine());
            var F = C * 1.8 + 32;
            Console.WriteLine("The Temperature in Fahrenheit is {0}", F);
        }
    }
}
