﻿using System;
using Exercises;
using Function_Exercises;

namespace string_exercises_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;
            int number = 0;

            while (continueLoop == true)
            {
                continueLoop = UtilityMethods.getValidProgramNumber(out number);

                switch (number)
                {
                    case 1:
                        Exercise_01.Execute();
                        break;

                    default:
                        Console.WriteLine("Program does not exist!");
                        break;
                }

            }
        }
    }
}