using System;
using System.Collections.Generic;
using System.Text;
using Exercises;
using System.Linq;

namespace Conditional_Statement
{
    //https://www.w3resource.com/csharp-exercises/conditional-statement/index.php
    public static class Exercise_1
    {
        /*
            1. Write a C# Sharp program to accept two integers and check whether they are equal or not. 
            Test Data :
            Input 1st number: 5 
            Input 2nd number: 5 
            Expected Output: 5 and 5 are equal 
        */

        public static void Execute()
        {
            int firstNumber = UtilityMethods.GetValidNumber();
            int secondNumber = UtilityMethods.GetValidNumber();

            string Condition = firstNumber == secondNumber ? " " : " not ";

            Console.WriteLine($"{firstNumber} and {secondNumber} are{Condition}equal.");
        }
    }

    public static class Exercise_2
    {
        /*2. Write a C# Sharp program to check whether a given number is even or odd. 
        Test Data : 15
        Expected Output : 
        15 is an odd integer
        */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidNumber();

            string result = number % 2 > 0 ? "odd" : "even";

            Console.WriteLine($"{number} is {result}");

        }
    }

    public static class Exercise_3
    {
        /*
         3. Write a C# Sharp program to check whether a given number is positive or negative. 
            Test Data : 14 
            Expected Output :
            14 is a positive number
         */

        public static void Execute()
        {
            int number = UtilityMethods.GetValidNumber();

            string sign = number < 0 ? "negative" : "position";

            Console.WriteLine($"{number} is a {sign} number.");

        }
    }

    public static class Exercise_4
    {
        /*
         4. Write a C# Sharp program to find whether a given year is a leap year or not. 
            Test Data : 2016 
            Expected Output :
            2016 is a leap year.
         */

        public static void Execute()
        {
            string message = "";
            int year = UtilityMethods.GetValidNumber();

            DateTime givenDate;// = Convert.ToDateTime( $"02/29/{year}" );

            bool isYear = DateTime.TryParse($"02/29/{year}", out givenDate);

            if (isYear)
            {
                string isLeap = DateTime.IsLeapYear(year) ? " " : " not ";

                message = $"{year} is{isLeap}a leap year";
            }
            else
            {
                message = $"{year} is not a year!";
            }

            Console.WriteLine(message);
        }
    }

    public static class Exercise_5
    {
        /*5. Write a C# Sharp program to read the age of a candidate 
        and determine whether it is eligible for casting his/her own vote. 
        Test Data : 21 
        Expected Output:
        Congratulation! You are eligible for casting your vote.
        */

        public static void Execute()
        {
            const int ageThreshold = 21;

            int age = UtilityMethods.GetValidAbsoluteNumber("Enter Candidate Age");

            string message = age >= ageThreshold ? "Congratulations! You are eligible for casting your vote."
                                                    : "You are not eligible for casting your vote.";

            Console.WriteLine(message);
        }

    }

    public static class Exercise_6
    {
        /*6. Write a C# Sharp program to read the value of an integer m 
        and display the value of n is 1 when m is larger than 0
        , 0 when m is 0 
        and -1 when m is less than 0. 

        Test Data : -5 
        Expected Output:
        The value of n = -1
        */

        public static void Execute()
        {
            int m = 0;
            int n = 0;

            m = UtilityMethods.GetValidNumber();
            n = m > 0 ? 1 : (m < 0 ? -1 : 0);

            Console.WriteLine("The value of n = {0}", n);
        }
    }

    public static class Exercise_7
    {
        /*
         7. Write a C# Sharp program to accept the height of a person in centimeter 
            and categorize the person according to their height. 
            Test Data : 135 
            Expected Output: The person is Dwarf.
        */

        private class heightChart
        {
            //heightChart( int minHeight, int maxHeight, string category )
            //{
            //    MinHeight = minHeight;
            //    MaxHeight = maxHeight;
            //    Category = category;
            //}

            public int MinHeight { get; set; }
            public int MaxHeight { get; set; }
            public string Category { get; set; }
        }

        public static void Execute()
        {
            List<heightChart> heights = new List<heightChart>() {
                                                                new heightChart { MinHeight = 0, MaxHeight = 146, Category = "dwarf" },
                                                                new heightChart { MinHeight = 147, MaxHeight = 160, Category = "short" },
                                                                new heightChart { MinHeight = 161, MaxHeight = 170, Category = "average" },
                                                                new heightChart { MinHeight = 171, MaxHeight = 1000, Category = "tall" },
                                                                };

            int height = UtilityMethods.GetValidAbsoluteNumber("Enter height in centimeters");

            heightChart heightRange = heights.Find(e => e.MinHeight <= height & e.MaxHeight >= height);

            Console.WriteLine("The person is {0}", heightRange.Category);

        }
    }

    public static class Exercise_8
    {
        /*8. Write a C# Sharp program to find the largest of three numbers. 
            Test Data :
            Input the 1st number :25 
            Input the 2nd number :63 
            Input the 3rd number :10 
            Expected Output :
            The 2nd Number is the greatest among three 
        */

        private class Numbers
        {
            public int number { get; set; }
            public string name { get; set; }
        }

        public static void Execute()
        {
            int number1 = UtilityMethods.GetValidNumber("Enter 1st number");
            int number2 = UtilityMethods.GetValidNumber("Enter 2nd number");
            int number3 = UtilityMethods.GetValidNumber("Enter 3rd number");

            List<Numbers> numbers = new List<Numbers> {
                                                         new Numbers() { number = number1, name = "1st number" }
                                                        ,new Numbers{ number = number2, name = "2nd number" }
                                                        ,new Numbers{ number = number3, name = "3rd number" }
                                                      };

            List<Numbers> largest = numbers.OrderBy(n => n.number).ToList();

            string largestName = largest.Last().name;

            Console.WriteLine(largestName);
        }
    }

    public static class Exercise_9
    {
        /*9. Write a C# Sharp program to accept a coordinate point in an XY coordinate system
            and determine in which quadrant the coordinate point lies. 
            Test Data :
            Input the value for X coordinate :7 
            Input the value for Y coordinate :9 
            Expected Output :
            The coordinate point (7,9) lies in the First quadrant.
        */

        private static string getQuadrant(int x, int y)
        {
            if (x > 0 & y > 0) return "1st";

            if (x < 0 & y < 0) return "3rd";

            if (x < 0 & y > 0) return "4th";

            if (x > 0 & y < 0) return "2nd";

            return "Origin";
        }

        public static void Execute()
        {
            int x = UtilityMethods.GetValidNumber("Input the value for X coordinate");
            int y = UtilityMethods.GetValidNumber("Input the value for y coordinate");

            string quadrant = getQuadrant(x, y);

            Console.WriteLine($"The coordinate point ({x},{y}) lies in the {quadrant} quadrant.");

        }
    }

    public static class Exercise_10
    {
        /*10. Write a C# Sharp program to find the eligibility of admission for a professional course 
        based on the following criteria: 
        Marks in Maths >=65
        Marks in Phy >=55
        Marks in Chem>=50
        Total in all three subject >=180
        or
        Total in Math and Subjects >=140 
        Test Data : 
        Input the marks obtained in Physics :65 
        Input the marks obtained in Chemistry :51 
        Input the marks obtained in Mathematics :72
        Expected Output :
        The candidate is eligible for admission.
        */

        const int eligibleGrade = 140;

        public static void Execute()
        {
            int Physics = UtilityMethods.GetValidNumber(0, 100, "Input the marks obtained in Physics");
            int Chemistry = UtilityMethods.GetValidNumber(0, 100, "Input the marks obtained in Chemistry");
            int Mathematics = UtilityMethods.GetValidNumber(0, 100, "Input the marks obtained in Mathematics");

            int total = Physics + Chemistry + Mathematics;

            string eligibility = total >= eligibleGrade ? "eligible" : "ineligible";

            Console.WriteLine("The candidate is {0} for admission.", eligibility);

        }
    }

    public static class Exercise_11
    {
        /*
          11. Write a C# Sharp program to calculate root of Quadratic Equation. 
            Test Data : 
            Input the value of a : 1 
            Input the value of b : 5 
            Input the value of c : 7 
            Expected Output :
            Root are imaginary; 
            No Solution.
         */

        public static void Execute()
        {
            Console.WriteLine("I'm skipping this one.");
        }
    }

    public static class Exercise_12
    {
        /*
         * 12. Write a C# Sharp program to read roll no, name and marks of three subjects 
            and calculate the total, percentage, and division. 
            Test Data : 
            Input the Roll Number of the student :784 
            Input the Name of the Student :James 
            Input the marks of Physics, Chemistry and Computer Application : 70 80 90
            Expected Output :
            Roll No : 784 
            Name of Student : James 
            Marks in Physics : 70 
            Marks in Chemistry : 80 
            Marks in Computer Application : 90 
            Total Marks = 240 
            Percentage = 80.00 
            Division = First
        */

        public static void Execute()
        {
            int roll = UtilityMethods.GetValidAbsoluteNumber("Input the Roll Number of the student");
            string name = UtilityMethods.GetValidString("Input the Name of the Student");
            int physics = UtilityMethods.GetValidAbsoluteNumber("Input the marks in Physics");
            int chemistry = UtilityMethods.GetValidAbsoluteNumber("Input the marks in Chemistry");
            int CompApp = UtilityMethods.GetValidAbsoluteNumber("Input the marks in Computer Applications");

            int Total = physics + chemistry + CompApp;
            decimal Percentage = Total / 300.00m * 100.00m;

            string Division = "";

            Console.WriteLine($"Roll No: {roll}");
            Console.WriteLine($"Name of Student: {name}");
            Console.WriteLine($"Marks in Physics: {physics}");
            Console.WriteLine($"Marks in Chemistry: {chemistry}");
            Console.WriteLine($"Marks in Computer Application : {CompApp}");
            Console.WriteLine($"Total Marks = {Total}");
            Console.WriteLine($"Percentage = {Percentage}");

            if (Percentage >= 60m) Division = "First";
            if (Percentage >= 48m & Percentage < 60m) Division = "Second";
            if (Percentage >= 36m & Percentage < 48m) Division = "Pass";
            if (Percentage < 36m) Division = "Fail";

            Console.WriteLine($"Division = {Division}");
        }
    }

    public static class Exercise_13
    {
        /*
         13. Write a C# Sharp program to read temperature in centigrade 
            and display a suitable message according to temperature state below: 
            Temp < 0 then Freezing weather 
            Temp 0-10 then Very Cold weather
            Temp 10-20 then Cold weather
            Temp 20-30 then Normal in Temp 
            Temp 30-40 then Its Hot 
            Temp >=40 then Its Very Hot 
            Test Data : 
            42 
            Expected Output: Its very hot.
         */

        public static void Execute()
        {
            var tempRanges = new[]{
                new{ low=0, high=10, message="Very Cold Weather"}
                ,new { low = 0, high = 10, message = "Very Cold Weather" }
                ,new { low = 11, high = 20, message = "Cold Weather" }
                ,new { low = 21, high = 30, message = "Normal" }
                ,new { low = 31, high = 40, message = "Its Hot" }
                ,new { low = 41, high = 100, message = "Its Very Hot" }
                };

            int temperature = UtilityMethods.GetValidNumber("Enter Temperature");

            string message = tempRanges.Where(e => e.low <= temperature & e.high >= temperature).First().message;

            Console.WriteLine(message);
        }
    }

    public static class Exercise_14
    {
        /*14. Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene. 
            Test Data: 50 50 60 
            Expected Output: This is an isosceles triangle.
        */
        public static void Execute()
        {
            decimal angle1 = UtilityMethods.GetValidDecimal("Enter first angle");
            decimal angle2 = UtilityMethods.GetValidDecimal("Enter second angle");
            decimal angle3 = UtilityMethods.GetValidDecimal("Enter third angle");

            string triangle = "";

            if (angle1 == angle2 & angle2 == angle3 & angle1 == 60) triangle = "Equalateral";

            if ((angle1 == angle2 & angle3 != angle2) | (angle2 == angle3 & angle1 != angle2) | (angle1 == angle3 & angle1 != angle2)) triangle = "Isosceles";

            if (angle1 != angle2 & angle2 != angle3 & angle1 != angle3) triangle = "Scalene";

            if (triangle == "") triangle = "invalid";

            Console.WriteLine($"This is an {triangle} triangle.");

        }
    }

    public static class Exercise_15
    {
        /*15. Write a C# Sharp program to check whether a triangle can be formed by the given value for the angles. 
            Test Data: 40 55 65
            Expected Output: The triangle is not valid.
        */
        public static void Execute()
        {
            decimal angle1 = UtilityMethods.GetValidDecimal("Enter 1st angle");
            decimal angle2 = UtilityMethods.GetValidDecimal("Enter 2nd angle");
            decimal angle3 = UtilityMethods.GetValidDecimal("Enter 3rd angle");

            string validity = angle1 + angle2 + angle3 != 180m ? "not" : "";

            Console.WriteLine($"The triangle is {validity} valid.");
        }
    }

    public static class Exercise_16
    {
        /*16. Write a C# Sharp program to check whether an alphabet is a vowel or consonant.
            Test Data: k
            Expected Output: The alphabet is a consonant.
        */

        public static void Execute()
        {
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            char letter = UtilityMethods.GetValidChar("Enter letter");

            bool isVowel = vowels.Contains(letter);

            string letterType = isVowel == true ? "vowel" : "consonent";

            Console.WriteLine($"The letter is a {letterType}");
        }
    }

    public static class Exercise_17
    {
        /*
         * 17. Write a C# Sharp program to calculate profit and loss on a transaction. 
            Test Data: 500 700
            Expected Output: You can book your profit amount : 200
         */

        public static void Execute()
        {
            decimal cost = UtilityMethods.GetValidDecimal("Enter item cost");
            decimal salePrice = UtilityMethods.GetValidDecimal("Enter sale price");

            decimal profit = salePrice - cost;

            string message = profit > 0 ? $"You can book your profit amount {profit}" :
                    profit < 0 ? $"You lost { Math.Abs(profit)}" : "You broke even";

            Console.WriteLine(message);
        }
    }

    public static class Exercise_18
    {
        /*18. Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. 
         The customer id., name and unit consumed by the user should be taken from the keyboard 
         and display the total amount to pay to the customer. The charge are as follow : 
            Unit
            Charge/unit
            upto 199 
                @1.20
            200 and above but less than 400 
                @1.50
            400 and above but less than 600
                @1.80
            600 and above 
                @2.00
            If bill exceeds Rs. 400 then a surcharge of 15% will be charged and the minimum bill should be of Rs. 100/-
            Test Data : 
                1001
                James 
                800 
                Expected Output :
                Customer IDNO :1001 
                Customer Name :James 
                unit Consumed :800 
                Amount Charges @Rs. 2.00 per unit : 1600.00 
                Surchage Amount : 240.00 
                Net Amount Paid By the Customer : 1840.00
        */

        public static void Execute()
        {
            int custID = UtilityMethods.GetValidAbsoluteNumber("Enter customer ID#");
            string custName = UtilityMethods.GetValidString("Enter customer name");
            int units = UtilityMethods.GetValidAbsoluteNumber("Enter number of units consumed");

            decimal rate = 0.00m;

            if (units <= 199) rate = 1.20m;
            if (units >= 200 & units <= 399) rate = 1.50m;
            if (units >= 400 & units <= 599) rate = 1.80m;
            if (units >= 600) rate = 2.00m;

            decimal charges = units * rate;

            decimal surCharge = charges > 400m ? charges * .15m : 0;

            decimal net = charges + surCharge;
            net = net < 100 ? 100 : net;

            Console.WriteLine($"Customer IDNO: {custID}");
            Console.WriteLine($"Customer Name: {custName}");
            Console.WriteLine($"Unit Consumed: {units}");
            Console.WriteLine($"Amount Charges @Rs. {rate} per unit: {charges}");
            Console.WriteLine($"Surchage Amount: {surCharge}");
            Console.WriteLine($"Net Amount Paid By the Customer: {net}");

        }
    }

    public static class Exercise_19
    {
        /*
         * 19. Write a program in C# Sharp to accept a grade and declare the equivalent description : 
            Grade
            Description
            E
            Excellent
            V
            Very Good 
            G
            Good
            A
            Average
            F
            Fail
            Test Data : 
                Input the grade :a
                Expected Output :
                You have chosen : Average
         */

        public static void Execute()
        {
            Dictionary<char, string> gradeList = new Dictionary<char, string>(){
                { 'E', "Excellent" }
                ,{ 'V', "Very Good" }
                ,{ 'G', "Good" }
                ,{ 'A', "Average" }
                ,{ 'F', "Fail" }
            };

            char grade = UtilityMethods.GetValidChar("Input the grade");
            grade = char.ToUpper(grade);

            var search = gradeList.Where(e => e.Key.Equals(grade));

            string description = search.Count() > 0 ? search.First().Value : "invalid grade";

            Console.WriteLine("You have chosen {0}", description);
        }
    }

    public static class Exercise_20
    {
        /*
         * 20. Write a program in C# Sharp to read any day number in integer and display day name in the word. 
            Test Data: 4
            Expected Output: Thursday
         */

        public static void Execute()
        {
            int DayOfWeek = UtilityMethods.GetValidNumber(0, 6, "Enter number of day of the week.");

            //Get enum value by index
            DayOfWeek dow = (DayOfWeek)DayOfWeek;

            Console.WriteLine(dow);
        }
    }

    public static class Exercise_21
    {
        /*21. Write a program in C# Sharp to read any digit, display in the word. 
            Test Data : 
            4
            Expected Output :
            Four
        */

        public static Dictionary<int, string> digits = new Dictionary<int, string>(){
            { 0, "Zero" }
            ,{ 1, "One" }
            ,{ 2, "Two" }
            ,{ 3, "Three" }
            ,{ 4, "Four" }
            ,{ 5, "Five" }
            ,{ 6, "Six" }
            ,{ 7, "Seven" }
            ,{ 8, "Eight" }
            ,{ 9, "Nine" }
        };

        public static void Execute()
        {
            int digit = UtilityMethods.GetValidNumber(1, 9, "Enter digit from 1 to 9");

            string digitName = "";

            digits.TryGetValue(digit, out digitName);

            Console.WriteLine(digitName);
        }
    }

    public static class Exercise_22
    {
        /*
          22. Write a program in C# Sharp to read any Month Number in integer and display Month name in the word. 
            Test Data : 
            4
            Expected Output:
            April
        */
        public static void Execute()
        {
            int month = UtilityMethods.GetValidNumber(1, 12, "Enter number of month");

            string monthName = new DateTime(DateTime.Now.Year, month, 1).ToString("MMMM", System.Globalization.CultureInfo.CurrentCulture);

            Console.WriteLine(monthName);

        }
    }

    public static class Exercise_23
    {
        /*
         * 23. Write a program in C# Sharp to read any Month Number in integer 
            and display the number of days for this month. 
            Test Data: 7 
            Expected Output: Month have 31 days
         */

        public static void Execute()
        {
            int monthNumber = UtilityMethods.GetValidNumber(1, 12, "Enter month number");

            int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, monthNumber);

            string monthName = new DateTime(DateTime.Now.Year, monthNumber, 1).ToString("MMMM", System.Globalization.CultureInfo.CurrentCulture);

            Console.WriteLine("Month {0} ({1}) has {2} days in it.", monthNumber, monthName, daysInMonth);
        }
    }

    public static class Exercise_24
    {
        /*
         * 24. Write a program in C# Sharp which is a Menu-Driven 
            Program to compute the area of the various geometrical shape. 
            Test Data : 
                Input your choice: 1 
                Input radius of the circle: 5
                Expected Output:
                The area is: 78.500000 
        */

        public static decimal Circle(decimal radius)
        {
            //pie * r squared

            decimal area = (decimal)(Math.PI * (Math.Pow((double)radius, 2)));

            return area;
        }

        public static decimal Quadrilateral(decimal height, decimal width)
        {
            decimal area = height * width;

            return area;
        }

        public static decimal Triangle(decimal side1, decimal side2, decimal side3)
        {
            /*
             you first have to find the half-perimeter (s) of the triangle
             ,which you do by adding all three sides and dividing the result by two. 
             For a triangle with sides a, b and c, 
             the half-perimeter s = 1/2(a + b + c). 
             Once you know s, you calculate area using this formula:

             Area = square root [s (s - a) (s - b) (s - c)]
            */

            decimal p = (side1 + side2 + side3) / 2;

            decimal area = p * (p - side1) * (p - side2) * (p - side3);
            area = (decimal)Math.Sqrt((double)area);

            return area;
        }


        public static void Execute()
        {
            string typeOfShape = UtilityMethods.GetValidString("Enter type of shape: Square, Rectangle, Triangle, or Circle").ToLower();
            decimal height, width;
            decimal area = 0m;

            switch (typeOfShape)
            {
                case "square":
                    height = UtilityMethods.GetValidDecimal("Enter measurement of one side of square");
                    //width = UtilityMethods.GetValidDecimal("Enter width of square");

                    area = Quadrilateral(height, height);
                    break;

                case "rectangle":
                    height = UtilityMethods.GetValidDecimal("Enter height of rectangle");
                    width = UtilityMethods.GetValidDecimal("Enter width of rectangle");

                    area = Quadrilateral(height, width);
                    break;

                case "triangle":
                    decimal side1 = UtilityMethods.GetValidDecimal("Enter length of side 1");
                    decimal side2 = UtilityMethods.GetValidDecimal("Enter length of side 2");
                    decimal side3 = UtilityMethods.GetValidDecimal("Enter length of side 3");

                    area = Triangle(side1, side2, side3);

                    break;

                case "circle":
                    decimal radius = UtilityMethods.GetValidDecimal("Enter radius of circle");

                    area = Circle(radius);
                    break;

                default:
                    break;

            }

            Console.WriteLine($"The area of this {typeOfShape} is {area}");
        }
    }

    public static class Exercise_25
    {
        /*
            Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation. 

            Test Date and Expected Output
            Enter the first Integer :10
            Enter the second Integer :2

            Here are the options :
            1-Addition.
            2-Substraction.
            3-Multiplication.
            4-Division.
            5-Exit.

            Input your choice :3
            The Multiplication of 10 and 2 is: 20
        */

        static Dictionary<int, string> calcOptions = new Dictionary<int, string>() 
            { 
                 { 1, "Addition" }
                ,{ 2, "Substraction" }
                ,{ 3, "Multiplication" }
                ,{ 4, "Division" }
                ,{ 5, "Exit" }
            };

        public static void Execute()
        {
           int option = 0;

           Console.WriteLine("************Calculator {0}***********", DateTime.Today);

            while ( option != 5 )
            {
                Console.WriteLine("Options:");
                printOptions(calcOptions);

                option = UtilityMethods.GetValidNumber(1, 5, "Enter option:");

                if ( option < 5 )
                {
                    int firstInt = UtilityMethods.GetValidNumber("Enter 1st Integer:");
                    int secondInt = UtilityMethods.GetValidNumber("Enter 2nd Integer:");

                    decimal result = compute(firstInt, secondInt, option);
                    calcOptions.TryGetValue(option, out string chosenOption);

                    Console.WriteLine($"The {chosenOption} of {firstInt} and {secondInt} is: {result}\n");
                }
            }
        }

        private static void printOptions(Dictionary<int, string> calcOptions)
        {
            int length = calcOptions.Count();

            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine($"{calcOptions.FirstOrDefault( k => k.Key == i).Key} - {calcOptions.FirstOrDefault(k => k.Key == i).Value}");
            }

            Console.WriteLine();

        }

        private static decimal compute(int int1, int int2, int operation)
        {
            decimal result = 0.00m;

            switch (operation)
            {
                case 1:
                    result = int1 + int2;
                    break;
                case 2:
                    result = int1 - int2;
                    break;
                case 3:
                    result = int1 * int2;
                    break;
                case 4:
                    result = int1 / int2;
                    break;
                case 5:
                    result = 0;
                    break;
                default:
                    break;
            }

            return result;
        }

    }

} 