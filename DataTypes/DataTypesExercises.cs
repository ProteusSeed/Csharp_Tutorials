using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace DataTypes_Exercises
{
    class Exercise_1
    {
        /*
         * Write a C# Sharp program that takes three letters as input and display them in reverse order. 
        Test Data
        Enter letter: b 
        Enter letter: a
        Enter letter: t
        Expected Output :
        t a b
        */

        public static void Execute()
        {
            string input = UtilityMethods.GetValidString(MinimalLength: 3, MaximumLength: 3);

            input = reverse(input);

            Console.WriteLine(input);

        }

        private static string reverse( string inputString)
        {
            string newString = "";
            char[] characters = inputString.ToCharArray();

            for(int index = characters.GetUpperBound(0); index >= 0; index--)
            {
                newString += characters[index];
            }

            return newString;
        }
    }


}
