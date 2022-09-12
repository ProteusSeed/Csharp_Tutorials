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

    public static class Exercise_05
    {
        /*
          5. Write a program in C# Sharp to calculate the sum of elements in an array. 
            Test Data :
            Input 5 elements in the array :
            element - 0 : 5
            element - 1 : 7
            element - 2 : 3
            element - 3 : 2
            element - 4 : 9
            Expected Output :
            The sum of the elements of the array is 26
        */

        public static void Execute()
        {
            int[] numbers = UtilityMethods.getValidNumbersArray();

            string sumMessage = arraySum(numbers);

            Console.WriteLine($"The sum of the elments of the array is {sumMessage}");
        }

        private static string arraySum(int[] elements)
        {
            int sum = 0;

            foreach( int number in elements )
            {
                sum += number;
            }
            return sum.ToString();
        }
    }

    public static class Exercise_06
    {
        /*
         * 6. Write a program in C# Sharp to create a function to swap the values of two integer numbers. 
            Test Data :
            Enter a number: 5
            Enter another number: 6
            Expected Output :
            Now the 1st number is : 6 , and the 2nd number is : 5
        */

        public static void Execute()
        {
            int integer1 = UtilityMethods.GetValidAbsoluteNumber("Enter 1st number");
            int integer2 = UtilityMethods.GetValidAbsoluteNumber("Enter 2nd number");
            int newInteger1 = 0, newInteger2 = 0;

            swap(integer1, integer2, out newInteger1, out newInteger2);

            Console.WriteLine($"Now the 1st number is : {newInteger1}, and the 2nd number is: {newInteger2}");
        }

        private static void swap(int integer1, int integer2, out int newInteger1, out int newInteger2)
        {
            newInteger1 = integer2;
            newInteger2 = integer1;

        }
    }

    public static class Exercise_07
    {
        /*
          7. Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another.
                Test Data :
                Input Base number: 3
                Input the Exponent : 2
                Expected Output :
                So, the number 3 ^ (to the power) 2 = 9
        */

        public static void Execute()
        {
            int baseNum = UtilityMethods.GetValidAbsoluteNumber("Input the base number");
            int exp = UtilityMethods.GetValidAbsoluteNumber("Input the Exponent");
            int result = 0;

            result = (int)(Math.Pow((double)baseNum, (double)exp));
            Console.WriteLine($"So, the number {baseNum} ^ (to the power of) {exp} = {result}");
        }
    }

    public static class Exercise_08
    {
        /*
         * 8. Write a program in C# Sharp to create a function to display the n number Fibonacci sequence. 
            Test Data:
            Input number of Fibonacci Series : 5
            Expected Output :
            The Fibonacci series of 5 numbers is: 0 1 1 2 3
         */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber("Enter amount of numbers in sequence");

            fibonacci(number);

        }

        private static void fibonacci(int number)
        {
            int previous = 1;
            int prePrevious = 0;
            int current = 0;

            Console.Write($"{ prePrevious} ");
            Console.Write($"{ previous} ");

            for ( int n = 1; n <= number - 2; n++ )
            {
                current = prePrevious + previous;

                Console.Write($"{current} ");
                prePrevious = previous;
                previous = current;
            }
        }
    }

    public static class Exercise_09
    {
        /*
         * 9. Write a program in C# Sharp to create a function to check whether a number is prime or not.
            Test Data :
            Input a number : 31
            Expected Output :
            31 is a prime number
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber();

            string isPrime = prime(number) == true ? "is" : "is not";

            Console.WriteLine($"{number} {isPrime} a prime number");
        }

        private static bool prime(int number)
        {
            for( int i = 2; i < number; i++ )
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }

    public static class Exercise_10
    {
        /*
         * 10. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. 
            Test Data :
            Enter a number: 1234
            Expected Output:
            The sum of the digits of the number 1234 is: 10
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber();
            
            int sum = digitSum(number);

            Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");
        }

        private static int digitSum( int number )
        {
            int digits = number.ToString().Length;
            string numberString = number.ToString();
            int sum = 0;

            foreach( char character in numberString )
            {
                sum += Convert.ToInt32(character.ToString());
            }

            return sum;
        }
    }

    public static class Exercise_11
    {
        /*
         * 11. Write a program in C# Sharp to create a recursive function to find the factorial of a given number.
            Test Data :
            Enter a number: 5
            Expected Output:
            The factorial of 5! is 120
         */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber();

            int factorial = factorialCalc(number);

            Console.WriteLine(factorial);
        }

        private static int factorialCalc( int number )
        {
            int factorial = 0;

            // number * factorialCalc(number - 1);
            if (number == 1) return number;

            factorial = factorialCalc(number - 1); //recursion
            factorial = number * factorial;//executes after recursion hits bottom

            return factorial;

        }
    }

    public static class Exercise_12
    {
        /*
         * 12. Write a program in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term. 
            Test Data :
            Enter a number: 10
            Expected Output :
            The Fibonacci of 10th term is 55
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ..
         */

        public static int Fib(int n1, string call)
        {
            int retNum1 = 0, retNum2 = 0;
            Console.WriteLine($"{call} {n1}");

            //if ( (n1 == 1) || (number == 2) )
            if (n1 <= 2)
                return 1;
            else
            {
                retNum1 = Fib(n1 - 1, "a");
                //Console.WriteLine($"{retNum1}");
                retNum2 = Fib(n1 - 2, "b");
                //Console.WriteLine($"{retNum1} {retNum2}");
            }

            Console.WriteLine($"Return {retNum1} {retNum2}");

            return retNum1 + retNum2;
                //function recurses down to one in first call,
                //then the 2nd call is executed going down to one
        }

        public static void Execute()
        {
 
            Console.Write("\n\nRecursive Function : To calculate the Fibonacci number of a specific term :\n");
            Console.Write("-------------------------------------------------------------------------------\n");

            int num = UtilityMethods.GetValidAbsoluteNumber("Enter number off terms");

            Console.WriteLine("\nThe Fibonacci of {0} th term  is {1} \n", num, Fib(num, "m"));
        }
    }
}
