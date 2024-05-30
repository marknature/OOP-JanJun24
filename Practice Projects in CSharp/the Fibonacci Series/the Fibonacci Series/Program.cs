using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms you want in the Fibonacci series: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci series with " + n + " terms:");
            foreach (int num in FibonacciSeries(n))
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }

        static int[] FibonacciSeries(int n)
        {
            int[] fibSeries = new int[n]; // Initialize an array to store the Fibonacci series

            if (n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return null;
            }
            else if (n == 1)
            {
                return new int[] { 0 }; // Return [0] for the case when n is 1
            }
            else if (n == 2)
            {
                return new int[] { 0, 1 }; // Return [0, 1] for the case when n is 2
            }
            else
            {
                fibSeries[0] = 0;
                fibSeries[1] = 1;

                for (int i = 2; i < n; i++)
                {
                    fibSeries[i] = fibSeries[i - 1] + fibSeries[i - 2]; // Add the last two numbers to get the next number
                }

                return fibSeries;
            }
        }
    }
}
