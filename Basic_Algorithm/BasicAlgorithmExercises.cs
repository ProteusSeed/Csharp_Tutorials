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


}
