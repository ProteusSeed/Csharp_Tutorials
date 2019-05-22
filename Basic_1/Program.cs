using System;

namespace Basic_1
{
    /*
     1. Write a C# Sharp program to print Hello and your name in a separate line. 
        Expected Output : 
        Hello: Alexandra Abramov
    */
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
                        Basic_1();
                        break;

                    default:
                        Console.WriteLine("No such Excercise exists.");

                        break;
                }


                while (entry != "")
                {
                    Console.WriteLine("\nPress [ENTER] to continue, \"x\" to end");
                    entry = Console.ReadLine();

                    if (entry == "x")
                    {
                        run = false;
                        break;
                    }
                }

                exercise = 0;
            }
            
        }

        static void Basic_1()
        {
            Console.WriteLine("Hello \nStan Caceres");

        }

    }
}
