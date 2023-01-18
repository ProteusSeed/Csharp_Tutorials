using System;
using Exercises;

namespace Recursion
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

                    case 2:
                        Exercise_02.Execute();
                        break;

                    case 3:
                        Exercise_03.Execute();
                        break;

                    case 4:
                        Exercise_04.Execute();
                        break;

                    case 5:
                        Exercise_05.Execute();
                        break;

                    case 6:
                        Exercise_06.Execute();
                        break;

                    default:
                        Console.WriteLine("Program does not exist!");
                        break;
                }

            }
        }
    }
}
