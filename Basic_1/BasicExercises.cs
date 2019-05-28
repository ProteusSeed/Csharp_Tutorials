﻿using System;
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
}
