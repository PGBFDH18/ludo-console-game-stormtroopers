using System;
using LudoGameEngine;

namespace LudoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            bool running = true;
            int choice = -1;

            while (running)
            {
                switch (choice)
                {
                    case -1: // Menu
                        PrintTitle();
                        Console.WriteLine("1. Start new game");
                        Console.WriteLine("2. Load previous game");
                        Console.WriteLine("3. Exit");
                        Console.Write("Your choice: ");
                        choice = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();
                        break;

                    case 1: // New Game
                        game.InitializeNewGame(NewGame());
                        break;

                    case 2: // Load game
                        //game = LoadGame();
                        // Load Game
                        break;

                    case 0: // Exit
                        // When user decides to close the application.
                        running = false;
                        break;
                }
            }

            Console.Write("Application closing.. Press any key to continue...");
            Console.ReadKey();
        }

        static void PrintTitle()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("   _____ __                     ______                                         __             __    ");
            Console.WriteLine("  / ___// /_____  _________ ___/_  ___________  ____  ____  ___  __________   / /  __  ______/ ____ ");
            Console.WriteLine("  \\__ \\/ __/ __ \\/ ___/ __ `__ \\/ / / ___/ __ \\/ __ \\/ __ \\/ _ \\/ ___/ ___/  / /  / / / / __  / __ \\");
            Console.WriteLine(" ___/ / /_/ /_/ / /  / / / / / / / / /  / /_/ / /_/ / /_/ /  __/ /  (__  )  / /__/ /_/ / /_/ / /_/ /");
            Console.WriteLine("/____/\\__/\\____/_/  /_/ /_/ /_/_/ /_/   \\____/\\____/ .___/\\___/_/  /____/  /_____\\__,_/\\__,_/\\____/ ");
            Console.WriteLine("                                                  /_/                                              ");
            Console.ResetColor();
        }

        static string[] NewGame()
        {
            PrintTitle();
            Console.WriteLine("How many players will be playing? ( 2 - 4 )");
            Console.Write("Your choice: ");
            int nrOfPlayers = SetNrOfPlayers();

            Console.Clear();

            PrintTitle();
            string[] newGameArgs = new string[nrOfPlayers + 1];
            newGameArgs[0] = nrOfPlayers.ToString();
            
            for (int i = 1; i < newGameArgs.Length; i++)
            {
                Console.WriteLine($"Enter name for Player {i}:");
                Console.Write("Player name: ");
                newGameArgs[i] = Console.ReadLine();
                Console.WriteLine();
            }

            return newGameArgs;
        }

        static int SetNrOfPlayers()
        {
            bool done = false;
            int nrOfPlayers = 0;

            while (!done)
            {
                try
                {
                    nrOfPlayers = Convert.ToInt32(Console.ReadLine());

                    if (nrOfPlayers < 2 || nrOfPlayers > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Number of players is out of speficied range. Try again.");
                        Console.ResetColor();
                        Console.Write("Your choice: ");
                    }
                    else
                    {
                        done = true;
                    }
                }
                catch (FormatException f)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Try again.");
                    Console.ResetColor();
                    Console.Write("Your choice: ");
                }
            }
            return nrOfPlayers;
        }
    }
}
