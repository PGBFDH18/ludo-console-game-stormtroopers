using System;
using System.Collections.Generic;
using LudoGameEngine;

namespace LudoGame
{
    class Program
    {
        static Game game;

        static void Main(string[] args)
        {
            bool running = true;
            int choice = -1;

            while (running)
            {
                PrintTitle();
                Console.WriteLine("1. Start new game");
                Console.WriteLine("2. Load previous game");
                Console.WriteLine("0. Exit");
                Console.Write("Your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1: // New Game
                        game = NewGame();
                        RunSession();
                        break;

                    case 2: // Load game
                        //game = LoadGame();
                        //choice = -1;
                        break;

                    case 0: // Exit
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

        static Game NewGame()
        {
            Game newGame = new Game();
            bool done = false;

            PrintTitle();
            Console.WriteLine("How many players will be playing? ( 2 - 4 )");
            Console.Write("Your choice: ");

            while (!done)
            {
                try
                {
                    int nrOfPlayers = Convert.ToInt32(Console.ReadLine());

                    if (!newGame.SetNrOfPlayers(nrOfPlayers))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid input. Please enter a value between 2 and 4.");
                        Console.ResetColor();
                        Console.Write("Your choice: ");
                    }
                    else
                    {
                        done = true;
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    Console.ResetColor();
                    Console.Write("Your choice: ");
                }
            }

            Console.Clear();
            PrintTitle();
            for (int i = 0; i < newGame.NrOfPlayers; i++)
            {
                Console.WriteLine($"Enter name for player {i + 1}: ");
                Console.Write("Player name: ");
                newGame.SetPlayerName(Console.ReadLine(), i);
            }

            return newGame;
        }

        static void RunSession()
        {
            Console.Clear();
            PrintTitle();
            Console.WriteLine("Roll the dice to see who starts!");
            Console.WriteLine(game.StartRoll());

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
