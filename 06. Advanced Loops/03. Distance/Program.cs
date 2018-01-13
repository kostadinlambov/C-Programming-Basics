using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_18_12_2016_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialSpeed = int.Parse(Console.ReadLine());
            int firstTimeMinutes = int.Parse(Console.ReadLine());
            int secondTimeMinutes = int.Parse(Console.ReadLine());
            int thirdTimeMinutes = int.Parse(Console.ReadLine());

            double firstTimeHours = firstTimeMinutes / 60.0;
            double secondTimeHours = secondTimeMinutes / 60.0;
            double thirdTimeHours = thirdTimeMinutes / 60.0;

            double secondSpeed = initialSpeed * 1.1;
            double thirdSpeed = secondSpeed * 0.95;

            double firstDistance = 0;
            double secondDistance = 0;
            double thirdDistance = 0;
            double totalDistance = 0;
            
            firstDistance = initialSpeed * firstTimeHours;
            secondDistance = secondSpeed * secondTimeHours;
            thirdDistance = thirdSpeed * thirdTimeHours;
            totalDistance = firstDistance + secondDistance + thirdDistance;
            Console.WriteLine("{0:f2}", totalDistance);
        }
    }
}
