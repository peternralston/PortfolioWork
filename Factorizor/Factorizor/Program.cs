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

                if (!isValidNumber || result == 0)
                {
                    // Bad input
                    isValidNumber = false; // redundant incase of "0" input.

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
        public static void PrintFactors(int number)
        {
            Console.Clear();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i.ToString() + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("The numbers listed are your factors");
            Console.ReadKey();
        }

        public static void IsPerfectNumber(int number)
        {
            int factorSum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    factorSum += i;
                }
            }
            if (factorSum == number)
            {
                Console.WriteLine();
                Console.WriteLine("Your number is a Perfect Number!");
                Console.ReadKey();
            }


        }

        public static void IsPrimeNumber(int number)
        {
            int factorSum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    factorSum += i;
                }
            }
            if (factorSum == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Your number is a Prime Number!");
                Console.ReadKey();
            }
            Console.WriteLine();


        }
    }
}
