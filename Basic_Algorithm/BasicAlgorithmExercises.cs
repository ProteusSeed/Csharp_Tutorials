using System;
using System.Collections.Generic;
using System.Text;
using Exercises;
using System.Linq;

namespace Basic_Algorithm_Exercises
{
    //https://www.w3resource.com/csharp-exercises/basic-algo/index.php

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

    public static class Exercise_15
    {
        /*
          15. Write a C# Sharp program to check whether three given integer values 
          are in the range 20..50 inclusive. 
          Return true if 1 or more of them are in the said range otherwise false. 
            Expected Output: 
            True
            True
            True
            False
        */

        public class integers
        {
            private int integer1;
            private int integer2;
            private int integer3;

            public int Integer1
            {
                get { return integer1; }
                set { integer1 = value; }
            }

            public int Integer2
            {
                get { return integer2; }
                set { integer2 = value; }
            }

            public int Integer3
            {
                get { return integer3; }
                set { integer3 = value; }
            }

            public bool evaluateRange(int rangeLower, int rangeUpper)
            {
                if (Integer1 >= rangeLower & Integer1 <= rangeUpper) return true;
                if (Integer2 >= rangeLower & Integer2 <= rangeUpper) return true;
                if (Integer3 >= rangeLower & Integer3 <= rangeUpper) return true;

                return false;
            }
        }

        public static void Execute()
        {
            bool isWithinRange;
            int lowerRange = 20; int upperRange = 50;
            integers ints = new integers();

            ints.Integer1 = UtilityMethods.GetValidNumber();
            ints.Integer2 = UtilityMethods.GetValidNumber();
            ints.Integer3 = UtilityMethods.GetValidNumber();

            isWithinRange = ints.evaluateRange(lowerRange, upperRange);

            Console.WriteLine("On of these numbers is between {1} and {2}: {0}", isWithinRange, lowerRange, upperRange);
        }
    }

    public static class Exercise_16
    {
        /*
         16. Write a C# Sharp program to check whether two given integer values
         are in the range 20..50 inclusive. 
         Return true if 1 or other is in the said range otherwise false.
            Expected Output: 
            True
            True
            True
            False
        */

        public class ints
        {
            //auto implemented properties
            public int integer1 { get; set; }
            public int integer2 { get; set; }

            public bool evaluateRange( int lowerRange, int upperRange )
            {
                bool int1Truth = integer1 >= lowerRange & integer1 <= upperRange;
                bool int2Truth = integer2 >= lowerRange & integer2 <= upperRange;

                if (int1Truth ^ int2Truth) return true;

                return false;
            }
        }

        public static void Execute()
        {
            int lowerRange = 20;
            int upperRange = 50;

            ints integers = new ints();

            integers.integer1 = UtilityMethods.GetValidNumber();
            integers.integer2 = UtilityMethods.GetValidNumber();

            Console.WriteLine("Either {0} or {1} is between {2} and {3} but not both: {4}"
                                ,integers.integer1
                                ,integers.integer2
                                ,lowerRange
                                ,upperRange
                                , integers.evaluateRange(lowerRange, upperRange)
                                );
        }
    }

    public static class Exercise_17
    {
        /*17. Write a C# Sharp program to check if a string 'yt' appears 
         at index 1 in a given string. If it appears return a string without 'yt' 
         otherwise return the original string. 
        Expected Output: 
        Phon
        ytade
        jsues
    */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            theString = theString.Replace("yt", "");

