using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public static class UtilityMethods
    {
        public static int GetValidNumber( string entryMessage = "Enter Number: " )
        {
            int number = 0;

            Console.WriteLine(entryMessage);

            while(int.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.WriteLine( "Value must be a valid number! \nEnter Number: " );
            }

            return number;
        }
    }

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
            var iteration = new[] { //this is an anonymous type, instantiated with "initializer syntax"
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

    static class Basic_07
    {
        public static void Execute()
        {
            /*
             7. Write a C# Sharp program to print on screen the output of adding, subtracting
             , multiplying and dividing of two numbers which will be entered by the user. 
                Test Data:
                Input the first number: 25
                Input the second number: 4
                Expected Output:
                25 + 4 = 29
                25 - 4 = 21
                25 x 4 = 100 
                25 / 4 = 6
                25 mod 4 = 1
                */
            bool valid = false;
            int firstNumber = 0; int secondNumber = 0;
            int iterationIndex = 0;
            var iteration = new[] {
                                     new { iterationNumber = 1, iterationName = "first" }
                                    ,new { iterationNumber = 1, iterationName = "second" }
                                  };

            while (iterationIndex < 2)
            {
                Console.Write("Enter {0} number: ", iteration[iterationIndex].iterationName);

                if (iterationIndex == 0)
                {
                    valid = int.TryParse(Console.ReadLine(), out firstNumber);
                }
                else
                {
                    valid = int.TryParse(Console.ReadLine(), out secondNumber);
                }

                if (valid)
                {
                    iterationIndex++;
                }
                else
                {
                    Console.WriteLine("Value must be a valid number!");
                }

            }

            Console.WriteLine("Results...");
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber);
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, firstNumber - secondNumber);
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, firstNumber * secondNumber);
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, firstNumber / secondNumber);
            Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, firstNumber % secondNumber);
        }
    }

    static class Basic_08
    {
        public static void Execute()
        {
            /*
             8. Write a C# Sharp program that takes a number as input and print its multiplication table. 
                Test Data:
                Enter the number: 5
                Expected Output:
                5 * 0 = 0
                5 * 1 = 5
                5 * 2 = 10 
                5 * 3 = 15
                ....
                5 * 10 = 50
            */

            int number = 0;

            Console.Write("Enter number: ");

           while( int.TryParse(Console.ReadLine(), out number) == false )
            {
                Console.WriteLine("Value must be a valid number!");
                Console.Write("Enter number: ");
            }

            Console.WriteLine("Multiplication table...");

            for (int multiplier = 0; multiplier <= 12; multiplier++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, multiplier, number * multiplier);
            }
        }
    }

    static class Basic_09
    {
        /*
         9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
            Test Data:
            Enter the First number: 10 
            Enter the Second number: 15 
            Enter the third number: 20 
            Enter the four number: 30 

            Expected Output:
            The average of 10 , 15 , 20 , 30 is: 18
        */

            class Iteration{//This class provides the type for the list that will store the entries.

            public string iterationName { get; set; }
            public int iterationNumber { get; set; }
            public int iterationValue { get; set; }
        }

        public static void Execute()
        {
            int number = 0;
            int result = 0;
            /*
            var iteration = new[] {
                                     new { iterationName = "first", iterationNumber = 1, iterationValue = 0 } 
                                    ,new{ iterationName = "second", iterationNumber = 2, iterationValue = 0 }
                                    ,new{ iterationName = "third", iterationNumber = 3, iterationValue = 0 }
                                    ,new{ iterationName = "fourth", iterationNumber = 4, iterationValue = 0 }

            };
            */
            //List of type Iteration class (declared above)
            List<Iteration> Iteration = new List<Iteration>
            {
                new Iteration{ iterationName = "first", iterationNumber = 1, iterationValue = 0 }
                ,new Iteration{ iterationName = "second", iterationNumber = 2, iterationValue = 0 }
                ,new Iteration{ iterationName = "third", iterationNumber = 3, iterationValue = 0 }
                ,new Iteration{ iterationName = "fourth", iterationNumber = 4, iterationValue = 0 }
            };

            int iterationIndex;

            for (iterationIndex = 0; iterationIndex <= Iteration.Count- 1; iterationIndex++ )
            {
                Console.Write("Enter {0} number: ", Iteration[iterationIndex].iterationName);

                while (int.TryParse(Console.ReadLine(), out number) == false)
                {
                    Console.WriteLine("Value must be a valid number!");
                    Console.Write("Enter {0} number: ", Iteration[iterationIndex].iterationName);
                }

                //Add the entered value to the list
                Iteration[iterationIndex].iterationValue = number;

                //Add the #s as they're entered
                result = Iteration[iterationIndex].iterationValue + result;
            }

            result /= Iteration.Count;

            Console.WriteLine("The Average of is: {0}", result);

        }
    }

    static class Basic_10
    {
        /*
          Write a C# program that takes three numbers (x,y,z) as input
          and print the output of (x+y)z and x.y + y.z
          Test data:
          Enter 1st number: -5
          2nd: -6
          3rd: -7

           Expected Output:
            Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
    */

        public class numbers
        {
            public string iterationName { get; set; }
            public int value { get; set; }
        }
        public static void Execute()
        {
            int number = 0;
            int result = 0;

            //Dictionary
            Dictionary<int, numbers> numbers = new Dictionary<int, numbers>();

            numbers.Add(0, new Basic_10.numbers { iterationName = "first", value = 0 });
            numbers.Add(1, new Basic_10.numbers { iterationName = "second", value = 0 });
            numbers.Add(2, new Basic_10.numbers { iterationName = "third", value = 0 });            

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("Enter {0} number", numbers[i].iterationName);

                while (int.TryParse(Console.ReadLine(), out number) == false)
                {
                    Console.WriteLine("Value must be a number!");
                    Console.WriteLine("Enter {0} number", numbers[i].iterationName);
                }

                numbers[i].value = number;
            }

            result = (numbers[0].value + numbers[1].value) * numbers[2].value;

            Console.WriteLine("The result of ({0} + {1}) * {2} is: {3}",numbers[0].value,numbers[1].value,numbers[2].value, result);

            result = (numbers[0].value * numbers[1].value) + ( numbers[1].value * numbers[2].value );
            Console.WriteLine("The result of ({0} * {1}) + ({1} * {3}) is: {3}", numbers[0].value, numbers[1].value, numbers[2].value, result);
        }
    }

    static class Basic_11
    {
        /*
         11. Write a C# Sharp program that takes an age (for example 20) as input 
            and prints something as "You look older than 20". Go to the editor
        Test Data:
        Enter your age - 25
        Expected Output:
        You look older than 25
        */

        public static void Execute()
        {
            int age = 0;

            Console.Write("Enter your age: ");

            while (int.TryParse(Console.ReadLine(), out age) == false)
            {
                Console.WriteLine("Value must be a number!");
                Console.Write("Enter your age: ");
            }
           
            Console.WriteLine("You look older than {0}", age);

        }

    }

    static class Basic_12
    {
        /*
         12. Write a C# program that takes a number as input and display it 
         four times in a row (separated by blank spaces), and then four times in the next row, 
         with no separation. You should do it two times: Use Console. Write and then use {0}. 
        Test Data:
        Enter a digit: 25 
        Expected Output:
        25 25 25 25 
        25252525 
        25 25 25 25 
        25252525
        */

        public static void Execute()
        {
            int number = 0;

            Console.Write("Enter a number: ");

            while (int.TryParse(Console.ReadLine(), out number) == false )
            {
                Console.WriteLine("Value must be a number!");
                Console.Write("Enter a number: ");
            }

            Console.WriteLine("Output: ");
            Console.WriteLine("{0} {0} {0}",number);
            Console.WriteLine("{0}{0}{0}", number);
            Console.WriteLine("{0} {0} {0}", number);
            Console.WriteLine("{0}{0}{0}", number);
        }
    }

    static class Basic_13
    {
        /*
         13. Write a C# program that takes a number as input 
            and then displays a rectangle of 3 columns wide and 5 rows tall 
            using that digit. 
            Test Data:
            Enter a number: 5 
            Expected Output:
            555 
            5 5
            5 5 
            5 5 
            555
        */
        public static void Execute()
        {
            int number = 0;

            Console.WriteLine("Enter number: ");

            //Validation
            while (int.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.WriteLine("Value must be a number!");
                Console.WriteLine("Enter number: ");

            }

            for (int i = 1; i <= 5; i++)
            {
                if (i == 1 | i == 5)
                {
                    Console.WriteLine("{0}{0}{0}", number);
                }
            else {
                Console.WriteLine("{0} {0}", number);
                }
            }
        }
    }

    static class Basic_14
    {
        /*
          14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. 
        Test Data:
        Enter the amount of celsius: 30
        Expected Output:
        Kelvin = 303
        Fahrenheit = 86

        k=c+273.15
        f=(c*9/5)+32
        */

        public static void Execute()
        {
            int temperature = 0;

            Console.WriteLine("Enter temperature: ");

            //validate
            while (int.TryParse(Console.ReadLine(), out temperature) == false)
            {
                Console.WriteLine("Enter temperature: ");
                Console.WriteLine("Value must be a number!");

            }

            Console.WriteLine("The temperature in Kelvins is: {0}", temperature + 273.15);
            Console.WriteLine("The temperature in Farenheit is: {0}", (temperature * 9/5) + 32 );
        }

    }

    static class Basic_15
    {
        /*
         15. Write a C# program to remove specified a character 
         from a non-empty string using index of a character. 
        Test Data:
            w3resource
        Sample Output:
            wresource
            w3resourc
            3resource
        */
        public static void Execute()
        {
            string theString = "";
            int characterIndex = 0;
            string message = "";

            while (theString.Length == 0 )
            {
                Console.WriteLine("{0}", message);
                Console.WriteLine("Enter string: ");
                theString = Console.ReadLine();
                message = "String cannot be empty!";

            }

            message = "";

            Console.WriteLine("Enter character index: ");

            while ( int.TryParse(Console.ReadLine(), out characterIndex) == false )
            {
                Console.WriteLine("{0}", message);
                message = "Value must be a number! n/Enter character index: ";

            }

            Console.WriteLine(theString.Remove(characterIndex - 1,1));

        }
    }

    static class Basic_16
    {
        /*
         16. Write a C# program to create a new string from a given string 
            where the first and last characters will change their positions. 
            Test Data:
                w3resource
                Python
                Sample Output:
                e3resourcw
                nythoP 
        */

        public static void Execute()
        {
            string theString = "";
            string message = "";

            while (theString.Length < 2)
            {
                Console.WriteLine("{0} Enter string: ", message);
                theString = Console.ReadLine();
                message = "Value must be at least two characters!";
            }                       

            theString = theString.Substring(theString.Length - 1, 1) + theString.Substring(1, theString.Length - 2) + theString.Substring(0, 1);

            Console.WriteLine(theString);
        }
    }

    static class Basic_17
    {
        /*
          17. Write a C# program to create a new string from a given string (length 1 or more ) 
           with the first character added at the front and back. Go to the editor
            Sample Output:
            Input a string : The quick brown fox jumps over the lazy dog. 
            TThe quick brown fox jumps over the lazy dog.T
            */
        public static void Execute()
        {
            string theString = "";
            string message = "";
            string firstChar = "";

            //validation
            while ( theString == "" )
            {
                Console.WriteLine("{0}Enter string: ", message);
                theString = Console.ReadLine();
                message = "Value must be at least one character! ";
            }

            firstChar = theString.Substring(0, 1);
            theString = firstChar + theString + firstChar;
            Console.WriteLine(theString);
        }
    }

    static class Basic_18
    {
        /*
         18. Write a C# program to check two given integers and return true
            if one is negative and one is positive. 
            Sample Output:
                Input first integer:
                -5 
                Input second integer: 
                25 
                Check if one is negative and one is positive: 
                True 
        */

        public static void Execute()
        {
            string entry = "";
            int integer = 0;
            int first = 0; int second = 0;
            string message = "";

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Enter number: ");
                //validate
                while (int.TryParse(Console.ReadLine(), out integer) == false)
                {
                    message = "Value must be a valid number! ";
                    Console.WriteLine("{0}Enter number: ", message);                    
                }

                if (integer < 0)
                {
                    Console.WriteLine("TRUE!");
                    break;
                }

                message = "";
            }

        }
    }

    static class Basic_19
    {
        /*
         19. Write a C# program to compute the sum of two given integers, 
         if two values are equal then return the triple of their sum.
         */

        public static void Execute()
        {
            int integer = 0;
            int first = 0; int second = 0;
            bool validity = false;
            string iteration = "first";
            string message = "";
            int result = 0;

            for (int i = 1; i <=2; i++)
            {
                while (validity == false)
                {
                    iteration = i == 1 ? "first" : "second";

                    Console.WriteLine("{0}\nEnter {1} number: ", message, iteration);

                    if (i == 1)
                    {
                        validity = int.TryParse(Console.ReadLine(), out first);
                    }
                    else
                    {
                        validity = int.TryParse(Console.ReadLine(), out second);
                    }
                    message = "Value must be a valid number!";
                }
                validity = false;//re-initialize
                message = "";

            }
            result = first == second ? (first + second) * 3 : (first + second);
            Console.WriteLine("Result: {0}", result);
        }
    }

    static class Basic_20
    {
        /*
         20. Write a C# program to get the absolute value of the difference between two given numbers. 
         Return double the absolute value of the difference if the first number is greater than second number. 
         */

        public static void Execute()
        {
            int first = 0; int second = 0;
            string iteration = "first";
            int result = 0;
            string message = "";

            first = UtilityMethods.GetValidNumber("Enter first number: "); 

            second = UtilityMethods.GetValidNumber("Enter second number: ");

            result = first > second ? (first - second) * 2 : first - second;

            Console.WriteLine("Result: {0}", result);

        }
    }
}

