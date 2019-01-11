using System;

namespace LudoGameEngine
{
    public class Game
    {
        private int[] Board = new int[40];
        private Player[] Players;
        public int nrOfPlayers { get; set; }


        public Game()
        {
            
        }

        public void InitializePlayersArray(string[] playerNames)
        {
            Players = new Player[nrOfPlayers];
            
            for(int i = 0; i < nrOfPlayers; i++)
            {
                Players[i] = new Player();
                Players[i].Name = playerNames[i];
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
