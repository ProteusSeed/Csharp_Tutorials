using System;
using Exercises;

namespace Basic_1
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
