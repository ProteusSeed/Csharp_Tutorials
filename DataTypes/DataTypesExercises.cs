using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace DataTypes_Exercises
{
    public static class Exercise_1
    {
        /*
         * Write a C# Sharp program that takes three letters as input and display them in reverse order. 
        Test Data
        Enter letter: b 
        Enter letter: a
        Enter letter: t
        Expected Output :
        t a b
        */

        public static void Execute()
        {
            string input = UtilityMethods.GetValidString(MinimalLength: 3, MaximumLength: 3);

            input = reverse(input);

            Console.WriteLine(input);

        }

        private static string reverse( string inputString)
        {
            string newString = "";
            char[] characters = inputString.ToCharArray();

            for(int index = characters.GetUpperBound(0); index >= 0; index--)
            {
                newString += characters[index];
            }

            return newString;
        }
    }

    public static class Exercise_2
    {
        /*2. Write a C# Sharp program that takes a number and a width also a number
         , as input and then displays a triangle of that width, using that number. 
        Test Data
        Enter a number: 6 
        Enter the desired width: 6 
        Expected Output :
        666666                                                      
        66666                                                           
        6666                                                                  
        666                                                        
        66                                                                  
        6 
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidNumber();
            int width = UtilityMethods.GetValidNumber("Enter width: ");

            for (int i = width; i >= 0; i--)
            {
                Console.WriteLine(repeatString(number.ToString(), i));

            }
            
        }

        private static string repeatString(string inputString, int repeats )
        {
            string theString = new String('x', repeats);

            theString = theString.Replace("x", inputString);

            return theString;
        }

    }

    public static class Exercise_3
    {
        /*
          3. Write a C# Sharp program that takes userid and password as input (type string).
           After 3 wrong attempts, user will be rejected.
         */
         public static void Execute()
        {
            string userid = "LexLuthor";
            string password = "Krypt0N1ght";
            string useridEntry = "";
            string passwordEntry = "";
            int attemptThreshold = 3;
            int attempts = 1;
            string message = "User ID and / or Password do not match, please try again.";

            while (attempts <= attemptThreshold)
            {
                useridEntry = UtilityMethods.GetValidString("Enter User ID");
                passwordEntry = UtilityMethods.GetValidString("Enter Password");

                if (useridEntry != userid | passwordEntry != password)
                {
                    message = $" You have {attemptThreshold - attempts} attempts left.";
                    message += attemptThreshold == attempts ? " ACCESS DENIED!!!" : "";

                    Console.WriteLine( message );

                    attempts++;
                }
                else {
                    Console.WriteLine("Welcome to the app!");
                    break; 
                }
            }


        }
    }

    public static class Exercise_4
    {
        /*4. Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) 
         on them and displays the result of that operation. 
        Test Data
        Input first number: 20
        Input operation: - 
        Input second number: 12
        Expected Output :
        20 - 12 = 8
        */

        private static char[] operators = new char[]{ '+', '-', '*', '/' };

        private static char getValidOperator()
        {
            bool entryValid = false;
            string entry = ""; char entryToChar = ' ';
            char operation = ' ';

            while (entryValid == false ) 
            {
                Console.WriteLine("Enter one of the following operators +, -, *, /");

                entry = Console.ReadLine();
                entryToChar = Convert.ToChar(entry);

                if (entry.Length == 1 & Array.FindIndex(operators, c => c.Equals(entryToChar)) != -1 )
                {
                    operation = entryToChar;
                    entryValid = true;
                }
                else
                {
                    Console.WriteLine("Entry is not a valid operator!");
                }
                //Array.Find(operators, c => c = entry


               // entry = Console.ReadLine();
            }

            return operation;
        }

        public static void Execute()
        {
            int firstNumber = UtilityMethods.GetValidNumber();
            int secondNumber = UtilityMethods.GetValidNumber();
            char operation = getValidOperator();
            int result = 0;

            if (operation == '+')
            {
                result = firstNumber + secondNumber;
            }

            if (operation == '-')
            {
                result = firstNumber - secondNumber;
            }

            if (operation == '*')
            {
                result = firstNumber * secondNumber;
            }

            if (operation == '/')
            {
                result = firstNumber / secondNumber;
            }

            Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");
        }

    }

    public static class Exercise_5
    {
        /*
          5. Write a C# Sharp program that takes the radius of a circle as input 
            and calculate the perimeter and area of the circle. 
            Test Data
            Input the radius of the circle :
            12 
            Expected Output :
            Perimeter of Circle : 75.36

         */

        public static void Execute()
        {
            decimal radius = UtilityMethods.GetValidDecimal("Input the radius of the circle");

            decimal perimeter = 2 * (decimal)Math.PI * radius;
            decimal area = (decimal)( Math.PI * Math.Pow((double)radius, 2) );

            Console.WriteLine($"Perimeter of a circle: {perimeter}");
            Console.WriteLine($"Area of a circle: {area}");
        }
    }

    public static class Exercise_6
    {
        /*
         * 6. Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 
            (using integer numbers for y , ranging from -5 to +5).
         */

        public static void Execute()
        {
            int x = 0;

            for (int y = -5; y <= 5; y++)
            {
                x = ( y * 2 ) + ( y * 2 ) + 1;

                Console.WriteLine( $"{x} = ({y} * 2) + (2 * {y}) + 1" );
            }
        }
    }

    public static class Exercise_7
    {
        /*
         * 7. Write a C# Sharp program that takes distance and time as input 
            and displays the speed in kilometers per hour and miles per hour. 
            Test Data:
            Input distance(meters): 50000 
            Input timeSec(hour): 1 
            Input timeSec(minutes): 35
            Input timeSec(seconds): 56
            Expected Output:
            Your speed in meters/sec is 8.686588
            Your speed in km/h is 31.27172 
            Your speed in miles/h is 19.4355
         */

        public static void Execute()
        {
            double distance = (double)UtilityMethods.GetValidDecimal("Input distance(meters)");
            int timeHour = UtilityMethods.GetValidNumber("Input time(hours)");
            int timeMinutes = UtilityMethods.GetValidNumber("Input time(minutes)");
            int timeSeconds = UtilityMethods.GetValidNumber("Input time(seconds)");

            TimeSpan time = new TimeSpan(timeHour, timeMinutes, timeSeconds);

            double speedMeters = distance / time.TotalSeconds;
            double speedKM = ( distance / 1000 ) / time.TotalHours;
            double speedMiles = ( distance * 0.00062137D ) / time.TotalHours;

            Console.WriteLine("Your speed in meters/sec is: {0}", speedMeters);
            Console.WriteLine("Your speed in km/h is: {0}", speedKM);
            Console.WriteLine("Your speed in miles/h is: {0}", speedMiles);

        }
    }
}
