using System;

namespace Guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Frame.Title();
            bool hasChosen = false;
            Console.WriteLine("Welcome to the random number guessing game");
            Console.WriteLine("Easy - 0");
            Console.WriteLine("Medium - 1");
            Console.WriteLine("Hard - 2");
            Console.Write("What level do you want to play? ");


            while (!hasChosen)
            {


                try
                {   int levelChoice = Convert.ToInt32(Console.ReadLine());
                    if (levelChoice == 0)
                    {
                        Levels.easy();
                        hasChosen = true;
                    }
                    else if (levelChoice == 1)
                    {
                        Levels.medium();
                        hasChosen = true;

                    }
                    else if (levelChoice == 2)
                    {
                        Levels.hard();
                        hasChosen = true;

                    }
                    else if(levelChoice > 2)
                    {
                        Console.WriteLine("That is not an level option");
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("That is not an level option");
                    Console.WriteLine("Easy - 0");
                    Console.WriteLine("Medium - 1");
                    Console.WriteLine("Hard - 2");
                    Console.Write("What level do you want to play? ");
                }
            }




            Console.ReadLine();
        }
    }
}
