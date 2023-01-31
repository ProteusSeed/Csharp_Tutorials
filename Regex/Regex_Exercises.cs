using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Exercises;

namespace Regex_Exercises
{
    public static class Exercise_01
    {
        /*
         * 1. Write a C# Sharp program to check whether a given string is a valid Hex code or not. Return true if the said string is a valid code otherwise false. 
            Sample Data:
            ("#CD5C5C") -> True
            ("#f08080") -> True
            ("#E9967A") -> True
            ("#EFFA07A") -> False
        */

        public static void Execute()
        {
            string hex = UtilityMethods.GetValidString();

            //string validHex = @"^#[A-F|0-9][A-F|0-9][A-F|0-9][A-F|0-9][A-F|0-9][A-F|0-9][A-F|0-9]";
            string validHex = @"^[#][A-F|0-9]{6}";

            Regex expression = new Regex(validHex);

            Console.WriteLine( $"{expression.IsMatch(hex)}");


        }
    }

    public static class Exercise_02
    {
        /*
         * 2. Write a C# Sharp program to calculate the average word length in a given string. Round the average length up to two decimal places. 
            Sample Data:
            ("CPP Exercises." -> 6
            ("C# syntax is highly expressive, yet it is also simple and easy to learn.") -> 4
            (“C# is an elegant and type-safe object-oriented language") -> 5.62
         */

        public static void Execute()
        {
            string sentence = UtilityMethods.GetValidString();
            string expression = @"^\w*|\s\w*";
            int letterCount = 0;
            decimal averageLength = 0m;

            Regex regex = new Regex(expression);

            MatchCollection sentenceMatches = regex.Matches(sentence);

            foreach( Match word in sentenceMatches)
            {
                Console.WriteLine( word.ToString());
                letterCount += word.Length;
            }

            
            averageLength = decimal.Divide(letterCount, sentenceMatches.Count);

            averageLength = Math.Round(averageLength, 2);

            Console.WriteLine($"Average Length: {averageLength}");
        }

        private static int wordLength(string word)
        {
            return word.Trim().Length;
        }
    }
}
