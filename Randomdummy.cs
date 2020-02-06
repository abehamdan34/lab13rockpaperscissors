using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class Randomdummy : Player
    {
        public Randomdummy()
        {
            Name = "Rando Randy";
        }

        public override string GenerateRoshambo()
        {
            Random number = new Random();
            int num = number.Next(1, 4);
            Decision = Enum.GetName(typeof(Roshambo), num);
            return Decision;
        }
    }
}
