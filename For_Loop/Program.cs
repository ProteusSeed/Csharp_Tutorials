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
                    default:
                            Console.WriteLine("Program does not exist!");
                            break;
                    }

                }
            }

    }
}
