using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    static class BasicExercises
    {
        public static void Basic_1()
        {
            /*
             1. Write a C# Sharp program to print Hello and your name in a separate line. 
                Expected Output : 
                Hello: Alexandra Abramov
            */
            Console.WriteLine("Hello \nStan Caceres");

        }
        public static void Basic_2()
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

        public static void Basic_3()
        {
            //3. Write a C# Sharp program to print the result of dividing two numbers. Go to the editor
            string entry;
            decimal firstNum = 0; decimal secondNum = 0;
            decimal quotient;
            Boolean valid = false;
            string invalidMessage = "";

            Console.WriteLine("We are dividing two numbers...");

            while (valid == false)
            {
                Console.WriteLine("{0}Enter first number: ",invalidMessage);
                entry = Console.ReadLine();
                valid = decimal.TryParse(entry, out firstNum);
                valid = firstNum > 0;
                invalidMessage = valid ? null : "\nValue must be a valid number greater than zero!\n";
                entry = null;
            }

            Console.WriteLine("Enter second number: ");
            entry = Console.ReadLine();
            decimal.TryParse(entry, out secondNum);
            entry = null;

            quotient = decimal.Divide(firstNum, secondNum);

            Console.WriteLine("The quotient is: {0}", quotient);

        }
    }
}
