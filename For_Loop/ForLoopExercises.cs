using Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
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

    public static class Exercise_4
    {
        /*
          4. Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average. 
            Test Data :
            Input the 10 numbers :
            Number-1 :2
            ...
            Number-10 :2
            Expected Output :
            The sum of 10 no is : 51
            The Average is : 5.100000
         */

        public static void Execute()
        {
            int[] numbers = new int[10];
            string prefix;

            Console.WriteLine("Enter 10 numbers to sum and average: ");

            for (int i = 1; i <= 10; i++)
            {
                prefix = i == 1 ? "st" : i == 2 ? "nd" : i == 3 ? "rd" : "th";

                numbers[i-1] = UtilityMethods.GetValidAbsoluteNumber($"Enter {i}{prefix} number");
            }

            int sum = numbers.Sum();
            double average = numbers.Average();

            Console.WriteLine($"The sum of the 10 numbers is: {sum}");
            Console.WriteLine($"The Average is: {average}");
        }
    }

    public static class Exercise_5
    {
        /*
          5. Write a program in C# Sharp to display the cube of the number upto given an integer. 
            Test Data :
            Input number of terms : 5
            Expected Output :
            Number is : 1 and cube of the 1 is :1
            Number is : 2 and cube of the 2 is :8
            Number is : 3 and cube of the 3 is :27
            Number is : 4 and cube of the 4 is :64
            Number is : 5 and cube of the 5 is :125
         */

        public static void Execute()
        {
            int length = UtilityMethods.GetValidNumber("Number of integers:");
            double cube = 0;

            for (int i = 1; i <= length; i++)
            {
                cube = Math.Pow(i, 2);

                Console.WriteLine($"Number is {i} and cube of {i} is {cube}");
            }
        }
    }
}
