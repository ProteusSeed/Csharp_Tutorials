using Exercises;
using System;
using System.Collections.Generic;
using System.Text;

namespace For_Loop
{
    public static class Exercise_1
    {
        /*
         1. Write a program in C# Sharp to display the first 10 natural numbers.
            Expected Output: 1 2 3 4 5 6 7 8 9 10
         */

        public static void Execute()
        {
            int length = 10;

            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine(i);
            }
            
        }
    }

    public static class Exercise_2
    {
        /*2. Write a C# Sharp program to find the sum of first 10 natural numbers. 
            Expected Output :
            The first 10 natural number is :
            1 2 3 4 5 6 7 8 9 10
            The Sum is : 55
        */

        public static void Execute()
        {
            int length = 10;
            int result = 0;

            for (int i = 1; i <= length; i++)
            {
                result += i;
            }

            Console.WriteLine("The sum is: {0}", result);
        }
    }

    public static class Exercise_3
    {
        /*
          3. Write a program in C# Sharp to display n terms of natural number and their sum.
            Test Data : 7
            Expected Output :
            The first 7 natural number is :
            1 2 3 4 5 6 7
            The Sum of Natural Number upto 7 terms : 28
         */
        public static void Execute()
        {
            int numberOfNumbers = UtilityMethods.GetValidAbsoluteNumber("Enter number of natural numbers to sum: ");
            int result = 0;

            for (int i = 0; i <= numberOfNumbers; i++)
            {
                result += i;
            }

            Console.WriteLine("The Sum of Natural Number upto 7 terms : {0}", result);
        }
    }
}
