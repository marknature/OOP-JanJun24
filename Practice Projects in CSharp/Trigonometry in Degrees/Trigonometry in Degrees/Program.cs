using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigonometry_in_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the degrees: ");
            double angleDegrees = Convert.ToInt32(Console.ReadLine());

            // Convert degrees to radians
            double angleRadians = angleDegrees * Math.PI / 180.0;

            // Trigonometric functions
            double sinValue = Math.Sin(angleRadians);
            double cosValue = Math.Cos(angleRadians);
            double tanValue = Math.Tan(angleRadians);

            // Display results
            Console.WriteLine("For angle " + angleDegrees + " degrees:");
            Console.WriteLine("Sine: " + sinValue);
            Console.WriteLine("Cosine: " + cosValue);
            Console.WriteLine("Tangent: " + tanValue);
            Console.ReadKey();
        }
    }
}
