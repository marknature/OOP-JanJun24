using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMtransactionsystem
{
    class ATMTransaction
    {
        static void Main(string[] args)
        {
            int balance = 10000; // start balance

            Console.WriteLine("Welcome to the ATM Transaction System");

            while (true)
            {
                // Display menu
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Balance checking");
                Console.WriteLine("2. Cash withdrawal");
                Console.WriteLine("3. Cash deposition");
                Console.WriteLine("4. Exit");

                // Read user choice
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your balance is: " + balance);
                        break;
                    case 2:
                        Console.Write("Enter the amount to withdraw: ");
                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                        if (withdrawAmount > balance)
                        {
                            Console.WriteLine("Insufficient balance!");
                        }
                        else
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine("Withdrawn amount: " + withdrawAmount);
                            Console.WriteLine("Remaining balance: " + balance);
                        }
                        break;
                    case 3:
                        Console.Write("Enter the amount to deposit: ");
                        int depositAmount = Convert.ToInt32(Console.ReadLine());
                        balance += depositAmount;
                        Console.WriteLine("Deposited amount: " + depositAmount);
                        Console.WriteLine("Updated balance: " + balance);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the ATM Transaction System");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a valid option.");
                        break;
                }
            }
        }
    }
}