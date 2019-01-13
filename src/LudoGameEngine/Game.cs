using System;

namespace LudoGameEngine
{
    public class Game
    {
        public Player[] Players;
        public int NrOfPlayers;
        public int CurrentPlayersTurn;

        public Game()
        {

        }

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
            resultString += $"\n\n{highestRoller} rolled the highest value.";

            return resultString;
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
                    Players[i] = new Player();
                    Players[i].PlayerId = i;
                }

                Players[playerNumber].Name = name;
            }
            else
            {
                Players[playerNumber].Name = name;
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
