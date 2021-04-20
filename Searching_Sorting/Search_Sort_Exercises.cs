using System;
using System.Collections.Generic;
using System.Text;

namespace Searching_Sorting
{
    public static class Exercise_1
    {
        /*
         * 1. Write a C# Sharp program to sort a list of elements using Shell sort. 

         */

        public static void Execute()
        {
           
            List<int> theList = new List<int> { 5, 10, 25, 36, 18, 11, 105, 34,  31, 111, 14, 3, 44, 88, 29, 30 }; //15 elements
            int interval = theList.Count / 2;
            int listRange = theList.Count - 1;
            List<int> tempList = new List<int>();
            int firstValue = 0, secondValue = 0;
            int swapValue = 0;

            //Iterate through the intervals
            for ( int i = interval; i > 0; i = i / 2 )
            {
                Console.WriteLine($"Interval: {i}");

                //iterate through the values at each interval comprising the sublists
                for (int n = 0; n <= i; n++)
                {
                    //Console.WriteLine($"{theList[n]}");

                    //Iterate through the sublist
                    int position = n;
                    while( position <= listRange - i)
                    {
                        //Console.Write($"{theList[position]} ");

                        int index = position;
                        //iterate backwards to place value in right sort position
                        /*FIX THIS*/
                        while (theList[index] > theList[index + i] )
                        {
                            swapValue = theList[index];
                            theList[index] = theList[index + i];
                            theList[index + i] = swapValue;
                            index -= i;
                            if (index < position) break;
                        }

                        position += i;
                    }
                    Console.WriteLine();

                }
                
            }

            printList(theList);
        }

        private static void printList( List<int> theList)
        {
            foreach( var item in theList )
            {
                Console.Write($"{item} ");
            }
        }
    }
}