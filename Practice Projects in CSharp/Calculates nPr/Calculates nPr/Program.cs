using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculates_nPr
{
    class Permutations
    {
        // Function to calculate factorial
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

        // Function to calculate nPr
        static int Permutation(int n, int r)
        {
            return Factorial(n) / Factorial(n - r);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("This C# Program Calculates nPr and n > r! \n");
            Console.Write("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of r: ");
            int r = Convert.ToInt32(Console.ReadLine());

            if (n < r)
            {
                Console.WriteLine("Invalid input! n must be greater than or equal to r.");
            }
            else
            {
                int result = Permutation(n, r);
                Console.WriteLine("nPr = " + result);
            }
            Console.ReadKey();
        }
    }
}
