using System;
using System.Collections.Generic;
using System.Text;

namespace Guessing_game
{
    class Levels
    {
        internal static void Game(int numberRange)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, (numberRange + 1));
            int guess;
            Console.Clear();
            Frame.Title();
            Console.WriteLine("Welcome to the random guessing game");
            Console.Write("Guess a number between 1 and " + numberRange + ": ");
            do {
                try {
                    guess = Convert.ToInt32(Console.ReadLine());
                }                
                catch {
                    guess = 0;
                }
                Console.WriteLine();
                if (guess == 99) {
                    Console.WriteLine("Congratulations, you found the cheat code! The awnser is: " + randomNumber);
                    Console.Write("Now type it in: ");
                }
                else if (guess < 1 || guess > numberRange) {
                    Console.Write("That is not a valid guess! Try again: ");
                }
                else if (guess > randomNumber) {
                    Console.Write("That's too high! Try again: ");
                }
                else if (guess < randomNumber) {
                    Console.Write("That's too low! Try again: ");
                }
                else {
                    Console.Write("That is not a valid guess! Try again: ");
                }
            } while (guess != randomNumber);
            Console.Clear();
            Frame.Title();
            Console.WriteLine("You win!");
            Console.WriteLine();
        }        
    }
}
