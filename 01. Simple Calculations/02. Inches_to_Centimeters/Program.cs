using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches=");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = a * 2.54;
            Console.Write("Centimeters=");
            Console.WriteLine(b);
        }
    }
}
