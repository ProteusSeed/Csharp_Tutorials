using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Recursion
{
    public static class Exercise_01
    {
        /*
        1. Write a program in C# Sharp to print the first n natural number using recursion. 
            Test Data:
            How many numbers to print: 10
            Expected Output:
            1 2 3 4 5 6 7 8 9 10
        */

        public static void Execute()
        {
            int numbers = UtilityMethods.GetValidAbsoluteNumber("How many numbers to print: ");

            naturals(10);
        }

        private static void naturals(int start)
        {
            if (start == 0) return;

            naturals(start - 1);

            Console.Write("{0} ", start);

            return;
        }
    }

    public static class Exercise_02
    {
        /*
         * 2. Write a program in C# Sharp to print numbers from n to 1 using recursion. 
            Test Data :
            How many numbers to print : 10
            Expected Output :
            10 9 8 7 6 5 4 3 2 1
        */

        public static void Execute()
        {
            int numbers = UtilityMethods.GetValidAbsoluteNumber("How many numbers to print: ");

            printNumbers(numbers);
        }

        private static void printNumbers(int start)
        {
            if (start == 0) return;

            Console.Write($"{start} ");

            printNumbers(start - 1);

            return;
        }
    }

    public static class Exercise_03
    {
        /*
         * 3. Write a program in C# Sharp to find the sum of first n natural numbers using recursion. 
            Test Data :
            How many numbers to sum : 10
            Expected Output :
            The sum of first 10 natural numbers is : 55
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber("How many numbers to sum: ");

            Console.WriteLine("The sum of first 10 natural numbers is: {0}", naturalSum(number));
        }

        private static int naturalSum( int numbers )
        {
            if (numbers == 0) return 0;

            return numbers + naturalSum(numbers - 1);
        }
    }

    public static class Exercise_04
    {
        /*
         * 4. Write a program in C# Sharp to display the individual digits of a given number using recursion. 
            Test Data :
            Input any number : 1234
            Expected Output:
            The digits in the number 1234 are : 1 2 3 4
         */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber();

            digits(number);

        }

        private static void digits( int number )
        {
            if (number <= 0) return;

            digits(number / 10);

            Console.Write("{0} ", number % 10);
         
        }
    }
}
