using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5__Triangle_of_dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("$");
                for (int r = 0; r < i; r++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }         
        }
    }
}
