using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class Rockdummy : Player
    {
        public Rockdummy()
        {
            Name = "Fingerless Fred";
        }

        public override string GenerateRoshambo()
        {
            Decision = Roshambo.Rock.ToString();
            return Decision;
        }
    }
}
