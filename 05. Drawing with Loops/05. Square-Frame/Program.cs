using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char special = '|';

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                { 
                    special = '+';
                    Console.Write(special);
                    for (int r = 0; r < n-2; r++)
                    {
                        Console.Write(" -");
                    }
                    Console.WriteLine(" "+special);
                }
                else
                {
                    special = '|';
                    Console.Write(special);
                    for (int r = 0; r < n-2; r++)
                    {
                        Console.Write(" -");
                    }
                    Console.WriteLine(" " + special);
                }
            }
        }
    }
}
