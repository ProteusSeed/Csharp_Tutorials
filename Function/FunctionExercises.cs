using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Function_Exercises
{
    public static class Exercise_01
    {
        /*
         * 1. Write a program in C# Sharp to create a user define function. 
            Expected Output :
            Welcome Friends!
            Have a nice day!
         */

        public static void Execute()
        {
            welcome();
        }

        private static void welcome()
        {
            Console.WriteLine("Welcome Friends! \nHave a nice day!");
        }
    }

    public static class Exercise_02
    {
        /*
         * 2. Write a program in C# Sharp to create a user define function with parameters. 
            Test Data:
            Please input a name: John
            Expected Output:
            Welcome friend John !
            Have a nice day!
        */

        public static void Execute()
        {
            welcome(UtilityMethods.GetValidString("Enter name"));
        }

        private static void welcome(string name)
        {
            Console.WriteLine($"Welcome friend {name}!\nHave a nice day!");
        }
    }


}
