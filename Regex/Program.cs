using System;
using Exercises;
using Regex_Exercises;

namespace Regular_Exp
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

                    case 4:
                        Exercise_04.Execute();
                        break;

                    case 6:
                        Exercise_06.Execute();
                        break;

                    case 7:
                        Exercise_07.Execute();
                        break;

                    case 8:
                        Exercise_08.Execute();
                        break;

                    case 9:
                        Exercise_09.Execute();
                        break;

                    default:
                        Console.WriteLine("Program does not exist!");
                        break;
                }

            }
        }
    }
}
