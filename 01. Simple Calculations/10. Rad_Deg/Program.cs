using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad_Deg
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var grad = rad* (360 / (2 * Math.PI));
            Console.WriteLine("The degree measure is {0}",Math.Round(grad));
        }
    }
}
