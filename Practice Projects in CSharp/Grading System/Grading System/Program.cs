using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a programme that allows a user to enter any mark and displays the appropriate grade _ 0-49 fail, 50-64 pass, 65-79 credit, 80-100 Distinction
            Console.Write("Please enter your mark as a percentage from 0-100: ");
            int per = Convert.ToInt32(Console.ReadLine());
            Console.Write("You had " + per + "%: ");

            if (per > 100)
            {
                Console.WriteLine("Enter a number less the 100 and greater then or equal to 0");
            }
            else if (per < 0)
            {
                Console.WriteLine("Enter a number greater then or equal to 0 and less the 100");
            }
            else
            {
                if (per >= 80)
                {
                    Console.WriteLine("You have a Distinction.");
                }
                else if (per >= 65)
                {
                    Console.WriteLine("You have credit.");
                }
                else if (per >= 50)
                {
                    Console.WriteLine("You have Passed.");
                }
                else if (per >= 0)
                {
                    Console.WriteLine("You have Failed.");
                }
            }
            Console.ReadKey();
        }
    }
}
