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
}
