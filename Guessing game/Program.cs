using System;
// hallo
namespace Guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 11);
            Console.WriteLine(randomNumber);

            Console.WriteLine("Welcome to the random guessing game");
            Console.Write("Guess a number between 0 and 10");

            int guess = 0;
            while (guess != randomNumber)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > randomNumber)
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

            if (guess == randomNumber)
            {
                Console.WriteLine("You win!");
            }


           

            Console.ReadLine();
        }
    }
}
