using System;
using Basic_Algorithm_Exercises;

namespace Basic_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;
            int number = 0;

            while (continueLoop == true)
            {
                continueLoop = getValidProgramNumber(out number);

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

        static bool getValidProgramNumber( out int Number)
        {
            bool valid = false;
            string entry = "";
            int entryNum = 0;
            string errMsg = "";

            while (valid == false & entry != "x")
            {
                Console.WriteLine("{0} Enter program number to run or X to exit: ", errMsg);

                entry = Console.ReadLine().ToLower();

                valid = int.TryParse(entry, out entryNum) | entry == "x";

                errMsg = "Value must be a valid number or X to exit!";
            }

            Number = entryNum;
            return entry ==  "x" ? false : true;
        }
    }
}
