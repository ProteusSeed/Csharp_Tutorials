﻿using System;
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

    public static class Exercise_04
    {
        /*
        4. Write a C# Sharp program to validate a password of length 7 to 16 characters with the following guidelines: 
        • Length between 7 and 16 characters.
        • At least one lowercase letter (a-z).
        • At least one uppercase letter (A-Z).
        • At least one digit (0-9).
        • Supported special characters: ! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; " ' ? < > , .
        Sample Data:
        ("Suuu$21g@") -> True
        ("W#1g@") -> False
        ("a&&g@") -> False
        ("sdsd723#$Amid") -> True
        ("sdsd723#$Amidkiouy") -> False
         */

        public static void Execute()
        {
            string password = UtilityMethods.GetValidString();

            string regex = @"^[a-zA-Z!@#$%^&*()+=_-{}\[\]:;""'?<>,.]{7,16}$";

            Regex expression = new Regex(regex);

            Console.WriteLine(expression.IsMatch(password));
        }
    }

    public static class Exercise_06
    {
        /*
         * 6. Write a C# Sharp program to check for repeated occurrences of words in a given string string.
            Sample Data:
            ("C# C# syntax is highly expressive, yet it is is also simple and easy to to learn learn.") -> 3 matches found
            ("Red Green Green Black Black Green.") -> 2 matches found
        */

        public static void Execute()
        {
            string givenString = UtilityMethods.GetValidString();
            string matchString = "";

            string expression = @"\b(?<word>\w+)\s+(\k<word>)\b"; // \k = named backreference

            Regex regex = new Regex(expression);

            MatchCollection matches = regex.Matches(givenString);

            foreach (Match item in matches)
            {
                matchString += item + " ";
            }
           
            Console.WriteLine("{0} matches found", matches.Count);

        }

    }

    public static class Exercise_07
    {
        /*
         7. Write a C# Sharp program to check whether a given string either represents a currency value or has the correct format to represent a currency value. 
         */

        public static void Execute()
        {
            string givenString = UtilityMethods.GetValidString();

            string expression = @"^\$?\d+.\d+$";

            Regex regex = new Regex(expression);

            Console.WriteLine(regex.IsMatch(givenString));


        }
    }

    public static class Exercise_08
    {
        /*
         * 8. Write a C# Sharp program to remove the special characters from a given text. 
            Return the new string which allowed alphanumeric characters, spaces, underscores _ and dashes - .
            Sample Data:
            ("AA@%^&CC") -> "AACC"
            ("Python") -> "Python"
            ("w3resource.com") -> "w3resourcecom"
         */

        public static void Execute()
        {
            string text = UtilityMethods.GetValidString();

            string alphaString = Regex.Replace(text, @"[^A-Za-z _-]", String.Empty);

            Console.WriteLine(alphaString);
        }
    }

    public static class Exercise_09
    {
        /*
          9. Write a C# Sharp program to find the word "C#" in a given string. If the word "C#" found return "C# document found." otherwise return “Sorry no C# document!". 
            Sample Data:
            ("C# Exercises") -> "C# document found."
            ("Python Exercises") -> "Sorry no C# document!"
            ("Tutorial on c#") -> "C# document found."
         */

        public static void Execute()
        {
            string givenString = UtilityMethods.GetValidString();
            string regex = "C#";

            bool found = Regex.IsMatch(givenString, regex);

            Console.WriteLine(found);
        }
    }


}
