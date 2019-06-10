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

                if (entry == "x")
                {
                   return false;
                }
            }
            return true;
        }

    }
}
