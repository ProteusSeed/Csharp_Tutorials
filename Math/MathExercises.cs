using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Math_Exercises
{
    public static class Exercise_02
    {
        /*
         * 2. Write a C# Sharp program to find the greater and smaller value of two variables. 
            Expected Output:
            Display the greater of two values:
            Byte : The greater of 1 and 51 is 51.
            Int16 : The greater of -2 and 52 is 52.
            Int32 : The greater of -3 and 53 is 53.
            Int64 : The greater of -4 and 54 is 54.
            Single : The greater of 5 and 55 is 55.
            Double : The greater of 6 and 56 is 56.
            Decimal: The greater of 7 and 57 is 57.
            Display the lesser of two values:
            Byte : The lesser of 1 and 51 is 1.
            Int16 : The lesser of -2 and 52 is -2.
            Int32 : The lesser of -3 and 53 is -3.
            Int64 : The lesser of -4 and 54 is -4.
            Single : The lesser of 5 and 55 is 5.
            Double : The lesser of 6 and 56 is 6.
            Decimal: The lesser of 7 and 57 is 7.
         */

        public static void Execute()
        {
            List<string> types = new List<string>(){
                                                    { "byte" }
                                                    ,{ "Int16" }
                                                    ,{ "Int32" }
                                                    ,{ "Int64" }
                                                    ,{ "Single" }
                                                    ,{ "Double" }
                                                    ,{ "Decimal" }
                                                    ,{ "Display" }
                                                   }
        ;

            string type = UtilityMethods.GetValidString("Enter Type").ToLower();
            string value1 = ""; // UtilityMethods.GetValidString("Enter 1st Value");
            string value2 = ""; // UtilityMethods.GetValidString("Enter 2nd Value");
            bool value1Greater = true;

            switch (type)
            {
                case "byte":
                    getTypeValues( ref value1, ref value2 );
                    byte byteVar1 = byte.Parse(value1);
                    byte byteVar2 = byte.Parse(value2);
                    value1Greater = byteVar1 > byteVar2;//need to learn how to compare bytes, this doesn't work.
                    break;

                case "int16":
                    getTypeValues(ref value1, ref value2);
                    Int16 int16Var1 = Int16.Parse(value1);
                    Int16 int16Var2 = Int16.Parse(value2);
                    value1Greater = int16Var1 > int16Var2;
                    break;

                case "int32":
                    getTypeValues(ref value1, ref value2);
                    Int32 int32Var1 = Int32.Parse(value1);
                    Int32 int32Var2 = Int32.Parse(value2);
                    value1Greater = int32Var1 > int32Var2;
                    break;

                case "int64":
                    getTypeValues(ref value1, ref value2);
                    Int64 int64Var1 = Int64.Parse(value1);
                    Int64 int64Var2 = Int64.Parse(value2);
                    value1Greater = int64Var1 > int64Var2;
                    break;

                case "single":
                    getTypeValues(ref value1, ref value2);
                    Single singleVar1 = Single.Parse(value1);
                    Single singleVar2 = Single.Parse(value2);
                    value1Greater = singleVar1 > singleVar2;
                    break;

                case "double":
                    getTypeValues(ref value1, ref value2);
                    double doubleVar1 = double.Parse(value1);
                    double doubleVar2 = double.Parse(value2);
                    value1Greater = doubleVar1 > doubleVar2;
                    break;

                case "decimal":
                    getTypeValues(ref value1, ref value2);
                    decimal decimalVar1 = decimal.Parse(value1);
                    decimal decimalVar2 = decimal.Parse(value2);
                    value1Greater = decimalVar1 > decimalVar2;
                    break;

                default:
                    getTypeValues(ref value1, ref value2);
                    Console.WriteLine($"{type} is not one of the available types");
                    break;
            }

            Console.WriteLine($"{value1Greater}");
            Console.ReadLine();
        }

        private static void getTypeValues(ref string value1, ref string value2)
        {
            value1 = UtilityMethods.GetValidString("Enter 1st Value");
            value2 = UtilityMethods.GetValidString("Enter 2nd Value");
        }

    }

    public static class Exercise_03
    {
        /*
         * 3. Write a C# Sharp program to calculate the value that results from raising 3 to a power ranging from 0 to 32.
            3^0 = 1 (0x1)
            3^1 = 3 (0x3)
            3^2 = 9 (0x9)
            3^3 = 27 (0x1B)
            3^4 = 81 (0x51)
            3^5 = 243 (0xF3)
            3^6 = 729 (0x2D9)
            3^7 = 2,187 (0x88B)
        */

        public static void Execute()
        {
            double res = System.Math.Pow(3, 5);

            for (int i = 0; i <= 32; i++)
            {
                Console.WriteLine("3 ^ {0} = {1}", i, System.Math.Pow(3,i));
            }            
        }

    }

    public static class Exercise_24
    {
        /*
         * 24. Write a C# Sharp program to reverse the binary representation of an given integer and convert the reversed binary number into an integer.
            Expected Output:
            Original number: 120
            Reverse the binary representation of the said integer and convert it into an integer: 15
            Original number: 321
            Reverse the binary representation of the said integer and convert it into an integer: 261
            Original number: 43
            Reverse the binary representation of the said integer and convert it into an integer: 53
            Original number: 4433
            Reverse the binary representation of the said integer and convert it into an integer: 4433
         */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber();
            string binary = toBinary(number);

            Console.WriteLine($"binary: {binary}");

            Console.WriteLine($"binary reversed: {stringReverse(binary)}");

            Console.WriteLine($"Reverse the binary representation of the said integer and convert it into an integer: {binaryToInteger(stringReverse(binary))}");
        }

        private static string toBinary(int number)
        {
            int integer = number;
            string binary = "";

            while (integer > 0)
            {
                
                binary = (integer % 2 > 0 ? "1" : "0") + binary;
                integer = integer / 2;
            }

            return binary;
        }

        private static string stringReverse(string theString)
        {
            string reversedString = "";
            char[] charArray = theString.ToCharArray();

            Array.Reverse(charArray);

            reversedString = new string(charArray);

            return reversedString;
        }

        private static int binaryToInteger(string binary)
        {
            int integer = 0;
            int bitAsInt = 0;
            int multiplier = 1;

            char[] charArray = binary.ToCharArray();

            Array.Reverse(charArray);

            foreach( char bit in charArray )
            {
                bitAsInt = int.Parse(bit.ToString());
                integer += bitAsInt == 1 ? multiplier : 0;
                multiplier *= 2;
            }

            return integer;
        }
    }

    public static class Exercise_25
    {
        /*
         25. Write a C# Sharp program to find the closest palindrome number of a given integer. 
         If there are two palindrome numbers in absolute distance return the smaller number. 
         */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidAbsoluteNumber();
            int higherNumber = number;
            int lowerNumber = number;

            palindrome(ref higherNumber, '+');
            palindrome(ref lowerNumber, '-');

            int palidromeNumber = ( higherNumber - number ) > ( number - lowerNumber ) | (higherNumber - number) == (number - lowerNumber) ? lowerNumber : higherNumber;

            Console.WriteLine("Palindrome: {0}", palidromeNumber);
        }

        private static void palindrome(ref int number, char sign)
        {
            char[] charArray = number.ToString().ToCharArray();
            char[] charArrayReversed = charArray;

            Array.Reverse(charArrayReversed);

            int numberReversed = int.Parse(new string(charArrayReversed));
            if (number != numberReversed | number == 0)
            {
                if (sign == '+')
                {
                    number++;
                    palindrome(ref number, '+');
                }
                else
                {
                    number--;
                    palindrome(ref number, '-');
                }
            }
            else
            {
                return;
            }
        }
    }
}
