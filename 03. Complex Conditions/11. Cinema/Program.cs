using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeCinema = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double profit;

            if (typeCinema == "premiere")
            {
                profit = rows * columns * 12.00;
                Console.WriteLine("{0:f2} leva", profit);
            }
            else if (typeCinema == "normal")
            {
                profit = rows * columns * 7.50;
                Console.WriteLine("{0:f2} leva", profit);
            }
            else if (typeCinema == "discount")
            {
                profit = rows * columns * 5.00;
                Console.WriteLine("{0:f2} leva", profit);
            }
        }
    }
}
