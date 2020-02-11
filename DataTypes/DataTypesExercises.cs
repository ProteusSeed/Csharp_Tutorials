using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace DataTypes_Exercises
{
    public static class Exercise_1
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

    public static class Exercise_2
    {
        /*2. Write a C# Sharp program that takes a number and a width also a number
         , as input and then displays a triangle of that width, using that number. 
        Test Data
        Enter a number: 6 
        Enter the desired width: 6 
        Expected Output :
        666666                                                      
        66666                                                           
        6666                                                                  
        666                                                        
        66                                                                  
        6 
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidNumber();
            int width = UtilityMethods.GetValidNumber("Enter width: ");

            for (int i = width; i >= 0; i--)
            {
                Console.WriteLine(repeatString(number.ToString(), i));

            }
            
        }

        private static string repeatString(string inputString, int repeats )
        {
            string theString = new String('x', repeats);

            theString = theString.Replace("x", inputString);

            return theString;
        }

    }
}
