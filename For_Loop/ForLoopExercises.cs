using Exercises;
using System;
using System.Collections.Generic;
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
                line = new StringBuilder(i).Insert(0, number.ToString(), i ).ToString();
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
                spaces = new string(' ', ( ( (pyramidHeight - pyramidStep) * spaceMultiplier) / 2));
                pyramidRow = spaces + pyramidRow;

                Console.WriteLine( pyramidRow);
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
                pyramidRow = new StringBuilder(i).Insert(0,"* ",i).ToString();
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
                calculation = calculation * ( number - i );
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
                if ( i % 2 == 0 )
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
                numberOfSpaces = ( pyramidHeight * spaceMultiplier / 2 ) - ( (i * spaceMultiplier) / 2 );

                spaces = new string( ' ', numberOfSpaces );
                trailingSpaces = new string(' ', spaceMultiplier);
                
                for (int r = 1; r <= i; r++)
                {
                    row += string.Concat( i.ToString(), trailingSpaces );   
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
                    pyramidBlock = column >= (PyramidBaseWidth-1) / 2 - row & column <= (PyramidBaseWidth-1) / 2 + row ? "*" : " ";
                    pyramid[row, column] = pyramidBlock;
                }
                
            }

            printPyramid(pyramid);
             
        }

        public static void printPyramid( string[,] pyramid)
        {
            for (int row = 0; row <= pyramid.GetUpperBound(0); row++)
            {
                for (int column = 0; column < pyramid.GetUpperBound(1); column++)
                {
                    Console.Write(pyramid[row,column]);
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


}
