using System;

namespace Lab13RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Player challenger = null;
            Player rock = new Rockdummy();
            Player random = new Randomdummy();

            int userNum = Validator.CheckRange(Validator.GetUserInput("Who would you like to challenge? \t1.Fingerless Fred\t2.Rando Randy"), 1, 2);

            if (userNum == 1)
            {
                challenger = rock;
            }
            if (userNum == 2)
            {
                challenger = random;
            }

            Console.WriteLine(RoshamboApp.Play(challenger, "Faten"));
            Console.WriteLine($"{challenger.Name} chose {challenger.Decision}");
        }
    }
}
