using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
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

    public static class Exercise_22
    {
        /*
         * 22. Write a C# Sharp program to compare two substrings that only differ in case. The first comparison ignores case and the second comparison considers case. 
            Expected Output :

            str1 = 'COMPUTER', str2 = 'computer'                                             
            Ignore case:                                                                     
            Substring 'MP' in 'COMPUTER' is equal to substring 'mp' in 'compu                                                                              
            Honor case:                                                                      
            Substring 'MP' in 'COMPUTER' is greater than substring 'mp' in 'computer'.   
         */

        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString("Enter 1st string");
            string string2 = UtilityMethods.GetValidString("Enter 2nd string");

            int start = UtilityMethods.GetValidAbsoluteNumber("Enter start index");
            int length = UtilityMethods.GetValidAbsoluteNumber("Enter length");

            string substring1 = string1.Substring(start, length);
            string substring2 = string2.Substring(start, length);

            string equality = substring1.ToLower() == substring2.ToLower() ? "equal" : "not equal";

            Console.WriteLine("Ignore case:");
            Console.WriteLine($"Substring '{substring1}' in '{string1}' is {equality} to substring '{substring2}' in '{string2}' ");

            equality = substring1 == substring2 ? "equal" : "not equal";

            Console.WriteLine("Honor Case");
            Console.WriteLine($"Substring '{substring1}' in '{string1}' is {equality} to substring '{substring2}' in '{string2}' ");

        }
    }

    public static class Exercise_23
    {
        /*
         * 23. Write a C# Sharp program to compare two substrings using different cultures and ignoring the case of the substrings. Go to the editor
            Expected Output :

            str1 = 'COMPUTER', str2 = 'computer'                                             
            Ignore case, Turkish culture:                                                    
            Substring 'UT' in 'COMPUTER' is equal to substring 'ut' in 'computer'.           
                                                                                 
            Ignore case, invariant culture:                                                  
            Substring 'UT' in 'COMPUTER' is equal to substring 'ut' in 'computer'.   
         */

        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString("Enter 1st string");
            string string2 = UtilityMethods.GetValidString("Enter 2nd string");

            int start = UtilityMethods.GetValidAbsoluteNumber("Enter start index");
            int length = UtilityMethods.GetValidAbsoluteNumber("Enter length");

            string substring1 = string1.Substring(start, length);
            string substring2 = string2.Substring(start, length);

            string equality = string.Compare( substring1.ToLower() , substring2.ToLower(), false, new System.Globalization.CultureInfo("tr-TR") ) == 0 ? "equal" : "not equal";

            Console.WriteLine("Ignore case:");
            Console.WriteLine($"Substring '{substring1}' in '{string1}' is {equality} to substring '{substring2}' in '{string2}' ");

            equality = string.Compare( substring1.ToLower(), substring2.ToLower(), true, System.Globalization.CultureInfo.InvariantCulture ) == 0 ? "equal" : "not equal";

            Console.WriteLine("Honor Case");
            Console.WriteLine($"Substring '{substring1}' in '{string1}' is {equality} to substring '{substring2}' in '{string2}' ");

        }
    }

    public static class Exercise_24
    {
        /*
         * 24. Write a C# Sharp program to compare the last names of two people. It then lists them in alphabetical order. 
            Expected Output :

            Sorted alphabetically by last name:                                              
            Michel Jhonson                                                                   
            John Peterson  
        */

        public static void Execute()
        {
            string firstPerson = UtilityMethods.GetValidString("First person");
            string secondPerson = UtilityMethods.GetValidString("Second person");
            string firstLastname = "", secondLastName = "";

            char[] firstPersonChar = firstPerson.ToCharArray();
            Array.Reverse(firstPersonChar);

            char[] secondPersonChar = secondPerson.ToCharArray();
            Array.Reverse(secondPersonChar);

            //get last name
            foreach (char character in firstPersonChar) 
            {
                if (character == ' ') break;
                firstLastname = character + firstLastname;
                
            }

            foreach (char character in secondPersonChar)
            {
                if (character == ' ') break;
                secondLastName = character + secondLastName;
            }

            if (string.Compare(firstLastname, secondLastName) == -1)
            {
                Console.WriteLine(firstLastname);
                Console.WriteLine(secondLastName);
            }
            else
            {
                Console.WriteLine(secondLastName);
                Console.WriteLine(firstLastname);
            }

        }
    }

    public static class Exercise_25
    {
        /*
         * 25. Write a C# Sharp program to compare four sets of words by using each member of the string comparison enumeration. The comparisons use the conventions of the English (United States) and Sami (Upper Sweden) cultures.
            Note : The strings "encyclopedia" and "encyclopedia" are considered equivalent in the en-US culture but not in the Sami (Northern Sweden) culture.

            Expected Output :

               case = Case (CurrentCulture): False                                           
               case = Case (CurrentCultureIgnoreCase): True                                  
               case = Case (InvariantCulture): False                                         
               case = Case (InvariantCultureIgnoreCase): True                                
               case = Case (Ordinal): False                                                  
               case = Case (OrdinalIgnoreCase): True                                         
            ........ 
         */

        public static void Execute()
        {
            String[] cultureNames = { "en-AU", "sv-SE" };

            String[] strs1 = { "case",  "encyclopedia",
                            "encyclopedia", "Archeology" };
            String[] strs2 = { "Case", "encyclopedia",
                            "encyclopedia" , "ARCHEOLOGY" };

            //get all string comparison types into a string comparison type array
            StringComparison[] comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));

            foreach (var cultureName in cultureNames)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
                Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);

                //loop through the strings evaluating each set
                for (int ctr = 0; ctr <= strs1.GetUpperBound(0); ctr++)
                {
                    foreach (var comparison in comparisons)
                    {
                        Console.WriteLine(
                            "   {0} = {1} ({2}): {3}"
                            ,strs1[ctr]
                            ,strs2[ctr]
                            ,comparison
                            ,String.Equals(strs1[ctr], strs2[ctr], comparison)
                        );
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }

    public static class Exercise_26
    {
        /*
         * 26. Write C# Sharp program to demonstrate that the Compare(String, String, Boolean) method is equivalent to using ToUpper or ToLower when comparing strings. 
            Expected Output :

            Comparing 'QRS' and 'qrs':                                                       
            The Strings are equal when capitalized? true                                     
            The Strings are equal when case is ignored? true
        */

        public static void Execute()
        {
            string string1 = "QRS";
            string string2 = "qrs";

            Console.WriteLine($"The Strings are equal when capitalized? {string.Compare(string1,string2,true) == 0}");                                     
            Console.WriteLine($"The Strings are equal when case is ignored? {string1.ToLower() == string2.ToLower()}");
        }
    }

    public static class Exercise_27
    {
        /*
         * 27. Write a C# Sharp program to demonstrate how culture can affect a comparison. 

            Note : In Czech – Czech Republic culture, "ch" is a single character that is greater than "d". However, in English - United States culture, "ch" consists of two characters, and "c" is less than "d".

            Expected Output :

            For en-US: change < dollar                                                       
            For cs-CZ: change > dollar
         */

        public static void Execute()
        {
            string string1 = "change";
            string string2 = "dollar";

            CultureInfo current = CultureInfo.CurrentCulture;
            CultureInfo czech = new CultureInfo("cs");

            string compare1 = string.Compare(string1, string2, false, current) < 0 ? "<" : ">";
            string compare2 = string.Compare(string1, string2, false, czech) < 0 ? "<" : ">";

            Console.WriteLine($"For {current}: {string1} {compare1} {string2}");
            Console.WriteLine($"For {czech}: {string1} {compare2} {string2}");


        }
    }

    public static class Exercise_28
    {
        /*
         * 28. Write a C# Sharp program to compare two strings in following three different ways produce three different results. 

        a. using linguistic comparison for the en-US culture;
        b. using linguistic case-sensitive comparison for the en-US culture;
        c. using an ordinal comparison. It illustrates how the three methods of comparison

        Expected Output :

        'sister' comes before 'Sister'.                                                  
        'sister' is the same as 'Sister'.                                                
        'sister' comes after 'Sister'.
        */

        public static void Execute()
        {
            string string1 = "sister";
            string string2 = "Sister";

            string compareUS = "", compareCSUS = "", compareOrd = "";

            switch (string.Compare(string1, string2, CultureInfo.GetCultureInfo("en-US"), CompareOptions.None))
            {
                case -1:
                    compareUS = "comes before";
                    break;

                case 0:
                    compareUS = "is the same as";
                    break;

                case 1:
                    compareUS = "comes after";
                    break;

                default: break;
            }

            Console.WriteLine($"'{string1}' {compareUS} '{string2}'.");

            switch (string.Compare(string1, string2, CultureInfo.GetCultureInfo("en-US"), CompareOptions.IgnoreCase))
            {
                case -1:
                    compareUS = "comes before";
                    break;

                case 0:
                    compareUS = "is the same as";
                    break;

                case 1:
                    compareUS = "comes after";
                    break;

                default: break;
            }

            Console.WriteLine($"'{string1}' {compareUS} '{string2}'.");

            if (string.CompareOrdinal(string1, string2) < 0)
                {
                    compareUS = "comes before";
                }
            else if (string.CompareOrdinal(string1, string2) == 0)
                {
                    compareUS = "is the same as";
                }
            else
                {
                    compareUS = "comes after";
                }

            Console.WriteLine($"'{string1}' {compareUS} '{string2}'.");
        }
    }

    public static class Exercise_29
    {
        /*
         * 29. Write a C# Sharp program to compare three versions of the letter "I". The results are affected by the choice of culture
            , whether case is ignored, and whether an ordinal comparison is performed. 

            Expected Output :
            Compare three versions of the letter I using different values of StringComparison.                                                                                
            The current culture is en-US.                                                    
                                                                                 
            StringComparison.CurrentCulture:                                                 
            LATIN SMALL LETTER I (U+0069) is less than LATIN SMALL LETTER DOTLESS I (U+0131) 
            LATIN SMALL LETTER I (U+0069) is less than LATIN CAPITAL LETTER I (U+0049)       
            LATIN SMALL LETTER DOTLESS I (U+0131) is greater than LATIN CAPITAL LETTER I (U+0
            049)
         */

        public class compares 
            {
                public int compare1 { get; set; }
                public int compare2 { get; set; }

                public compares( int vcompare1, int vcompare2 )
                {
                    compare1 = vcompare1;
                    compare2 = vcompare2;
                }
            }

        public static void Execute()
        {
            string[,] letters = { 
                                    { "/U=0069", "LATIN SMALL LETTER I", Convert.ToString('\u0069') } 
                                    ,{ "/U+0049", "LATIN CAPITAL LETTER I", Convert.ToString('\u0049') }
                                    ,{ "/U+0131", "LATIN SMALL LETTER DOTLESS I", Convert.ToString('\u0131') }    
            };
            string compareMsg = "", compareTypeMsg = "";

            List<compares> trackCompared = new List<compares>();

            for (int compareType = 1; compareType <= 3; compareType++)
            {
                switch (compareType)
                {
                    case 1:
                            compareTypeMsg = "Culture " + CultureInfo.CurrentCulture.Name;
                        break;
                    case 2:
                            compareTypeMsg = "Ignore Case";
                        break;
                    case 3:
                            compareTypeMsg = "ordinal";
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"\r\n{compareTypeMsg}\r\n");

                for (int i = 0; i <= letters.GetUpperBound(0); i++)
                {

                    for (int j = 0; j <= letters.GetUpperBound(0); j++)
                    {
                        if (!(trackCompared.Contains(new compares(i, j)) | trackCompared.Contains(new compares(j, i))) & i != j)
                        {
                            compareMsg = compare(letters[i, 2], letters[j, 2], compareType);
                            Console.WriteLine($"{letters[i, 1]} {compareMsg} {letters[j, 1]}");
                            trackCompared.Add(new compares(i, j));
                        }
                    }
                }
            }
        }

        private static string compare( string string1, string string2, int compareType )
        {
            int compareResult = compareType == 1 ? string.Compare(string1, string2, false, CultureInfo.CurrentCulture ) 
                                : compareType == 2 ? string.Compare(string1, string2, true ) 
                                : string.CompareOrdinal( string1, string2 );

            if ( compareResult < 0 )
            {
                return "is less than";
            }
            else if ( compareResult > 0 )
            {
                return "is greater than";
            }
            else return "is equal to";
        }

    }

    public static class Exercise_30
    {
        /*
         * 30. Write a C# Sharp program to demonstrate that compare ordinal and Compare use different sort orders. 
            Expected Output:

            CompareOrdinal("xyz"[1], "XYZ"[1]):                                              
               'y' is greater than 'Y'                                                       
            Compare("xyz"[1], "XYZ"[1]):                                                     
               'y' is less than 'Y'
         */

        public static void Execute()
        {
            int compareResult = string.CompareOrdinal("xyz", 1, "XYZ", 1, 1);

            string compareMsg = compareResult < 0 ? "is less than" : compareResult > 0 ? "is greater than" : "is equal to";

            Console.WriteLine($"CompareOrdinal(\"xyz\" [1], \"XYZ\"[1]):\"y\" {compareMsg} \"Y\" ");

            compareResult = string.Compare("xyz", 1, "XYZ", 1, 1);

            compareMsg = compareResult < 0 ? "is less than" : compareResult > 0 ? "is greater than" : "is equal to";

            Console.WriteLine($"Compare(\"xyz\" [1], \"XYZ\"[1]):\"y\" {compareMsg} \"Y\" ");
        }
    }

    public static class Exercise_31
    {
        /*
         * 31. Write a C# Sharp program to perform and ordinal comparison of two strings that only differ in case. 

            Expected Output :

            Compare the numeric values of the corresponding Char objects in each string.     
            str1 = 'JAVA', str2 = 'python'                                                   
            String 'JAVA' is less than String 'python'.
        */

        public static void Execute()
        {
           string str1 = "JAVA";
           string str2 = "python";

           int compareResult = string.CompareOrdinal(str1, str2);
            string compareMsg = compareResult < 0 ? "is less than" : compareResult > 0 ? "is greater than" : "is equal to";

            Console.WriteLine($"String ''{str1}'' {compareMsg} String ''{str2}''");

        }
    }

    public static class Exercise_32
    {
        /*
         * 32. Write a C# Sharp program to compare a given string with set of strings. 

            Expected Output :

            Bad argument: TestClass (type TestClass)                                         
            Comparing 'some text' with 'TestClass': -1                                       
            Bad argument: 123 (type Int32)                                                   
            Comparing 'some text' with '123': 1                                              
            Comparing 'some text' with 'some text': 0                                        
            Comparing 'some text' with 'Some Text': -1
        */

        public class TestClass
        { }

        public static void Execute()
        {
            var test = new TestClass();
            Object[] objectsToCompare = { test, test.ToString(), 123,
                                    123.ToString(), "some text",
                                    "Some Text" };
            string s = "some text";
            foreach (var objectToCompare in objectsToCompare)
            {
                try
                {
                    int i = s.CompareTo(objectToCompare);
                    Console.WriteLine("Comparing '{0}' with '{1}': {2}",
                                      s, objectToCompare, i);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Bad argument: {0} (type {1})",
                                      objectToCompare,
                                      objectToCompare.GetType().Name);
                }
            }
        }
    }

    public static class Exercise_33
    {
        /*
        33. Write a C# Sharp program to compare the current string instance with another string. 
        Expected Output :

        The strings occur in the same position in the sort order.                        
        The first string follows the second in the sort order.                           
                                                                                 
        The first string precedes the second in the sort order.                          
        The first string precedes the second in the sort order.                          
        The first string follows the second in the sort order.
         */

        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString("Enter the 1st string");
            string string2 = UtilityMethods.GetValidString("Enter the 2nd string");

            string precedes = "The first string precedes the second in the sort order.";
            string follows = "The first string follows the second in the sort order.";
            string same = "The strings occur in the same position in the sort order.";

            int compareResult = string.Compare(string1, string2, false);

            if (compareResult < 0) Console.WriteLine(precedes);
            if (compareResult == 0) Console.WriteLine(same);
            if (compareResult > 0) Console.WriteLine(follows);
        }

    }

    public static class Exercise_34
    {
        /*
         * 34. Write a C# Sharp program to concatenate three objects, objects with a variable and 3-element object array. 

            Expected Output :

            Search for the target string "Å" in the string "abcЙࠉ".                          
                                                                                 
            Using the English (United Kingdom) - "en-GB" culture:                            
            Case sensitive:                                                                  
              The string to search ends with the target string: False 
         */

        public static void Execute()
        {
                int i = -123;
                Object o = i;
                Object[] objs = new Object[] { -123, -456, -789 };

                Console.WriteLine("Concatenate 1, 2, and 3 objects:");
                Console.WriteLine("1) {0}", String.Concat(o));
                Console.WriteLine("2) {0}", String.Concat(o, o));
                Console.WriteLine("3) {0}", String.Concat(o, o, o));

                Console.WriteLine("\nConcatenate 4 objects and a variable length parameter list:");
                Console.WriteLine("4) {0}", String.Concat(o, o, o, o));
                Console.WriteLine("5) {0}", String.Concat(o, o, o, o, o));

                Console.WriteLine("\nConcatenate a 3-element object array:");
                Console.WriteLine("6) {0}", String.Concat(objs));

        }
    }

    public static class Exercise_36
    {
        /*
         * 36. Write a C# Sharp program to concatenate three strings and display the result. 
         
            Expected Output :
            Don't count your chickens, before the eggs, have hatched.
        */

        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString("Enter string1");
            string string2 = UtilityMethods.GetValidString("Enter string2");
            string string3 = UtilityMethods.GetValidString("Enter string3");

            Console.WriteLine(string.Concat(string1, " ", string2, " ", string3));
        }
    }

    public static class Exercise_37
    {
        /*
         * 37. Write a C# Sharp program to concatenate the array values of strings. 

            Expected Output :

            hello welcome to C# Sharp create Windows client applications                     
                                                                                 
            hello applicationsC# Sharp client create to welcome Windows
            Click me to see the solution
        */

        public static void Execute()
        {
            int numOfStrings = UtilityMethods.GetValidAbsoluteNumber("Enter # of strings");
            string[] stringArray = new string[numOfStrings];
            string concatenated = "";

            for( int i = 0; i < numOfStrings; i++ )
            {
                stringArray[i] = UtilityMethods.GetValidString($"Enter string {i}");
                
            }

            foreach( string aString in stringArray )
            {
                concatenated += aString;
            }

            Console.WriteLine(concatenated);
        }
    }

    public static class Exercise_38
    {
        /*
         * 38. Write a C# Sharp program to determine whether the string "birds" is a substring of a familiar. 

            Note : Quotation 'two birds with one stone'.

            Expected Output :

            'birds' is in the string 'Kill two birds with one stone': True                   
            'birds begins at character position 10
        */

        public static void Execute()
        {
            string theString = UtilityMethods.GetValidString("Enter string");
            string subString = UtilityMethods.GetValidString("Enter substring");

            int position = theString.IndexOf(subString);

            Console.WriteLine(position);
        }
    }

    public static class Exercise_39
    {
        /*
         * 39. Write a C# Sharp program to creates two string objects with different values. 
           When it calls the Copy method to assign the first value to the second string, 
            the output indicates that the strings represent different object references although their values are now equal. 
            On the other hand, when the first string is assigned to the second string
            , the two strings have identical values because they represent the same object reference. 

            Expected Output :
                s1 = 'JAVA'                                                                      
                s2 = 'Python''
         */

        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString("Enter 1st string");
            string string2 = ""; // UtilityMethods.GetValidString("Enter 2nd string");

            string2 = String.Copy(string1);
            Console.WriteLine($"{string1.GetType().Name} {string1} \n{string2.GetType().Name} {string2} \n Reference Equals: {Object.ReferenceEquals(string1,string2)} \n Object Equals: {Object.Equals(string1,string2)}");

            string2 = string1;
            Console.WriteLine($"{string1.GetType().Name} {string1} \n{string2.GetType().Name} {string2} \n Reference Equals: {Object.ReferenceEquals(string1, string2)} \n Object Equals: {Object.Equals(string1, string2)}");

        }
    }

    public static class Exercise_40
    {
        /*
         * 40. Write a C# Sharp program to demonstrate the CopyTo method. 

            Expected Output :
                w3resource CSharp Tutoral                                                        
                w3resource Python Tutoral                                                        
                w3resourcedifferentutoral
         */

        public static void Execute()
        {
            string string1 = UtilityMethods.GetValidString();
            char[] string2 = { 'w','3','r','e','s','o','u','r','c','e',' ','C','S','h','a','r','p',' ','T','u','t','o','r','a','l' };
            string string3 = "";

            string3 = string2.ToString();

            Console.Write($"Original string: ");
            Console.WriteLine(string2);

            string1.CopyTo(0,string2,11,string1.Length);

            string3 = string2.ToString();

            Console.Write($"Copied-To string: ");
            Console.WriteLine(string2);
        }
    }

    public static class Exercise_41
    {
        /*
         * 41. Write a C# Sharp program to indicate whether each string in an array ends with a period ("."). 

            Expected Output :

            'Actions speak louder than words' ends in a period: False                        
            'Hello!' ends in a period: False                                                 
            'Python.' ends in a period: True                                                 
            'PHP.' ends in a period: True                                                    
            'random' ends in a period: False
        */

        public static void Execute()
        {
            string[] string1 = new string[]{
                "Actions speak louder than words"
                ,"Hello!"
                ,"Python."
                ,"PHP."
                ,"random"
                };
            bool endsWithPeriod = false;

            foreach (string item in string1)
            {
                endsWithPeriod = item.Substring(item.Length - 1) == ".";
                Console.WriteLine($"{item}: {endsWithPeriod}");
            }
        }
    }
}