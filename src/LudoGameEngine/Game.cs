using System;

namespace LudoGameEngine
{
    public class Game
    {
        private int[] Board = new int[40];
        private Player[] Players;
        public int nrOfPlayers;
        

        public Game()
        {

        }

        public Game(int nrOfPlayers, string[] playerNames)
        {
            this.nrOfPlayers = nrOfPlayers;
            Players = new Player[this.nrOfPlayers];
            for(int i = 0; i < Players.Length; i++)
            {
                Players[i] = new Player();
            }

            for(int i = 0; i < nrOfPlayers; i++)
            {
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
