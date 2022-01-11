using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Function_Exercises
{
    public static class Exercise_01
    {
        /*
         * 1. Write a program in C# Sharp to create a user define function. 
            Expected Output :
            Welcome Friends!
            Have a nice day!
         */

        public static void Execute()
        {
            welcome();
        }

        private static void welcome()
        {
            Console.WriteLine("Welcome Friends! \nHave a nice day!");
        }
    }

    public static class Exercise_02
    {
        /*
         * 2. Write a program in C# Sharp to create a user define function with parameters. 
            Test Data:
            Please input a name: John
            Expected Output:
            Welcome friend John !
            Have a nice day!
        */

        public static void Execute()
        {
            welcome(UtilityMethods.GetValidString("Enter name"));
        }

        private static void welcome(string name)
        {
            Console.WriteLine($"Welcome friend {name}!\nHave a nice day!");
        }
    }

    public static class Exercise_03
    {
        /*
         * 3. Write a program in C# Sharp to create a function for the sum of two numbers. 
            Test Data :
            Enter a number: 15
            Enter another number: 16
            Expected Output :
            The sum of two numbers is : 31
        */

        public static void Execute()
        {
            int number1 = UtilityMethods.GetValidAbsoluteNumber("Enter 1st number");
            int number2 = UtilityMethods.GetValidAbsoluteNumber("Enter 2nd number");

            int sumOfNumbers = sum(number1, number2);

            Console.WriteLine("The sum of {0} and {1} is: {2}", number1, number2, sumOfNumbers);
        }

        private static int sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }

    public static class Exercise_04
    {
        /*
         * 4. Write a program in C# Sharp to create a function to input a string 
            and count number of spaces are in the string. 
            Test Data :
            Please input a string : This is a test string.
            Expected Output:
            "This is a test string." contains 4 spaces
        */

        public static void Execute()
        {
            Console.WriteLine(spaces());
        }

        private static string spaces()
        {
            string inputString = UtilityMethods.GetValidString();
            inputString.Trim();
            string[] splits = inputString.Split(' ');
            int numberOfSplits = splits.Length;
            int numberOfSpaces = numberOfSplits - 1;

            return $"\"{inputString}\" contains {numberOfSpaces} spaces";
        }
    }
}
