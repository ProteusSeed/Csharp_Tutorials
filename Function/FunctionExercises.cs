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

}
