using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11_House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
             int starsCount = 2;

            if (n % 2 == 1)
            {

                Console.Write(new string('-', n / 2 ));
                Console.Write(new string('*',1));
                Console.Write(new string('-', n / 2));
                Console.WriteLine();
                starsCount++;
            }
                   
            for (int i = 0; i < (n/2); i++)
            {
                Console.Write(new string('-', n/2-i-1 ));
                Console.Write(new string('*', starsCount + 2*i));
                Console.Write(new string('-', n / 2 - i - 1));
                    Console.WriteLine();
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|" + new string('*', n - 2) + "|");
            }
        }
    }
}
