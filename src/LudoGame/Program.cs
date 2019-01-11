using System;
using LudoGameEngine;

namespace LudoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int choice = -1;

            Game game = new Game();

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
                        PrintTitle();
                        Console.WriteLine("How many players will be playing? ( 2 - 4 )");
                        Console.Write("Your choice: ");
                        game.nrOfPlayers = SetNumberOfPlayers();

                        PrintTitle();
                        string[] playerNames = new string[game.nrOfPlayers];
                        for(int i = 0; i < game.nrOfPlayers; i++)
                        {
                            Console.WriteLine($"Enter name for Player {i + 1}");
                            playerNames[i] = Console.ReadLine();
                        }
                        
                        game.InitializePlayersArray(playerNames);
                        Console.ReadKey();


                        for(int i = 0; i < game.nrOfPlayers; i++)
                        {
                            Console.WriteLine(game.GetPlayerInfo(i));
                        }

                        Console.WriteLine("End of test");
                        Console.ReadKey();
                        break;

                    case 2: // Load game
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

        static int SetNumberOfPlayers()
        {
            int temp = 0;
            try
            {
                temp = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("I said a number between 2 - 4... get real bro\n");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }

            if (temp < 2 || temp > 4)
            {
                Console.WriteLine("Number of players is out of range.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

            }
            Console.Clear();

            return temp;
        }
    }
}
