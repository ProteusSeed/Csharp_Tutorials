using System;
using System.Linq;
using Exercises;

namespace For_Loop
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

                        case 7:
                            Exercise_7.Execute();
                            break;

                        case 8:
                            Exercise_8.Execute();
                            break;

                        case 9:
                            Exercise_9.Execute();
                            break;

                        case 10:
                            Exercise_10.Execute();
                            break;
                    default:
                            Console.WriteLine("Program does not exist!");
                            break;
                    }

                }
            }

    }
}
