using System;
using System.Collections.Generic;
using System.Text;

namespace Guessing_game
{
    class Levels
    {
        public static void easy()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            Console.WriteLine("Welcome to the random guessing game");
            Console.Write("Guess a number between 1 and 10: ");

            int guess = 0;
            try
            {
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
            }

            while (guess != randomNumber)
            {
                try
                {
                    if(guess == 99)
                    {
                        Console.WriteLine("Congratulations, you found the cheat code! The awnser is: ");
                        Console.WriteLine(randomNumber);
                    }
                    else if (guess <= 0 || guess >= 11)
                    {
                        Console.Write("That is not a valid guess! Try again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }

                    else if (guess > randomNumber)
                    {
                        Console.Write("That's too high! Try again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (guess < randomNumber)
                    {
                        Console.Write("That's too low! Try again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }

                    else
                    {
                        Console.WriteLine("Unknown Error");
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("That is not a number!");
                }

            }

            if (guess == randomNumber)
            {
                Console.WriteLine("You win!");
            }
        }

        public static void medium()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 26);

            Console.WriteLine("Welcome to the random guessing game");
            Console.Write("Guess a number between 1 and 25: ");

            int guess = 0;
            try
            {
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
            }

            while (guess != randomNumber)
            {

                try
                {
                    if (guess == 99)
                    {
                        Console.WriteLine("Congratulations, you found the cheat code! The awnser is: ");
                        Console.WriteLine(randomNumber);
                    }
                    else if (guess <= 0 || guess >= 26)
                    {
                        Console.Write("That is not a valid guess! Try again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }

                    else if (guess > randomNumber)
                    {
                        Console.Write("That's too high! Try again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (guess < randomNumber)
                    {
                        Console.Write("That's too low! Try again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }

                    else
                    {
                        Console.WriteLine("Unknown Error");
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("That is not a number!");
                }

            }

            if (guess == randomNumber)
            {
                Console.WriteLine("You win!");
            }
        }

        public static void hard()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 51);

            Console.WriteLine("Welcome to the random guessing game");
            Console.Write("Guess a number between 1 and 50: ");

            int guess = 0;
            try
            {
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
            }

            while (guess != randomNumber)
            {
                try
                {
                    if (guess == 99)
                    {
                        Console.WriteLine("Congratulations, you found the cheat code! The awnser is: ");
                        Console.WriteLine(randomNumber);
                    }
                    else if (guess <= 0 || guess >= 51)
                    {
                        Console.Write("That is not a valid guess! Try again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }

                    else if (guess > randomNumber)
                    {
                        Console.Write("That's too high! Try again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (guess < randomNumber)
                    {
                        Console.Write("That's too low! Try again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }

                    else
                    {
                        Console.WriteLine("Unknown Error");
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("That is not a number!");
                }

            }

            if (guess == randomNumber)
            {
                Console.WriteLine("You win!");
            }
        }
    }
}
