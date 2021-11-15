using System;
using Exercises;

namespace String_Exercises
{
    public static class Exercise_01
    {
        /*
         * 1. Write a program in C# Sharp to input a string and print it. 
            Test Data :
            Input the string : Welcome, w3resource
            Expected Output :

            The string you entered is : Welcome, w3resource 
        */

        public static void Execute()
        {
            string inputString = UtilityMethods.GetValidString();
            Console.WriteLine("{0}", inputString);
        }
    }

    public static class Exercise_02
    {
        /*
         * 2. Write a program in C# Sharp to find the length of a string without using library function. 
        Test Data :
        Input the string : w3resource.com
        Expected Output :

        Length of the string is : 15 
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            char[] charArray = theString.ToCharArray();

            Console.WriteLine($"Length of the string is: {charArray.Length}");

        }
    }

    public static class Exercise_03
    {
        /*
          3. Write a program in C# Sharp to separate the individual characters from a string. 
            Test Data :
            Input the string : w3resource.com
            Expected Output :

            The characters of the string are : 
            w  3  r  e  s  o  u  r  c  e  .  c  o  m 
         */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            foreach( char letter in theString)
            {
                Console.Write($"{letter}  ");
            }
        }
    }

    public static class Exercise_04
    {
        /*
         4. Write a program in C# Sharp to print individual characters of the string in reverse order. 
            Test Data :
            Input the string : w3resource.com
            Expected Output :

            The characters of the string in reverse are : 

            m  o  c  .  e  c  r  u  o  s  e  r  3  w 
         */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            int stringLength = theString.Length;
            int index = stringLength - 1;

            while(index >= 0)
            {
                Console.Write($"{theString[index]} ");
                index--;
            }
        }
    }

    public static class Exercise_05
    {
        /*
         * 5. Write a program in C# Sharp to count the total number of words in a string.
            Test Data :
            Input the string : This is w3resource.com
            Expected Output :

            Total number of words in the string is : 3 
         */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            string previousCharacter = "";
            int count = 0;

            if( theString.Length > 0 )
            {
                count++;

                foreach (char character in theString)
                {                    
                    if (character == ' ' & previousCharacter != " ") count++;
                    previousCharacter = character.ToString();
                }
            }          

            Console.WriteLine("Total number of words in the string is: {0}", count);
        }
    }

    public static class Exercise_06
    {
        /*
         * 6. Write a program in C# Sharp to compare two string without using string library functions.
            Test Data :
            Input the 1st string : This is first string
            Input the 2nd string : This is first string
            Expected Output :

            The length of both strings are equal and 
            also, both strings are equal.
         */
        public static void Execute()
        {
            string firstString = UtilityMethods.GetValidString("Enter first string: ");
            string secondString = UtilityMethods.GetValidString("Enter second string: ");
            string isUnequal = " ", isUnequalLength = " ";
            int firstStrLength = firstString.Length;
            int secondStrLength = secondString.Length;

            if (firstStrLength == secondStrLength)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    if (firstString[i] != secondString[i])
                    {
                        isUnequal = "not";
                    }
                }
            }
            else {
                    isUnequal = "not";
                    isUnequalLength = "not"; 
            }

            Console.WriteLine($"The length of both strings are{isUnequalLength}equal and also, both strings are{isUnequal}equal.");
        }
    }

    public static class Exercise_07
    {
        /*
         * 7. Write a program in C# Sharp to count a total number of alphabets
            , digits and special characters in a string. 
            Test Data :
            Input the string : Welcome to w3resource.com
            Expected Output :

            Number of Alphabets in the string is : 21 
            Number of Digits in the string is : 1 
            Number of Special characters in the string is : 4
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            int digits = 0, alphabets = 0, special = 0;

            foreach (char character in theString)
            {
                if (int.TryParse(character.ToString(), out int number) == true)
                {
                    digits++;
                }
                else
                {
                    if (character >= 'a' & character <= 'z')
                    {
                        alphabets++;
                    }
                    else
                    {
                        if( character != ' ' ) special++;
                    }
                }

            }

            string message = $"Number of Alphabets in the string is: {alphabets}"
                           + $"\nNumber of Digits in the string is: {digits}"
                           + $"\nNumber of Special characters in the string is: {special}";

            Console.WriteLine(message);
        }
    }

    public static class Exercise_08
    {
        /*
         * 8. Write a program in C# Sharp to copy one string to another string. \
            Test Data :
            Input the string : This is a string to be copied.
            Expected Output :

            The First string is : This is a string to be copied. 

            The Second string is : This is a string to be copied. 

            Number of characters copied : 31 
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString("The First String Is ");

            string stringCopy = theString;

            Console.WriteLine($"The Second String is: {stringCopy}");


        }
    }
}
