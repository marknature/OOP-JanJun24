using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Pattern
{
    class DiamondPattern
    {
        static void Main(string[] args)
        {
            int n = 5; // Number of rows (should be odd for perfect diamond shape)
            Console.WriteLine("Diamond Pattern\nwith * and spaces:\n"); // Heading

            // Upper part of the diamond
            for (int i = 1; i <= n; i += 2)
            {
                for (int j = 0; j < (n - i) / 2; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Lower part of the diamond
            for (int i = n - 2; i >= 1; i -= 2)
            {
                for (int j = 0; j < (n - i) / 2; j++)
                {
                    Console.Write(" ");
                }
                
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
