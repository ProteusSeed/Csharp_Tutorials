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

    public static class Exercise_05
    {
        /*
          5. Write a program in C# Sharp to count the number of digits in a number using recursion. 
            Test Data :
            Input any number : 12345
            Expected Output :
            The number 12345 contains number of digits : 5
         */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber();

            Console.WriteLine($"The number {number} contains number of digits: {digits(number, 0)}");
        }

        private static int digits( int number, int count)
        {
            if (number <= 0) return count;            

            return digits(number / 10, count + 1); ;
        }
    }

    public static class Exercise_06
    {
        /*
         * 6. Write a program in C to print even or odd numbers in a given range using recursion.
            Test Data :
            Input the range to print starting from 1 : 20
            Expected Output :
            All even numbers from 1 to 20 are :
            2 4 6 8 10 12 14 16 18 20

            All odd numbers from 1 to 20 are :
            1 3 5 7 9 11 13 15 17 19
         */

        public static void Execute()
        {
            int range = UtilityMethods.GetValidAbsoluteNumber("Input the range to print starting from 1: ");

            even(range);
        }

        private static void even( int range )
        {
            if (range < 1) return;

            even(range - 2);

            Console.Write($"{range} ");
        }
    }

    public static class Exercise_07
    {
        /*
          7. Write a program in C# Sharp to check whether a number is prime or not using recursion. 
            Test Data :
            Input any positive number : 37
            Expected Output :
            The number 37 is a prime number.
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber("Input any positive number:");

            Console.WriteLine(prime(number, 1));
        }

        private static Boolean prime(int number, int divisor)
        {
            if (divisor > (number / 2) ) return true;

            if (number % divisor == 0 & divisor != 1) return false;

            return prime( number, divisor + 1 );
        }
    }

    public static class Exercise_08
    {
        /*
         * 8. Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion. 
            Test Data :
            Input a string : RADAR
            Expected Output :
            The string is Palindrome.
         */

        public static void Execute()
        {
            string word = UtilityMethods.GetValidString();

            Console.WriteLine($"The string is a Palindrome: {Palindrome(word)}");
        }

        private static Boolean Palindrome( string word )
        {
            if (word.Length < 2) return true;

            bool isPalindrome = word.Substring(0, 1) == word.Substring(word.Length - 1, 1);

            if (isPalindrome == false)
            {
                //Console.WriteLine("false!");
                return false;
            }

           return Palindrome(word.Substring(1, word.Length - 2));

        }
    }

    public static class Exercise_09
    {
        /*
         * 9. Write a program in C# Sharp to find the factorial of a given number using recursion. 
            Test Data:
            Input any positive number: 5
            Expected Output:
            The factorial of 5 is: 120
         */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber("Input any positive number: ");

            int factorial = Factorial(number);

            Console.WriteLine("The factorial of {0} is: {1}", number, factorial);
        }

        private static int Factorial(int number)
        {
            if (number == 1) return 1;

            int factorial = Factorial(number - 1);

            return number * factorial;
        }
    }

    public static class Exercise_10
    {
        /*
         * 10. Write a program in C# Sharp to find the Fibonacci numbers for a n numbers of series using recursion.
            Test Data :
            Input number of terms for the Fibonacci series : 10
            Expected Output :
            The Fibonacci series of 10 terms is : 0 1 1 2 3 5 8 13 21 34
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber("Input number of terms for the Fibonacci series");

            Fibonacci(0, 1, 1, number);
        }

        public static void Fibonacci(int a, int b, int counter, int number)
        {
            Console.WriteLine(a);
            if (counter < number) Fibonacci(b, a + b, counter + 1, number);
        }
    }

    public static class Exercise_11
    {
        /*
         * 11. Write a program in C# Sharp to generate all possible permutations of an array using recursion. 
            Test Data :
            Input the number of elements to store in the array [maximum 5 digits ] :3
            Input 3 number of elements in the array :
            element - 0 : 1
            element - 1 : 2
            element - 2 : 3
            Expected Output :
            The Permutations with a combination of 3 digits are :
            123 132 213 231 321 312
         */

        public static void Execute()
        {
            int[] array = UtilityMethods.getValidNumbersArray();

            Permutations(array, 0);


        }

        private static void Permutations(int[] array, int index)
        {
            if (index >= array.Length) return;

            Console.WriteLine(array[index]);
            Permutations(array, index - 1);
            Permutations(array, index + 1);

        }
    }

    public static class Exercise_12
    {
        /*
         * 12. Write a program in C# Sharp to find the LCM and GCD of two numbers using recursion. 
            Test Data :
            Input the first number : 10
            Input the second number : 15
            Expected Output :
            The GCD of 10 and 15 = 5
            The LCM of 10 and 15 = 30
        */
    }

    public static class RecursionTest
    {

        public static void Execute()
        {
            Function(5, 'M');
        }

        private static void Function(int number, char execution)
        {
            if (number == 0) return;
            
            Function(number - 1, 'A');

            Function(number - 1, 'B');

            Console.WriteLine($"{execution} {number}");
        }
    }
}
