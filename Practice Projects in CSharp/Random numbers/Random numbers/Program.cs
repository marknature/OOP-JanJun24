using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Random object
            Random rand = new Random();

            // Generate and print 5 random integers between 1 and 200
            Console.WriteLine("Random Integers:");
            for (int i = 0; i < 6; i++)
            {
                int randomNumber = rand.Next(1, 201); // Generates a random integer between 1 and 200
                Console.WriteLine(randomNumber);
            }
            Console.ReadKey();
        }
    }
}
