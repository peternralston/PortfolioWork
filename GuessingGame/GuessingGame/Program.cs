using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int theAnswer;
            int playerGuess;
            string playerInput;

            Random r = new Random();
            theAnswer = r.Next(1, 21);

            string userName = GetNameFromUser();

            do
            {
                // get player input
                
                Console.Write("Enter your guess (1-20): ");
                playerInput = Console.ReadLine();

                // is number within range

                //attempt to convert the string to a number
                if (int.TryParse(playerInput, out playerGuess))
                {
                    if (playerGuess == theAnswer)
                    {
                        Console.WriteLine($"{theAnswer} was the number.  Great job {userName} You Win!");
                        break;
                    }
                    else
                    {
                        if (playerGuess > theAnswer)
                        {
                            Console.WriteLine($"Sorry {userName} Your guess was too High!");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry {userName} Your guess was too low!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That wasn't a number!");
                }

            } while (true);

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }

        public static string GetNameFromUser()
        {
            Console.WriteLine("Please Tell me your name!");
            string userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello " + userName + "!! Welcome to the Guessing Game! Press any key to get started");
            Console.ReadKey();

            return userName;
        }
    }
}
