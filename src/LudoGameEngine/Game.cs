using System;

namespace LudoGameEngine
{
    public class Game
    {
       int[] Board = new int[41];

        public Game()
        {
            Player[] players = new Player[4];
            players[0].name = "Samuel";
            players[1].name = "Rocky";
            players[2].name = "Lovedeep";
            players[3].name = "Wael";
        }

        public int RollDice()
        {
            Random rnd = new Random();
            int nr = rnd.Next(1, 7);
            return nr;
        }
        
          


      

    

    }
    public class Player
    {
        public string name;

        public Player()
        {

        }
    }
}
