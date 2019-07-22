using System;
using Exercises;

namespace Basics
{

    class Program
    {
        static void Main(string[] args)
        {
            Boolean run = true;
            int exercise;
            string entry;

            while (run == true)
            {
                Console.WriteLine("Which Excercise shall we run?: ");
                entry = Console.ReadLine();

                if (entry == "x") { break; };

                int.TryParse(entry, out exercise);

                //do some validation here in case not an int

                switch (exercise)
                {
                    case 1:
                        Basic_01.Execute();
                        break;

                    case 2:
                        Basic_02.Execute();
                        break;

                    case 3:
                        Basic_03.Execute();
                        break;
                    case 4:
                        Basic_04.Execute();
                        break;
                    case 5:
                        Basic_05.Execute();
                        break;
                    case 6:
                        Basic_06.Execute();
                        break;
                    case 7:
                        Basic_07.Execute();
                        break;
                    case 8:
                        Basic_08.Execute();
                        break;
                    case 9:
                        Basic_09.Execute();
                        break;
                    case 10:
                        Basic_10.Execute();
                        break;
                    case 11:
                        Basic_11.Execute();
                        break;
                    case 12:
                        Basic_12.Execute();
                        break;
                    case 13:
                        Basic_13.Execute();
                        break;
                    case 14:
                        Basic_14.Execute();
                        break;
                    case 15:
                        Basic_15.Execute();
                        break;
                    case 16:
                        Basic_16.Execute();
                        break;
                    case 17:
                        Basic_17.Execute();
                        break;
                    case 18:
                        Basic_18.Execute();
                        break;
                    case 19:
                        Basic_19.Execute();
                        break;
                    case 20:
                        Basic_20.Execute();
                        break;
                    case 21:
                        Basic_21.Execute();
                        break;
                    case 22:
                        Basic_22.Execute();
                        break;
                    case 23:
                        Basic_23.Execute();
                        break;
                    case 24:
                        Basic_24.Execute();
                        break;

                    case 28:
                        Basic_28.Execute();
                        break;
                    case 30:
                        Basic_30.Execute();
                        break;
                    case 31:
                        Basic_31.Execute();
                        break;
                    case 32:
                        Basic_32.Execute();
                        break;
                    case 33:
                        Basic_33.Execute();
                        break;
                    case 34:
                        Basic_34.Execute();
                        break;
                    case 35:
                        Basic_35.Execute();
                        break;
                    case 36:
                        Basic_36.Execute();
                        break;
                    case 37:
                        Basic_37.Execute();
                        break;
                    case 38:
                        Basic_38.Execute();
                        break;
                    case 39:
                        Basic_39.Execute();
                        break;
                    case 40:
                        Basic_40.Execute();
                        break;
                    case 41:
                        Basic_41.Execute();
                        break;
                    case 42:
                        Basic_42.Execute();
                        break;
                    case 43:
                        Basic_43.Execute();
                        break;
                    case 44:
                        Basic_44.Execute();
                        break;
                    case 45:
                        Basic_45.Execute();
                        break;
                    default:
                        Console.WriteLine("No such Excercise exists.");
                        break;
                }

                run = endOrContinue();

                exercise = 0;
            }
            
        }

        static Boolean endOrContinue()
        {
            string entry = null;
            while (entry != "")
            {
                Console.WriteLine("\nPress [ENTER] to continue, \"x\" to end");
                entry = Console.ReadLine();

                if (entry == "x" | entry == "X")
                {
                   return false;
                }
            }
            return true;
        }

    }
}
