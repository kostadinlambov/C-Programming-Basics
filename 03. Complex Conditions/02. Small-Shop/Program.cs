using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            
            double amount = double.Parse(Console.ReadLine());

            double coffee, water, beer, sweets, peanuts;

            if (product == "coffee")
            {
                if (city == "Sofia")
                {
                    coffee = 0.50 * amount;
                    Console.WriteLine(coffee);
                }
                else if (city == "Plovdiv")
                {
                    coffee = 0.40 * amount;
                    Console.WriteLine(coffee);
                }
                else if(city == "Varna")
                {
                    coffee = 0.45 * amount;
                    Console.WriteLine(coffee);
                }
            }
            else if (product == "water")
            {
                if (city == "Sofia")
                {
                    water = 0.80 * amount;
                    Console.WriteLine(water);
                }
                else if (city == "Plovdiv")
                {
                    water = 0.70 * amount;
                    Console.WriteLine(water);
                }
                else if (city == "Varna")
                {
                    water = 0.70 * amount;
                    Console.WriteLine(water);
                }
            }
            else if (product == "beer")
            {
                if (city == "Sofia")
                {
                    beer = 1.20 * amount;
                    Console.WriteLine(beer);
                }
                else if (city == "Plovdiv")
                {
                    beer = 1.15 * amount;
                    Console.WriteLine(beer);
                }
                else if (city == "Varna")
                {
                    beer = 1.10 * amount;
                    Console.WriteLine(beer);
                }
            }
            else if (product == "sweets")
            {
                if (city == "Sofia")
                {
                    sweets = 1.45 * amount;
                    Console.WriteLine(sweets);
                }
                else if (city == "Plovdiv")
                {
                    sweets = 1.30 * amount;
                    Console.WriteLine(sweets);
                }
                else if (city == "Varna")
                {
                    sweets = 1.35 * amount;
                    Console.WriteLine(sweets);
                }
            }
            else if (product == "peanuts")
            {
                if (city == "Sofia")
                {
                    peanuts = 1.60 * amount;
                    Console.WriteLine(peanuts);
                }
                else if (city == "Plovdiv")
                {
                    peanuts = 1.50 * amount;
                    Console.WriteLine(peanuts);
                }
                else if (city == "Varna")
                {
                    peanuts = 1.55 * amount;
                    Console.WriteLine(peanuts);
                }
            }      
        }
    }
}
