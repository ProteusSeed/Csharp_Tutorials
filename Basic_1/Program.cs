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
                        BasicExercises.Basic_1();
                        break;

                    case 2:
                        BasicExercises.Basic_2();
                        break;

                    case 3:
                        BasicExercises.Basic_3();
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
