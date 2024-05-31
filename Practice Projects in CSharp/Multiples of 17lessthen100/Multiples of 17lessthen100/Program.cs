using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_17lessthen100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiples of 17 less than 100:");
            for (int i = 1; i * 17 < 100; i++)
            {
                int multiple = i * 17;
                Console.WriteLine(multiple);
            }
            Console.ReadKey();
        }
    }
}
