using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var Input_currency = Console.ReadLine();
            var Output_currency = Console.ReadLine();
            double BGN = 1.0;
            var USD = 1.79549 * BGN;
            var EUR = 1.95583 * BGN;
            var GBP = 2.53405 * BGN;

            if (Input_currency == "USD" && Output_currency == "BGN")
            {
                BGN = 1.79549 * a;
                Console.WriteLine(Math.Round(BGN, 2));
            }
            else if (Input_currency == "BGN" && Output_currency == "USD")
            {
                USD = a / 1.79549;
                Console.WriteLine(Math.Round(USD, 2));
            }
            else if (Input_currency == "EUR" && Output_currency == "BGN")
            {
                BGN = 1.95583 * a;
                Console.WriteLine(Math.Round(BGN, 2));
            }
            else if (Input_currency == "BGN" && Output_currency == "EUR")
            {
                EUR = a / 1.95583;
                Console.WriteLine(Math.Round(EUR, 2));
            }
            else if (Input_currency == "GBP" && Output_currency == "BGN")
            {
                BGN = 2.53405 * a;
                Console.WriteLine(Math.Round(BGN, 2));
            }

            else if (Input_currency == "BGN" && Output_currency == "GBP")
            {
                GBP = a / 2.53405;
                Console.WriteLine(Math.Round(GBP, 2));
            }
            else if (Input_currency == "GBP" && Output_currency == "USD")
            {
                USD = (2.53405 / 1.79549) * a;
                Console.WriteLine(Math.Round(USD, 2));
            }

            else if (Input_currency == "USD" && Output_currency == "GBP")
            {
                GBP = (1.79549 / 2.53405) * a;
                Console.WriteLine(Math.Round(GBP, 2));
            }
            else if (Input_currency == "GBP" && Output_currency == "EUR")
            {
                EUR = (2.53405 / 1.95583) * a;
                Console.WriteLine(Math.Round(EUR, 2));
            }

            else if (Input_currency == "EUR" && Output_currency == "GBP")
            {
                GBP = (1.95583 / 2.53405) * a;
                Console.WriteLine(Math.Round(GBP, 2));
            }
            else if (Input_currency == "USD" && Output_currency == "EUR")
            {
                EUR = (1.79549 / 1.95583) * a;
                Console.WriteLine(Math.Round(EUR, 2));
            }
            else if (Input_currency == "EUR" && Output_currency == "USD")
            {
                USD = (1.95583 / 1.79549) * a;
                Console.WriteLine(Math.Round(USD, 2));
            }
        }
    }
}