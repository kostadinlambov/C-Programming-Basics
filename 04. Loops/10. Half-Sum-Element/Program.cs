using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentNumber=0;
            int sum=0;
            int maxNumber=0;
            int diff=0;

            for (int i = 0; i < n; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());

                sum += currentNumber;

                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }

            diff = Math.Abs(sum - 2*maxNumber);

            if (diff==0)
            {
                Console.WriteLine("Yes \nSum = " + maxNumber);
            }
            else
            {
                Console.WriteLine("No \nDiff = " + diff);
            }
        }
    }
}
