using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Even
            Console.WriteLine("Even numbers between 1 and 10:");
            int i;
            for (i=2; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\n");

            //Odd
            Console.WriteLine("Odd numbers between 1 and 10:");
            int n;
            for (n = 2; n < 10; n++)
            {
                if (n % 2 != 0) //if (n % 2 == 1)
                {
                    Console.WriteLine(n);
                }
            }
            Console.ReadKey();
        }
    }
}
