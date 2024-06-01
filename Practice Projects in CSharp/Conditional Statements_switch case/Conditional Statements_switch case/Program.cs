using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            // Days of the week
            int day;
            Console.Write("Enter a number from 1 to 7: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("If today is day " + day + " then: ");

            switch(day)
            {
                case 1:
                    Console.WriteLine("Today is Monday.");
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday.");
                    break;
                case 3:
                    Console.WriteLine("Today is Wednesday.");
                    break;
                case 4:
                    Console.WriteLine("Today is Thursday.");
                    break;
                case 5:
                    Console.WriteLine("Today is Friday.");
                    break;
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Invalid number. Please enter a number from 1 to 7, which represents days of the week.");
                    break;
            }

            Console.Write("\n");

            // Months of the year
            int month;
            Console.Write("Enter a number from 1 to 12: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("If the month is " + month + " then: ");

            switch (month)
            {
                case 1:
                    Console.WriteLine("We are in January.");
                    break;
                case 2:
                    Console.WriteLine("We are in February.");
                    break;
                case 3:
                    Console.WriteLine("We are in March.");
                    break;
                case 4:
                    Console.WriteLine("We are in April.");
                    break;
                case 5:
                    Console.WriteLine("We are in May.");
                    break;
                case 6:
                    Console.WriteLine("We are in June.");
                    break;
                case 7:
                    Console.WriteLine("We are in July.");
                    break;
                case 8:
                    Console.WriteLine("We are in August.");
                    break;
                case 9:
                    Console.WriteLine("We are in September.");
                    break;
                case 10:
                    Console.WriteLine("We are in October.");
                    break;
                case 11:
                    Console.WriteLine("We are in November.");
                    break;
                case 12:
                    Console.WriteLine("We are in December.");
                    break;

                default:
                    Console.WriteLine("Invalid number. Please enter a number from 1 to 12, which represents Months of the year.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
