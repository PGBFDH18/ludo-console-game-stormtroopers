using System;
using System.Collections.Generic;
using System.Text;

namespace LudoGameEngine
{
    class Player
    {
        int PlayerId;
        public string Name;
        BoardPiece[] BoardPieces = new BoardPiece[4];
        

        public Player()
        {
            for (int i = 0; i < BoardPieces.Length; i++)
            {
                BoardPieces[i] = new BoardPiece(i);
            }
        }

        public string ToString()
        {
            string temp = Name + "\n";

            for (int i = 0; i < BoardPieces.Length; i++)
            {
                temp += BoardPieces[i].ToString();
            }

            return temp;
        }
    }
}
