using System;

namespace LudoGameEngine
{
    public class Game
    {
        private Player[] Players;
        public int NrOfPlayers;
        public int CurrentPlayersTurn;

        #region Setup-related methods
        public Game()
        {

        }

        public bool SetNrOfPlayers(int value)
        {
            if(value < 2 || value > 4)
            {
                return false;
            }
            else
            {
                NrOfPlayers = value;
                return true;
            }
        }

        public void SetPlayerName(string name, int playerNumber)
        {
            if(Players == null)
            {
                Players = new Player[NrOfPlayers];
                for(int i = 0; i < NrOfPlayers; i++)
                {
                    Players[i] = new Player
                    {
                        PlayerId = i
                    };
                }

                Players[playerNumber].Name = name;
            }
            else
            {
                Players[playerNumber].Name = name;
            }
        }
        #endregion

        #region Game Mechanics and info getters
        public string StartRoll()
        {
            int[] diceRolls = new int[NrOfPlayers];
            int highestRoll = 0;
            string highestRoller = "";
            string resultString = "";

            for (int i = 0; i < NrOfPlayers; i++)
            {
                diceRolls[i] = RollDice();

                if (diceRolls[i] > highestRoll)
                {
                    highestRoll = diceRolls[i];
                    highestRoller = Players[i].Name;
                    CurrentPlayersTurn = Players[i].PlayerId;
                }
                resultString += $"{Players[i].Name} rolled: {diceRolls[i]}\n";
            }
            resultString += $"\n\n{highestRoller} rolled the highest value and will be the starting player!";

            return resultString;
        }

        public int RollDice()
        {
            Random rnd = new Random();
            int nr = rnd.Next(1, 7);
            return nr;
        }

        public string GetCurrentPlayer()
        {
            return Players[CurrentPlayersTurn].Name;
        }

        public string GetAllPlayers()
        {
            string temp = "";

            for(int i = 0; i < Players.Length; i++)
            {
                temp += Players[i].ToString();
            }

            return temp;
        }
        #endregion
    }
}
