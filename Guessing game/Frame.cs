using System;
using System.Collections.Generic;
using System.Text;

namespace Guessing_game
{
    class Frame
    {
        internal static void Title()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"  _____                 _                 _   _                 _               
 |  __ \               | |               | \ | |               | |              
 | |__) |__ _ _ __   __| | ___  _ __ ___ |  \| |_   _ _ __ ___ | |__   ___ _ __ 
 |  _  // _` | '_ \ / _` |/ _ \| '_ ` _ \| . ` | | | | '_ ` _ \| '_ \ / _ \ '__|
 | | \ \ (_| | | | | (_| | (_) | | | | | | |\  | |_| | | | | | | |_) |  __/ |   
 |_|  \_\__,_|_| |_|\__,_|\___/|_| |_| |_|_| \_|\__,_|_| |_| |_|_.__/ \___|_|   
                                                                                
                                                                                
");
            Console.ResetColor();
        }


    }
}
