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


}
