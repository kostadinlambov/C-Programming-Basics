﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;
            int minutesToDisplay = totalTime / 60;
            int secondsToDisplay = totalTime % 60;

            Console.WriteLine("{0}:{1:00}", minutesToDisplay, secondsToDisplay);
        }
    }
}
