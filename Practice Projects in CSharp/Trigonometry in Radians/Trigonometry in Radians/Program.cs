using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigonometry_in_Radians
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1 for 180 degrees, 2 for 90 degrees, 3 for 60 degrees or 0 for 0 degrees: ");
            int value;
            value = Convert.ToInt32(Console.ReadLine());

            double angleRadians = 0;            // 0 degrees in radians
            if (value <= 3)
            {
                if (value == 1)
                {
                    angleRadians = Math.PI;     // 180 degrees in radians
                }
                else if (value == 2)
                {
                    angleRadians = Math.PI / 2; // 90 degrees in radians
                }
                else if (value == 3)
                {
                    angleRadians = Math.PI / 3; // 60 degrees in radians
                }

                Console.WriteLine("\nTrigonometric functions in radians:");
                Console.WriteLine("Angle in radians: " + angleRadians);
                Console.WriteLine("Sine of " + angleRadians + ": " + Math.Sin(angleRadians));
                Console.WriteLine("Cosine of " + angleRadians + ": " + Math.Cos(angleRadians));
                Console.WriteLine("Tangent of " + angleRadians + ": " + Math.Tan(angleRadians));
                Console.ReadKey();
            }

            else if(value > 3)
            {
                Console.WriteLine("Please enter a number from 1 to 3!");
            }
            Console.ReadKey();
        }
    }
}
