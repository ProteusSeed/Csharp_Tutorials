using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Basic_Algorithm_Exercises
{

    public static class Exercise_1
    {
        /*
            1. Write a C# Sharp program to compute the sum of the two given integer values. 
            If the two values are the same, then return triple their sum. 
            Expected Output: 
                3
                5
                12   
        */

        public static void Execute()
        {
            int intOne = UtilityMethods.GetValidNumber();
            int intTwo = UtilityMethods.GetValidNumber();
            int result = 0;

            if (intOne == intTwo)
            {
                result = (intOne + intTwo) * 3;
            }
            else
            {
                result = (intOne + intTwo);
            }

            Console.WriteLine("Triple the sum is: {0}", result);

        }
    }

    public static class Exercise_2
    {
        /*
        2. Write a C# Sharp program to get the absolute difference between n and 51. 
        If n is greater than 51 return triple the absolute difference. 
            Expected Output: 
            6
            21
            0
        */

        public static void Execute()
        {
            int n = UtilityMethods.GetValidNumber();
            int result = Math.Abs( n - 51);

            result = n > 51 ? result * 3 : result;

            Console.WriteLine("Result: {0}", result);
        }

    }

    public static class Exercise_3
    {
        /*
         * 3. Write a C# Sharp program to check two given integers, 
            and return true if one of them is 30 or if their sum is 30. 
            Expected Output: 
            True
            True
            True
            False
        */

        public static void Execute()
        {
            int intOne = UtilityMethods.GetValidNumber();
            int intTwo = UtilityMethods.GetValidNumber();
            bool result = false;

            result = intOne == 30 | intTwo == 30 | intTwo + intTwo == 30 ? true : false;

            Console.WriteLine("One number is 30 or the sum of these two numbers is 30: {0}", result);

        }
    }

    public static class Exercise_4
    {
        /*
          4. Write a C# Sharp program to check a given integer 
          and return true if it is within 10 of 100 or 200. 
            Expected Output: 
            True
            True
            False
        */

        public static void Execute()
        {
            int integer = UtilityMethods.GetValidNumber();
            bool result = false;

            result = Math.Abs(100 - integer) <= 10 | Math.Abs(200 - integer) <= 10;

            Console.WriteLine(result);
        }
    }

    public static class Exercise_5
    {
        /*
          5. Write a C# Sharp program to create a new string 
          where 'if' is added to the front of a given string. 
          If the string already begins with 'if', return the string unchanged. 
            Expected Output: 
            if else
            not else
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            theString = theString.ToLower().IndexOf("if") == 0 ? theString : "if " + theString;

            Console.WriteLine(theString);
        }
    }

    public static class Exercise_6
    {
        /*
          6. Write a C# Sharp program to remove the character 
          in a given position of a given string. 
          The given position will be in the range 0.. string length -1 inclusive. 
            Expected Output: 
            Pthon
            ython
            Pythn
         */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            int position = getStringPosition( theString );

            theString = theString.Remove(position, 1);

            Console.WriteLine(theString);
        }

        static int getStringPosition(string theString )
        {
            int position = theString.Length;
            string errMsg = "";
            
            while (position >= theString.Length)
            {
                Console.WriteLine(errMsg);
                position = UtilityMethods.GetValidNumber();
                errMsg = "Character position must be between zero and less than the string length which is " + theString.Length;
            }

            return position;
        }
    }

    public static class Exercise_7
    {
        /*
          7. Write a C# Sharp program to exchange the first and last characters 
            in a given string and return the new string.
            Expected Output: 
            dbca
            a
            yx
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            theString = theString.Substring(theString.Length - 1, 1) + theString.Substring(1, theString.Length - 2) + theString.Substring(0, 1);

            Console.WriteLine(theString);
        }
    }

    public static class Exercise_8
    {
        /*
         * 8. Write a C# Sharp program to create a new string 
            which is 4 copies of the 2 front characters of a given string. 
            If the given string length is less than 2 return the original string. 
            Expected Output: 
            C C C C 
            JSJSJSJS
            a
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();                      

            if (theString.Length >= 2)
            {
                for (int i = 1; i <= 4; i++)
                {
                    theString = theString.Substring(0, 2);
                    Console.Write(theString);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine(theString);
            }
        }
    }

    public static class Exercise_9
    {
        /*
          9. Write a C# Sharp program to create a new string with the last char added 
            at the front and back of a given string of length 1 or more. 
            Expected Output: 
            dRedd
            nGreenn
            111
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            if(theString.Length >= 1)
            {
                theString = theString.Substring(theString.Length - 1, 1) + theString + theString.Substring(theString.Length - 1, 1);
            }

                Console.WriteLine(theString);
            
        }
    }

    public static class Exercise_10
    {
        /*
          10. Write a C# Sharp program to check if a given positive number 
          is a multiple of 3 or a multiple of 7. 
            Expected Output: 
            True
            True
            True
            False
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidNumber();
            int multiple = 0;

            multiple = number % 3 == 0 ? 3 : number % 7 == 0 ? 7 : 0;

            if (multiple > 0)
            {
                Console.WriteLine("{0} is a multiple of {1}", number, multiple);
            }
            else
            {
                Console.WriteLine("{0} is not a multiple of 3 or 7");
            }
        }
    }

    public static class Exercise_11
    {
        /*
         * 11. Write a C# Sharp program to create a new string 
         taking the first 3 characters of a given string and return the string 
         with the 3 characters added at both the front and back. 
         If the given string length is less than 3, use whatever characters are there. 
        Expected Output: 
        PytPythonPyt
        JSJSJS
        CodCodeCod
         */
        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            if (theString.Length >= 3)
            {
                theString = theString.Substring(0, 3) + theString + theString.Substring(0, 3);
            }
            else
            {
                theString = theString + theString + theString;
            }

            Console.WriteLine(theString);

        }
    }

    public static class Exercise_12
    {
        /*
          12. Write a C# Sharp program to check if a given string starts with 'C#' or not. 
            Expected Output: 
            True
            True
            False
         */
        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            bool starts = theString.IndexOf("C#") == 0 ? true : false;

            Console.WriteLine("String begins with \"c#\": {0}", starts);
        }
    }

    public static class Exercise_13
    {
        /*13. Write a C# Sharp program to check if one given temperatures 
            is less than 0 and the other is greater than 100. 
            Expected Output: 
            True
            True
            False
        */

        public class temps
        {
            private decimal temp1;
            private decimal temp2;

            public decimal Temp1 {
                                get { return temp1; }
                                set { temp1 = value;  }
                             }
            public decimal Temp2 {
                                get { return temp2; }
                                set { temp2 = value;  }        
                             }

            public bool evaluate()
            {
                if ( (temp1 < 0 & temp2 > 100) | (temp1 > 0 & temp2 < 100) )
                {
                    return true;
                }
                return false;
            }
        }

        public static void Execute()
        {
            temps temperatures = new temps();

            temperatures.Temp1 = UtilityMethods.GetValidDecimal("Enter 1st temperature: ");
            temperatures.Temp2 = UtilityMethods.GetValidDecimal("Enter 2nd temperature: ");

            Console.WriteLine("One temp is less than zero and the other greater than 100: {0}", temperatures.evaluate());
        }
    }

    public static class Exercise_14
    {
        /*
          14. Write a C# Sharp program to check two given integers whether 
            either of them is in the range 100..200 inclusive. 
            Expected Output: 
            True
            False
            True
         */

        public class integers
        {
            public readonly int integer1;
            public readonly int integer2;

            public integers(int Integer1, int Integer2)
            {
                integer1 = Integer1;
                integer2 = Integer2;
            }

            public bool evauluate()
            {
                bool ret = false;

                if ( (integer1 >= 100 & integer1 <= 200) | (integer2 >= 100 & integer2 <= 200))
                {
                    ret = true;
                }
                return ret;
            }
        }

        public static void Execute()
        {
            int integer1 = UtilityMethods.GetValidNumber();
            int integer2 = UtilityMethods.GetValidNumber();

            integers Integers = new integers(integer1, integer2);

            Console.WriteLine( "Either integer one or integer two are between 100 and 200: {0}", Integers.evauluate() );
        }
    }

}
