using System;
using System.Collections.Generic;
using System.Text;
using Exercises;
using System.Linq;

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

    public static class Exercise_2
    {
        /*
          2. Write a C# Sharp program to sort a list of elements using Bogosort sort. 
            In computer science, bogosort is a particularly ineffective sorting algorithm based on the generating and test paradigm. 
            The algorithm successively generates permutations of its input until it finds one that is sorted. 
            It is not useful for sorting, but may be used for educational purposes, to contrast it with other more realistic algorithms.
         */

        public static List<int> randos = new List<int>();

        public static void Execute()
        {
            List<int> theList = UtilityMethods.getValidNumbersList();//new List<int>();
            int listSize = theList.Count;
            List<int> testList = new List<int>(theList);

            while (isSorted(testList) == false)
            {//keep generating lists until one matches.

                for (int i = 0; i < listSize; i++)
                {//add a random number from the list to the new list, until all #s are added, without repeating any.
                    testList[i] = theList[generateRando(listSize)];
                }

                randos.Clear(); //Since the class will still be instantiated when this method re-runs this member list needs to be cleareed.

            }

            //Print sorted list
            foreach (var item in testList)
            {
                Console.WriteLine(item);
            }
        }

        private static int generateRando(int maxValue)
        {
            var rand = new Random();
            int rando = 0;
            bool randoExists = true;

            while (randoExists)
            {
                rando = rand.Next(maxValue);
               if( randos.FindIndex( e => e == rando) == -1 ) randoExists = false;               

            }

            randos.Add(rando);

            return rando;
        }

        private static bool isSorted(List<int> theList)
        {
            for( int i = 0; i < theList.Count - 1; i++)
            {//if a # is greater than the next # the list is not sorted, return false
                if (theList[i] > theList[i + 1]) return false;
            }

            return true;
        }
    }

    public static class Exercise_3
    {
        /*
         * 3. Write a C# Sharp program to sort a list of elements using Bubble sort. 
            According to Wikipedia "Bubble sort, sometimes referred to as sinking sort, 
            is a simple sorting algorithm that repeatedly steps through the list to be sorted,
            compares each pair of adjacent items and swaps them if they are in the wrong order. 
            The pass through the list is repeated until no swaps are needed, which indicates that the list is sorted.
        The algorithm, which is a comparison sort, is named for the way smaller elements "bubble" to the top of the list. 
        Although the algorithm is simple, it is too slow and impractical for most problems even when compared to insertion sort.
        It can be practical if the input is usually in sort order but may occasionally have some out-of-order elements nearly in position."
        */

        public static void Execute()
        {
            List<int> theList = UtilityMethods.getValidNumbersList();
            int listLength = theList.Count;
            int swapValue = 0;
            bool swapped = true;

            while (swapped == true)
            {
                swapped = false;

                for (int i = 0; i < listLength - 1; i++)
                {
                    if (theList[i] > theList[i + 1])
                    {
                        swapValue = theList[i];
                        theList[i] = theList[i + 1];
                        theList[i + 1] = swapValue;
                        swapped = true;
                    }
                }
                
            }

            foreach( var item in theList)
            {
                Console.WriteLine(item);
            }

        }

    }

    public static class Exercise_4
    {
        /*4. Write a C# Sharp program to sort a list of elements using Counting sort.
            According to Wikipedia "In computer science, counting sort is an algorithm for sorting a collection of objects according to keys that are small integers; 
        that is, it is an integer sorting algorithm. It operates by counting the number of objects that have each distinct key value, and using arithmetic on those counts
        to determine the positions of each key value in the output sequence. Its running time is linear in the number of items and the difference between the maximum and minimum key values,
        so it is only suitable for direct use in situations where the variation in keys is not significantly greater than the number of items. 
        However, it is often used as a subroutine in another sorting algorithm, radix sort that can handle larger keys more efficiently".
        */

        public static void Execute()
        {
            List<int> theList = UtilityMethods.getValidNumbersList();
            List<int> sortedList = new List<int>();

            int highest = theList.Max();

            int[] counts = new int[highest + 1];


            //fill the count array
            foreach (var item in theList)
            {
                //Add to the tally of the # as it occurs on the list
                counts[item] = counts[item] + 1;

            }

            //iterate through the counts array
            for( int i = 0; i < counts.Length; i++ )
            {
                for (int n = 0; n < counts[i]; n++)
                {
                    if (counts[i] > 0) sortedList.Add(i);
                }
            }

            foreach( var element in sortedList)
            {
                Console.WriteLine(element);
            }
        }
    }
}