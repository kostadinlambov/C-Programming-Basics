using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12_Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine().ToLower();
            int holidaysInYear = int.Parse(Console.ReadLine());
            int weekendsInHomeTown = int.Parse(Console.ReadLine());

            int weekendsInSofia = 48 - weekendsInHomeTown;
            double hollidayWeeknds = 3.0 * weekendsInSofia / 4;

            double holidayVolleyballDays = 2.0 * holidaysInYear / 3;
            int volleyballdaysInHomeTown = weekendsInHomeTown;
            
            double totalVolleyballDaaysInYear = hollidayWeeknds + volleyballdaysInHomeTown +
                holidayVolleyballDays ;

            if (yearType=="leap")
            {
                totalVolleyballDaaysInYear *= 1.15;
                Console.WriteLine((int)totalVolleyballDaaysInYear);
            }
            else if (yearType == "normal")
            {
                Console.WriteLine((int)totalVolleyballDaaysInYear);
            }
        }
    }
}
