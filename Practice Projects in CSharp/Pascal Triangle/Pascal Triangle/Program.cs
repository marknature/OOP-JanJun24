using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Triangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pascal's Triangle:\n");
            int numRows = 6; // Number of rows in the triangle

            for (int i = 0; i < numRows; i++)
            {
                int number = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number = number * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
