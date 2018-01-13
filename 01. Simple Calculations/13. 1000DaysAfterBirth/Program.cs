using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "dd-MM-yyyy";
            DateTime result;
            result = DateTime.ParseExact(Console.ReadLine(), format, new CultureInfo("en-US"));
            System.DateTime after1000days = result.AddDays(999);
            Console.WriteLine(after1000days.ToString(format));
        }
    }
}
