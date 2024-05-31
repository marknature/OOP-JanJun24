using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumoffirst50naturalnumbersusingForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            // Iterate through the first 50 natural numbers
            for (int i = 1; i <= 50; i++)
            {
                sum += i; // Add the current number to the sum
            }
            Console.WriteLine("The sum of the first 50 natural numbers is: " + sum);
            Console.ReadLine();
        }
    }
}
