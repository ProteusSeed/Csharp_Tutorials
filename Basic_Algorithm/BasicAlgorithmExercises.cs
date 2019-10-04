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


}
