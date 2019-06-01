using System;

namespace Guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {           
            int levelChoice;
            int numberRange = 0;
            bool hasChosen;
            Frame.Title();           
            Console.WriteLine("Welcome to the random number guessing game");            
            do
            {                
                hasChosen = true;
                Console.WriteLine("Easy - 0");
                Console.WriteLine("Medium - 1");
                Console.WriteLine("Hard - 2");
                Console.Write("What level do you want to play? ");
            try
            {
                levelChoice = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                levelChoice = 0;
            }
            switch (levelChoice)
                {
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
                        hasChosen = false;
                        Console.WriteLine("That is not an level option!");
                        Console.WriteLine();
                        break;
                }                                       
            } while (hasChosen == false);
            Console.ReadKey();
            Levels.Game(numberRange);          
        }
    }
}
