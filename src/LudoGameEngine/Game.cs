using System;

namespace LudoGameEngine
{
    public class Game
    {
        public int RollDice()
        {
            Random rnd = new Random();
            int nr = rnd.Next(1, 7);
            return nr;
        }

    }
}
