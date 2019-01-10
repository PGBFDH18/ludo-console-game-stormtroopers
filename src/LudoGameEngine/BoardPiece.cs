using System;
using System.Collections.Generic;
using System.Text;

namespace LudoGameEngine
{
    public class BoardPiece
    {
        private int PieceID;
        private int CurrentPosition;

        public BoardPiece(int arrayPos)
        {
            PieceID = arrayPos;
            CurrentPosition = 0;
        }

        public void EnterBoard()
        {
            CurrentPosition = 1;
        }

        public void KickFromBoard()
        {

        }

        public int MovePiece(int diceValue)
        {
            CurrentPosition += diceValue;

            return CurrentPosition;
        }
    }
}
