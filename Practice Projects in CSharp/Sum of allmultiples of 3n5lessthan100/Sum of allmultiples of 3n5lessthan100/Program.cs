using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_allmultiples_of_3n5lessthan100
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            // Iterate through numbers less than 100
            for (int i = 1; i < 100; i++)
            {
                // Check if the number is a multiple of 3 or 5
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i; // Add the number to the sum
                }
            }
            Console.WriteLine("The sum of all multiples of 3 and 5 less than 100 is: " + sum);
            Console.ReadKey();
        }
    }
}
