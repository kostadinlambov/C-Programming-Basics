using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
         
            for (int i = 0; i < num; i++)
            {            
                Console.Write(new string(' ', num - i-1));
                Console.Write("*");
                for (int r = 0; r < i; r++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < num-1; i++)
            {
                Console.Write(new string(' ', i+1));
                Console.Write("*");
                for (int r = num-2; r >= i+1; r--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
