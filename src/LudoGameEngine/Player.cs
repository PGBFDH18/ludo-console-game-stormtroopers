using System;
using System.Collections.Generic;
using System.Text;

namespace LudoGameEngine
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        BoardPiece[] BoardPieces = new BoardPiece[4];
        

        public Player()
        {
            for (int i = 0; i < BoardPieces.Length; i++)
            {
                BoardPieces[i] = new BoardPiece(i);
            }
        }

        public void SelectPieceToMove(int pieceNr, int nrOfSteps)
        {
            BoardPieces[pieceNr - 1].MovePiece(nrOfSteps);
        }

        public override string ToString()
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
