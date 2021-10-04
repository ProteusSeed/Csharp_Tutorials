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

    public static class Exercise_5
    {
        /*
         * 5. Write a C# Sharp program to sort a list of elements using Heap sort. 
            In computer science, heapsort (invented by J. W. J. Williams in 1964) is a comparison-based sorting algorithm. 
            Heapsort can be thought of as an improved selection sort: like that algorithm, it divides its input into a sorted and an unsorted region, 
            and it interactively shrinks the unsorted region by extracting the largest element and moving that to the sorted region. 
            The improvement consists of the use of a heap data structure rather than a linear-time search to find the maximum.
            Although somewhat slower in practice on most machines than a well-implemented quicksort, it has the advantage of a more favorable worst-case O(n log n) runtime. 
            Heapsort is an in-place algorithm, but it is not a stable sort.
         */

        public static void Execute()
        {
            List<int> elements = UtilityMethods.getValidNumbersList();
            int countOfElements = elements.Count;
            List<int> sortedList = new List<int>();
            int parentIndex = countOfElements / 2 - 1;
 
            //Loop through the parent nodes
            for (int i = parentIndex; i >= 0; i--)
            {
                Heapify(ref elements, i);
            }

            while(elements.Count > 0)
            {
                sortedList.Insert(0, elements[0]);

                //put the last value into the 1st node
                elements[0] = elements.Last();

                //Remove the last node
                elements.RemoveAt(elements.Count - 1);

                //re-heapify
                Heapify(ref elements, 0);
            }

            //Display the sorted numbers
            for (int x = 0; x < sortedList.Count; x++)
            {
                Console.WriteLine($"{x}: {sortedList[x]}");
            }
 
        }

        private static void Heapify(ref List<int> elements, int parentIndex)
        {
            int leftChildVal = 0, rightChildVal = 0;
            int leftChildIndex = 0, rightChildIndex = 0;

            leftChildIndex = 2 * parentIndex + 1;
            rightChildIndex = 2 * parentIndex + 2;

            if (leftChildIndex < elements.Count)
            {
                leftChildVal = elements[leftChildIndex];
            }
            else
            {
                return;
            }

            if (rightChildIndex < elements.Count)
            {
                rightChildVal = elements[rightChildIndex];
            }
            else
            {//If the rightChildIndex exceeds the element count then there is no right child; give the value a dummy value that's lower than all the values.
                rightChildVal = elements[parentIndex] - leftChildVal  - 1;
            }

                if (leftChildVal > rightChildVal & leftChildVal > elements[parentIndex] )
                {
                    //swap
                    elements[leftChildIndex] = elements[parentIndex];
                    elements[parentIndex] = leftChildVal;

                    if ( (2 * leftChildIndex + 1 ) < elements.Count ) Heapify(ref elements, leftChildIndex);
                }

                if (leftChildVal < rightChildVal & rightChildVal > elements[parentIndex])
                {
                    //swap
                    elements[rightChildIndex] = elements[parentIndex];
                    elements[parentIndex] = rightChildVal;

                if ((2 * rightChildIndex + 2) < elements.Count) Heapify(ref elements, rightChildIndex);
            }

        }
    }

    public static class Exercise_6
    {
        /*
         * 6. Write a C# Sharp program to sort a list of elements using Insertion sort. 
            Insertion sort is a simple sorting algorithm that builds the final sorted array (or list) one item at a time. 
         */

        public static void Execute()
        {
            List<int> elements = UtilityMethods.getValidNumbersList();
            int newIndex = 0;

            for( int i = 1; i < elements.Count; i++)
            {
                newIndex = i;

                while (newIndex > 0 )
                {
                    //if value is less than the value of the element to the left...
                    if (elements[i] < elements[newIndex - 1])
                    {
                        //Move the new index down one
                        newIndex--;
                    } 
                    else
                    {
                        break;
                    }
                }

                //Move element to new index
                elements.Insert(newIndex, elements[i]);
                elements.RemoveAt(i + 1);
            }

            foreach( var element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }

    public static class Exercise_7
    {
        /*
         7. Write a C# Sharp program to sort a list of elements using Merge sort. 
         */

        public static void Execute()
        {
            int[] arrayA = UtilityMethods.getValidNumbersArray();
            int[] arrayB = (int[])arrayA.Clone();

            TopDownSplitMerge( ref arrayB, 0, arrayA.Length, ref arrayA, '0' );
            //recurssionTest('0', arrayA.Length, arrayA.Length);
            //return;
            
            //Print out array
            foreach (var item in arrayB)
            {
                Console.WriteLine(item);
            }

        }

        private static void recurssionTest( char CalledBy, int Anumber, int Bnumber )
        {
            Console.WriteLine( $"{CalledBy} {Anumber} {Bnumber}" );
            if ( ( CalledBy == 'A' & Anumber == 0 ) || (CalledBy == 'B' & Bnumber == 0) )
            {
                //Console.WriteLine("---Return---");
                return;
            }

            recurssionTest('A', Anumber - 1, Bnumber);
            recurssionTest('B', Anumber, Bnumber - 1 );

            Console.WriteLine($"Execute: {Anumber} {Bnumber}");
            
        }

        private static void TopDownSplitMerge( ref int[] arrayB, int begin, int end, ref int[] arrayA, char CalledBy )
        {

            Console.WriteLine($"Called By: {CalledBy} | {begin} {end}");            

            //if (calledBy == 'A' ) RecursionNumber++;

            if (end - begin <= 1)
            {
                Console.WriteLine("Return");
                return;
            }

            int iMiddle = (end + begin) / 2;
            
            //recursively split the elements down the tree
            TopDownSplitMerge(ref arrayA, begin, iMiddle, ref arrayB, 'A' );

            TopDownSplitMerge(ref arrayA, iMiddle, end, ref arrayB, 'B' );

            //Merge the splits from the bottom of the tree back up.
            TopDownMerge(ref arrayB, begin,  iMiddle, end, ref arrayA );

         }

        private static void TopDownMerge( ref int[] arrayA,  int begin,  int iMiddle, int end, ref int[] arrayB )
        {
            int left = begin, right = iMiddle;

            //Iterate through the new array (ArrayB) adding elements from left (begin to middle) and right (middle to end) branches of ArrayA in order.
            for ( int NewArrayIndex = begin; NewArrayIndex < end; NewArrayIndex++)
            {
                // If left run head exists and is <= existing right run head.
                if (left < iMiddle && (right >= end || arrayA[left] <= arrayA[right])) //if left branch value is less than right branch value...
                {
                    arrayB[NewArrayIndex] = arrayA[left];
                    left = left + 1; //since the current element has now been merged go to the next one.
                }
                else
                {
                    arrayB[NewArrayIndex] = arrayA[right];
                    right = right + 1; //since the current element has now been merged go to the next one.
                }
            }
        }

    }

    public static class Exercise_8
    {
        /*
         Write a C# Sharp program to sort a list of elements using Permutation sort. 
        Permutation sort, proceeds by generating the possible permutations of the input array/list until discovering the sorted one.
         */

        public static void Execute()
        {
            List<int> elements = UtilityMethods.getValidNumbersList();
            sort(ref elements);

            foreach ( int element in elements )
            {
                Console.WriteLine(element);
            }

        }

        private static void sort( ref List<int> elements )
        {
            List<int> newList = new List<int>();

            int rand = 0;
            bool sorted = isSorted(elements);

            if (sorted == true) return;

            while(elements.Count > 0)
            {
                rand = new Random().Next(elements.Count);
                newList.Add(elements[rand]);
                elements.RemoveAt(rand);
                
            }

            elements = newList;
            sort(ref elements);
            
        }

        private static bool isSorted(List<int> elements)
        {
            int i = elements.Count - 1;

            while( i > 0 )
            {
                if (elements[i] < elements[i - 1]) return false;
                i--;
            }

            return true;
        }
    }

    public static class Exercise_9
    {
        /*
         9. Write a C# Sharp program to sort a list of elements using Quick sort.
            Quick sort is a comparison sort, meaning that it can sort items of any type for which a "less-than" relation (formally, a total order) is defined.

            
        */

        public static void Execute()
        {
            List<int> elements = UtilityMethods.getValidNumbersList();

            quickSort(ref elements, 0, elements.Count - 1);

            print(elements);
        }

        private static void quickSort(ref List<int> elements, int begin, int end)
        {
            int middle = 0;
            //Console.WriteLine($"{begin} {end}");

            //Move every element that's higher than the last element to the right of the last element
            //and move every element that's lower to the left
            middle = partition(ref elements, begin, end);
            if (middle < begin) return;

            //split the array and recursively call this function 
            quickSort(ref elements, begin, middle - 1);
            quickSort(ref elements, middle + 1, end);

        }

        private static int partition(ref List<int> elements, int begin, int end)
        {
            //moves every element lower than the pivot to the left of the pivot (the last element) and 
            //every element higher to the right of the pivot

            if (begin >= end) return -1;

            int pivotValue = elements[end];

            int i = begin - 1;

           for( int pointer = begin; pointer < end; pointer++ )
            {
                if (elements[pointer] < pivotValue)
                {
                    /*
                     note each iteration of the loop the pointer moves right but i only moves if the value at pointer is less than the pivot value 
                    so the element at i will always either be at an element value higher than the pivot so the swap will be a lower value with a higher, 
                    or the i will = pointer in the case of the array starting with a # smaller than the pivot value 
                    in which case the element will be swapped with itself changing nothing
                    */
                    i++;
                    swap(ref elements, pointer, i);
                }
            }

            swap(ref elements, i + 1, end);
            return i + 1; //this will be the basis of the next pivot 

        }

        private static void swap( ref List<int> elements, int positionA, int positionB )
        {
            int swapValue = elements[positionB];

            elements[positionB] = elements[positionA];
            elements[positionA] = swapValue;
        }

        private static void print( List<int> elements)
        {
            foreach( int element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }

}
