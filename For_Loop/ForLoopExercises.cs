﻿using Exercises;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

                numbers[i - 1] = UtilityMethods.GetValidAbsoluteNumber($"Enter {i}{prefix} number");
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

    public static class Exercise_6
    {
        /*
         6. Write a program in C# Sharp to display the multiplication table of a given integer. 
            Test Data :
            Input the number (Table to be calculated) : 15
            Expected Output :
            15 X 1 = 15
            ...
            ...
            15 X 10 = 150
         */

        public static void Execute()
        {
            int integer = UtilityMethods.GetValidNumber();
            int result = 0;

            for (int i = 0; i <= 10; i++)
            {
                result = integer * i;
                Console.WriteLine($"{integer} X {i} = {result}");
            }
        }
    }

    public static class Exercise_7
    {
        /*
          7. Write a program in C# Sharp to display the multiplication table vertically from 1 to n. 
            Test Data :
            Input upto the table number starting from 1 : 8
            Expected Output :
            Multiplication table from 1 to 8
            1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
            ...
            1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80
         */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber("Display multiplication tables up to this number");
            int result = 0;
            string table = "";

            for (int i = 1; i <= number; i++)
            {
                table = "";

                for (int y = 0; y <= 10; y++)
                {
                    result = i * y;
                    table += $"{i}x{y} = {result}, ";
                }

                Console.WriteLine(table);

            }
        }
    }

    public static class Exercise_8
    {
        /*
         8. Write a program in C# Sharp to display the n terms of odd natural number and their sum. 
            Test Data
            Input number of terms : 10
            Expected Output :
            The odd numbers are :1 3 5 7 9 11 13 15 17 19
            The Sum of odd Natural Number upto 10 terms : 100
         */
        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber("Display odd natural numbers up to...");
            int sum = 0;

            for (int i = 1; i < number; i = i + 2)
            {
                Console.Write($"{i} ");
                sum += i;

            }

            Console.WriteLine($"The Sum of odd Natural Number up to {number} terms: {sum}");
        }
    }

    public static class Exercise_9
    {
        /*
         9. Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk. 
            The pattern like :
            *
            **
            ***
            ****
         */

        public static void Execute()
        {
            int triangleHeight = UtilityMethods.GetValidAbsoluteNumber("Enter height of triangle");
            int triangeWidth = 1;
            string line = "";

            for (int i = 0; i < triangleHeight; i++)
            {
                line = new StringBuilder(triangeWidth).Insert(0, "*", triangeWidth).ToString();

                Console.WriteLine(line);

                triangeWidth++;
            }
        }

    }

    public static class Exercise_10
    {
        /*
         * 10. Write a program in C# Sharp to display the pattern like right angle triangle with a number.
            The pattern like :
            1
            12
            123
            1234
         */

        public static void Execute()
        {
            int triangleHeight = UtilityMethods.GetValidAbsoluteNumber("Enter triangle height: ");
            string line = "";
            int triangeWidth = 1;

            for (int i = 1; i <= triangleHeight; i++)
            {
                for (int y = 1; y <= triangeWidth; y++)
                {
                    line += y.ToString();
                }

                Console.WriteLine(line);

                triangeWidth++;
                line = "";
            }
        }
    }

    public static class Exercise_11
    {
        /*
         * 11. Write a program in C# Sharp to make such a pattern like right angle triangle
            with a number which will repeat a number in a row. 
            The pattern like :
            1
            22
            333
            4444
         */

        public static void Execute()
        {
            int triangeHeight = UtilityMethods.GetValidAbsoluteNumber("Enter triange height");
            int number = 1;
            string line = "";

            for (int i = 1; i <= triangeHeight; i++)
            {
                line = new StringBuilder(i).Insert(0, number.ToString(), i).ToString();
                Console.WriteLine(line);
                number++;
            }
        }
    }

    public static class Exercise_12
    {
        /*
         * 12. Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1.
            The pattern like :
            1
            2 3
            4 5 6
            7 8 9 10 
         */

        public static void Execute()
        {
            int triangleHeight = UtilityMethods.GetValidAbsoluteNumber("Enter triangle height");
            int lineWidth = 1; int n = 1;
            string triangleLine = "";

            for (int i = 1; i <= triangleHeight; i++)
            {
                for (int y = 1; y <= lineWidth; y++)
                {
                    triangleLine += n.ToString();
                    n++;
                }

                Console.WriteLine(triangleLine);
                lineWidth++;
                triangleLine = "";
            }
        }
    }

    public static class Exercise_13
    {
        /*
         13. Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1. 

               1 
              2 3 
             4 5 6 
            7 8 9 10
         */

        public static void Execute()
        {
            int pyramidHeight = UtilityMethods.GetValidAbsoluteNumber();
            string pyramidRow = "";
            int number = 1; int numberCount = 1;
            string spaces = "";
            int spaceMultiplier = 0;

            for (int pyramidStep = 1; pyramidStep <= pyramidHeight; pyramidStep++)
            {
                for (int n = 1; n <= numberCount; n++)
                {

                    pyramidRow += number.ToString() + " ";
                    number++;
                }

                spaceMultiplier = 3;
                spaces = new string(' ', (((pyramidHeight - pyramidStep) * spaceMultiplier) / 2));
                pyramidRow = spaces + pyramidRow;

                Console.WriteLine(pyramidRow);
                pyramidRow = "";
                numberCount++;
            }

        }
    }

    public static class Exercise_14
    {
        /*
         14. Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk. Go to the editor

           *
          * * 
         * * *
        * * * *
       * * * * * 
      * * * * * *
         */

        public static void Execute()
        {
            int pyramidHeight = UtilityMethods.GetValidNumber();
            int leadSpaceCount = pyramidHeight;
            string pyramidRow = "";
            string spaces = "";

            for (int i = 1; i <= pyramidHeight; i++)
            {
                //pyramidRow = new string('*', i).ToString() + " ";
                pyramidRow = new StringBuilder(i).Insert(0, "* ", i).ToString();
                spaces = new string(' ', leadSpaceCount).ToString();
                pyramidRow = spaces + pyramidRow;

                Console.WriteLine(pyramidRow);
                leadSpaceCount -= 1;
            }


        }
    }

    public static class Exercise_15
    {
        /*
          15. Write a C# Sharp program to calculate the factorial of a given number. 
            Test Data :
            Input the number : 5
            Expected Output :
            The Factorial of 5 is: 120
         */
        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber();
            int calculation = number;

            for (int i = 1; i < number; i++)
            {
                calculation = calculation * (number - i);
            }

            Console.WriteLine("The factorial of {0} is {1}", number, calculation);
        }
    }

    public static class Exercise_16
    {
        /*
         16. Write a program in C# Sharp to display the n terms of even natural number and their sum.
            Test Data :
            Input number of terms : 5
            Expected Output :
            The even numbers are :2 4 6 8 10
            The Sum of even Natural Number upto 5 terms : 30
         */
        public static void Execute()
        {
            int terms = UtilityMethods.GetValidAbsoluteNumber("Input Number of Terms");
            //int number = 2;
            int calculation = 0;
            string evens = "";

            terms *= 2;

            for (int i = 2; i <= terms; i += 2)
            {
                if (i % 2 == 0)
                {
                    calculation += i;
                    evens += i.ToString() + " ";
                    //number += 2;
                }
            }

            Console.WriteLine("The even numbers are: {0}", evens);
            Console.WriteLine("The Sum of even Natural Numbers upto 5 terms: {0}", calculation);

        }
    }

    public static class Exercise_17
    {
        /*
          17. Write a program in C# Sharp to make such a pattern like a pyramid 
            with a number which will repeat the number in the same row. 
               1
              2 2
             3 3 3
            4 4 4 4
         */
        public static void Execute()
        {
            int pyramidHeight = UtilityMethods.GetValidAbsoluteNumber("Enter pyramid height");
            int spaceMultiplier = 0; int numberOfSpaces = 0;
            string spaces = ""; string trailingSpaces = "";
            string row = "";

            for (int i = 1; i <= pyramidHeight; i++)
            {
                spaceMultiplier = pyramidHeight.ToString().Length - i.ToString().Length + 1;
                numberOfSpaces = (pyramidHeight * spaceMultiplier / 2) - ((i * spaceMultiplier) / 2);

                spaces = new string(' ', numberOfSpaces);
                trailingSpaces = new string(' ', spaceMultiplier);

                for (int r = 1; r <= i; r++)
                {
                    row += string.Concat(i.ToString(), trailingSpaces);
                }

                row = spaces + row;

                Console.WriteLine(row);

                row = "";
            }
        }
    }

    public static class Exercise_20
    {
        /*20. Write a program in C# Sharp to display the pattern like pyramid using an asterisk 
            and each row contain an odd number of an asterisks. 
              *
             ***
            *****
           *******
        */
        public static void Execute()
        {
            int pyramidHeight = UtilityMethods.GetValidAbsoluteNumber("Enter pyramid height");
            int PyramidBaseWidth = pyramidHeight * 2;
            string pyramidBlock = "";

            //using an array grid to create the space/asterisk plot the creates the pyramid
            string[,] pyramid = new string[pyramidHeight, PyramidBaseWidth];

            for (int row = 0; row < pyramidHeight; row++)
            {
                for (int column = 0; column < PyramidBaseWidth; column++)
                {
                    //(PyramidBaseWidth-1) is used because columns are zero based
                    pyramidBlock = column >= (PyramidBaseWidth - 1) / 2 - row & column <= (PyramidBaseWidth - 1) / 2 + row ? "*" : " ";
                    pyramid[row, column] = pyramidBlock;
                }

            }

            printPyramid(pyramid);

        }

        public static void printPyramid(string[,] pyramid)
        {
            for (int row = 0; row <= pyramid.GetUpperBound(0); row++)
            {
                for (int column = 0; column < pyramid.GetUpperBound(1); column++)
                {
                    Console.Write(pyramid[row, column]);
                }

                Console.WriteLine();
            }

        }
    }

    public static class Exercise_21
    {
        /*
          21. Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...]. 
            Test Data :
            Input the number or terms :5
            Expected Output :
            9 99 999 9999 99999
            The sum of the series = 111105
         */

        public static void Execute()
        {
            int terms = UtilityMethods.GetValidAbsoluteNumber("Enter number of terms");
            Int64 sum = 0;
            string summand = "";

            for (int i = 1; i <= terms; i++)
            {
                summand += "9";
                sum += Int64.Parse(summand);
            }

            Console.WriteLine("The sum of the series = {0}", sum);
        }
    }

    public static class Exercise_22
    {
        /*
         * 22. Write a program in C# Sharp to print the Floyd's Triangle. 
            1
            01 
            101
            0101 
            10101
        */

        public static void Execute()
        {
            int triangleHeight = UtilityMethods.GetValidAbsoluteNumber("Enter triangle height");
            string triangleRow = "";
            char triangleBlock = '0';

            for (int i = 0; i < triangleHeight; i++)
            {
                triangleBlock = triangleBlock == '1' ? '0' : '1';
                triangleRow += triangleBlock;
                Console.WriteLine(triangleRow);
            }
        }
    }

    public static class Exercise_23
    {
        /*
         * 23. Write a program in C# Sharp to display the sum of the series [ 1+x+x^2/2!+x^3/3!+....]. 
            Test Data :
            Input the value of x :3
            Input number of terms : 5
            Expected Output :
            The sum is : 16.375000
            Number of terms = 5
            The value of x = 3.000000
         */

    }

    public static class Exercise_25
    {
        /*
         25. Write a program in C# Sharp to display the n terms of square natural number and their sum. 
            1 4 9 16 ... n Terms
            Test Data :
            Input the number of terms : 5
            Expected Output :
            The square natural upto 5 terms are :1 4 9 16 25
            The Sum of Square Natural Number upto 5 terms = 55
        */

        public static void Execute()
        {
            int terms = UtilityMethods.GetValidAbsoluteNumber("Input the number of terms");
            int square = 0;
            int sum = 0;
            string squares = "";

            for (int i = 1; i <= terms; i++)
            {
                square = i * i;
                squares += square.ToString() + " ";
                sum += square;
            }

            Console.WriteLine($"The square natural upto {terms} terms are {squares}");
            Console.WriteLine($"The Sum of Square Natural Number up to {terms} terms = {sum}");

        }
    }

    public static class Exercise_26
    {
        /*
         26. Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms.
            Test Data :
            Input the number of terms : 5
            Expected Output :
            1 + 11 + 111 + 1111 + 11111 +
            The Sum is : 12345
         */

        public static void Execute()
        {
            int terms = UtilityMethods.GetValidAbsoluteNumber("Number of methods");
            string number = "";
            string output = "";
            int sum = 0;

            for (int n = 1; n <= terms; n++)
            {
                number = new string('1', n).ToString();
                sum += int.Parse(number);
                output += number + " + ";
            }

            Console.WriteLine(output);
            Console.WriteLine(sum);
        }
    }

    public static class Exercise_27
    {
        /*
         27. Write a C# Sharp program to check whether a given number is perfect number or not.
            Test Data :
            Input the number : 56
            Expected Output :
            The positive divisor : 1 2 4 7 8 14 28
            The sum of the divisor is : 64
            So, the number is not perfect.
         */

        public static void Execute()
        {
            Console.WriteLine("skipped");
        }

    }

    public static class Exercise_28
    {
        /*
         * 28. Write a C# Sharp program to find the perfect numbers within a given range of number. 
            Test Data :
            Input the starting range or number : 1
            Input the ending range of number : 50
            Expected Output :
            The Perfect numbers within the given range : 6 28
        */
    }

    public static class Exercise_31
    {
        /*
        31. Write a program in C# Sharp to display the pattern like a diamond. 
            *
           ***
          *****
         *******
        *********
         *******
          *****
           ***
            *
        */

        public static void Execute()
        {
            int height = UtilityMethods.GetValidAbsoluteNumber("Enter diamond height");
            int numberOfSpace = height + 1;
            int numberOfBlocks = 1;
            string spaces = ""; string row = "";

            for (int i = 1; i <= height; i += 1)
            {
                spaces = new string(' ', numberOfSpace);
                row = new string('*', numberOfBlocks);

                Console.WriteLine(spaces + row);

                numberOfBlocks += 2;
                if (numberOfSpace > 0) numberOfSpace--;
            }

            numberOfSpace += 2;
            numberOfBlocks -= 4;

            for (int r = 1; r < height; r += 1)
            {
                spaces = new string(' ', numberOfSpace);
                row = new string('*', numberOfBlocks);

                Console.WriteLine(spaces + row);

                numberOfBlocks -= 2;
                numberOfSpace++;
            }

        }
    }

    public static class Exercise_32
    {
        /*32. Write a C# Sharp program to determine whether a given number is prime or not. 
         Test Data :
        Input a number: 13
        Expected Output :
        13 is a prime number.
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber();

            int half = number / 2;

            bool prime = true;
            int quotient = 0; int remainder = 0;

            if (number > 0)
            {
                for (int i = half; i > 2; i--)
                {
                    quotient = Math.DivRem(number, i, out remainder);

                    if (quotient > 1 & remainder == 0)
                    {
                        prime = false;
                        break;
                    };
                }
            }
            else
            {
                prime = false;
            }


            Console.WriteLine(prime);
        }
    }

    public static class Exercise_33
    {
        /*
          Write a C# Sharp program to display by Pascal's triangle. 
         Test Data :
        Input number of rows: 5
        Expected Output :

        1 1 1 1 2 1 1 3 3 1 1 4 6 4 1
         */

        public static void Execute()
        {
            int triangleHeight = UtilityMethods.GetValidAbsoluteNumber("Enter triangle height");

            int triangleWidth = triangleHeight * 2;//The base is twice the height because of the staggered blocks

            int[,] triangleArray = new int[triangleHeight, triangleWidth];

            int trianglePointer = triangleHeight; //The top-most block is always = to the height
            int endColumn = triangleHeight;

            //Fill the blocks
            for (int row = 0; row < triangleHeight; row++)
            {
                //int column = trianglePointer;

                //columns
                for (int startColumn = trianglePointer; startColumn <= endColumn; startColumn += 2)
                {
                    triangleArray[row, startColumn] = calculatePascal(triangleArray, row, startColumn);
                    //column += 2;
                }

                endColumn++; //Increment the number of blocks plus empty for each row interation
                trianglePointer--;//Reposition the start of the blocks each row
            }

            printTriangle(triangleArray);
        }

        private static int calculatePascal(int[,] Array, int row, int column)
        {
            int previousRow = row - 1;
            int columnToLeft = column - 1 < Array.GetLowerBound(1) ? 0 : column - 1;
            int columnToRight = column + 1 < Array.GetLowerBound(1) ? 0 : column + 1;
            int columnToLeftValue = previousRow >= 0 & previousRow < Array.GetUpperBound(0) & columnToLeft > 0 & columnToLeft < Array.GetUpperBound(1) ? Array[previousRow, columnToLeft] : 0;
            int columnToRightValue = previousRow >= 0 & previousRow < Array.GetUpperBound(0) & columnToRight > 0 & columnToRight < Array.GetUpperBound(1) ? Array[previousRow, columnToRight] : 0;

            int pascal = columnToLeftValue + columnToRightValue;
            pascal = pascal == 0 ? 1 : pascal;

            return pascal;
        }

        private static void printTriangle(int[,] triangleArray)
        {
            string value = "";

            for (int row = 0; row < triangleArray.GetLength(0); row++)
            {
                for (int column = 0; column < triangleArray.GetLength(1); column++)
                {
                    value = triangleArray[row, column].ToString();

                    value = (value == "0" ? " " : value);

                    Console.Write(value);
                }

                Console.WriteLine();
            }

        }
    }

    public static class Exercise_34
    {
        /*
          34. Write a program in C# Sharp to find the prime numbers within a range of numbers. 
            Test Data :
                Input starting number of range: 1
                Input ending number of range : 50
                Expected Output :
                The prime number between 1 and 50 are :
                    2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
        */

        public static void Execute()
        {
            int starting = UtilityMethods.GetValidAbsoluteNumber("Input starting number of range");
            int ending = UtilityMethods.GetValidAbsoluteNumber("Input ending number of range");

            int square = 0;

            Boolean prime = true;

            //prime must be greater than 1
            starting = starting < 2 ? 2 : starting;

            for (int n = starting; n <= ending; n++)
            {
                square = Convert.ToInt32(Math.Sqrt(n));
                prime = true;

                //Test for primacy 
                for (int m = 2; m <= square; m++)
                {
                    if (n % m == 0)
                    {
                        prime = false;

                    }
                }

                if (prime == true) Console.WriteLine(n);
            }

        }
    }

    public static class Exercise_35
    {
        /*
         * Fibonacci series 0 1 2 3 5 8 13 .....
            Test Data :
            Input number of terms to display : 10
            Expected Output :
            Here is the Fibonacci series upto to 10 terms :
            0 1 1 2 3 5 8 13 21 34
         */

        public static void Execute()
        {
            int terms = UtilityMethods.GetValidAbsoluteNumber("Input number of terms to display");
            int fib = 0;
            int previous1 = 0; int previous2 = 1;

            Console.WriteLine(0);

            for (int n = 0; n <= terms; n++)
            {
                fib = previous2 + previous1;

                Console.WriteLine(fib);

                previous2 = previous1;
                previous1 = fib;

            }

        }
    }

    public static class Exercise_36
    {
        /*
          Write a program in C# Sharp to display the such a pattern for n number of rows using a number which will start with the number 1 and the first and a last number of each row will be 1. Go to the editor

          1
         121
        12321
         */

        public static void Execute()
        {
            int numberOfRows = UtilityMethods.GetValidAbsoluteNumber("Enter number of rows to display");
            string spaces = ""; int numberOfSpaces = numberOfRows * 2;

            for (int n = 1; n <= numberOfRows; n++)
            {
                //spaces
                spaces = new string(' ', numberOfSpaces);

                Console.Write(spaces);

                for (int up = 1; up <= n; up++)
                {
                    Console.Write(up);

                }

                for (int down = n - 1; down > 0; down--)
                {
                    Console.Write(down);
                }
                Console.WriteLine();
                numberOfSpaces--;
            }

        }
    }

    public static class Exercise_37
    {
        /*
         * 37. Write a program in C# Sharp to display the number in reverse order. 
            Test Data :
            Input a number: 12345
            Expected Output :
            The number in reverse order is : 54321
         */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber();

            //Reverse a string by converting to a char array
            char[] array = number.ToString().ToCharArray();

            Array.Reverse(array);

            string numberReversed = new string(array);

            Console.WriteLine($"The number in reverse order: {numberReversed}");

        }
    }

    public static class Exercise_38
    {
        /*
         * 38. Write a program in C# Sharp to check whether a number is a palindrome or not. 
            Test Data :
            Input a number: 121
            Expected Output :
            121 is a palindrome number.
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber();

            char[] array = number.ToString().ToCharArray();

            Array.Reverse(array);

            string numberReversed = new string(array);

            if (number.ToString() == numberReversed)
            {
                Console.WriteLine("{0} is a palindrome number", number);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome number", number);
            }
        }
    }

    public static class Exercise_40
    {
        /*
         * 40. Write a C# Sharp Program to display the following pattern using the alphabet. 

            A
            A B A 
            A B C B A
            A B C D C B A 
         */

        public static void Execute()
        {
            int begin = 65;
            int stop = begin;

            for (int r = 1; r <= 24; r++)
            {


                for (int l = begin; l <= stop; l++)
                {
                    Console.Write((char)l);

                    //for( int lb = l; l >= 0; l--)
                    //{

                    //}
                }

                for (int l = stop - 1; l >= begin; l--)
                {
                    Console.Write((char)l);

                    //for( int lb = l; l >= 0; l--)
                    //{

                    //}
                }

                stop++;
                Console.WriteLine();
            }

        }
    }

    public static class Exercise_41
    {
        /*
         Write a program in C# Sharp to convert a decimal number into binary without using an array. 
            Test Data :
            Enter a number to convert : 25
            Expected Output :
            The Binary of 25 is 11001.
         */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber("Enter a number to convert ");
            int quotient = number;
            int remainder = 0;
            string binaryString = "";

            while (quotient > 0)
            {
                remainder = quotient % 2;
                quotient = quotient / 2;

                binaryString = remainder.ToString() + binaryString;
            }

            Console.WriteLine(binaryString);
        }
    }

    public static class Exercise_42
    {
        /*
         * 42. Write a program in C# Sharp to convert a binary number into a decimal number without using array, function and while loop.
            Test Data :
            Input a binary number :1010101
            Expected Output :
            The Binary Number : 1010101
            The equivalent Decimal Number : 85
        */

        public static void Execute()
        {
            int binary = UtilityMethods.GetValidAbsoluteNumber("Enter binary number");

            string binaryString = binary.ToString();

            int numberofDigits = binaryString.Length;

            int decimalNumber = 0;

            int multiplier = 0;

            int currentBinaryDigit = 0;

            char[] binaryCharArray = binaryString.ToCharArray();
            binaryCharArray.Reverse();

            binaryString = new string(binaryCharArray);

            for (int d = 0; d < numberofDigits; d++)
            {
                currentBinaryDigit = int.Parse(binaryString.Substring(d, 1));

                if (currentBinaryDigit == 1)
                {
                    multiplier = (int)Math.Pow(2, d);//two times the power of the binary digit number
                    multiplier = multiplier == 0 ? currentBinaryDigit : multiplier;//first binary digit is not a power of two
                    decimalNumber += (currentBinaryDigit * multiplier);
                }
            }

            Console.WriteLine(decimalNumber);
        }
    }

    public static class Exercise_43
    {
        /*
         * 43. Write a C# Sharp program to find HCF (Highest Common Factor) of two numbers. 
            Test Data :
            Input 1st number for HCF: 24
            Input 2nd number for HCF: 28
            Expected Output :
            HCF of 24 and 28 is : 4
        */

        public static void Execute()
        {
            int firstNumber = UtilityMethods.GetValidAbsoluteNumber("Input 1st number for HCF");
            int secondNumber = UtilityMethods.GetValidAbsoluteNumber("Input 2nd number for HCF");
            int firstFactor = 0; int firstRemainder = 0;
            int secondFactor = 0; int secondRemainder = 0;

            List<int> firstFactors = new List<int>();
            List<int> secondFactors = new List<int>();

            for (int f = 2; f <= (firstNumber / 2); f++)
            {
                firstFactor = firstNumber / f;
                firstRemainder = firstNumber % f;

                if (firstRemainder == 0) firstFactors.Add(firstFactor);   //Console.WriteLine(firstFactor);
            }

            for (int s = 2; s <= (secondNumber / 2); s++)
            {
                secondFactor = secondNumber / s;
                secondRemainder = secondNumber % s;

                if (secondRemainder == 0) secondFactors.Add(secondFactor); // Console.WriteLine(secondFactor);
            }

            firstFactors.OrderByDescending(a => a);

            foreach (var item in firstFactors)
            {
                if (secondFactors.Contains(item))
                {
                    Console.WriteLine($"{item} yes");
                    break;
                }
            }

            //Console.WriteLine($"contains: {firstFactors.Contains(4)}");
        }
    }

    public static class Exercise_44
    {
        public static void Execute()
        {
            Console.WriteLine("skip");
        }
    }

    public static class Exercise_45
    {
        /*
         45. Write a program in C# Sharp to find LCM of any two numbers. 
            Test Data :
            Input 1st number for LCM: 15
            Input 2nd number for LCM: 20
            Expected Output :
            The LCM of 15 and 20 is : 60
        */

        public static void Execute()
        {
            int firstNumber = UtilityMethods.GetValidAbsoluteNumber("Input 1st number for LCM");
            int secondNumber = UtilityMethods.GetValidAbsoluteNumber("Input 2nd number for LCM");

            int maxNumber = 0; int minNumber = 0;

            if (firstNumber > secondNumber)
            {
                maxNumber = firstNumber;
                minNumber = secondNumber;
            }
            else
            {
                maxNumber = secondNumber;
                minNumber = firstNumber;
            };

            for (int x = 2; ; x++)
            {
                if ((maxNumber * x) % minNumber == 0)
                {
                    Console.WriteLine($"The LCM is: {x * maxNumber}");

                    break;
                }

            }
        }
    }

    public static class Exercise_46
    {
        /*
         * 46. Write a program in C# Sharp to convert a binary number into a decimal number using math function. 
            Test Data :
            Input the binary number :1010100
            Expected Output :
            The Binary Number : 1010100
            The equivalent Decimal Number is : 84
        */

        public static void Execute()
        {
            //Already did this in Exercise 42
            Exercise_42.Execute();
        }
    }

    public static class Exercise_47
    {
        /*
         47. Write a C# Sharp program to check whether a number is a Strong Number or not. 
            Test Data :
            Input a number to check whether it is Strong number: 15
            Expected Output :
            15 is not Strong number.
         */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber();
            string numberString = number.ToString();
            char[] digits = numberString.ToCharArray();

            //Recompose the char-array
            int[] intArray = Array.ConvertAll(digits, c => (int)Char.GetNumericValue(c));


            int factorialSum = 0;

            string returnMessage = "is not a strong number";

            foreach (char digit in intArray)
            {

                factorialSum += factorial(digit);
            }

            if (factorialSum == number) returnMessage = "is a strong number";

            Console.WriteLine($"{number} {returnMessage}");

        }

        public static int factorial(int number)
        {
            int factorial = number;

            for (int i = number - 1; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }

    public static class Exercise_48
    {
        /*
          48. Write a C# Sharp program to find Strong Numbers within a range of numbers. \
            Test Data :
            Input starting range of number : 1
            Input ending range of number: 200
            Expected Output :
            The Strong numbers are :
            1 2 145
        */
        public static void Execute()
        {
            int lower = UtilityMethods.GetValidAbsoluteNumber("Enter lowest number");
            int higher = UtilityMethods.GetValidAbsoluteNumber("Enter highest number");

            for (int n = lower; n <= higher; n++)
            {
                if (strong(n)) Console.Write($"{n} ");
            }
        }

        private static Boolean strong(int number)
        {
            char[] digitsCharArray = number.ToString().ToCharArray();
            int[] digitsArray = Array.ConvertAll(digitsCharArray, d => (int)char.GetNumericValue(d)).ToArray();
            int factorialSum = 0;

            foreach (int digit in digitsArray)
            {
                factorialSum += Exercise_47.factorial(digit);
            }

            if (factorialSum == number) return true;
            return false;
        }
    }

    public static class Exercise_49
    {
        /*
         * 49. Write a C# Sharp program to find out the sum of in A.P. series. 
            Test Data :
            Input the starting number of the A.P. series: 1
            Input the number of items for the A.P. series: 10
            Input the common difference of A.P. series: 4
            Expected Output :
            The Sum of the A.P. series are :
            1 + 5 + 9 + 13 + 17 + 21 + 25 + 29 + 33 + 37 = 190
        */

        public static void Execute()
        {
            int starting = UtilityMethods.GetValidAbsoluteNumber(" Input the starting number of the A.P. series");
            int numItems = UtilityMethods.GetValidAbsoluteNumber("Input the number of items for the A.P. series");
            int commonDiff = UtilityMethods.GetValidAbsoluteNumber("Input the common difference of A.P. series");
            int series = starting;
            int sum = starting;

            for (int x = 1; x < numItems; x++)
            {
                Console.Write($"{series} ");
                series += commonDiff;
                sum += series;
            }

            Console.Write($" = {sum}");
        }
    }

    public static class Exercise_50
    {
        /*
         * 50. Write a program in C# Sharp to convert a decimal number into octal without using an array. 
            Test Data :
            Enter a number to convert : 79
            Expected Output :
            The Octal of 79 is 117.
         */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber("Enter number to convert to octal");
            int highestPower = 0;
            string octal = "";

            //The remainder of the quotient divided by the highest power is the next quotient
            for (int quotient = number; quotient > 0; quotient = quotient %= highestPower)
            {

                //get highest power
                for (int hp = 1; hp <= quotient; hp *= 8)
                {
                    highestPower = hp;

                }

                //divide quotient by highest power to get next rightmost digit in octal
                octal += (quotient / highestPower).ToString();

            }

            Console.WriteLine($"The octal is: {octal}");
        }
    }

    public static class Exercise_51
    {
        /*
         * 51. Write a program in C# Sharp to convert an octal number to decimal without using array. 
            Test Data :
            Input an octal number (using digit 0 - 7) :745
            Expected Output :
            The Octal Number : 745
            The equivalent Decimal Number : 485
         */

        public static void Execute()
        {
            int octal = UtilityMethods.GetValidAbsoluteNumber("Input an octal number (using digit 0 - 7)");
            string octalString = octal.ToString();
            int numberOfDigits = octalString.Length;
            int digit = 0; int digitValue = 0;
            string decimalString = ""; int decimalNumber = 0;
            int power = numberOfDigits - 1;

            for (int x = 0; x < numberOfDigits; x++)
            {
                digit = int.Parse(octalString.Substring(x, 1));
                digitValue = (int)Math.Pow(8, power) * digit;
                decimalNumber += digitValue;

                power--;
                // Console.WriteLine($"{octalString.Substring(x, 1)} {(int)Math.Pow( 8, x )}");
            }

            Console.WriteLine(decimalNumber);
        }
    }

    public static class Exercise_52
    {
        /*
         * 52. Write a program in C# Sharp to find the Sum of GP series.
        Test Data :
        Input the first number of the G.P. series: 1
        Input the number or terms in the G.P. series: 5
        Input the common ratio of G.P. series: 2
        Expected Output :
        The numbers for the G.P. series:
        1 2 4 8 16 32
        The tn terms of G.P. : 16.000000
        The Sum of the G.P. series : 63.000000 
        */

        public static void Execute()
        {
            int firstNumber = UtilityMethods.GetValidAbsoluteNumber("Input the first number of the G.P. series");
            int terms = UtilityMethods.GetValidAbsoluteNumber(" Input the number or terms in the G.P. series");
            int ratio = UtilityMethods.GetValidAbsoluteNumber("Input the common ratio of G.P. series");
            int number = firstNumber;
            int sum = firstNumber;

            Console.Write($"{number} ");

            for (int n = 1; n <= terms; n++)
            {
                
                number *= ratio;
                sum += number;
                Console.Write($"{number} ");
            }

            Console.WriteLine("The Sum of the G.P. series: {0}", sum);
        }
    }

    public static class Exercise_53
    {
        /*
         * 53. Write a program in C# Sharp to convert a binary number to octal. 
            Test Data :
            Input a binary number :1001
            Expected Output :
            The Binary Number : 1001
            The equivalent Octal Number : 11
         */

        public static void Execute()
        {
            int binary = UtilityMethods.GetValidAbsoluteNumber("Input a binary number");
            string binaryString = binary.ToString();
            int numberOfDigits = binaryString.Length;
            int binaryDigit = 0;  int binaryDigitSum = 0;
            int power = 1;

            //binary to decimal
            for( int d = numberOfDigits - 1; d > -1; d--)
            {
                binaryDigit = int.Parse(binaryString.Substring(d, 1));

                binaryDigitSum += binaryDigit * power;

                //Console.WriteLine(binaryString.Substring(d, 1));

                power *= 2;
            }

           //Console.WriteLine(binaryDigitSum);

            //Decimal to Octal
            int number = binaryDigitSum;
            int highestPower = 0;
            string octal = "";

            //The remainder of the quotient divided by the highest power is the next quotient
            for (int quotient = number; quotient > 0; quotient = quotient %= highestPower)
            {

                //get highest power
                for (int hp = 1; hp <= quotient; hp *= 8)
                {
                    highestPower = hp;

                }

                //divide quotient by highest power to get next rightmost digit in octal
                octal += (quotient / highestPower).ToString();

            }

            Console.WriteLine($"The equivalent Octal Number: {octal}");
        }
    }

    public static class Exercise_54
    {
        /*
         54. Write a program in C# Sharp to convert an octal number into binary. 
            Test Data :
            Input an octal number :11
            Expected Output :
            The Octal Number : 11
            The equivalent Binary Number : 1001
        */

        public static void Execute()
        {
            int octal = UtilityMethods.GetValidAbsoluteNumber("Input an octal number");

            int decimalNumber = OctalToInt(octal);
            int binaryNumber = decimalToBinary(decimalNumber);

            Console.WriteLine(binaryNumber);
        }

        public static int OctalToInt( int octal )
        {
            string octalString = octal.ToString();
            int numOfDigits = octalString.Length;
            int digit = 0;
            int power = 1;
            int digitSum = 0;

            for( int d = 0; d < numOfDigits; d++ )
            {
                digit = int.Parse( octalString.Substring(d, 1) );
                digitSum += digit * power;
                power *= 8;
            }

            return digitSum;
        }

        public static int decimalToBinary( int decimalNumber )
        {
            string binaryString = "";
            int binaryNumber = 0;

            for( int d = decimalNumber; d > 0; d = d / 2 )
            {
                binaryString += (d % 2).ToString();
            }

            binaryNumber = int.Parse(binaryString);
            return binaryNumber;
        }
    }

    public static class Exercise_55
    {
        /*
          55. Write a program in C# Sharp to convert a decimal number to hexadecimal. 
            Test Data :
            Input any Decimal number: 79
            Expected Output :
            The equivalent Hexadecimal Number : 4F
        */

        enum hexa
        {
            A = 10
                    , B = 11
                    , C = 12
                    , D = 13
                    , E = 14
                    , F = 15
        };

        public static void Execute()
        {
            int decimalNumber = UtilityMethods.GetValidAbsoluteNumber("Input any Decimal number");
            string hexaString = "";
            string quotient = "";

            //Note that if d is < 16 then d = d % 16 would just keep d's existing value so a condition is necessary
            for( int d = decimalNumber; d > 0; d = d > 16 ? d % 16 : 0 )
            {
                if( d < 16 )
                {
                    quotient = d > 9 ? ((hexa)d).ToString() : d.ToString();
                }
                else
                {
                    quotient = (d / 16) > 9 ? ((hexa)(d / 16)).ToString() : (d / 16).ToString();
                }
                
                hexaString += quotient;
            }

            Console.WriteLine($"The equivalent Hexadecimal Number: {hexaString}");
        }
    }

    public static class Exercise_56
    {
        /*56. Write a program in C# Sharp to Check Whether a Number can be Express as Sum of Two Prime Numbers. 
            Test Data :
            Input a positive integer: 16
            Expected Output :
            16 = 3 + 13
            16 = 5 + 11
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber("Input a positive integer");

            //test if two addends of given number are primes.  
            for (int n = 2; n < number; n++)
            {
                if (isPrime(n) && isPrime(number - n))
                {
                    Console.WriteLine($"{number} = {n} + {number - n}");
                    return;
                }
            }
            Console.WriteLine($"{number} cannot be expressed as a sum of two prime numbers");
        }

        public static Boolean isPrime( int number )
        {
            Boolean prime = true;

            //Check if number is perfectly divisbile by any number between the humber and 1/2 of the number 
            for( int n = 2; n <= (number / 2); n++)
            {
                if (number % n == 0) prime = false;
            }

            return prime;
        }
    }

    public static class Exercise_57
    {
        /*
         * 57. Write a program in C# Sharp to print a string in reverse order. 
            Test Data :
            Input a string to reverse : Welcome
            Expected Output :
            Reversed string is: emocleW
            Click me to see the solution
        */

        public static void Execute()
        {
            string inputString = UtilityMethods.GetValidString("Input a string to reverse");

            var varReverseString = new string( inputString.ToCharArray().Reverse().ToArray() );

            // string reverseString = varReverseString.


            Console.WriteLine("Reversed string is {0}", varReverseString);
        }
    }

    public static class Exercise_58
    {
        /*
         * Write a C#Sharp program to display alphabet pattern like A with an asterisk. 

            Display the pattern like 'A' with an asterisk:                                      
            ---------------------------------------------                                    
                                                                                 
              ***                                                                            
             *   *                                                                           
             *   *                                                                           
             *****                                                                           
             *   *                                                                           
             *   *                                                                           
             *   *                                                                           
             *   * 
         */
        public static void Execute()
        {
            string character = "*";

            for( int a = 0; a < 8; a++ )
            {
                for (int c = 0; c < 5; c++)
                {
                    if (
                         ((a == 1 | a == 2 | a >= 4 ) & c >= 1 & c <= 3)
                         |
                         (a == 0 & (c == 0 | c == 4 ) )
                        )
                    {
                        character = " ";
                    }
                    else { character = "*"; }

                    Console.Write(character);
                }

                Console.WriteLine();
            }
        }

    }

    public static class Exercise_59
    {
        /*
         * 59. Write a C#Sharp program to display alphabet pattern like B with an asterisk.

            Display the pattern like 'B' with an asterisk:                                      
            ---------------------------------------------                                    
                                                                                 
             ****                                                                            
             *   *                                                                           
             *   *                                                                           
             ****                                                                            
             *   *                                                                           
             *   *                                                                           
             ****   
         */

        public static void Execute()
        {
            string character = "*";

            for (int b = 0; b < 7; b++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (
                        ((b != 0 & b != 3 & b != 6) & c != 0 & c != 4)
                        |
                        ( (b == 0 | b == 3 | b == 6 ) & c == 4 )
                        )
                    {
                       character = " ";
                    }
                    else
                    {
                        character = "*";
                    }
                    Console.Write(character);
                }

                Console.WriteLine();

            }

           
        }
    }

    public static class Exercise_83
    {
        /*
         * Write a C#Sharp program to display alphabet pattern like Z with an asterisk. 

            Display the pattern like 'Z' with an asterisk:                                      
            ---------------------------------------------                                    
                                                                                 
            *******                                                                          
                 *                                                                           
                *                                                                            
               *                                                                             
              *                                                                              
             *                                                                               
            *******   
         */

        public static void Execute()
        {
            string character = "*";

            for( int x = 0; x < 7; x ++ )
            {
                Console.Write(character);
            }

            Console.WriteLine();

            for ( int y = 5; y > 0; y-- )
            {
                Console.WriteLine(new string(' ', y - 1) + "*" );
            }

            for (int z = 0; z < 7; z++)
            {
                Console.Write(character);
            }
        }
    }
}