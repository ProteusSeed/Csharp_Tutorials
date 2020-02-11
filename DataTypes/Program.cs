using System;
using Exercises;
using DataTypes_Exercises;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;
            int number = 0;

            while (continueLoop == true)
            {
                continueLoop = UtilityMethods.getValidProgramNumber(out number);

                switch (number)
                {
                    case 1:
                        Exercise_1.Execute();
                        break;

                    case 2:
                        Exercise_2.Execute();
                        break;

                    case 0:
                        //exit
                        continueLoop = false;
                        break;

                    default:
                        Console.WriteLine("Program does not exist!");
                        break;
                }

            }
        }
    }
}
