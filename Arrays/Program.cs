using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;
            int number = 0;

            while (continueLoop == true)
            {
                continueLoop = Exercises.UtilityMethods.getValidProgramNumber(out number);

                switch (number)
                {
                    case 1:
                        Exercise_1.Execute();
                        break;

                    case 2:
                        Exercise_2.Execute();
                        break;

                    case 3:
                        Exercise_3.Execute();
                        break;

                    case 4:
                        Exercise_4.Execute();
                        break;

                    case 5:
                        Exercise_5.Execute();
                        break;

                    case 6:
                        Exercise_6.Execute();
                        break;

                    default:
                        Console.WriteLine("Program does not exist!");
                        break;
                }

            }
        }
    }
}
