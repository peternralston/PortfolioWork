using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumberFromUser();

            Calculator.PrintFactors(number);
            Calculator.IsPerfectNumber(number);
            Calculator.IsPrimeNumber(number);

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        static int GetNumberFromUser()
        {
            bool isValidNumber = false;
            int userNumber = 0;

            while (!isValidNumber)
            {
                string userInput;
                Console.Clear();
                Console.WriteLine("What number would you like to factor?");
                userInput = Console.ReadLine();
                isValidNumber = int.TryParse(userInput, out int result);
                userNumber = result;

                if (!isValidNumber)
                {
                    // Bad input
                    Console.WriteLine("Your entry " + userInput + " is not a valid entry. Press any key to try again.");
                    Console.ReadKey();
                }
                else
                {
                    // Valid input
                    Console.WriteLine("The number you chose was " + userNumber + ". Press any key to continue.");
                    Console.ReadKey();
                }
            }


            return userNumber;
        }
    }

    class Calculator
    {
        /// <summary>
        /// Given a number, print the factors per the specification
        /// </summary>
        public static void PrintFactors(int number)
        {

        }

        /// <summary>
        /// Given a number, print if it is perfect or not
        /// </summary>
        public static void IsPerfectNumber(int number)
        {

        }

        /// <summary>
        /// Given a number, print if it is prime or not
        /// </summary>
        public static void IsPrimeNumber(int number)
        {

        }
    }
}
