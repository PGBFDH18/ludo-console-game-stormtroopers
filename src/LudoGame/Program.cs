using System;
using LudoGameEngine;

namespace LudoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int choice = 0;

            while(running)
            {
                Console.WriteLine("Welcome to Stormtroopers Ludo-game!");
                Console.WriteLine("1. Start new game");
                Console.WriteLine("2. Load previous game");
                Console.WriteLine("0. Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        // Game.NewGame();
                        // Game.Start();
                        break;
                    case 2:
                        // Game.LoadGame();
                        // Game.Start();
                        break;
                    case 0:
                        // When user decides to close the application.
                        running = false;
                        break;
                }
            }

            Console.Write("Application closing.. Press any key to continue...");
            Console.ReadKey();
        }
    }
}
