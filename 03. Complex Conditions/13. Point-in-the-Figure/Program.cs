using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13_Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool inside = (x > 0 && x < 3 * h) && (y > 0 && y < h)
                || (x > h && x < 2 * h) && (y > 0 && y < 4 * h);

            bool outside = (x < 0 || h > 3 * h || y < 0 || y > 4 * h
                || (x>0 && x<h && y>h &&y>4*h)
                || (x>3*h && x<4*h && y>h &&y>4*h));

            if (inside)
            {
                Console.WriteLine("inside");
            }
            else if (outside)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
