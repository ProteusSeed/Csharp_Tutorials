using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Basic_Algorithm_Exercises
{

    public static class Exercise_1
    {
        /*
            1. Write a C# Sharp program to compute the sum of the two given integer values. 
            If the two values are the same, then return triple their sum. 
            Expected Output: 
                3
                5
                12   
        */

        public static void Execute()
        {
            int intOne = UtilityMethods.GetValidNumber();
            int intTwo = UtilityMethods.GetValidNumber();
            int result = 0;

            if (intOne == intTwo)
            {
                result = (intOne + intTwo) * 3;
            }
            else
            {
                result = (intOne + intTwo);
            }

            Console.WriteLine("Triple the sum is: {0}", result);

        }
    }

    public static class Exercise_2
    {
        /*
        2. Write a C# Sharp program to get the absolute difference between n and 51. 
        If n is greater than 51 return triple the absolute difference. 
            Expected Output: 
            6
            21
            0
        */

        public static void Execute()
        {
            int n = UtilityMethods.GetValidNumber();
            int result = Math.Abs( n - 51);

            result = n > 51 ? result * 3 : result;

            Console.WriteLine("Result: {0}", result);
        }

    }


}
