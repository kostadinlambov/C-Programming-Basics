﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());

            if(dayNumber==1)
                Console.WriteLine("Monday");
            else if (dayNumber == 2)
                Console.WriteLine("Tuesday");
            else if (dayNumber == 3)
                Console.WriteLine("Wednesday");
            else if (dayNumber == 4)
                Console.WriteLine("Thursday");
            else if (dayNumber == 5)
                Console.WriteLine("Friday");
            else if (dayNumber == 6)
                Console.WriteLine("Saturday");
            else if (dayNumber == 7)
                Console.WriteLine("Sunday");
            else
                Console.WriteLine("Error");
        }
    }
}
