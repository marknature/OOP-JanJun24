using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer to find its factors: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Factors of " + number + " are: ");
            DisplayFactors(number);
            Console.ReadKey();
        }

        static void DisplayFactors(int number)
        {
            if (number <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
