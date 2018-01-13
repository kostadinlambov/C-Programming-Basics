using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4_Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();

            switch (productName)
            {
                case "apple":
                case "banana":
                case "grapes":
                case "kiwi":
                case "cherry":
                case "lemon":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
