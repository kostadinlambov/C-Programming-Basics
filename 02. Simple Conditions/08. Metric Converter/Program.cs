using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberToConvert = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();
            double outputValue=0.0;

            double m=1;
            double mm = 1000 / m;
            double cm = 100 / m;
            double mi = 0.000621371192 / m;
            double @in = 39.3700787 / m;
            double km = 0.001 / m;
            double ft = 3.2808399 / m;
            double yd = 1.0936133 / m;

            if (inputUnit == "m" && outputUnit == "mm")
            {
                outputValue = 1000 * numberToConvert;
                Console.WriteLine("{0} mm", outputValue);
            }

            else if (inputUnit == "mm" && outputUnit == "m")
            {
                outputValue =  numberToConvert/1000 ;
                Console.WriteLine("{0} m", outputValue);
            }
            else if (inputUnit == "m" && outputUnit == "cm")
            {
                outputValue = 100 * numberToConvert;
                Console.WriteLine("{0} cm", outputValue);
            }
            else if (inputUnit == "cm" && outputUnit == "m")
            {
                outputValue = numberToConvert / 100;
                Console.WriteLine("{0} m", outputValue);
            }
            else if (inputUnit == "m" && outputUnit == "mi")
            {
                outputValue = 0.000621371192 * numberToConvert;
                Console.WriteLine("{0} mi", outputValue);
            }
            else if (inputUnit == "mi" && outputUnit == "m")
            {
                outputValue = numberToConvert / 0.000621371192;
                Console.WriteLine("{0} m", outputValue);
            }
            else if (inputUnit == "m" && outputUnit == "km")
            {
                outputValue = 0.001 * numberToConvert;
                Console.WriteLine("{0} km", outputValue);
            }
            else if (inputUnit == "km" && outputUnit == "m")
            {
                outputValue = numberToConvert / 0.001;
                Console.WriteLine("{0} m", outputValue);
            }
            else if (inputUnit == "m" && outputUnit == "ft")
            {
                outputValue = 3.2808399 * numberToConvert;
                Console.WriteLine("{0} ft", outputValue);
            }
            else if (inputUnit == "ft" && outputUnit == "m")
            {
                outputValue = numberToConvert / 3.2808399;
                Console.WriteLine("{0} m", outputValue);
            }
            else if (inputUnit == "m" && outputUnit == "yd")
            {
                outputValue = 1.0936133 * numberToConvert;
                Console.WriteLine("{0} yd", outputValue);
            }
            else if (inputUnit == "yd" && outputUnit == "m")
            {
                outputValue = numberToConvert / 1.0936133;
                Console.WriteLine("{0} m", outputValue);               
            }
            else if (inputUnit == "cm" && outputUnit == "mm")
            {
                outputValue = 10 * numberToConvert;
                Console.WriteLine("{0} mm", outputValue);
            }
            else if (inputUnit == "mm" && outputUnit == "cm")
            {
                outputValue = numberToConvert / 10;
                Console.WriteLine("{0} cm", outputValue);
            }

            else if (inputUnit == "cm" && outputUnit == "mi")
            {
                outputValue = 0.000621371192/100 * numberToConvert;
                Console.WriteLine("{0} mi", outputValue);
            }
            else if (inputUnit == "mi" && outputUnit == "cm")
            {
                outputValue = numberToConvert * 100/0.000621371192;
                Console.WriteLine("{0} cm", outputValue);
            }
            else if (inputUnit == "cm" && outputUnit == "km")
            {
                outputValue = 0.001 / 100 * numberToConvert;
                Console.WriteLine("{0} km", outputValue);
            }
            else if (inputUnit == "km" && outputUnit == "cm")
            {
                outputValue = numberToConvert * 100 / 0.001;
                Console.WriteLine("{0} cm", outputValue);
            }

            else if (inputUnit == "cm" && outputUnit == "ft")
            {
                outputValue = 3.2808399 / 100 * numberToConvert;
                Console.WriteLine("{0} ft", outputValue);
            }
            else if (inputUnit == "ft" && outputUnit == "cm")
            {
                outputValue = numberToConvert * 100 / 3.2808399;
                Console.WriteLine("{0} cm", outputValue);
            }

            else if (inputUnit == "cm" && outputUnit == "yd")
            {
                outputValue = 1.0936133 / 100 * numberToConvert;
                Console.WriteLine("{0} yd", outputValue);
            }
            else if (inputUnit == "yd" && outputUnit == "cm")
            {
                outputValue = numberToConvert * 100 / 1.0936133;
                Console.WriteLine("{0} cm", outputValue);
            }
            else if (inputUnit == "mi" && outputUnit == "km")
            {
                outputValue = 0.001 / 0.000621371192 * numberToConvert;
                Console.WriteLine("{0} km", outputValue);
            }
            else if (inputUnit == "km" && outputUnit == "mi")
            {
                outputValue = numberToConvert * 0.000621371192 / 0.001;
                Console.WriteLine("{0} mi", outputValue);
            }
            else if (inputUnit == "mi" && outputUnit == "ft")
            {
                
                outputValue = 3.2808399 / 0.000621371192 * numberToConvert;
                Console.WriteLine("{0} ft", outputValue);
            }
            else if (inputUnit == "ft" && outputUnit == "mi")
            {
               
                outputValue = numberToConvert * 0.000621371192 / 3.2808399;
                Console.WriteLine("{0} mi", outputValue);
            }

            else if (inputUnit == "mi" && outputUnit == "yd")
            {
                outputValue = 1.0936133 / 0.000621371192 * numberToConvert;
                Console.WriteLine("{0} yd", outputValue);
            }
            else if (inputUnit == "yd" && outputUnit == "mi")
            {
                outputValue = numberToConvert * 0.000621371192 / 1.0936133;
                Console.WriteLine("{0} mi", outputValue);
            }
            else if (inputUnit == "km" && outputUnit == "ft")
            {
                
                outputValue = 3.2808399 / 0.001 * numberToConvert;
                Console.WriteLine("{0} ft", outputValue);
            }
            else if (inputUnit == "ft" && outputUnit == "km")
            {
              
                outputValue = numberToConvert * 0.001 / 3.2808399;
                Console.WriteLine("{0} km", outputValue);
            }
            else if (inputUnit == "km" && outputUnit == "yd")
            {
                outputValue = 1.0936133 / 0.001 * numberToConvert;
                Console.WriteLine("{0} yd", outputValue);
            }
            else if (inputUnit == "yd" && outputUnit == "km")
            {
                outputValue = numberToConvert * 0.001 / 1.0936133;
                Console.WriteLine("{0} km", outputValue);
            }
            else if (inputUnit == "ft" && outputUnit == "yd")
            {
                outputValue = 1.0936133 / 3.2808399 * numberToConvert;
                Console.WriteLine("{0} yd", outputValue);
            }
            else if (inputUnit == "yd" && outputUnit == "ft")
            {
                outputValue = numberToConvert * 3.2808399 / 1.0936133;
                Console.WriteLine("{0} ft", outputValue);
            }
        }
    }
}
