using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.UI
{
    public static class InputIO
    {
        public static int GetIntegerInput()
        {
            int intToReturn;
            string userInput;

            Console.WriteLine("Please enter an Integer:");
            userInput = Console.ReadLine();
            while (!int.TryParse(userInput, out intToReturn))
            {
                Console.WriteLine("Input was not a valid Integer");
                Console.WriteLine("Please enter an Integer:");
                userInput = Console.ReadLine();
            }

            return intToReturn;
        }

        public static bool GetTrueFalseInput()
        {
            bool boolean;

            Dictionary<string, bool> acceptableValues = new Dictionary<string, bool>()
            {
                { "Y", true},
                { "N", false}
            };
            Console.WriteLine("Continue? (Y/N):");
            string userInput = Console.ReadLine();
            while (!acceptableValues.ContainsKey(userInput.ToUpper()))
            {
                Console.WriteLine("Please answer with Y or N");
                Console.WriteLine("Continue? (Y/N):");
                userInput = Console.ReadLine();
            }
            boolean = acceptableValues[userInput.ToUpper()];

            return boolean;
        }
    }
}
