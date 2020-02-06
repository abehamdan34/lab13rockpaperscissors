using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    public class RoshamboApp
    {
        public static string Play(Player challenger, string name)
        {

            Player user = new Userdummy(name);
            string userHand = user.GenerateRoshambo();
            string hand = challenger.GenerateRoshambo();

            if (userHand == "Rock")
            {
                return Rock(hand);
            }
            if (userHand == "Paper")
            {
                return Paper(hand);
            }
            else
            {
                return Scissors(hand);
            }
        }
        private static string Rock(string enemyHand)
        {
            if (enemyHand == "Rock")
            {
                return "Draw!";
            }
            if (enemyHand == "Paper")
            {
                return "You Lose!";
            }
            if (enemyHand == "Scissors")
            {
                return "You Win!";
            }
            else { return "fail"; }
        }

        private static string Paper(string enemyHand)
        {
            if (enemyHand == "Paper")
            {
                return "Draw!";
            }
            if (enemyHand == "Scissors")
            {
                return "You Lose!";
            }
            if (enemyHand == "Rock")
            {
                return "You Win!";
            }
            else
            {
                return "fail";
            }
        }

        private static string Scissors(string enemyHand)
        {
            if (enemyHand == "Scissors")
            {
                return "Draw!";
            }
            if (enemyHand == "Rock")
            {
                return "You Lose!";
            }
            if (enemyHand == "Paper")
            {
                return "You Win!";
            }
            else
            {
                return "fail";
            }
        }

    }
}
