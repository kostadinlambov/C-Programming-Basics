using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_06_03_2016_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int r = 1; r <= n; r++)
                {
                    for (char alpha1 = 'a'; alpha1 < 'a' + l; alpha1++)
                    {
                        for (char alpha2 = 'a'; alpha2 < 'a' + l; alpha2++)
                        {
                            for (int num3 = Math.Max(i,r)+1; num3 <= n; num3++)
                            {                             
                                Console.Write("{0}{1}{2}{3}{4} ",
                                    i, r, alpha1, alpha2, num3);
                               
                            }

                        }
                    }

                }                                        

            }
        }
    }
}
