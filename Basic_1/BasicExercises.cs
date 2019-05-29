using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    static class Basic_01
        {
        public static void Execute()
        {
            /*
             1. Write a C# Sharp program to print Hello and your name in a separate line. 
                Expected Output : 
                Hello: Alexandra Abramov
            */
            Console.WriteLine("Hello \nStan Caceres");

        }
    }

    static class Basic_02
    {
        public static void Execute()
        {
            //2. Write a C# Sharp program to print the sum of two numbers. 
            string entry;
            int firstNum; int secondNum;
            int sum;

            Console.WriteLine("We are adding two numbers...");
            Console.WriteLine("Enter the first number: ");
            entry = Console.ReadLine();
            int.TryParse(entry, out firstNum);

            Console.WriteLine("Enter the second number: ");
            entry = Console.ReadLine();
            int.TryParse(entry, out secondNum);

            sum = firstNum + secondNum;
            Console.WriteLine("The sum is: {0}", sum);
        }
    }

    static class Basic_03
    {
        public static void Execute()
        {
            //3. Write a C# Sharp program to print the result of dividing two numbers. Go to the editor
            string entry;
            decimal firstNum = 0; decimal secondNum = 0;
            decimal quotient;
            Boolean valid = false;
            string invalidMessage = "";
            string entryMsg = "Enter first number: ";

            Console.WriteLine("We are dividing two numbers...");

            while (valid == false)
            {
                Console.WriteLine("{0} {1}", invalidMessage, entryMsg);
                entry = Console.ReadLine();
                valid = decimal.TryParse(entry, out firstNum);
                valid = firstNum > 0;
                invalidMessage = valid ? null : "\nValue must be a valid number greater than zero!\n";
                entry = null;
            }

            valid = false;
            invalidMessage = null;

            while (valid == false)
            {
                entryMsg = "Enter second number: ";
                Console.WriteLine("{0} {1}", invalidMessage, entryMsg);
                entry = Console.ReadLine();
                valid = decimal.TryParse(entry, out secondNum);
                valid = secondNum > 0;
                invalidMessage = valid ? null : "\nValue must be a valid number greater than zero!\n";
                entry = null;
            }

            quotient = decimal.Divide(firstNum, secondNum);

            Console.WriteLine("The quotient is: {0}", quotient);

        }
    }

    static class Basic_04
    {
        public static void Execute()
        {
            /*
             4. Write a C# Sharp program to print the result of the specified operations. 
                Test data:
                -1 + 4 * 6 
                ( 35+ 5 ) % 7 
                14 + -4 * 6 / 11 
                2 + 15 / 6 * 1 - 7 % 2 
            */
            Console.WriteLine("-1 + 4 * 6 = {0}", (-1 + 4 * 6));
            Console.WriteLine("( 35 + 5 ) % 7 = {0}", ( 35 + 5 ) % 7 );
            Console.WriteLine("14 + -4 * 6 / 11 = {0}", 14 + -4 * 6 / 11 );
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = {0}", 2 + 15 / 6 * 1 - 7 % 2);
            Console.ReadLine();

        }
    }

    static class Basic_05
    {
        public static void Execute()
        {
            /*
            5.Write a C# Sharp program to swap two numbers. 
            Test Data:
            Input the First Number : 5
            Input the Second Number : 6
            Expected Output: 
            After Swapping :
            First Number : 6
            Second Number : 5
            */
            bool valid = false;
            string entry;
            string ordinal = "first";
            int number; int firstNumber = 0; int secondNumber = 0;

            while (valid == false || ordinal == "first")
            {
                if (ordinal == "first" && valid == true)
                {
                    ordinal = "second";
                }
               // ordinal = ordinal == "first" && valid == true ? "second" : "first";

                Console.Write("Enter {0} number: ", ordinal);

                entry = Console.ReadLine();
                valid = int.TryParse(entry, out number);

                if (valid == false)
                {
                    Console.WriteLine("Value must be a valid number!");
                }
                else
                {                   
                    if (ordinal == "first")
                    {
                        firstNumber = number;
                    }
                    else
                    {
                        secondNumber = number;
                    }
                }
            }

            Console.WriteLine("First Number: {0}\nSecond Number: {1}", secondNumber, firstNumber);            

        }
    }

    static class Basic_06
    {
        public static void Execute()
        {
            /*
             6. Write a C# Sharp program to print the output of multiplication of three numbers 
                which will be entered by the user. Go to the editor
                Test Data:
                Input the first number to multiply: 2
                Input the second number to multiply: 3
                Input the third number to multiply: 6
                Expected Output:
                2 x 3 x 6 = 36
            */
            int iterationIndex = 0;
            var iteration = new[] {
                                     new{ iterationNumber = 1, iterationName = "first" }
                                    ,new{ iterationNumber = 2, iterationName = "second" }
                                    ,new{ iterationNumber = 3, iterationName = "third" }
                                  };                                        

            //int iteration = 1;
            //string iterationMsg = "first";
            int firstNumber = 0; int secondNumber = 0; int thirdNumber = 0;
            bool valid = false;

            while (iterationIndex < 3)
            {
                Console.Write("Enter {0} number: ", iteration[iterationIndex].iterationName);

                switch (iterationIndex)
                {
                    case 0:
                        valid = int.TryParse(Console.ReadLine(), out firstNumber);
                        break;
                    case 1:
                        valid = int.TryParse(Console.ReadLine(), out secondNumber);
                        break;
                    case 2:
                        valid = int.TryParse(Console.ReadLine(), out thirdNumber);
                        break;
                    default:
                        break;
                }

                if (valid == false)
                {
                    Console.WriteLine("Value must be a valid number!");
                }
                else
                {
                    iterationIndex++;
                }
            }

            Console.WriteLine("Result: {0}", firstNumber * secondNumber * thirdNumber);
        }
    }
}
