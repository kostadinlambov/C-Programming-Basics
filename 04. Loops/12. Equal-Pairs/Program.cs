using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12_Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double currentNumber1 = 0;
            double currentNumber2 = 0;
            double sumPair = 0;
            double diff = 0;
            double maxDiff = 0;
            int p = 0;

            for (int i = 0; i < n; i++)
            {
                currentNumber1 = double.Parse(Console.ReadLine());
                currentNumber2 = double.Parse(Console.ReadLine());
                if (i > 0)
                {
                    if (sumPair != currentNumber1 + currentNumber2)
                    {
                        diff = Math.Abs(sumPair - (currentNumber1 + currentNumber2));
                        if (diff > maxDiff)
                        {
                            maxDiff = diff;
                            p++;
                        }
                    }
                }
                sumPair = currentNumber1 + currentNumber2;
            }

            if (p!=0)
            {
                Console.WriteLine("No, maxdiff=" + maxDiff);
            }
            else
            {
                Console.WriteLine("Yes, value=" + sumPair);
            }
        }
    }
}
