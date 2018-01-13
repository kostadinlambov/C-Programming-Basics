using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
                for (int r = 1; r < n; r++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();                          
            }
        }
    }
}
