using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Arrays
{
    public static class Exercise_1
    {
        /*
         * 1. Write a program in C# Sharp to store elements in an array and print it. 
            Test Data:
            Input 10 elements in the array:
            element - 0 : 1
            element - 1 : 1
            element - 2 : 2
            .......
            Expected Output :
            Elements in array are: 1 1 2 3 4 5 6 7 8 9
        */
        public static void Execute()
        {
            string[] elements = new string[10];

            Console.WriteLine("Input 10 elements in the array");

            for( int element = 0; element < 10; element++)
            {
                elements[element] = UtilityMethods.GetValidString($"Element {element + 1}");
            }

            foreach (var item in elements)
            {
                Console.Write($"{item} ");
            }

            return;
        }
    }

    public static class Exercise_2
    {
        /*
         * 2. Write a program in C# Sharp to read n number of values in an array and display it in reverse order.
        Test Data :
        Input the number of elements to store in the array :3
        Input 3 number of elements in the array :
        element - 0 : 2
        element - 1 : 5
        element - 2 : 7
        Expected Output:
        The values store into the array are:
        2 5 7
        The values store into the array in reverse are :
        7 5 2
         */

        public static void Execute()
        {
            int numOfElements = UtilityMethods.GetValidAbsoluteNumber("Input the number of elements to store in the array");
            string[] elements = new string[numOfElements];

            Console.WriteLine("Input {0} elements into array:", numOfElements);

            for( int e = 0; e < numOfElements; e++ )
            {
                Console.Write($"Element - {e}: ");
                elements[e] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.Write($"The values stored in the array are: ");

            foreach( var item in elements)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.Write($"The values stored in reverse are: ");

            Array.Reverse(elements);

            foreach (var item in elements)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }

    public static class Exercise_3
    {
        /*
         * 3. Write a program in C# Sharp to find the sum of all elements of the array. 
            Test Data :
            Input the number of elements to be stored in the array :3
            Input 3 elements in the array :
            element - 0 : 2
            element - 1 : 5
            element - 2 : 8
            Expected Output :
            Sum of all elements stored in the array is : 15
         */

        public static void Execute()
        {
            int numOfElements = UtilityMethods.GetValidAbsoluteNumber("Input the number of elements to be stored in the array ");
            int[] elements = new int[numOfElements];
            int sum = 0;

            Console.WriteLine($"Input {numOfElements} in the array:");

            for(int e = 0; e < numOfElements; e++)
            {
                elements[e] = UtilityMethods.GetValidAbsoluteNumber($"element - {e}: ");

                sum += elements[e];
            }

            Console.WriteLine($"Sum of all elements stored in the array is: {sum}");
        }
    }

    public static class Exercise_4
    {
        /*
         * 4. Write a program in C# Sharp to copy the elements one array into another array. 
            Test Data :
            Input the number of elements to be stored in the array :3
            Input 3 elements in the array :
            element - 0 : 15
            element - 1 : 10
            element - 2 : 12
            Expected Output:
            The elements stored in the first array are :
            15 10 12
            The elements copied into the second array are :
            15 10 12
         */

        public static void Execute()
        {
            int numOfElements = UtilityMethods.GetValidAbsoluteNumber("Input the number of elements to be stored in the array");
            string[] elements = new string[numOfElements];

            Console.WriteLine($"Input {numOfElements} elements in the array");

            for( int e = 0; e < numOfElements; e++)
            {
                elements[e] = UtilityMethods.GetValidString($"element - {e}");
            }

            Console.Write("The elements stored in the first array are: ");

            foreach( var e in elements)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();
            Console.Write("The elements copied into the second array are: ");

            string[] elements2 = elements;

            foreach( string e in elements2)
            {
                Console.Write($"{e} ");
            }


        }
    }

    public static class Exercise_5
    {
        /*
         * 5. Write a program in C# Sharp to count a total number of duplicate elements in an array. 
            Test Data :
            Input the number of elements to be stored in the array :3
            Input 3 elements in the array :
            element - 0 : 5
            element - 1 : 1
            element - 2 : 1
            Expected Output :
            Total number of duplicate elements found in the array is : 1
         */

        public static void Execute()
        {
            int numOfElements = UtilityMethods.GetValidAbsoluteNumber("Input the number of elements to be stored in the array");
            string[] elements = new string[numOfElements];

            Console.WriteLine($"Input {numOfElements} elements in the array: ");

            for( int e = 0; e < numOfElements; e++ )
            {
                elements[e] = UtilityMethods.GetValidString($"element - {e}");
            }

            Console.WriteLine($" Total number of duplicate elements found in the array is: {CountDupes(elements)}");
        }

        private static int CountDupes( string[] elements )
        {
            int countOfDupes = 0;
            int countOfElements = 0;

            foreach (var element in elements)
            {
                countOfElements = Array.FindAll(elements, e => e == element).Length;

                if (countOfElements > 1) countOfDupes++;

                //update array
                elements = Array.FindAll(elements, e => e != element);
            }

            return countOfDupes;
        }
    }

    public static class Exercise_6  
    {
        /*
         * 6. Write a program in C# Sharp to print all unique elements in an array. 
            Test Data :
            Input the number of elements to be stored in the array :3
            Input 3 elements in the array :
            element - 0 : 1
            element - 1 : 5
            element - 2 : 1
            Expected Output :
            The unique elements found in the array are :
            5
         */

        public static void Execute()
        {
            int numOfElements = UtilityMethods.GetValidAbsoluteNumber("Input the number of elements to be stored in the array");
            string[] Elements = new string[numOfElements];
            int numOfCopies = 0;

            for( int e = 0; e < numOfElements; e++ )
            {
                Elements[e] = UtilityMethods.GetValidString($"element - {e}");
            }

            Console.Write("The unique elements found in the array are: ");

            for(int e = 0; e < numOfElements; e++)
            {
                numOfCopies = Array.FindAll(Elements, el => el == Elements[e]).Length;
                if (numOfCopies == 1) Console.Write($"{Elements[e]} ");

                numOfElements -= numOfCopies; //update the # of elements.
                //return only those elements not matching the current element
                Elements = Array.FindAll(Elements, el => el != Elements[e]);
            }
        }
    }

    public static class Exercise_7
    {
        /*
         * 7. Write a program in C# Sharp to merge two arrays of same size sorted in ascending order. 
            Test Data :
            Input the number of elements to be stored in the first array :3
            Input 3 elements in the array :
            element - 0 : 1
            element - 1 : 2
            element - 2 : 3
            Input the number of elements to be stored in the second array :3
            Input 3 elements in the array:
            element - 0 : 1
            element - 1 : 2
            element - 2 : 3
            Expected Output:
            The merged array in ascending order is :
            1 1 2 2 3 3
         */

        public static void Execute()
        {
            int firstNumElements = UtilityMethods.GetValidAbsoluteNumber("Input the number of elements to be stored in the first array");
            int secondNumElements = UtilityMethods.GetValidAbsoluteNumber("Input the number of elements to be stored in the second array");

            int[] firstElements = new int[firstNumElements];
            int[] secondElements = new int[secondNumElements];

            int[] allElements = new int[firstNumElements + secondNumElements];

            Console.Write($"Input {firstNumElements} elements in the array: ");

            for( int e = 0; e < firstNumElements; e++)
            {

                firstElements[e] = UtilityMethods.GetValidAbsoluteNumber($" element - 0{e}");
            }

            Console.WriteLine($"Input {secondNumElements} elements in the array: ");

            for (int e2 = 0; e2 < secondNumElements; e2++)
            {
                secondElements[e2] = UtilityMethods.GetValidAbsoluteNumber($" element - 0{e2}");
            }

            firstElements.CopyTo(allElements, 0);
            secondElements.CopyTo(allElements, firstNumElements);

            Array.Sort(allElements);

            Console.WriteLine("The merged array in ascending order is: ");

            foreach( var element in allElements)
            {
                Console.Write($"{element} ");
            }    

        }
    }

    public static class Exercise_8
    {
        /*
         * 8. Write a program in C# Sharp to count the frequency of each element of an array. 
            Test Data :
            Input the number of elements to be stored in the array :3
            Input 3 elements in the array :
            element - 0 : 25
            element - 1 : 12
            element - 2 : 43
            Expected Output :
            Frequency of all elements of array :
            25 occurs 1 times
            12 occurs 1 times
            43 occurs 1 times
         */

        public static void Execute()
        {
            int numOfElemeents = UtilityMethods.GetValidAbsoluteNumber("Input the number of elements to be stored in the array");
            string[] elements = new string[numOfElemeents];
            int countOfElements = 0;
            string es = "";

            for ( int e = 0; e < numOfElemeents; e++)
            {
                elements[e] = UtilityMethods.GetValidString($"element - {e}:");
            }

            foreach( var element in elements)
            {
                countOfElements = Array.FindAll(elements, e => element == e).Length;
                es = countOfElements == 1 ? "" : "s";

                Console.WriteLine($"{element} occurs {countOfElements} time{es}");
            }

        }
    }
}
