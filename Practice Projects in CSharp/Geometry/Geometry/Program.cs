using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            double bas, height, AreaTri, radius, PI = 3.142, AreaCircle2, AreaCircle;

            // Calculate Area of a Triangle

            Console.Write("Enter a value for base: ");
            bas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a value for vertical height: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            AreaTri = height * bas/2;
            Console.WriteLine("The area of your triangle is " + AreaTri + ".");

            Console.Write("\n");

            // Calculate Area of a Circle
            
            Console.Write("Enter a value for radius of your circle: ");
            radius = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            AreaCircle = PI*radius*radius;
            AreaCircle2 = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The area of your circle is " + AreaCircle + ".");
            Console.WriteLine("The area of your circle is " + AreaCircle2 + ".");
            Console.ReadKey();
        }
    }
}
