using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftRight = (n - 1) / 2;
            int mid = n - 2 * leftRight - 2;

            int count = (n - 1) / 2;

            if (n%2==1)
            {
                Console.Write(new string('-', n/2)+ "*"+ new string('-',n/2));
                Console.WriteLine();
                leftRight--;
                count--;
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', leftRight - i));
                Console.Write('*');
                Console.Write(new string('-', (n - 2 * leftRight - 2) + i * 2));
                Console.Write('*');
                Console.Write(new string('-', leftRight - i));     
                Console.WriteLine();
            }
           
            for (int r = 0; r < count; r++)
            {
                Console.Write(new string('-', r + 1));
                Console.Write('*');
                Console.Write(new string('-', n - 2 * (r+1) - 2));
                Console.Write('*');
                Console.Write(new string('-', r + 1));
                Console.WriteLine();
            }

            if (n % 2 == 1 && n>1)
            {
                Console.Write(new string('-', n / 2) + "*" + new string('-', n / 2));
                Console.WriteLine();
            
            }
        }
    }
}
