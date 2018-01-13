using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2= int.Parse(Console.ReadLine());

            if (number1 > number2)
                Console.WriteLine("Greater number:{0}", number1);
            else 
                Console.WriteLine("Greater number:{0}", number2);
        }
    }
}
