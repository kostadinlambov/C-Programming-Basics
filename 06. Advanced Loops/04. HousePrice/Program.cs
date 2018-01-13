using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_20_11_2016_HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaSmallRoom = double.Parse(Console.ReadLine());
            double areaKitchen = double.Parse(Console.ReadLine());
            double priceSquareMeter = double.Parse(Console.ReadLine());

            double areaBathroom = 0.5 * areaSmallRoom;
            double areaSecondRoom = 1.1 * areaSmallRoom;
            double areaThirdRoom = 1.1 * areaSecondRoom;

            double areaHall = 0;
            double areaHouse = (areaBathroom + areaSecondRoom + areaThirdRoom +
               areaSmallRoom + areaKitchen) * 1.05;

            double priceHouse = areaHouse * priceSquareMeter;
            Console.WriteLine("{0:f2}",priceHouse);
        }
    }
}
