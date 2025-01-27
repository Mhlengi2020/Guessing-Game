using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a Guessing Game");
            int playAgain = 1;

            while (playAgain!=100)
            {
                if (Guess1Digit())
                {
                    Console.WriteLine();
                    Guess2Digit();
                }
                Console.Write("Press 1 to playagain and 100 to exit: ");
                int response = int.Parse(Console.ReadLine());
                Console.WriteLine();
                playAgain = response;
            }
            Console.WriteLine("Thank you for playing,GoodBye!!");
            Console.ReadLine();
        }
        static bool Guess1Digit()
        {
            Random number = new Random();
            int digitGuess = number.Next(0, 10);
            int userGuess = -1;

            Console.Write("Guess a 1 digit number (0-9): ");

            while (userGuess != digitGuess)
            {
                userGuess = int.Parse(Console.ReadLine());
                if (userGuess < 0 || userGuess > 9)
                {
                    Console.Write("Please enter a valid 1 digit number (0-9): ");
                }
                else if (userGuess < digitGuess)
                {
                    Console.Write("Too low, try again: ");
                }
                else if (userGuess > digitGuess)
                {
                    Console.Write("Too high, try again: ");
                }
                else
                {
                    Console.WriteLine("Correct,You guessed the 1-digit number.");
                    return true;
                }
            }
            return false;
        }
        static bool Guess2Digit()
        {
            Random number = new Random();
            int digitGuess = number.Next(10, 100);
            int userGuess = -1;

            Console.Write("Now Guess a 2 digit number (10-99): ");

            while (userGuess != digitGuess)
            {
                userGuess = int.Parse(Console.ReadLine());
                if (userGuess < 10 || userGuess > 99)
                {
                    Console.Write("Please enter a valid 2 digit number (10-99): ");
                }
                else if (userGuess < digitGuess)
                {
                    Console.Write("Too low, try again: ");
                }
                else if (userGuess > digitGuess)
                {
                    Console.Write("Too high, try again: ");
                }
                else
                {
                    Console.WriteLine("Correct,You guessed the 2-digit number.");
                    return true;
                }
            }
            return false;
        }

    }

}
