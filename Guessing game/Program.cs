using System;

namespace Guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int levelChoice;
                int numberRange = 0;
                bool invalidInput;
                string playAgainInput;
                Console.Clear();
                Frame.Title();
                Console.WriteLine("Welcome to the random number guessing game");
                Console.WriteLine("Easy (1)");
                Console.WriteLine("Medium (2)");
                Console.WriteLine("Hard (3)");
                do
                {
                    invalidInput = true;                  
                    Console.Write("Enter the level you want to play: ");
                    try {
                        levelChoice = Convert.ToInt32(Console.ReadLine());
                    }
                    catch {
                        levelChoice = 0;
                    }
                    switch (levelChoice) {
                        case 1:
                            numberRange = 10;
                            break;
                        case 2:
                            numberRange = 25;
                            break;
                        case 3:
                            numberRange = 50;
                            break;
                        default:
                            invalidInput = false;
                            Console.WriteLine("That is not an level option!");
                            Console.WriteLine();
                            break;
                    }
                } while (invalidInput == false);
                Levels.Game(numberRange);
                Console.Write("Enter 'a' to play again: ");
                playAgainInput = Console.ReadLine();
                if (playAgainInput.Trim() == "a") {
                    continue;
                }
                else {
                    break;
                }
            } while (true);
        }
    }
}
