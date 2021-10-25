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


}
