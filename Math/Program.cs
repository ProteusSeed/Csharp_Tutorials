using System;
using Exercises;
using Math_Exercises;

namespace Math
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
                    case 2:
                        Exercise_02.Execute();
                        break;

                    case 3:
                        Exercise_03.Execute();
                        break;

                    default:
                        Console.WriteLine("Program does not exist!");
                        break;
                }

            }
        }
    }
}

