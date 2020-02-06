using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class Validator
    {
    

    public static string GetUserInput(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }

    public static bool ValidateInput(string message)
    {
        string usertInput = GetUserInput(message).ToLower();
        if (usertInput == "y")
        {
            return true;
        }
        else if (usertInput == "n")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Invalid Input");
            return ValidateInput(message);
        }
    }

        public static int CheckRange(string input, int rangeLower, int rangeUpper)
        {
            int number;
            if (int.TryParse(input, out number))
            {
                if (number >= rangeLower && number <= rangeUpper)
                {
                    return number;
                }
                else
                {

                    input = GetUserInput($"Invalid input must choose a number between {rangeLower} through {rangeUpper}");
                    return CheckRange(input, rangeLower, rangeUpper);
                }
            }
            else
            {

                input = GetUserInput($"Invalid input must choose a number between {rangeLower} through {rangeUpper}");
                return CheckRange(input, rangeLower, rangeUpper);
            }
        }
    }
}