            Console.WriteLine(theString);
        }

    }

    public static class Exercise_18
    {
        /*
         * 18. Write a C# Sharp program to check the largest number 
            among three given integers. 
            Expected Output: 
            3
            3
            1
            2
        */

        public class integers
        {
            private int integer1;
            private int integer2;
            private int integer3;

            public integers(int Integer1, int Integer2, int Integer3)
            {
                integer1 = Integer1;
                integer2 = Integer2;
                integer3 = Integer3;
            }

            public int largestInteger()
            {
                int largest = 0;

                largest = integer1 > integer2 ? integer1 : integer2;
                largest = largest > integer3 ? largest : integer3;

                return largest;
            }
        }

        public static void Execute()
        {
            int integer1 = UtilityMethods.GetValidNumber();
            int integer2 = UtilityMethods.GetValidNumber();
            int integer3 = UtilityMethods.GetValidNumber();

            integers ints = new integers(integer1, integer2, integer3);

            Console.WriteLine( "The largest integer is: {0}", ints.largestInteger());
        }
    }

    public static class Exercise_19
    {
        /*19. Write a C# Sharp program to check which number is nearest to the value 100 among two given integers. 
            Return 0 if the two numbers are equal. 
            Expected Output: 
            95
            0
            99
        */

        public class numbers
        {
            public int number1 { get; set; }
            public int number2 { get; set; }

            public int nearest( int nearestTo)
            {
                if (number1 != number2)
                {
                    return (nearestTo - number1) > (nearestTo = number2) ? number1 : number2;
                }
                else { return 0; }
            }
        }

        public static void Execute()
        {
            int nearest = 100;
            numbers nums = new numbers();

            nums.number1 = UtilityMethods.GetValidNumber();
            nums.number2 = UtilityMethods.GetValidNumber();

            Console.WriteLine("{0} is nearest to {1}", nums.nearest(100), nearest);
        }
    }

    public static class Exercise_20
    {
        /*
          20. Write a C# Sharp program to check whether two given integers 
          are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive. 
            Expected Output: 
            False
            False
            True
            True
        */

        public class numbers
        {
            private int number1;
            private int number2;

            public int Number1
            {
                get { return number1; }
                set { number1 = value; }
            }
           public int Number2
            {
                get { return number2; }
                set { number2 = value; }
            }

            public bool range()
            {
                return (number1 >= 40 & number1 <= 50) & (number2 >= 40 & number2 <= 50)
                        | (number1 >= 50 & number1 <= 60) & (number2 >= 50 & number2 <= 60);
            }
        }

        public static void Execute()
        {
            numbers numbs = new numbers();
            numbs.Number1 = UtilityMethods.GetValidNumber();
            numbs.Number2 = UtilityMethods.GetValidNumber();

            Console.WriteLine( "Both numbers are within the ranges 40 - 50 or 50 - 60: {0}", numbs.range());
        }
    }

    public static class Exercise_21
    {
        /*21. Write a C# Sharp program to find the larger value from two positive integer values 
          that is in the range 20..30 inclusive, or return 0 if neither is in that range. 
            Expected Output: 
            0
            30
            25
            28
        */

        public class integers
        {
            private int integer1 = 0;
            private int integer2 = 0;

            public int Integer1 {
                get { return integer1; }
                set { integer1 = value; }
            }

            public int Integer2
            {
                get { return integer2; }
                set { integer2 = value; }
            }

            public integers(int Integer1, int Integer2)
            {
                this.Integer1 = Integer1;
                this.Integer2 = Integer2;
            }

            public integers(){}

            public int getLarger()
            {
                int ret = 0;

                if( integer1 >= 20 & integer1 <= 30 & integer1 > integer2 )
                {
                    ret = integer1;
                }
                else
                {
                    if (integer2 >= 20 & integer2 <= 30 & integer2 > integer1)
                    {
                        ret = integer2;
                    }
                }

                return ret;
            }

        }

        public static void Execute()
        {
            integers ints = new integers();

            ints.Integer1 = UtilityMethods.GetValidNumber();
            ints.Integer2 = UtilityMethods.GetValidNumber();

            int larger = ints.getLarger();

            string strLarger = larger == 0 ? "no number" : larger.ToString();

            Console.WriteLine("{0} is largest and between 20 and 30", strLarger);
        }

    }

    public static class Exercise_22
    {
        /*
          22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters. 
            Expected Output: 
            True
            False
            True
            False
        */

        public static int CountZ(string theString)
        {
            int zCount = 0;
            theString = theString.ToLower();

            //store each individual character in the string as an element in a new array
            char[] charArray = theString.ToCharArray();

            foreach (char character in charArray)
            {
                if (character.ToString() == "z") zCount++;
            }

            return zCount;
        }

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            int zCount = CountZ(theString);
            bool between2and4 = false;

            between2and4 = zCount >= 2 & zCount <= 4 ? true : false;

            Console.WriteLine("The string contains between 2 and 4 'Z' characters: {0}", between2and4);

        }
    }

    public static class Exercise_23
    {
        /*
          23. Write a C# Sharp program to check if two given non-negative integers have the same last digit. 
            Expected Output: 
            False
            True
            True
        */

        public static void Execute()
        {
            string number1 = UtilityMethods.GetValidAbsoluteNumber().ToString();
            string number2 = UtilityMethods.GetValidAbsoluteNumber().ToString();
            bool returnVal = false;

            if( number1[number1.Length - 1] == number2[number1.Length - 1])
            { returnVal = true; };

            Console.WriteLine(returnVal);

        }

    }

    public static class Exercise_24
    {
        /*
         24. Write a C# Sharp program to convert the last 3 characters of a given string in upper case. 
         If the length of the string has less than 3 then uppercase all the characters. 
            Expected Output: 
            PytHON
            JavascrIPT
            JS
            PHP
        */
        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            int position = 0;

            position = theString.Length < 3 ? 0 : theString.Length - 3;

            theString = theString.Substring(0, position ) + theString.Substring(position).ToUpper();

            Console.WriteLine(theString);
        }
    }

    public static class Exercise_25
    {
        /*
         * 25. Write a C# Sharp program to create a new string which is n (non-negative integer) copies of a given string. 
            Expected Output: 
            JSJS
            JSJSJS
            JS
        */

        public static void Execute()
        {
            string stringCopies = "";
            string theString = UtilityMethods.GetValidString();
            int numberOfCopies = UtilityMethods.GetValidAbsoluteNumber("How many copies would you like?");

            for (int i = 0; i < numberOfCopies; i++)
            {
                stringCopies += theString;
            }

            Console.WriteLine(stringCopies);
        }
    }

    public static class Exercise_26
    {
        /*
         * 26. Write a C# Sharp program to create a new string which is n (non-negative integer) 
         * copies of the the first 3 characters of a given string. 
         * If the length of the given string is less than 3 then return n copies of the string. 
            Expected Output: 
            PytPyt
            PytPytPyt
            JSJSJS
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            int numberOfCopies = UtilityMethods.GetValidNumber();
            string truncatedString = theString.Substring(0, theString.Length < 3 ? theString.Length : 3);
            string stringCopies = "";

            for (int i = 0; i < numberOfCopies; i++)
            {
                stringCopies += truncatedString;
            }

            Console.WriteLine(stringCopies);
        }
    }

    public static class Exercise_27
    {
        /*27. Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa".
            Expected Output: 
            2
            2
            3
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString().ToLower();
            int position = 0; int stringIndex = 0;
            short count = 0;

            while (stringIndex >= 0)
            {
                theString = theString.Substring(position);
                stringIndex = theString.IndexOf("aa");//=-1 when not found!
               
                if (stringIndex >= 0)
                {
                    count++;
                    position = stringIndex + 2 < theString.Length ? stringIndex + 2 : theString.Length - 1;                   
                    stringIndex = 0;
                }
            }

            Console.WriteLine($"The string contains \"aa\" {count} times.");
        }
    }

    public static class Exercise_28
    {
        /*
         28. Write a C# Sharp program to check if the first appearance of "a" 
            in a given string is immediately followed by another "a". 
            Expected Output: 
            True
            False
            True
        */
        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            Console.WriteLine( "String begins with aa: {0}", theString.ToLower().IndexOf("aa") == 0 );
        }
    }

    public static class Exercise_29
    {
        /*
         * 29. Write a C# Sharp program to create a new string 
            made of every other character starting with the first from a given string. 
            Expected Output: 
            Pto
            PP
            J
        */
        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            string newString = "";
            string[] splits = theString.Split(",");

            for (int i = 0; i < theString.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newString += theString[i];
                }
            }

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_30
    {
        /*
         * 30. Write a C# Sharp program to create a string like "aababcabcd" 
           from a given string "abcd". 
            Expected Output: 
            aababcabcd
            aababc
            a
        */
        public static void Execute()
        {
            Console.WriteLine("I have no idea what's requested here");
        }
    }

    public static class Exercise_31
    {
        /*
        31. Write a C# Sharp program to count a substring of length 2 appears in a given string 
        and also as the last 2 characters of the string. Do not count the end substring.
        Expected Output: 
        1
        2
        3
        0
        */
        public static void Execute()
        {
            Console.WriteLine("I have no idea what's requested here");
        }
    }

    public static class Exercise_32
    {
        /*
          32. Write a C# Sharp program to check a specified number is present in a given array of integers. 
            Expected Output: 
            True
            True
            False
        */

        public static void Execute()
        {
            int[] numbers = UtilityMethods.getValidNumbersArray();

            int numberToSearch = UtilityMethods.GetValidNumber("Enter number to search for: ");

            bool found = Array.Find(numbers, n => n.Equals(numberToSearch)) > 0 ? true : false;

            Console.WriteLine($"{numberToSearch} exists in the array: {found}");
        }
    }

    public static class Exercise_33
    {
        /*
         * 33. Write a C# Sharp program to check if one of the first 4 elements in an array of integers
            is equal to a given element. 
            Expected Output: 
            True
            True
            False
        */

        public static void Execute()
        {
            int[] integers = UtilityMethods.getValidNumbersArray();
            int number = UtilityMethods.GetValidNumber("Enter number to search for: ");

            int index = Array.FindIndex(integers, i => i.Equals(number));

            bool foundIn4 = index >= 0 & index < 4 ? true : false;

            Console.WriteLine($"{number} found in one of the first four array elements: {foundIn4}");
        }
    }

    public static class Exercise_34
    {
        /*
         * 34. Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 
           appears in a given array of integers somewhere. 
            Expected Output: 
            True
            True
            False
         */

        public static void Execute()
        {
            int[] integers = UtilityMethods.getValidNumbersArray();

            int start = Array.FindIndex(integers, i => i.Equals(1));
            int nextSeq = 2;
            bool isInSeq = false;

            start++;

            for (int i = start; i < start + 2; i++)
            {
                isInSeq = integers[i] == nextSeq ? true : false;

                nextSeq++;
            }

            Console.WriteLine("The number sequence contains 1, 2, 3, {0}", isInSeq);
        }
    }

    public static class Exercise_35
    {
        /*35. 
         Write a C# Sharp program to compare two given strings and return
         the number of the positions where they contain the same length 2 substring. 
            Expected Output: 
            True
            True
            False
        */        

        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString("Enter string 1").ToLower();
            string string2 = UtilityMethods.GetValidString("Enter string 2").ToLower();

            string[] string1Array = StringToArray(string1);
            string[] string2Array = StringToArray(string2);

            int position1 = 0;

            Console.WriteLine();//carriage return.

            //Loop through each set of 2 characters in the 1st string
            Array.ForEach(string1Array, (e) => {

                int position2 = 0;

                //Loop through each set of 2 characters in the 2nd string..
                //and find the current set of characters from the 1st string.
                Array.ForEach(string2Array, (e2) =>
                {
                    //If the characters are the same, display the positions
                    //(Note with a lamda function you can refer to variables outside of the function.
                    if (e == e2) Console.WriteLine($"\"{e}\" is in string-1, position {position1}; string-2, position {position2}");
                    position2++;
                });

                position1++;
                
            });

        }

        private static string[] StringToArray( string theString )
        {
            //Create an array of one element per character and the character next to it.
            //Ex: "The cat" = th, he, e , ca, at

            int loopEnd = theString.Length - 1;

            string[] stringArray = new string[loopEnd];

            for (int i = 0; i < loopEnd; i++)
            {
                stringArray[i] = theString.Substring(i, 2);//The character at the index i and the character next to it.
            }

            return stringArray;
        }
        
    }

    public static class Exercise_36
    {
        /*36. Write a C# Sharp program to create a new string from a given string 
         * where a specified character have been removed 
         * except starting and ending position of the given string
         */

        public static void Execute()
        {
            string givenString = UtilityMethods.GetValidString();

            char character = UtilityMethods.GetValidChar();

            string newString = string.Concat( 
                givenString.Substring(0,1)
                , givenString.Substring(1, givenString.Length - 2).Replace(character.ToString(),"")
                , givenString.Substring(givenString.Length - 1, 1) 
                );

            Console.WriteLine(newString);

        }
    }

    public static class Exercise_37
    {
        /*37. Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ...
            from a given string. 
            Expected Output: 
            Pyon
            JaScpt
            HT
        */

        public static void Execute()
        {
            string givenString = UtilityMethods.GetValidString();

            int[] indexes = new int[6]{ 0, 1, 4, 5, 8, 9 };

            string newString = "";

            foreach (int number in indexes)
            {
                newString += givenString.Substring(number, 1);
            }

            Console.WriteLine("The new string is: {0}", newString);
        }
    }

    public static class Exercise_38
    {
        /*38. Write a C# Sharp program to count the number of two 5's that are next to each other 
         in an array of integers. Also count the situation where the second 5 is actually a 6. 
        Expected Output: 
            1
            2
            1
        */

        public static void Execute()
        {
            int[] numbers = UtilityMethods.getValidNumbersArray();
            int previousNumber = 0;
            int fives = 0; int sixes = 0;

            foreach (int number in numbers)
            {
                if (number == 5 & previousNumber == 5) fives++;

                if (number == 6 & previousNumber == 5) sixes++;

                previousNumber = number;

            }

            Console.WriteLine($"Number of pairs of fives: {fives} \nNumber of pairs of sixes: {sixes}");
        }
    }

    public static class Exercise_39
    {
        /*39. Write a C# Sharp program to check if a triple is present in an array of integers or not. 
         If a value appears three times in a row in an array it is called a triple. 
            Expected Output: 
            True
            True
            False
        */

        public static void Execute()
        {
            int[] integers = UtilityMethods.getValidNumbersArray();
            bool result = false;
            string message = "No integers appear 3 times in a row.";

            for (int i = 0; i <= integers.Length - 3; i++)
            {
                if (integers[i] == integers[i+1] & integers[i] == integers[i+2])
                {
                    message = integers[1].ToString() + " appears 3 times in a row";
                    break;
                }
            }

            Console.WriteLine(message);
        }
    }

    public static class Exercise_40
    {
        /*40. Write a C# Sharp program to compute the sum of the two given integers. 
            If the sum is in the range 10..20 inclusive return 30. 
            Expected Output: 
            29
            30
            39
            30
        */
        public static void Execute()
        {
            int int1 = UtilityMethods.GetValidNumber("Enter 1st number:");
            int int2 = UtilityMethods.GetValidNumber("Enter 2nd number:");

            int output = int1 + int2;
            output = output >= 10 & output <= 20 ? 30 : output;

            Console.WriteLine(output);
        }
    }

    public static class Exercise_41
    {
        /*41. Write a C# Sharp program that accepts two integers and return true 
            if either one is 5 or their sum or difference is 5. 
            Expected Output: 
            True
            False
            True
        */
        public static void Execute()
        {
            int Int1 = UtilityMethods.GetValidNumber("Enter 1st integer");
            int Int2 = UtilityMethods.GetValidNumber("Enter 2nd integer");

            bool result = Int1 == 5 | Int2 == 5 | Int1 + Int2 == 5 | Int1 - Int2 == 5 ? true : false;

            Console.WriteLine(result);
        }
    }

    public static class Exercise_42
    {
        /*42. Write a C# Sharp program to test if a given non-negative number 
            is a multiple of 13 or it is one more than a multiple of 13. 
            Expected Output: 
            True
            True
            True
            False
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber();

            bool result = number % 13 == 0 | number % 13 == 1;

            Console.WriteLine(result);
        }

    }

    public static class Exercise_43
    {
        /*43. Write a C# Sharp program to check if a given non-negative number 
         is a multiple of 3 or 7, but not both. 
            Expected Output: 
                True
                True
                False
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber();

            bool result = number % 3 == 0 ^ number % 7 == 0;

            Console.WriteLine("given number is a multiple of 3 or 7, but not both: {0}", result);
        }
    }

    public static class Exercise_44
    {
        /*44. Write a C# Sharp program to check 
          if a given number is within 2 of a multiple of 10. 
            Expected Output: 
                False
                False
                True
                True
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidNumber();

            bool result = Math.Abs(number) % 10 <= 2;

            Console.WriteLine($"Given number is within 2 of a multiple of 10: {result}");
        }
    }

    public static class Exercise_45
    {
        /*45. Write a C# Sharp program to compute the sum of the two given integers. 
          If one of the given integer value is in the range 10..20 inclusive return 18. 
            Expected Output: 
            10
            18
            18
            241
        */

        public static void Execute()
        {
            int integer1 = UtilityMethods.GetValidNumber("Enter 1st Number");
            int integer2 = UtilityMethods.GetValidNumber("Enter 2nd Number");

            int output = ( integer1 >= 10 & integer2 <= 20 ) | ( integer2 >= 10  & integer2 <= 20 ) ? 18 : integer1 + integer2;

            Console.WriteLine(output);
        }
    }

    public static class Exercise_46
    {
        /*46. Write a C# Sharp program to check whether a given string starts with "F" or ends with "B". 
          If the string starts with "F" return "Fizz" and return "Buzz" if it ends with "B" 
          If the string starts with "F" and ends with "B" return "FizzBuzz". 
          In other cases return the original string. 
            Expected Output: 
            Fizz
            founder
            club
            forb
        */

        public static void Execute()
        {
            string givenString = UtilityMethods.GetValidString();

            string starts = givenString.Substring(0, 1).ToLower() == "f" ? "Fizz" : "";
            string ends = givenString.Substring(givenString.Length - 1, 1).ToLower() == "b" ? "Buzz" : "";

            string result = starts + ends;
            result = result.Length == 0 ? givenString : result;

            Console.WriteLine(result);
        }
    }

    public static class Exercise_47
    {
        /*47. Write a C# Sharp program to check if it is possible to add two integers 
         to get the third integer from three given integers.
        Expected Output: 
            True
            False
            True
        */

        public static void Execute()
        {
            int[] integers = new int[3];
            bool result = false;

            integers[0] = UtilityMethods.GetValidNumber("Enter 1st number");
            integers[1] = UtilityMethods.GetValidNumber("Enter 2nd number");
            integers[2] = UtilityMethods.GetValidNumber("Enter 3rd number");

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                   Array.ForEach( integers, element => { if (element == integers[x] + integers[y]) result = true; });
                }
            }

            Console.WriteLine(result);
        }
    }

    public static class Excercise_48
    {
        /*48. Write a C# Sharp program to check if y is greater than x, 
         and z is greater than y from three given integers x,y,z. 
        Expected Output: 
            True
            True
            False
        */
        public static void Execute()
        {
            int x = UtilityMethods.GetValidNumber("Enter numeric value for X");
            int y = UtilityMethods.GetValidNumber("Enter numeric value for Y");
            int z = UtilityMethods.GetValidNumber("Enter numeric value for Z");

            bool result = y > x & z > y;

            Console.WriteLine("y is greater than x, and z is greater than y: {0}", result);
        }
    }

    public static class Exercise_49
    {
        /*49. Write a C# Sharp program to check if three given numbers 
            are in strict increasing order, such as 4 7 15, or 45, 56, 67
            , but not 4 ,5, 8 or 6, 6, 8.  
            However,if a fourth parameter is true, equality is allowed
            , such as 6, 6, 8 or 7, 7, 7. 
            Expected Output: 
            True
            True
            False
            True
        */

        public static void Execute()
        {
            int[] integers = UtilityMethods.getValidNumbersArray();

            Console.Write("Is equality allowed? (yes or no): ");
            bool equalityAllowed = Console.ReadLine().ToLower() == "yes" ? true : false;

            bool result = numbersAreInOrder(integers, equalityAllowed);

            Console.WriteLine("Numbers entered are in increasing order: {0}", result);
        }

        public static bool numbersAreInOrder( int[] integers, bool equalityAllowed )
        {
            bool result = true;
            int previous = 0;

            foreach (int number in integers)
            {
                if (
                    (equalityAllowed == false & number <= previous)
                    | (equalityAllowed == true & number < previous)
                    ) {
                    result = false;                    
                }
                previous = number;
            }

            /*
            Array.ForEach(integers, element => {
                if( element < previous) { result = false;  }
                previous = element; 
            });
            */
            return result;
        }
    }

    public static class Exercise_50
    {
        /*50. Write a C# Sharp program to check if two or more non-negative 
            given integers have the same rightmost digit. 
            Expected Output: 
            True
            True
            False
        */

        public static void Execute()
        {
            bool sameRightMost = false;

            int[] integers = UtilityMethods.getValidNumbersArray();

            getRightMostIntArray(ref integers);

            for( int i = 0; i < integers.Length; i++ )
            {
                for (int y = 0; y < integers.Length; y++)
                {
                    if( y != i )
                    {
                        if (integers[i] == integers[y]) sameRightMost = true;
                    }
                    
                }
            }

            Console.WriteLine("Two or more integers have the same rightmost digit: {0}", sameRightMost);
        }

        private static void getRightMostIntArray( ref int[] numbers)
        {
            string intString = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                intString = numbers[i].ToString();
                intString = intString.Substring(intString.Length - 1, 1);
                numbers[i] = int.Parse(intString);
            }
        }

    }

    public static class Exercise_51
    {
        /*
         51. Write a C# Sharp program to check three given integers
         and return true if one of them is 20 or more less than one of the others.
            Expected Output: 
            True
            True
            False
        */

        public static void Execute()
        {
            int int1 = UtilityMethods.GetValidNumber("Enter 1st number: ");
            int int2 = UtilityMethods.GetValidNumber("Enter 2nd number: ");
            int int3 = UtilityMethods.GetValidNumber("Enter 3rd number: ");

            int[] intsSorted = new int[] { Math.Abs(int1), Math.Abs(int2), Math.Abs(int3) };

            Array.Sort(intsSorted);

            bool diffGreaterThan20 = (intsSorted[2] - intsSorted[1]) >= 20 | (intsSorted[2] - intsSorted[0]) >= 20;

            Console.WriteLine("One or more integers are 20 or greater than the others: {0}", diffGreaterThan20);
        }
    }

    public static class Exercise_52
    {
        /*52. Write a C# Sharp program to find the larger from two given integers. 
         However if the two integers have the same remainder when divided by 7, 
         then return the smaller integer. If the two integers are the same, return 0. 
            Expected Output: 
            11
            20
            0
        */

       public static void Execute()
        {
            int int1 = UtilityMethods.GetValidNumber("Enter 1st Number: ");
            int int2 = UtilityMethods.GetValidNumber("Enter 2nd Number: ");

            int smallerInt = int1 > int2 ? int2 : int1;
            int largerInt = int1 > int2 ? int1 : int2;
            bool sameRemainder = int1 % 7 == int2 % 7;
            bool sameInteger = int1 == int2;

            if (sameInteger )
            {
                Console.WriteLine(0);                
            }
            else
            {
                if (sameRemainder)
                {
                    Console.WriteLine(smallerInt);
                }
                else
                {
                    Console.WriteLine(largerInt);
                }
            }
        }
    }

    public static class Exercise_53
    { 
        /*53. Write a C# Sharp program to check two given integers, each in the range 10..99. 
         * Return true if a digit appears in both numbers, such as the 3 in 13 and 33. 
            Expected Output: 
            True
            False
            True
        */

        public static void Execute()
        {
            bool AppearsInBoth = false;
            string number1 = UtilityMethods.GetValidNumber(10, 99).ToString();
            string number2 = UtilityMethods.GetValidNumber(10, 99).ToString();
            
            char[] digits1 = number1.ToCharArray();
            char[] digits2 = number2.ToCharArray();

            Array.ForEach(digits1, digit1 =>
           {
               Array.ForEach(digits2, digit2 =>
               {
                   if (digit1 == digit2) AppearsInBoth = true;
               });

           });

            Console.WriteLine(AppearsInBoth);
        }
    }

    public static class Exercise_54
    {
        /*54. Write a C# Sharp program to compute the sum of two given non-negative integers x and y 
         as long as the sum has the same number of digits as x. If the sum has more digits than x then return x without y. 
            Expected Output: 
            9
            7
            20
        */

        public static void Execute()
        {
            int x = UtilityMethods.GetValidAbsoluteNumber();
            int y = UtilityMethods.GetValidAbsoluteNumber();

            int result = (x + y).ToString().Length > x.ToString().Length ? x : x + y;

            Console.WriteLine(result);

        }
    }

    public static class Exercise_55
    {
        /*55. Write a C# Sharp program to compute the sum of three given integers. 
         * If the two values are same return the third value. 
            Expected Output: 
            16
            23
            12
            18
        */

        public static void Execute()
        {
            int integer1 = UtilityMethods.GetValidNumber("Enter 1st integer: ");
            int integer2 = UtilityMethods.GetValidNumber("Enter 2nd integer: ");
            int integer3 = UtilityMethods.GetValidNumber("Enter 3rd integer: ");

            Console.WriteLine("Description doesn't make sense");
        }
    }

    public static class Exercise_56
    {
        /*56. Write a C# Sharp program to compute the sum of the three integers.
         If one of the values is 13 then do not count it and its right towards the sum. 
            Expected Output: 
            16
            23
            10
            0
        */

        public static void Execute()
        {
            int integer1 = UtilityMethods.GetValidNumber("Enter 1st integer: ");
            int integer2 = UtilityMethods.GetValidNumber("Enter 2nd integer: ");
            int integer3 = UtilityMethods.GetValidNumber("Enter 3rd integer: ");

            integer1 = integer1 == 13 ? 0 : integer1;
            integer2 = integer2 == 13 ? 0 : integer2;
            integer3 = integer3 == 13 ? 0 : integer3;

            int result = integer1 + integer2 + integer3;

            Console.WriteLine(result);

        }
    }

    public static class Exercise_57
    {
        /*57. Write a C# Sharp program to compute the sum of the three given integers. 
           However, if any of the values is in the range 10..20 inclusive then that value counts as 0
           , except 13 and 17. 
            Expected Output: 
            16
            11
            13
            17
        */

        public static void Execute()
        {
            int integer1 = UtilityMethods.GetValidNumber("Enter 1st integer: ");
            int integer2 = UtilityMethods.GetValidNumber("Enter 2nd integer: ");
            int integer3 = UtilityMethods.GetValidNumber("Enter 3rd integer: ");

            exceptions(ref integer1);
            exceptions(ref integer2);
            exceptions(ref integer3);

            int result = integer1 + integer2 + integer3;

            Console.WriteLine(result);
        }

        private static void exceptions( ref int integer)
        {
            if( integer >= 10 
                & integer <= 20 
                & integer != 13 
                & integer != 17 
                )
                {
                    integer = 0;
                }
        }
    }

    public static class Exercise_58
    {
        /*58. Write a C# Sharp program to check two given integers 
         and return the value whichever value is nearest to 13 without going over. 
         Return 0 if both numbers go over. 
            Expected Output: 
            5
            12
            13
            0
            0
        */

        public static void Execute()
        {
            int integer1 = UtilityMethods.GetValidNumber("Enter 1st integer: ");
            int integer2 = UtilityMethods.GetValidNumber("Enter 2nd integer: ");

            integer1 = integer1 > 13 ? 0 : integer1;
            integer2 = integer2 > 13 ? 0 : integer2;

            int result = (13 - integer1) > (13 - integer2) ? integer2 : integer1;

            Console.WriteLine("{0} is closest to 13 without going over.", result);
        }
    }

    public static class Exercise_59
    {
        /*59. Write a C# Sharp program to check three given integers (small, medium and large) 
         and return true if the difference between small and medium 
         and the difference between medium and large is same. 
        Expected Output: 
        True
        False
        True
        */

        public static void Execute()
        {
            int firstNumber = UtilityMethods.GetValidNumber("Enter 1st number: ");
            int secondNumber = UtilityMethods.GetValidNumber("Enter 2nd number: ");
            int thirdNumber = UtilityMethods.GetValidNumber("Enter 3rd number: ");

            int[] numbers = new int[3] { firstNumber, secondNumber, thirdNumber };

            Array.Sort(numbers);

            bool sameDiff = numbers[1] - numbers[0] == numbers[2] - numbers[1];

            Console.WriteLine($"The difference between small and medium and the difference between medium and large is same {sameDiff}");

        }
    }

    public static class Exercise_60
    {
        /*60. Write a C# Sharp program to create a new string using two given strings s1, s2, 
            the format of the new string will be s1s2s2s1. 
            Expected Output: 
            HiHelloHelloHi
            whatsappappwhats
        */
        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString("Enter first string");
            string string2 = UtilityMethods.GetValidString("Enter second string");

            Console.WriteLine(string1 + string2 + string2 + string1);

        }
    }

    public static class Exercise_61
    {
        /*
          61. Write a C# Sharp program to insert a given string into middle of the another given string of length 4. Go to the editor
            Expected Output: 
            [[Hello]]
            ((Hi))
        */
        public static void Execute()
        {
            string baseString = UtilityMethods.GetValidString();
            string insertString = UtilityMethods.GetValidString();

            string newString = InsertString(baseString, insertString);

            Console.WriteLine(newString);

        }
        private static string InsertString( string baseString, string insertString )
        {
            int position = baseString.Length;
            string positionExceeds = "";

            while (position > baseString.Length - 1)
            {
                Console.WriteLine(positionExceeds);
                position = UtilityMethods.GetValidAbsoluteNumber("Enter position where the 2nd string will be inserted");
                positionExceeds = "Position must not exceed length of base string!";
            }

            string newString = baseString.Insert(position, insertString);

            return newString;
        }
    }

    public static class Exercise_62
    {
        /*62. Write a C# Sharp program to create a new string 
         using three copies of the last two characters of a given string 
         of length atleast two. s
        Expected Output: 
        lololo
        HiHiHi
        */
        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            int start = theString.Length >= 2 ? theString.Length - 2: 0;
            int length = start > 0 ? 2 : theString.Length;

            string lastTwo = theString.Substring(start, length);

            Console.WriteLine(lastTwo + lastTwo + lastTwo);
        }
    }

    public static class Exercise_63
    {
        /*63. Write a C# Sharp program to create a new string using first two characters of a given string. 
         If the string length is less than 2 then return the original string.. 
            Expected Output: 
            He
            Hi
            H
        */
        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            string result = theString.Length >= 2 ? theString.Substring(0, 2) : theString;

            Console.WriteLine(result);
        }
    }

    public static class Exercise_64
    {
        /*
          64. Write a C# Sharp program to create a new string 
          from the first half of a given string of even length. 
            Expected Output: 
            He
            H
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            string newString = theString.Substring(0, theString.Length / 2);

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_65
    {
        /*65. Write a C# Sharp program to create a new string without the first and last character 
          of a given string of length atleast two. 
            Expected Output: 
            ell
            ytho
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            int start = theString.Length >= 2 ? 1 : 0;
            int length = start > 0 ? theString.Length - 2 : theString.Length;


            string newString = theString.Substring( start, length);

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_66
    {
        /*66. Write a C# Sharp program to create a new string from two given strings 
         one shorter and another longer. The format of the new string will be
         long string + short string + long string. 
        Expected Output: 
        HiHelloHi
        JSPythonJS
        */
        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString("Enter 1st string");
            string string2 = UtilityMethods.GetValidString("Enter 2nd string");

            if(string1.Length > string2.Length)
            {
                Console.WriteLine(string1 + string2 + string1);
            }
            else
            {
                Console.WriteLine(string2 + string1 + string2);
            }

        }
    }

    public static class Exercise_67
    {
        /*67. Write a C# Sharp program to concat two given string of length atleast 1, 
            after removing their first character. 
            Expected Output: 
            elloi
            Sython
        */

        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString("Enter 1st string", 1);
            string string2 = UtilityMethods.GetValidString("Enter 2nd string", 1);

            Console.WriteLine(string1.Substring(1) + string2.Substring(1));
        }
    }

    public static class Exercise_68
    {
        /*68. Write a C# Sharp program to move the first two characters 
            to the end of a given string of length at least two. 
            Expected Output: 
            lloHe
            JS
        */

        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString(MinimalLength:2);

            string newString = string1.Substring(2) + string1.Substring(0, 2);

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_69
    {
        /*
         * Write a C# Sharp program to move the last two characters 
           to the start of a given string of length at least two.
        */

        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString(MinimalLength: 2);

            string newString = string1.Substring(string1.Length - 2, 2) + string1.Substring(0, string1.Length - 2);

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_70
    {
        /*70. Write a C# Sharp program to create a new string 
            without the first and last character of a given string of any length.
            Expected Output: 
            ell
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            int length = theString.Length > 2 ? theString.Length - 2 : theString.Length - 1;

            string newString = theString.Substring(1, length );

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_71
    {
        /*71. Write a C# Sharp program to create a new string 
         using the two middle characters of a given string of even length (at least 2).
            Expected Output: 
            el
            JS
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            int startIndex = theString.Length > 1 ? theString.Length / 2 - 1 : 0;
            int length = theString.Length > 1 ? 2 : 1;

            string newString = theString.Substring(startIndex, length);

            Console.WriteLine(newString);

        }
    }

    public static class Exercise_72
    {
        /*72. Write a C# Sharp program to check if a given string ends with "on". 
            Expected Output: 
            False
            True
            True
            False
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            bool endsWithOn = theString.EndsWith("on");

            Console.WriteLine("Ends with on: {0}", endsWithOn);
        }
    }

    public static class Exercise_73
    {
        /*
        73. Write a C# Sharp program to create a new string using 
        the first and last n characters from a given string of length at least n. 
        Expected Output: 
        Ho
        Pyon
        on
        oo
        */

        public static void Execute()
        {
            int numOfChars = UtilityMethods.GetValidNumber("Enter # of characters to get from string");
            string theString = UtilityMethods.GetValidString($"Enter a string at least {numOfChars * 2} characters long", numOfChars * 2);

            string newString = theString.Substring(0, numOfChars) + theString.Substring(theString.Length - numOfChars, numOfChars);

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_74
    {
        /*74. Write a C# Sharp program to create a new string of length 2 
         starting at the given index of a given string. 
        Expected Output: 
        el
        th
        on
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString("Enter a string of at least 2 characters in length",2);

            int index = UtilityMethods.GetValidNumber(0,theString.Length - 2, $"Enter index number lower than {theString.Length - 1}");

            string newString = theString.Substring(index, 2);

            Console.WriteLine(newString);

        }
    }

    public static class Exercise_75
    {
        /*75. Write a C# Sharp program to create a new string taking 3 characters 
            from the middle of a given string at least 3. Go to the editor
            Expected Output: 
            ell
            yth
            abc
        */
        public static void Execute()
        {
            string givenString = UtilityMethods.GetValidString(MinimalLength: 3);

            string newString = givenString.Substring(givenString.Length / 2 - 1 , 3);

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_76
    {
        /*76. Write a C# Sharp program to create a new string of length 2, 
            using first two characters of a given string. If the given string length is less than 2 
            use '#' as missing characters. 
            Expected Output: 
            He
            Py
            a#
            ##
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            if (theString.Length < 2)
            {
                theString = new string('#', 2 - theString.Length) + theString;
            }

            string newString = theString.Substring(0, 2);
            
            Console.WriteLine(newString);
        }
    }

    public static class Exercise_77
    {
        /*77. Write a C# Sharp program to create a new string taking the first character
            from a given string and the last character from another given string. 
            If the length of any given string is 0, use '#' as its missing character. 
            Expected Output: 
            Hi
            PP
            JS
            C#
        */

        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString("Enter 1st string");
            string string2 = UtilityMethods.GetValidString("Enter 2nd string");

            string newString = string.Concat( string1.Substring(0, 1), string2.Substring(string2.Length - 1) );

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_78
    {
        /*78. Write a C# Sharp program to concat two given strings (lowercase).
            If there are any double character in new string then omit one character. 
            Expected Output: 
            abcat
            pythonphp
            phphp
        */

        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString("Enter 1st string");
            string string2 = UtilityMethods.GetValidString("Enter 2nd string");

            string newString = string1 + string2;
            string finalString = "";
            bool charFound = false;

            char[] characters = newString.ToCharArray();

            Console.WriteLine(newString);

            for (int i = 0; i < characters.Length; i++)
            {
                //Console.WriteLine(characters[i]);

                for (int n = 0; n < i; n++)
                {

                    if (
                        characters[i].ToString().ToLower() == characters[n].ToString().ToLower() //take caps out of the equation
                        & i > n //not the same character
                        & characters[i] != ' ' //ignore spaces
                        )
                    {
                        charFound = true;
                        break;
                    }
                }

                //if the character hadn't been previous encountered add it to the string
                if ( charFound == false ) finalString += characters[i];

                charFound = false;
            }

            Console.WriteLine(finalString);
        }
    }

    public static class Exercise_79
    {
        /*
          79. Write a C# Sharp program to create a new string from a given string after swapping last two characters. Go to the editor
            Expected Output: 
            Helol
            Pythno
            PPH
            SJ
            C
        */

        public static void Execute()
        {
            string givenString = UtilityMethods.GetValidString();

            string newString = string.Concat(
                 givenString.Substring(0, givenString.Length - 2)
                ,givenString.Substring(givenString.Length - 1)
                ,givenString.Substring(givenString.Length - 2, 1) 
                );

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_80
    {
        /*80. Write a C# Sharp program to check if a given string begins with 'abc' or 'xyz'. 
         If the string begins with 'abc' or 'xyz' return 'abc' or 'xyz' otherwise return the empty string. 
        Expected Output: 
            abc
            abc
            xyz
            xyz
        */

        public static void Execute()
        {
            string givenString = UtilityMethods.GetValidString();

            bool beginsWith = givenString.ToLower().StartsWith("abc") | givenString.ToLower().StartsWith("xyz");

            string result = beginsWith ? givenString.Substring(0, 3) : "";

            Console.WriteLine(result);
        }
    }

    public static class Exercise_81
    {
        /*81. Write a C# Sharp program to check whether the first two characters 
         and last two characters of a given string are same. 
            Expected Output: 
            True
            False
            True
        */

        public static void Execute()
        {
            string givenString = UtilityMethods.GetValidString();

            bool same = givenString.Substring(0, 2).ToLower() == givenString.Substring(givenString.Length - 2).ToLower();

            Console.WriteLine("The first two characters and last two characters are the same: {0}", same);
        }
    }

    public static class Exercise_82
    {
        /*82. Write a C# Sharp program to concat two given strings. 
         If the given strings have different length remove the characters from the longer string. 
            Expected Output: 
            abcbcd
            PythonPython
            JSon
        */

        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString("Enter 1st string");
            string string2 = UtilityMethods.GetValidString("Enter 2nd string");

            if (string1.Length > string2.Length) string1 = string1.Substring(0, string2.Length);
            if (string1.Length < string2.Length) string2 = string2.Substring(0, string1.Length);

            Console.WriteLine(string1 + string2);
        }
    }

    public static class Exercise_83
    {
        /*83. Write a C# Sharp program to create a new string using 3 copies of the first 2 characters of a given string. 
         If the length of the given string is less than 2 use the whole string. 
            Expected Output: 
            ababab
            PyPyPy
            JJJ
        */
        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            string newString = theString.Substring(0, 2);

            StringBuilder repeatString = new StringBuilder(6);

            newString = repeatString.Insert(0, newString, 3).ToString();

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_84
    {
        /*84. Write a C# Sharp program to create a new string from a given string. 
        If the two characters of the given string from its beginning and end are same 
        return the given string without the first two characters otherwise return the original string. 
        Expected Output: 
        cab
        Python
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            string newString = theString;

            if ( theString.Substring(0,1).ToLower() == theString.Substring(theString.Length - 1).ToLower())
            {
                newString = theString.Substring(1, theString.Length - 2);
            }

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_85
    {
        /*85. Write a C# Sharp program to create a new string from a given string 
         without the first two characters. Keep the first character if it is "p" 
         and keep the second character if it is "y".
        Expected Output: 
            cab
            python
            pess
            ython
        */
        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            string characters = theString.Substring(0, 2);

            string newString = "";

            newString = theString.Substring(1,1) != "y" ? theString.Remove(1, 1) : theString;

            newString = newString.StartsWith("p") == false ? newString.Remove(0, 1) : newString;

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_86
    {
        /*86. Write a C# Sharp program to create a new string from a given string 
         without the first and last character if the first or last characters are 'a' 
         otherwise return the original given string. 
            Expected Output: 
            bcab
            python
            bcd
            jython
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            string newString = theString.ToLower().StartsWith("a") ? theString.Substring(1) : theString;
            newString = newString.ToLower().EndsWith("a") ? newString.Substring( 0, newString.Length - 1 ) : newString;

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_87
    {
        /*87. Write a C# Sharp program to create a new string from a given string. 
         If the first or first two characters is 'a', return the string without those 'a' characters 
         otherwise return the original given string.
            Expected Output: 
            bcab
            python
            cda
            jython
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            string newString = theString.ToLower().Substring(1,1) == "a" ? theString.Remove(1, 1) : theString;

            newString = newString.ToLower().StartsWith("a") ? newString.Remove(0, 1) : newString;

            Console.WriteLine(newString);
        }
    }

    public static class Exercise_88
    {
        /*88. Write a C# Sharp program to check a given array of integers of length 1 or more 
         and return true if 10 appears as either first or last element in the given array. 
            Expected Output: 
            True
            True
            True
            False
        */
        public static void Execute()
        {
            int[] numbers = UtilityMethods.getValidNumbersArray();

            bool tenAppears = numbers[numbers.GetLowerBound(0)] == 10 
                            | numbers[numbers.GetUpperBound(0)] == 10 
                            ? true : false;

            Console.WriteLine($"You entered 10 as the first or last number: {tenAppears}");
        }

    }

    public static class Exercise_89
    {
        /*89. Write a C# Sharp program to check a given array of integers of length 1 or more 
            and return true if the first element and the last element are equal in the given array.
            Expected Output: 
            False
            True
            False
        */

        public static void Execute()
        {
            int[] integers = UtilityMethods.getValidNumbersArray();

            bool equal = integers[integers.GetLowerBound(0)] == integers[integers.GetUpperBound(0)] ? true : false;

            Console.WriteLine( $"The first number entered equals that last number entered: {equal}");

        }
    }

    public static class Exercise_90
    {
        /*90. Write a C# Sharp program to check two given arrays of integers of length 1 or more 
         and return true if they have the same first element or they have the same last element. 
            Expected Output: 
            True
            True
            False
        */

        public static void Execute()
        {
            int[] array1 = UtilityMethods.getValidNumbersArray();
            int[] array2 = UtilityMethods.getValidNumbersArray();

            bool sameFirst = array1[array1.GetLowerBound(0)] == array2[array2.GetLowerBound(0)] ? true : false;
            bool sameLast = array1[array1.GetUpperBound(0)] == array2[array2.GetUpperBound(0)] ? true : false;

            bool sameFirstOrLast = sameFirst | sameLast ? true : false;

            Console.WriteLine($"The first numbers or last numbers match in each group: {sameFirstOrLast}");
        }
    }

    public static class Exercise_91
    {
        /*91. Write a C# Sharp program to compute the sum of the elements of an given array of integers. 
            Expected Output: 
            150
            10
        */

        public static void Execute()
        {
            int[] integers = UtilityMethods.getValidNumbersArray();
            int sum = 0;

            Array.ForEach(integers, n => sum += n);

            Console.WriteLine($"The sum is: {sum}");
        }
    }

    public static class Exercise_92
    {
        /*92. Write a C# Sharp program to rotate the elements of a given array of integers (length 4 ) 
         in left direction and return the new array. 
        Expected Output: 
        Rotated array: 20 -30 -40 10
        */
        public static void Execute()
        {
            int[] integers = UtilityMethods.getValidNumbersArray();
            int[] rotatedArray = new int[integers.Length];

            Array.ConstrainedCopy(integers, 1, rotatedArray, 0, integers.Length - 1);

            //add the 1st element to the end
            rotatedArray[rotatedArray.GetUpperBound(0)] = integers[integers.GetLowerBound(0)];

            Array.ForEach(rotatedArray, n => Console.WriteLine(n));
            
        }
    }

    public static class Exercise_93
    {
        /*
          93. Write a C# Sharp program to reverse a given array of integers and length 5. 
            Expected Output: 
            Reverse array: 50 -40 -30 20 10
        */

        public static void Execute()
        {
            int[] integers = UtilityMethods.getValidNumbersArray(5);

            Array.Reverse<int>(integers);

            Array.ForEach(integers, i => Console.WriteLine(i));
        }
    }

    public static class Exercise_94
    {
        /*
          94. Write a C# Sharp program to find out the maximum element 
          between the first or last element in a given array of integers ( length 4)
          , replace all elements with maximum element. 
            Expected Output: 
            New array: 20 20 20 20
        */

        public static void Execute()
        {
            int[] integers = UtilityMethods.getValidNumbersArray(4);
            int[] arrayCopy = new int[integers.Length - 2];

            Array.Copy(integers, 1, arrayCopy, 0, integers.Length - 2);

            int maxValue = arrayCopy.Max();

            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = maxValue;
            }

            Array.ForEach(integers, e => Console.WriteLine(e));
        }
    }

    public static class Exercise_95
    {
        /*95. Write a C# Sharp program to create a new array containing the middle elements 
         from the two given arrays of integers, each length 5. 
        Expected Output: 
        New array: -30 30
        */
        public static void Execute()
        {
            int[] array1 = UtilityMethods.getValidNumbersArray(5,"Enter number for 1st Group, or S to save");
            int[] array2 = UtilityMethods.getValidNumbersArray(5, "Enter number for 2nd Group, or S to save");

            int middleValue1 = array1[array1.Length / 2];
            int middleValue2 = array2[array2.Length / 2];

            int[] newArray = { middleValue1, middleValue2 };

            Console.WriteLine("Middle Values:");
            Array.ForEach(newArray, e => Console.WriteLine(e));
        }
    }

    public static class Exercise_96
    {
        /*96. Write a C# Sharp program to create a new array taking the first and last elements 
        of a given array of integers of length 1 or more. 
        Expected Output : 
        New array: 10 30
        */
        //Note: for this exercise I used an Action rather than an Arrow Function in the Array.ForEach method
        private static void ArrayDisplay(int number)
        {
            Console.WriteLine(number);
        }

        public static void Execute()
        {
            Action<int> arrayDisplay = new Action<int>(ArrayDisplay);

            int[] givenArray = UtilityMethods.getValidNumbersArray(1);

            int[] newarray = new int[2];

            newarray[0] = givenArray[0];
            newarray[1] = givenArray[givenArray.GetUpperBound(0)];

            Array.ForEach(newarray, arrayDisplay);
        }
    }

    public static class Exercise_97
    {
        /*97. Write a C# Sharp program to check if a given array of integers and length 2
         , contains 15 or 20. 
        Expected Output : 
            True
            True
            False
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            bool found = Array.Find( givenArray, e => e == 15) == 15 | Array.Find(givenArray, e => e == 20) == 20;

            Console.WriteLine(found);
        }
    }

    public static class Exercise_98
    {
        /*98. Write a C# Sharp program to check if a given array of integers of length 2
         , does not contain 15 or 20. 
        Expected Output : 
            False
            False
            True
        */

        public static void Execute()
        {
            int[] integers = UtilityMethods.getValidNumbersArray(2);

            bool numbersNotFound = Array.Find(integers, e => e == 15 | e == 20) == 0;

            Console.WriteLine("Entries do not contain 15 or 20: {0}", numbersNotFound);
        }
    }

    public static class Exercise_99
    {
        /*
         * 99. Write a C# Sharp program to create a new array of integers of length 1 or more. 
         The length of the new array will be double length of the given array 
         and all the elements are 1 except the first element which is equal to the given array. 
        Expected Output : 
            New array: 10 0 0 0 0 0 0 0 0 0
        */
        private static void ArrayDisplay(int number)
        {
            Console.WriteLine(number);
        }

        public static void Execute()
        {
            Action<int> arrayDisplay = new Action<int>( ArrayDisplay );

            int[] givenArray = UtilityMethods.getValidNumbersArray(1);
            int[] newArray = new int[givenArray.Length * 2];

            newArray[0] = givenArray[0];

            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = 1;
            }

            Array.ForEach(newArray, arrayDisplay);

        }


    }

    public static class Exercise_100
    {
        /*
          100. Write a C# Sharp program to check a given array of integers 
          and return true if the array contains 10 or 20 twice. 
          The length of the array will be 0, 1, or 2. 
            Expected Output : 
            False
            True
            True
            False
        */
        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            bool contains = givenArray.Count(e => e == 10 | e == 20) == 2;

            Console.WriteLine($"10 or 20 have been entered twice: {contains}");
        }
    }

    public static class Exercise_101
    {
        /*101. Write a C# Sharp program to check a given array of integers, length 3 and create a new array. 
         If there is a 5 in the given array immediately followed by a 7 then set 7 to 1. 
        Expected Output : 
        Original array:  1, 5, 7
        New array: 1 5 1
        */

        private static void WriteArray( int number)
        {
            Console.Write($"{number}, ");
        }

        public static void Execute()
        {
            Action<int> writeArray = new Action<int>(WriteArray);

            int[] givenArray = UtilityMethods.getValidNumbersArray(3);
            int[] newArray = new int[givenArray.Length];

            givenArray.CopyTo(newArray,0);            

            int locationOf5 = Array.IndexOf(givenArray, 5);

            int locationOf7 = Array.IndexOf(givenArray, 7);

            if (locationOf7 - locationOf5 == 1)
            {
                newArray[locationOf7] = 1;
            }

            Console.Write("Original Array: ");
            Array.ForEach(givenArray, writeArray);

            Console.WriteLine();

            Console.Write("New Array: ");
            Array.ForEach(newArray, writeArray);
        }
    }

    public static class Exercise_102
    {
        /*
         * Write a C# program to compute the sum of the two given arrays of integers, length 3
         * and find the array which has the largest sum:
         * Expected output:
         *  Original Array: 1, 5, 7
         *  Larger Array: 10 20 30
         */

        public static void Execute()
        {
            int [] array1 = UtilityMethods.getValidNumbersArray(3);
            int[] array2 = UtilityMethods.getValidNumbersArray(3);

            int sumOfArray1 = 0; int sumOfArray2 = 0;

            string messageOne = ""; string messageTwo = "";

            Array.ForEach(array1, e => sumOfArray1 += e);
            Array.ForEach(array2, e => sumOfArray2 += e);

            messageOne = sumOfArray1 > sumOfArray2 ? "Larger Array: " : "Original Array: ";
            messageTwo = sumOfArray1 > sumOfArray2 ? "Original Array: " : "Larger Array: ";

            Console.WriteLine(messageOne);
            Array.ForEach(array1, e => Console.WriteLine(e));

            Console.WriteLine(messageTwo);
            Array.ForEach(array2, e => Console.WriteLine(e));
        }

    }

    public static class Exercise_103
    {
        /*
         * Write a C# program to create an array taking two middle elements from a given array of integers of length even.
         * Expected Output:
         *  Original Array: 1, 5, 7, 9, 11, 13
         *  New array: 7, 9
         */

        private static void arrayDisplay(int number)
        {
            Console.WriteLine(number);
        }

        public static void Execute()
        {
            Action<int> ArrayDisplay = new Action<int>(arrayDisplay);

            int[] givenArray = UtilityMethods.getValidNumbersArray(2);
            int[] newArray = new int[2];

            newArray[0] = givenArray[ givenArray.Length / 2 - 1];
            newArray[1] = givenArray[givenArray.Length / 2];

            Array.ForEach(newArray, ArrayDisplay);
        }
    }

    public static class Exercise_104
    {
        /*
         * Write a C# program to create a new array from two given arrays of integers, each length 3.
         */

        public static void Execute()
        {
            int[] Array1 = UtilityMethods.getValidNumbersArray(3);
            int[] Array2 = UtilityMethods.getValidNumbersArray(3);

            int[] newArray = new int[Array1.Length + Array2.Length];

            Array1.CopyTo(newArray, 0);
            Array2.CopyTo(newArray, Array1.Length);

            Array.ForEach(newArray, e => Console.WriteLine(e));
        }
    }

    public static class Exercise_105
    {
        /*
         * Write a C# program to create a new array swapping the first and last elements 
         * of a given array of integers of length at least 1.
         */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray(1);
            int[] newArray = (int[])givenArray.Clone();

            newArray[0] = givenArray.Last();
            newArray[newArray.Length - 1] = givenArray.First();

            Array.ForEach(newArray, e => Console.WriteLine(e));
        }
    }

    public static class Exercise_106
    {
        /*
         * Write a C# program to create a new array length 3 from a given array (length at least 3)
         * using the elements from themiddle of the array.
         * 
         * Original array: 1, 5, 7, 9, 11, 13
         * New array: 7, 9 11
         */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray(3);
            int[] newArray = new int[3];

            Array.ConstrainedCopy(givenArray, givenArray.Length / 2 - 1, newArray, 0, 3);

            Array.ForEach(newArray, e => Console.WriteLine(e));
        }
    }

    public static class Exercise_107
    {
        /*
         * Write a C# program to find the largest value from the first, last, and middle 
         * elements of a given array of ints of odd length (at least 1)
         */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray(1);

            int[] newArray = new int[3];

            newArray[0] = givenArray.First();
            newArray[1] = givenArray.Last();
            newArray[2] = givenArray[givenArray.Length / 2];

            Console.WriteLine( $"Largest value is: {newArray.Max()}" );


        }
    }

    public static class Exercise_108
    {
        /*
         * Write a C# program to create a new array taking the 1st two elements
         * from a given array.  If the length of the given array is less than 2
         * then return the given array.
         */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            if (givenArray.Length >= 2)
            {
                int[] newArray = new int[2]{ givenArray[0], givenArray[1] };
                Array.ForEach(newArray, e => Console.WriteLine(e));
            }
            else
            {
                Array.ForEach(givenArray, e => Console.WriteLine(e));
            }
        }
    }

    public static class Exercise_109
    {
        /*
         * Write a C# program to count even number of elements in a given array of integers.
         */
         public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            int evenCount = givenArray.Count() / 2;

            Console.WriteLine($"Even number of elements: {evenCount}");
        }
    }

    public static class Exercise_110
    {
        /*
         * 110. Write a C# Sharp program to compute the difference between the largest 
            and smallest values in a given array of integers and length one or more. 
            Expected Output: 
            Original array: 1, 5, 7, 9, 10, 12 
            Difference between the largest and smallest values: 
            11
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            int difference = givenArray.Max() - givenArray.Min();

            Console.WriteLine("Difference between the largest and smallest values: {0}", difference);
        }
    }

    public static class Exercise_111
    {
        /*
          111. Write a C# Sharp program to compute the sum of values in a given array of integers 
         * except the number 17. Return 0 if the given array has no integer. 
            Expected Output : 
            Original array: 1, 5, 7, 9, 10, 17
            Sum of values in the array of integers except the number 17: 
            32
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            int numOfSeventeens = givenArray.Count(e => e == 17);

            int sum = givenArray.Sum() - (numOfSeventeens * 17);

            Console.WriteLine("Sum of values in the array of integers except the number 17: {0}", sum);
        }
    }

    public static class Exercise_112
    {
        /*112. Write a C# Sharp program to compute the sum of the numbers in a given array 
            except those numbers starting with 5 followed by atleast one 6. 
            Return 0 if the given array has no integer. 
            Expected Output : 
            Original array: 1, 5, 6, 9, 10, 17
            Sum of the numbers of the said array except those numbers starting with 5 followed by atleast one 6: 
            37
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            int sum = 0;
            
            Array.ForEach(
                            givenArray, e => {
                                if (e.ToString().StartsWith("56") != true ) { sum += e; }
                                            }
            );

            Console.WriteLine(sum);

        }
    }

    public static class Exercise_113
    {
        /*113. Write a C# Sharp program to check if a given array of integers contains 5 next to a 5 somewhere. 
            Expected Output : 
                False
                True
                True
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();
            bool contains5 = false;

            for (int i = 0; i < givenArray.Length - 1; i++)
            {
                contains5 = givenArray[i] == 5 & givenArray[i + 1] == 5;
            }

            Console.WriteLine("Given array contains 5 next to a 5: {0}", contains5);
        }
    }

    public static class Exercise_114
    {
        /*114. Write a C# Sharp program to check whether a given array of integers contains 5's and 7's. 
            Expected Output : 
                True
                True
                False
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            var contains = givenArray.Contains(5) | givenArray.Contains(7);

            Console.WriteLine("Given array of integers contains 5's and 7's: {0}", contains);

        }
    }

    public static class Exercise_115
    {
        /*115. Write a C# Sharp program to check if the sum of all 5's in the array 
         is exactly 15 in a given array of integers. 
        Expected Output : 
            False
            True
            False
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            bool exactly = givenArray.Count(e => e == 5) == 3;

            Console.WriteLine("The sum of all 5's in the array is exactly 15: {0}", exactly);
        }
    }

    public static class Exercise_116
    {
        /*116. Write a C# Sharp program to check if the number of 3's is greater than the number of 5's.
        Expected Output : 
        False
        True
        False
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            bool threesGreater = givenArray.Count(e => e == 3) > givenArray.Count(e => e == 5);

            Console.WriteLine($" the number of 3's is greater than the number of 5's: {threesGreater}");
        }
    }

    public static class Exercise_117
    {
        /*117. Write a C# Sharp program to check if a given array of integers contains a 3 or a 5. 
        Expected Output : 
            True
            True
            True
            False
        */
        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            bool contains = givenArray.Contains(3) | givenArray.Contains(5);

            Console.WriteLine("Given array of integers contains a 3 or a 5: {0}", contains);
        }
    }

    public static class Exercise_118
    {
        /*118. Write a C# Sharp program to check if a given array of integers contains no 3 or a 5. 
        Expected Output : 
            True
            True
            False
            True
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            bool contains = givenArray.Contains(3) == false | givenArray.Contains(5);

            Console.WriteLine("given array contains no 3 or a 5: {0}",contains);
        }
    }

    public static class Exercise_119
    {
        /*119. Write a C# Sharp program to check if an array of integers contains a 3 next to a 3 or a 5 next to a 5 or both. 
        Expected Output : 
            True
            False
            False
            True
        */
        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            int threeIndex = Array.FindIndex(givenArray, e => e == 3);
            int fiveIndex = Array.FindIndex(givenArray, e => e == 5);

            //make sure the indexes do not go over
            threeIndex++;
            threeIndex = threeIndex < givenArray.Length ? threeIndex : 0;

            fiveIndex++;
            fiveIndex = fiveIndex < givenArray.Length ? fiveIndex : 0;

            bool contains = givenArray[threeIndex] == 3 | givenArray[fiveIndex] == 5;

            Console.WriteLine("array contains a 3 next to a 3 or a 5 next to a 5 or both: {0}", contains);
        }
    }

    public static class Exercise_120
    {
        /*120. Write a C# Sharp program to check a given array of integers 
         and return true if the given array contains two 5's next to each other
         , or two 5s separated by one element. 
        Expected Output : 
            True
            False
            True
            True
        */
        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();
            bool contains = false;
            int indexPlusTwo = 0;
            int numberOfElements = givenArray.GetUpperBound(0);

            for (int i = 0; i < numberOfElements; i++)
            {
                indexPlusTwo = i <= numberOfElements - 2 ? i + 2 : i + 1;

                if ( givenArray[i] == 5 & ( givenArray[i + 1] == 5 || givenArray[indexPlusTwo] == 5 ) )
                {
                    contains = true;
                    break;
                }
            }

            Console.WriteLine("the given array contains two 5's next to each other" + 
                                ", or two  5 separated by one element: {0}", contains);
        }
    }

    public static class Exercise_121
    {
        /*121. Write a C# Sharp program to check a given array of integers 
            and return true if there is a 3, with a 5 somewhere later in the given array. 
            Expected Output : 
                True
                False
                True
                False
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            int three = Array.FindIndex(givenArray, e => e == 3);
            int five = Array.LastIndexOf(givenArray, 5);

            bool evaluate = three < five ? true : false;

            Console.WriteLine($"There is a 3, with a 5 somewhere later in the given array: {evaluate}");
        }
    }

    public static class Exercise_122
    {
        /*
         * 122. Write a C# Sharp program to check a given array of integers 
            and return true if the given array contains either 2 even or 2 odd values all next to each other. 
            Expected Output : 
                True
                False
                True
                True
        */
        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();
            int index = 0;
            bool evaluate = false;

            for (int i = 0; i < givenArray.GetUpperBound(0); i++)
            {
                if( 
                    givenArray[i] % 2 == 0 & givenArray[i + 1] % 2 == 0 //even
                    |
                    givenArray[i] % 2 > 0 & givenArray[i + 1] % 2 > 0 //odd
                )
                {
                    evaluate = true;
                }
            }

            Console.WriteLine($" Contains either 2 even or 2 odd values all next to each other: {evaluate}");
        }
    }

    public static class Exercise_123
    {
        /*
         * 123. Write a C# Sharp program to check a given array of integers 
            and return true if the value 5 appears 5 times and there are no 5 next to each other. 
            Expected Output : 
            True
            False
            True
            False
        */
        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            int fiveCount = givenArray.Count(e => e == 5);
            bool fiveNext = false;
            bool evaluate = false;

            for (int i = 0; i < givenArray.GetUpperBound(0); i++)
            {
                if (givenArray[i] == 5 & givenArray[ i + 1 ] == 5)
                {
                    fiveNext = true;
                    break;
                }
            }

            evaluate = fiveCount >= 5 & fiveNext == false ? true : false;

            Console.WriteLine("The value 5 appears 5 times and there are no 5s next to each other: {0}", evaluate);
        }
    }

    public static class Exercise_124
    {
        /*
         * 124. Write a C# Sharp program to check a given array of integers 
            and return true if every 5 that appears in the given array is next to another 5. 
            Expected Output : 
            True
            False
            True
            False
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();
            int nextValue = 0;
            bool fiveNextFive = false;

            for (int i = 0; i <= givenArray.GetUpperBound(0); i++)
            {
                nextValue = i < givenArray.GetUpperBound(0) ? givenArray[i + 1] : 0; //get the next as long as loop isn't on last value

                if (givenArray[i] == 5 & nextValue != 5)
                {
                    fiveNextFive = false;
                    break;
                }
                else
                {
                    if (givenArray[i] == 5 & nextValue == 5)
                    {
                        fiveNextFive = true;
                        i++; //skip the next five
                    }
                }
            }

            //result = fiveNextFive == true;

            Console.WriteLine("every 5 that appears in the given array is next to another 5: {0}", fiveNextFive);
        }
    }

    public static class Exercise_125
    {
        /*125. Write a C# Sharp program to check a given array of integers and return true 
         if the specified number of same elements appears at the start and end of the given array. 
        Expected Output : 
            True
            False
            True
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();
            int numElements = UtilityMethods.GetValidNumber("How many duplicate integers should I search for?: ");

            /*I skipped this, not sure what the requirements are*/
        }
    }

    public static class Exercise_126
    {
        /*
         * 126. Write a C# Sharp program to check a given array of integers 
            and return true if the array contains three increasing adjacent numbers. 
            Expected Output : 
            True
            False
            True
        */
        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            bool contains = false; int containsCount = 0;

            for (int i = 0; i < givenArray.GetUpperBound(0); i++)
            {
                if ( givenArray[i + 1] - givenArray[i] > 0 )
                {
                    containsCount++;
                }
                else
                {
                    containsCount = 0;
                }
            }

            contains = containsCount >= 2 ? true : false;

            Console.WriteLine($"the array contains three increasing adjacent numbers: {contains}" );
        }
    }

    public static class Exercise_127
    {
        /*127. Write a C# Sharp program to shift an element in left direction and return a new array. 
        Expected Output : 
        New array: 20 -30 -40 50 10
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();
            int[] newArray = new int[givenArray.Length];

            Array.Copy(givenArray, 1, newArray, 0, givenArray.Length - 1);

            newArray[newArray.GetUpperBound(0)] = givenArray[0];

            Array.ForEach(newArray, e => Console.WriteLine(e));

        }
    }

    public static class Exercise_128
    {
        /*128. Write a C# Sharp program to create a new array taking the elements 
         before the element value 5 from a given array of integers. 
        Expected Output : 
        New array: 1 2 3
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            Predicate<int> findInArray = new Predicate<int>(Find5InArray);

            int indexOf5 = Array.FindIndex(givenArray, findInArray);

            int[] newArray = new int[indexOf5];

            Array.Copy(givenArray, 0, newArray, 0, indexOf5);

            Array.ForEach(newArray, e => Console.WriteLine(e));
        }

        private static bool Find5InArray(int element)
        {
            bool evaluate = element == 5 ? true : false;
            
            return evaluate;
        }
    }

    public static class Exercise_129
    {
        /*129. Write a C# Sharp program to create a new array taking the elements after the element value 5 
         from a given array of integers.
        Expected Output : 
        New array: 7 9 11
        */

        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            Predicate<int> findIndexOf5 = new Predicate<int>(FindIndexOf5);

            int indexOf5 = Array.FindIndex(givenArray, findIndexOf5);

            int[] newArray = new int[givenArray.Length - ( indexOf5 + 1 )];

            Array.Copy(givenArray, indexOf5 + 1, newArray, 0, newArray.Length);

            Array.ForEach(newArray, e => Console.WriteLine(e));
        }

        private static bool FindIndexOf5( int elementValue )
        {
            bool evaluate = elementValue == 5 ? true : false;

            return evaluate;
        }
    }

    public static class Exercise_130
    {
        /*
         130. Write a C# Sharp program to create a new array from a given array 
         of integers shifting all zeros to left direction. 
            Expected Output : 
            New array: 0 0 1 3 5 7 2 9 11
         */
        public static void Execute()
        {
            int[] givenArray = UtilityMethods.getValidNumbersArray();

            int[] newArray = new int[givenArray.Length];

            int zeroCount = givenArray.Count(e => e == 0);

            //Array.Copy(zeroArray, 0, newArray, 0, zeroArray.Length);
            int[] nonZero = Array.FindAll(givenArray, e => e > 0);

            Array.Copy( nonZero, 0, newArray, zeroCount, nonZero.Length);

            Array.ForEach(newArray, e => Console.WriteLine(e));
            
        }
    }

    public static class Exercise_131
    {
        /*131. Write a C# Sharp program to create a new array after replacing 
         all the values of 5 with 0, shifting all zeros to right direction. 
        Expected Output : 
        New array: 1 2 3 7 9 11 0 0 0
        */

        public static void Execute()
        {
            Action<int> printArray = new Action<int>(PrintArray);

            int[] givenArray = UtilityMethods.getValidNumbersArray();

            int[] newArray = new int[givenArray.Length];

            int[] nonFive = Array.FindAll(givenArray, e => e != 5);

            Array.Copy(nonFive, newArray, nonFive.Length);

            Array.ForEach(newArray, printArray);
        }

        private static void PrintArray(int number)
        {
            Console.WriteLine(number);
        }
    }



}
