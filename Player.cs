using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    public abstract class Player
    {
        public string Name { get; set; }
        public string Decision { get; set; }

        public Player()
        {

        }

        public abstract string GenerateRoshambo();
    }
}
