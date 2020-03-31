using System;
using System.Collections.Generic;
using System.Text;
using Exercises;
using System.Linq;

namespace Conditional_Statement
{
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

            if (angle1 == angle2 & angle2 == angle3) triangle = "Equalateral";

            if ((angle1 == angle2 & angle3 != angle2) | (angle2 == angle3 & angle1 != angle2) | (angle1 == angle3 & angle1 != angle2) ) triangle = "Isosceles";

            if (angle1 != angle2 & angle2 != angle3 & angle1 != angle3) triangle = "Scalene";

            Console.WriteLine($"This is an {triangle} triangle.");

        }
    }
}