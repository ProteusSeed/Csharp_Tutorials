using System;
using String_Exercises;

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
                continueLoop = Exercises.UtilityMethods.getValidProgramNumber(out number);

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

                    case 7:
                        Exercise_07.Execute();
                        break;

                    case 8:
                        Exercise_08.Execute();
                        break;

                    case 9:
                        Exercise_09.Execute();
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

                    case 18:
                        Exercise_18.Execute();
                        break;

                    case 19:
                        Exercise_19.Execute();
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

                    case 23:
                        Exercise_23.Execute();
                        break;

                    case 24:
                        Exercise_24.Execute();
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

                    case 28:
                        Exercise_28.Execute();
                        break;

                    case 29:
                        Exercise_29.Execute();
                        break;

                    case 30:
                        Exercise_30.Execute();
                        break;

                    case 31:
                        Exercise_31.Execute();
                        break;

                    case 32:
                        Exercise_32.Execute();
                        break;

                    default:
                        Console.WriteLine("Program does not exist!");
                        break;
                }

            }
        }
    }
}
