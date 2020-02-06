using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class Userdummy : Player
    {
        //default
        public Userdummy()
        {

        }

        //constructor to all the user to set there own name.
        public Userdummy(string name)
        {
            Name = name;
        }

        public override string GenerateRoshambo()
        {
            int userChoice = Validator.CheckRange(Validator.GetUserInput("1.Rock\t2.Paper\t3.Scissors"), 1, 3);
            Decision = Enum.GetName(typeof(Roshambo), userChoice);
            return Decision;
        }

    }
}
