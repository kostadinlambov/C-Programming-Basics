using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_24_04_2016_Special_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int specialNumber = int.Parse(Console.ReadLine());

            for (int num1 = 1; num1 <= 9; num1++)
            {
                for (int num2 = 1; num2 <= 9; num2++)
                {
                    for (int num3 = 1; num3 <= 9; num3++)
                    {
                        for (int num4 = 1; num4 <= 9; num4++)
                           
                        {
                            if (specialNumber % num1 == 0 &&
                                specialNumber % num2 == 0 &&
                                specialNumber % num3 == 0 &&
                                specialNumber % num4 == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", num1, num2,
                                    num3, num4);
                            }
                        }
                    }
                }
            }
        }
    }
}
