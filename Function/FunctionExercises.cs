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


}
