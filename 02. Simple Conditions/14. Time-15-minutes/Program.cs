using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int minutesNew= minutes+15;

            if (minutesNew >= 60)
            {
                hour = hour + 1;
                if (hour >= 24)
                {
                    hour = hour % 24;
                    int minutenOutput = minutesNew % 60;
                    Console.WriteLine("{0}:{1:00}", hour, minutenOutput);
                }
                else
                {
                    int minutenOutput1 = minutesNew % 60;
                    Console.WriteLine("{0}:{1:00}", hour, minutenOutput1);
                }
            }
            else
                Console.WriteLine("{0}:{1:00}", hour, minutesNew);
        }
    }
}
