using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double areaOfFigure;

            if (figure=="square")
            {
                double a =double.Parse(Console.ReadLine());
                areaOfFigure = a * a;
                Console.WriteLine(Math.Round(areaOfFigure,3));
            }
            else if (figure == "rectangle")
            {
                double c = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                areaOfFigure = c * d;
                Console.WriteLine(Math.Round(areaOfFigure, 3));
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());              
                areaOfFigure = r*r*Math.PI;
                Console.WriteLine(Math.Round(areaOfFigure, 3));
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                areaOfFigure = 0.5*a * h;
                Console.WriteLine(Math.Round(areaOfFigure, 3));
            }
        }
    }
}
