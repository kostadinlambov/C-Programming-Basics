using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string dayOfTheWeek = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price=-1;

            if (dayOfTheWeek == "monday" || dayOfTheWeek == "tuesday" || dayOfTheWeek == "wednesday" ||
                dayOfTheWeek == "thursday" || dayOfTheWeek == "friday")
            {
                if (fruit == "banana")
                {
                    price = quantity * 2.50;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit=="apple")
                {
                    price = quantity * 1.20;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "orange")
                {
                    price = quantity * 0.85;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "grapefruit")
                {
                    price = quantity * 1.45;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "kiwi")
                {
                    price = quantity * 2.70;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "pineapple")
                {
                    price = quantity * 5.50;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "grapes")
                {
                    price = quantity * 3.85;
                    Console.WriteLine("{0:f2}", price);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (dayOfTheWeek == "saturday" || dayOfTheWeek == "sunday")
            {
                if (fruit == "banana")
                {
                    price = quantity * 2.70;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "apple")
                {
                    price = quantity * 1.25;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "orange")
                {
                    price = quantity * 0.90;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "grapefruit")
                {
                    price = quantity * 1.60;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "kiwi")
                {
                    price = quantity * 3.00;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "pineapple")
                {
                    price = quantity * 5.60;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (fruit == "grapes")
                {
                    price = quantity * 4.20;
                    Console.WriteLine("{0:f2}", price);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }      
        }
    }
}
 