using System;
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
}
