using System;
using Exercises;

namespace String_Exercises
{
    public static class Exercise_01
    {
        /*
         * 1. Write a program in C# Sharp to input a string and print it. 
            Test Data :
            Input the string : Welcome, w3resource
            Expected Output :

            The string you entered is : Welcome, w3resource 
        */

        public static void Execute()
        {
            string inputString = UtilityMethods.GetValidString();
            Console.WriteLine("{0}", inputString);
        }
    }

    public static class Exercise_02
    {
        /*
         * 2. Write a program in C# Sharp to find the length of a string without using library function. 
        Test Data :
        Input the string : w3resource.com
        Expected Output :

        Length of the string is : 15 
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            char[] charArray = theString.ToCharArray();

            Console.WriteLine($"Length of the string is: {charArray.Length}");

        }
    }

    public static class Exercise_03
    {
        /*
          3. Write a program in C# Sharp to separate the individual characters from a string. 
            Test Data :
            Input the string : w3resource.com
            Expected Output :

            The characters of the string are : 
            w  3  r  e  s  o  u  r  c  e  .  c  o  m 
         */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            foreach( char letter in theString)
            {
                Console.Write($"{letter}  ");
            }
        }
    }

    public static class Exercise_04
    {
        /*
         4. Write a program in C# Sharp to print individual characters of the string in reverse order. 
            Test Data :
            Input the string : w3resource.com
            Expected Output :

            The characters of the string in reverse are : 

            m  o  c  .  e  c  r  u  o  s  e  r  3  w 
         */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            int stringLength = theString.Length;
            int index = stringLength - 1;

            while(index >= 0)
            {
                Console.Write($"{theString[index]} ");
                index--;
            }
        }
    }

    public static class Exercise_05
    {
        /*
         * 5. Write a program in C# Sharp to count the total number of words in a string.
            Test Data :
            Input the string : This is w3resource.com
            Expected Output :

            Total number of words in the string is : 3 
         */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            string previousCharacter = "";
            int count = 0;

            if( theString.Length > 0 )
            {
                count++;

                foreach (char character in theString)
                {                    
                    if (character == ' ' & previousCharacter != " ") count++;
                    previousCharacter = character.ToString();
                }
            }          

            Console.WriteLine("Total number of words in the string is: {0}", count);
        }
    }

    public static class Exercise_06
    {
        /*
         * 6. Write a program in C# Sharp to compare two string without using string library functions.
            Test Data :
            Input the 1st string : This is first string
            Input the 2nd string : This is first string
            Expected Output :

            The length of both strings are equal and 
            also, both strings are equal.
         */
        public static void Execute()
        {
            string firstString = UtilityMethods.GetValidString("Enter first string: ");
            string secondString = UtilityMethods.GetValidString("Enter second string: ");
            string isUnequal = " ", isUnequalLength = " ";
            int firstStrLength = firstString.Length;
            int secondStrLength = secondString.Length;

            if (firstStrLength == secondStrLength)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    if (firstString[i] != secondString[i])
                    {
                        isUnequal = "not";
                    }
                }
            }
            else {
                    isUnequal = "not";
                    isUnequalLength = "not"; 
            }

            Console.WriteLine($"The length of both strings are{isUnequalLength}equal and also, both strings are{isUnequal}equal.");
        }
    }

    public static class Exercise_07
    {
        /*
         * 7. Write a program in C# Sharp to count a total number of alphabets
            , digits and special characters in a string. 
            Test Data :
            Input the string : Welcome to w3resource.com
            Expected Output :

            Number of Alphabets in the string is : 21 
            Number of Digits in the string is : 1 
            Number of Special characters in the string is : 4
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            int digits = 0, alphabets = 0, special = 0;

            foreach (char character in theString)
            {
                if (int.TryParse(character.ToString(), out int number) == true)
                {
                    digits++;
                }
                else
                {
                    if (character >= 'a' & character <= 'z')
                    {
                        alphabets++;
                    }
                    else
                    {
                        if( character != ' ' ) special++;
                    }
                }

            }

            string message = $"Number of Alphabets in the string is: {alphabets}"
                           + $"\nNumber of Digits in the string is: {digits}"
                           + $"\nNumber of Special characters in the string is: {special}";

            Console.WriteLine(message);
        }
    }

    public static class Exercise_08
    {
        /*
         * 8. Write a program in C# Sharp to copy one string to another string. \
            Test Data :
            Input the string : This is a string to be copied.
            Expected Output :

            The First string is : This is a string to be copied. 

            The Second string is : This is a string to be copied. 

            Number of characters copied : 31 
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString("The First String Is ");

            string stringCopy = theString;

            Console.WriteLine($"The Second String is: {stringCopy}");


        }
    }

    public static class Exercise_09
    {
        /*
         * 9. Write a program in C# Sharp to count a total number of vowel or consonant in a string. 
            Test Data :
            Input the string : Welcome to w3resource.com
            Expected Output :

            The total number of vowel in the string is : 9 
            The total number of consonant in the string is : 12 
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            
            int vowelCount = 0, consonants = 0;
            string cType = "";

            foreach(char character in theString )
            {
                cType = charType(character);

                switch (cType)
                {
                    case "vowel":
                            vowelCount++;
                        break;

                    case "consonant":
                        consonants++;
                        break;

                    default:
                        break;
                }

            }

            Console.WriteLine("The total number of vowel in the string is: {0}", vowelCount);
            Console.WriteLine("The total number of consonant in the string is: {0}", consonants);
        }

        private static string charType( char character )
        {
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            if( char.IsLetter(character) )
                {
                foreach (char vowel in vowels)
                {
                    if (character == vowel) return "vowel";
                }
                return "consonant";
            }

            return "N/A";
        }
    }

    public static class Exercise_10
    {
        /*
         * 10. Write a program in C# Sharp to find maximum occurring character in a string. 
            Test Data :
            Input the string : Welcome to w3resource.com.
            Expected Output :

            The Highest frequency of character 'e' 
            appears number of times : 4 
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();

            int[] characters = new int[256];

            foreach( char character in theString )
            {
                characters[(int)character]++;

            }

            char maxChar = ' '; int numberTimes = 0;
            maxChars(characters, ref maxChar, ref numberTimes);
            
            Console.WriteLine($"The Highest frequency of character: {maxChar}");
            Console.WriteLine($"Appears number of times: {numberTimes}");
       
        }

        private static void maxChars( int[] characters, ref char maxChar, ref int numberTimes )
        {
            int highest = 0; 
            int? highestIndex = 0;

            for( int i = 0; i <= 255; i++)
            {
                if( characters[i] > highest )
                {
                    highest = characters[i];
                    highestIndex = i;
                }
            }

            maxChar = (char)highestIndex;
            numberTimes = highest;
        }
    }

    public static class Exercise_11
    {
        /*
         * 11. Write a program in C# Sharp to sort a string array in ascending order. 
            Test Data :
            Input the string : this is a string
            Expected Output :

            After sorting the string appears like : 
            a g h i i i n r s s s t t 
         */

        public static void Execute()
        {
           string theString = UtilityMethods.GetValidString("Input the string");

            char[] characters = theString.ToCharArray();

            int[] charCodes = new int[256];

            foreach( char character in characters )
            {
                charCodes[Convert.ToInt32(character)]++;
            }

           for( int i = 1; i <= 255; i++ )
            {
                if( charCodes[i] > 0 ) Console.Write(repeatChar( Convert.ToChar(i), charCodes[i]) + " " );

            }


        }

        private static string repeatChar( char character, int repeat )
        {
            string theString = "";

            for( int i = 1; i <= repeat; i++ )
            {
                theString += character.ToString() + " ";
            }

            return theString.Substring(0, theString.Length - 1); //remove the trailing space.
        }
    }

    public static class Exercise_12
    {
        /*
         * 12. Write a program in C# Sharp to read a string through the keyboard and sort it using bubble sort.
            Test Data :
            Input number of strings :3
            Input 3 strings below :
            abcd
            zxcv
            mnop
            Expected Output :

            After sorting the array appears like : 
            abcd 
            mnop 
            zxcv
        */

        public static void Execute()
        {
            int numbStrings = UtilityMethods.GetValidAbsoluteNumber("Input number of strings");

            Console.WriteLine($"Input {numbStrings} below: ");

            string[] strings = UtilityMethods.getStringArray(numbStrings);

            string[] newStrings = bubbleSort(strings);

            printArray(newStrings);
        }

        private static string[] bubbleSort( string[] strings )
        {
            string stringValue = "";
            string swappedString = "";
            int charIndex = 0;
            bool swap = false;

            //Get the length of the longest string
            //Sort on the indexes using string.compareto()?

            for ( int index = 0; index < strings.Length - 1; index++ )
            {
                //initialize vars
                charIndex = 0;
                swap = false;

                while ( strings[index].Substring(charIndex, 1) == strings[index + 1].Substring(charIndex, 1) )
                {
                    charIndex++;
                }

                if (Convert.ToChar(strings[index].Substring(charIndex, 1)) > Convert.ToChar(strings[index + 1].Substring(charIndex, 1)))
                {

                    swappedString = strings[index];
                    strings[index] = strings[index + 1];
                    strings[index + 1] = swappedString;
                    swap = true;
                }

                if (index == strings.Length - 2 & swap == true) index = -1;
            }

            return strings;
        }

        private static void printArray(string[] strings)
        {
            foreach( string astring in strings )
            {
                Console.WriteLine(astring);
            }
        }
    }

    public static class Exercise_13
    {
        /*
        13. Write a program in C# Sharp to extract a substring from a given string without using the library function. 
        Test Data :
        Input the string : This is a test string
        Input the position to start extraction :5
        Input the length of substring :5
        Expected Output :

        The substring retrieve from the string is :  is a
        */

        public static void Execute()
        {
            string message = "The substring retrieved from the string is :";
            string theString = UtilityMethods.GetValidString("Input the string");
            int startPos = UtilityMethods.GetValidAbsoluteNumber("Input the position to start extraction") - 1;
            int length = UtilityMethods.GetValidAbsoluteNumber("Input the length of the substring");

            if (startPos < theString.Length & startPos >= 0 & length <= (theString.Length - startPos))
            {
                string theSubstring = theString.Substring(startPos, length);
                Console.WriteLine("The substring retrieved from the string is: {0}", theSubstring);
            }
            else
            {
                Console.WriteLine("Start Position out of range of string.");
            }

        }
    }

    public static class Exercise_14
    {
        /*
         * 14. Write a C# Sharp program to check whether a given substring is present in the given string. 
            Test Data :
            Input the string : This is a Test String
            Input the substring to search : Test
            Expected Output: The substring exists in the string
         */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            string theSubstring = UtilityMethods.GetValidString(MinimalLength: 1, MaximumLength: theString.Length);

            bool exists = theString.Contains(theSubstring);
            string existsMsg = exists == true ? "exists" : "does not exist";

            string message = $"The substring { existsMsg } in the string";

            Console.WriteLine(message);
        }
    }

    public static class Exercise_15
    {
        /*
         * 15. Write a program in C# Sharp to read a sentence and replace lowercase characters by uppercase and vice-versa. 
        Test Data :
        Input the string : This is a string
        Expected Output :

        After conversion, the string is : tHIS IS A STRING 
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            string newString = "";

            foreach( char character in theString.ToCharArray() )
            {
                newString += char.IsUpper(character) == true ? character.ToString().ToLower() : character.ToString().ToUpper();
            }

            Console.WriteLine($"After conversion, the string is: {newString}");
        }
    }

    public static class Exercise_16
    {
        /*
         * 16. Write a program in C# Sharp to check the username and password. 
            Test Data :
            Input a username: uesr
            Input a password: pass
            Input a username: abcd
            Input a password: 1234
            Expected Output :

            Password entered successfully!
         */

        public static void Execute()
        {
            string username = UtilityMethods.GetValidString("Input a username");
            string password = UtilityMethods.GetValidString("Input a password");

            string usernameCk = UtilityMethods.GetValidString("Input your username");
            string passwordCk = UtilityMethods.GetValidString("Input your password");

            //verify
            if( username == usernameCk & password == passwordCk )
            {
                Console.WriteLine("Password entered successfully!");
            }
            else
            {
                Console.WriteLine("Password failed!");
            }
        }
    }

    public static class Exercise_17
    {
        /*
         * 17. Write a program in C# Sharp to search the position of a substring within a string. 
            Test Data:
            Input a String: this is a string
            Input a substring to be found in the string: is
            Expected Output :

            Found 'is' in 'this is a string' at position 2
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString("Input a String");
            string theSubString = UtilityMethods.GetValidString("Input a substring to be found in the string");
            string found = "is";
            int position = 0;
            string positionMsg = "";

            position = theString.IndexOf(theSubString);

            found = position > -1 ? "is" : "is not";
            positionMsg = position > -1 ? "position " + position.ToString() : "";

            Console.WriteLine($"Found {found} in 'this is a string' at {positionMsg}");


        }

    }

    public static class Exercise_18
    {
        /*
         * 18. Write a program in C# Sharp to check whether a character is an alphabet and not and if so, go to check for the case. 
            Test Data :
            Input a character: Z

            Expected Output :

            The character is uppercase.
         */

        public static void Execute()
        {
            char character = UtilityMethods.GetValidChar("input a character");
            string message = "";

            if(char.IsLetter(character) == true)
            {
                if (char.IsUpper(character) == true)
                {
                    message = "uppercase";
                }
                else
                {
                    message = "lowercase";
                }
            }
            else
            {
                message = "not an alphabet";
            }

            Console.WriteLine("The character is {0}", message);
        }
    }

    public static class Exercise_19
    {
        /*
         * 19. Write a program in C# Sharp to find the number of times a substring appears in a given string. 
            Test Data :
            Input the original string : this is original string
            Input the string to be searched for : str
            Expected Output :

            The string 'str' occurs 1 times
         */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString();
            string searchString = UtilityMethods.GetValidString();

            int searchIx = theString.IndexOf(searchString);
            int NumTimes = 0;

            while (searchIx > -1 & searchIx <= theString.Length - 1)
            {                
                searchIx = theString.IndexOf(searchString, searchIx + 1);
                NumTimes++;
            } 

            Console.WriteLine($"The string '{searchString}' occurs {NumTimes} times");
        }
    }

    public static class Exercise_20
    {
        /*
         * 20. Write a program in C# Sharp to insert a substring before the first occurrence of a string.
            Test Data :
            Input the original string : this is a string
            Input the string to be searched for : a
            Input the string to be inserted : test
            Expected Output :

            The modified string is : this is  test a string
        */

        public static void Execute()
        {
            string original = UtilityMethods.GetValidString("Input the original string");
            string search = UtilityMethods.GetValidString("Input the string to be searched for");
            string insert = UtilityMethods.GetValidString("Input the string to be inserted");

           

            int index = original.IndexOf(search);
            if (index > 0)
            {
                insert = " " + insert + " ";
            }
            else
            {
                insert = insert + " ";
            }

            if ( index > -1 ) original = original.Insert(index, insert);

            Console.WriteLine("The modified string is: {0}", original);
        }
    }

    public static class Exercise_21
    {
        /*
         * 21. Write a C# Sharp program to compare (less than, greater than, equal to ) two substrings. 
            Expected Output :

            str1 = 'computer', str2 = 'system'                                               
            Substring 'mp' in 'computer' is less than substring 'sy' in 'system'.  
        */

        public static void Execute()
        {
            string String1 = UtilityMethods.GetValidString("Enter 1st string");
            string String2 = UtilityMethods.GetValidString("Enter 2nd string");

            int greaterThan = string.Compare(String1.Substring(2, 2), String2.Substring(2, 2));
            string Comparison = greaterThan < 0 ? "less than" : greaterThan == 0 ? "same as" : "more than";

            Console.WriteLine($"Substring '{String1.Substring(2, 2)}' in '{String1}' is {Comparison} substring '{String2.Substring(2, 2)}' in '{String2}'.");

        }
    }
}
