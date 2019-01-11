using System;
using System.Collections.Generic;
using System.Text;

namespace LudoGameEngine
{
    public class BoardPiece
    {
        private int PieceID;
        private int CurrentPosition;
        private int StepsTaken;


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
            CurrentPosition = 0;
        }

        public int MovePiece(int diceValue)
        {
            CurrentPosition += diceValue;

            // Implement logic for not walking of the mapS

            return CurrentPosition;
        }

        public string ToString()
        {
            return $"Piece: {PieceID + 1}\nBoard Position: {CurrentPosition}/40\nSteps: {StepsTaken}/44\n";
        }
    }
}
