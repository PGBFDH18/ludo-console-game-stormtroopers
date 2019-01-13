using System;

namespace LudoGameEngine
{
    public class Game
    {
        private int[] Board = new int[40];
        private Player[] Players;


        public Game()
        {
            
        }

        public void InitializeNewGame(string[] newGameArgs)
        {
            Players = new Player[Convert.ToInt32(newGameArgs[0])];
            for(int i = 0; i < Players.Length; i++)
            {
                Players[i] = new Player();
            }

            for(int i = 1; i < newGameArgs.Length; i++)
            {
                Players[i - 1].Name = newGameArgs[i];
            }
        }

        public int RollDice()
        {
            Random rnd = new Random();
            int nr = rnd.Next(1, 7);
            return nr;
        }

        public string GetPlayerInfo(int playerId)
        {
            return Players[playerId].ToString();
        }
    }
}
