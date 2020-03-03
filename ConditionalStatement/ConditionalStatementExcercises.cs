﻿using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Conditional_Statement
{
    public static class Exercise_1
    {
        /*
            1. Write a C# Sharp program to accept two integers and check whether they are equal or not. 
            Test Data :
            Input 1st number: 5 
            Input 2nd number: 5 
            Expected Output: 5 and 5 are equal 
        */

        public static void Execute()
        {
            int firstNumber = UtilityMethods.GetValidNumber();
            int secondNumber = UtilityMethods.GetValidNumber();

            string Condition = firstNumber == secondNumber ? " " : " not ";

            Console.WriteLine($"{firstNumber} and {secondNumber} are{Condition}equal.");
        }
    }

    public static class Exercise_2
    {
        /*2. Write a C# Sharp program to check whether a given number is even or odd. 
        Test Data : 15
        Expected Output : 
        15 is an odd integer
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidNumber();

            string result = number % 2 > 0 ? "odd" : "even";

            Console.WriteLine($"{number} is {result}");

        }
    }

    public static class Exercise_3
    {
        /*
         3. Write a C# Sharp program to check whether a given number is positive or negative. 
            Test Data : 14 
            Expected Output :
            14 is a positive number
         */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidNumber();

            string sign = number < 0 ? "negative" : "position";

            Console.WriteLine($"{number} is a {sign} number.");

        }
    }

    public static class Exercise_4
    {
        /*
         4. Write a C# Sharp program to find whether a given year is a leap year or not. 
            Test Data : 2016 
            Expected Output :
            2016 is a leap year.
         */

        public static void Execute()
        {
            string message = "";
            int year = UtilityMethods.GetValidNumber();

            DateTime givenDate;// = Convert.ToDateTime( $"02/29/{year}" );
            
            bool isYear = DateTime.TryParse($"02/29/{year}", out givenDate);

            if (isYear)
            {
                string isLeap = DateTime.IsLeapYear(year) ? " " : " not ";

                message = $"{year} is{isLeap}a leap year";
            }
            else
            {
                message = $"{year} is not a year!";
            }

            Console.WriteLine(message);
        }
    }


}
