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

                        case 11:
                            Exercise_11.Execute();
                            break;

                        case 12:
                                Exercise_12.Execute();
                                break;

                        case 13:
                            Exercise_13.Execute();
                            break;

                        case 14:
                            Exercise_14.Execute();
                            break;

                        case 15:
                            Exercise_15.Execute();
                            break;

                        case 16:
                            Exercise_16.Execute();
                            break;

                        case 17:
                            Exercise_17.Execute();
                            break;

                        case 20:
                            Exercise_20.Execute();
                            break;

                        case 21:
                            Exercise_21.Execute();
                            break;

                        case 22:
                            Exercise_22.Execute();
                            break;

                        case 25:
                            Exercise_25.Execute();
                            break;

                        case 26:
                            Exercise_26.Execute();
                            break;

                        case 27:
                            Exercise_27.Execute();
                            break;

                        case 31:
                            Exercise_31.Execute();
                            break;
                    default:
                            Console.WriteLine("Program does not exist!");
                            break;
                    }

                }
            }

    }
}
