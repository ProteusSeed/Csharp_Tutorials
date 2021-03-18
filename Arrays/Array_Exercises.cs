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

    public static class Exercise_9
    {
        /*
         * 9. Write a program in C# Sharp to find maximum and minimum element in an array. 
            Test Data :
            Input the number of elements to be stored in the array :3
            Input 3 elements in the array :
            element - 0 : 45
            element - 1 : 25
            element - 2 : 21
            Expected Output :
            Maximum element is : 45
            Minimum element is : 21
         */

        public static void Execute()
        {
            int numElements = UtilityMethods.GetValidAbsoluteNumber("Input the number of elements to be stored in the array");
            int[] elements = new int[numElements];
            int min = 0, max = 0;

            for( int e = 0; e < numElements; e++ )
            {
                elements[e] = UtilityMethods.GetValidAbsoluteNumber($"element - {e+1}:");
            }

            Array.Sort(elements);
            min = elements[0];
            max = elements[numElements - 1];

            Console.WriteLine($"Maximum element: {min}");
            Console.WriteLine($"Maximum element: {max}");
        }
    }

    public static class Exercise_10
    {
        /*
         * 10. Write a programin C# Sharp to separate odd and even integers in separate arrays. 
            Test Data :
            Input the number of elements to be stored in the array :5
            Input 5 elements in the array :
            element - 0 : 25
            element - 1 : 47
            element - 2 : 42
            element - 3 : 56
            element - 4 : 32
            Expected Output:
            The Even elements are:
            42 56 32
            The Odd elements are :
            25 47
         */

        public static void Execute()
        {
            int numElements = UtilityMethods.GetValidAbsoluteNumber("Input the number of elements to be stored in the array");
            int[] elements = new int[numElements];
            string evenElements = "", oddElements = "";

            for(int e = 0; e < numElements; e++)
            {
                elements[e] = UtilityMethods.GetValidAbsoluteNumber($"element - {e}");
            }

            int[] even = Array.FindAll(elements, e => e % 2 == 0);
            int[] odd = Array.FindAll(elements, e => e % 2 > 0);

            foreach( var element in even)
            {
                evenElements += element + " ";
            }

            Console.WriteLine($"The even elements are: {evenElements}");

            foreach (var element in odd)
            {
                oddElements += element + " ";
            }

            Console.WriteLine($"The Odd elements are: {oddElements}");

        }
    }

    public static class Exercise_11
    {
        /*
         * 11. Write a program in C# Sharp to sort elements of array in ascending order.
            Test Data :
            Input the size of array : 5
            Input 5 elements in the array :
            element - 0 : 2
            element - 1 : 7
            element - 2 : 4
            element - 3 : 5
            element - 4 : 9
            Expected Output :
            Elements of array in sorted ascending order:
            2 4 5 7 9
         */

        public static void Execute()
        {
            int arraySize = UtilityMethods.GetValidAbsoluteNumber("Input the size of array");
            int[] elements = new int[arraySize];
            string sortedElements = "";

            for( int e = 0; e < arraySize; e++ )
            {
                elements[e] = UtilityMethods.GetValidAbsoluteNumber($"element - {e}");
            }

            Array.Sort(elements);

            foreach( var element in elements )
            {
                sortedElements += element + " ";
            }

            Console.WriteLine($"Elements of array in sorted ascending order: {sortedElements}");
        }
    }

    public static class Exercise_12
    {
        /*
         * 12. Write a program in C# Sharp to sort elements of the array in descending order. 
            Test Data :
            Input the size of array : 3
            Input 3 elements in the array :
            element - 0 : 5
            element - 1 : 9
            element - 2 : 1
            Expected Output :
            Elements of the array in sorted descending order:
            9 5 1
        */

        public static void Execute()
        {
            int arraySize = UtilityMethods.GetValidAbsoluteNumber("Input the size of the array");
            int[] array = new int[arraySize];

            for( int e = 0; e < arraySize; e++ )
            {
                array[e] = UtilityMethods.GetValidAbsoluteNumber($"element - {e}");
            }

            //resort
            Array.Sort(array);
            Array.Reverse(array);            

            Console.WriteLine("Elements of the array in sorted descending order:");

            foreach( var element in array)
            {
                Console.Write($"{element} ");
            }
        }
    }

    public static class Exercise_13
    {
        /*
         * 13. Write a program in C# Sharp to insert New value in the array (sorted list ). 
            Test Data :
            Input the size of array : 3
            Input 3 elements in the array in ascending order:
            element - 0 : 5
            element - 1 : 7
            element - 2 : 9
            Input the value to be inserted : 8
            Expected Output :
            The exist array list is : 5 7 9
            After Insert the list is : 5 7 8 9
        */

        public static void Execute()
        {
            int arraySize = UtilityMethods.GetValidAbsoluteNumber("Input the size of array");
            int[] array = new int[arraySize];

            Console.WriteLine("Input {0} elements in the array in ascending order:", arraySize);

            for( int e = 0; e < arraySize; e ++ )
            {
                array[e] = UtilityMethods.GetValidAbsoluteNumber($"element - {e}");
            }

            int insertVal = UtilityMethods.GetValidAbsoluteNumber("Input the value to be inserted");

            Console.Write("The existing array list is: ");
            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
           

            Array.Resize(ref array, arraySize + 1);

            array[array.Length - 1] = insertVal;

            Array.Sort(array);

            Console.WriteLine();
            Console.Write("After Insert the list is: ");
            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }

        }
    }

    public static class Exercise_14
    {
        /*
         * 14. Write a program in C# Sharp to insert New value in the array (unsorted list ). 
            Test Data :
            Input the size of array : 4
            Input 4 elements in the array in ascending order:
            element - 0 : 1
            element - 1 : 8
            element - 2 : 7
            element - 3 : 10
            Input the value to be inserted : 5
            Input the Position, where the value to be inserted :2
            Expected Output :
            The current list of the array :
            1 8 7 10
            After Insert the element the new list is :
            1 5 8 7 10
        */

        public static void Execute()
        {
            int arraySize = UtilityMethods.GetValidAbsoluteNumber("Input the size of array");
            int[] array = new int[arraySize];
            int prevPosition = 0;

            for( int e = 0; e < arraySize; e++ )
            {
                array[e] = UtilityMethods.GetValidAbsoluteNumber($"element - {0}: ");
            }

            int insert = UtilityMethods.GetValidAbsoluteNumber("Input the value to be inserted");
            int position = UtilityMethods.GetValidAbsoluteNumber("Input the position where the value is to be inserted");
            position--; //positions are zero based.

            Console.Write("The current list of the array: ");
            foreach( var element in array)
            {
                Console.Write($"{element} ");

            }
            Console.WriteLine();

            //resize array
            Array.Resize(ref array, arraySize + 1);

            //move elements
            for( int p = array.Length - 1; p >= position; p-- )
            {
                prevPosition = p > 0 ? p - 1 : 0;

                array[p] = array[prevPosition];
            }

            array[position] = insert;

            Console.WriteLine("After Inserting the element the new list is:");
            foreach( var element in array)
            {
                Console.Write($"{element} ");
            }
        }
    }

    public static class Exercise_15
    {
        /*
         * 15. Write a program in C# Sharp to delete an element at desired position from an array. Go to the editor
            Test Data :
            Input the size of array : 5
            Input 5 elements in the array in ascending order:
            element - 0 : 1
            element - 1 : 2
            element - 2 : 3
            element - 3 : 4
            element - 4 : 5
            Input the position where to delete: 3
            Expected Output :
            The new list is : 1 2 4 5
            Click me to see the solution
        */

        public static void Execute()
        {
            int arraySize = UtilityMethods.GetValidAbsoluteNumber("Input the size of the array");
            int deletePosition = UtilityMethods.GetValidAbsoluteNumber("Input the position where to delete");
            deletePosition--;

            int[] array = new int[arraySize];

            for( int element = 0; element < arraySize; element++ )
            {
                array[element] = UtilityMethods.GetValidAbsoluteNumber($"element - {element}");
            }

            for( int e = deletePosition; e < array.Length - 1; e++ )
            {
                array[e] = array[e + 1];
            }

            Array.Resize(ref array, arraySize - 1);

            Console.Write("The new list is: ");
            foreach ( var element in  array)
            {
                Console.Write($"{element} ");
            }
        }

    }

    public static class Exercise_16
    {
        /*
         * 16. Write a program in C# Sharp to find the second largest element in an array. 
            Test Data :
            Input the size of array : 5
            Input 5 elements in the array :
            element - 0 : 2
            element - 1 : 9
            element - 2 : 1
            element - 3 : 4
            element - 4 : 6
            Expected Output :
            The Second largest element in the array is: 6
        */

        public static void Execute()
        {
            int arraySize = UtilityMethods.GetValidAbsoluteNumber($"Input the size of the array");
            int[] array = new int[arraySize];

            Console.WriteLine("Input 5 elements in the array:");

            for (int e = 0; e < arraySize; e++ )
            {
                array[e] = UtilityMethods.GetValidAbsoluteNumber($"element - {e}");
            }

            Array.Sort(array);

            Console.WriteLine($"The second largest element in the array is: {array[array.Length - 2]}");
        }
    }

    public static class Exercise_17
    {
        /*
         * 17. Write a program in C# Sharp to find the second smallest element in an array. 
            Test Data :
            Input the size of array : 5
            Input 5 elements in the array (value must be <9999) :
            element - 0 : 0
            element - 1 : 9
            element - 2 : 4
            element - 3 : 6
            element - 4 : 5
            Expected Output :
            The Second smallest element in the array is : 4
         */

        public static void Execute()
        {
            int arraySize = UtilityMethods.GetValidAbsoluteNumber($"Input the size of the array");
            int[] array = new int[arraySize];

            Console.WriteLine("Input 5 elements in the array:");

            for (int e = 0; e < arraySize; e++)
            {
                array[e] = UtilityMethods.GetValidAbsoluteNumber($"element - {e}");
            }

            Array.Sort(array);

            Console.WriteLine($"The second largest element in the array is: {array[1]}");
        }
    }

    public static class Exercise_18
    {
        /*
         * 18. Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix. 
            Test Data :
            Input elements in the matrix :
            element - [0],[0] : 1
            element - [0],[1] : 2
            element - [0],[2] : 3
            element - [1],[0] : 4
            element - [1],[1] : 5
            element - [1],[2] : 6
            element - [2],[0] : 7
            element - [2],[1] : 8
            element - [2],[2] : 9
            Expected Output :
            The matrix is :

            1 2 3
            4 5 6
            7 8 9
         */

        public static void Execute()
        {
            int[,] matrix = new int[3, 3];
            int elementCount = 1;

            for( int x = 0; x < 3; x++ )
            {
                for( int y = 0; y < 3; y++ )
                {
                    matrix[x, y] = UtilityMethods.GetValidAbsoluteNumber($"element - [{x}],[{y}]");
                }
            }

            Console.WriteLine("The matrix is: ");

            foreach( var element in matrix)
            {               
                Console.Write($"{element} ");
                if (elementCount % 3 == 0) Console.WriteLine();//Move to another line every 3 elements
                elementCount++;                
            }
        }
    }

    public static class Exercise_19
    {
        /*
         * 19. Write a program in C# Sharp for addition of two Matrices of same size. 
            Test Data :
            Input the size of the square matrix (less than 5): 2
            Input elements in the first matrix :
            element - [0],[0] : 1
            element - [0],[1] : 2
            element - [1],[0] : 3
            element - [1],[1] : 4
            Input elements in the second matrix :
            element - [0],[0] : 5
            element - [0],[1] : 6
            element - [1],[0] : 7
            element - [1],[1] : 8
            Expected Output:
            The First matrix is:

            1 2
            3 4
            The Second matrix is :

            5 6
            7 8
            The Addition of two matrix is :

            6 8
            10 12
        */

        public static void Execute()
        {
            int matrixSize = UtilityMethods.GetValidNumber(1, 5, " Input the size of the square matrix (less than 5)");
            int[,] matrix1 = new int[matrixSize, matrixSize];
            int[,] matrix2 = new int[matrixSize, matrixSize];

            Console.WriteLine("Input elements in the first matrix:");
            for ( int m1x = 0; m1x < matrixSize; m1x++ )
            {
                for (int m1y = 0; m1y < matrixSize; m1y++)
                {
                    matrix1[m1x, m1y] = UtilityMethods.GetValidAbsoluteNumber($"element - {m1x},{m1y}");
                }
            }

            Console.WriteLine("Input elements in the second matrix:");
            for (int m2x = 0; m2x < matrixSize; m2x++)
            {
                for (int m2y = 0; m2y < matrixSize; m2y++)
                {
                    matrix2[m2x, m2y] = UtilityMethods.GetValidAbsoluteNumber($"element - {m2x},{m2y}");
                }
            }

            Console.Write("The First matrix is: ");
            foreach( var element in matrix1 )
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
            Console.Write("The Second matrix is: ");
            foreach (var element in matrix2)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
            
            string addition = MatrixAddition(matrix1, matrix2);
            Console.Write($"The Addition of two matrix is: {addition}");
        }

        private static string MatrixAddition( int[,] matrix1, int[,] matrix2 )
        {
            int size = matrix1.GetLength(0);
            string addition = "";

            for( int x = 0; x < size; x++)
            {
                for( int y = 0; y < size; y++ )
                {
                    addition += Convert.ToString(matrix1[x, y] + matrix2[x, y]) + "\n";
                }
            }

            return addition;
        }

    }

    public static class Exercise_20
    {
        /*
         * 20. Write a program in C# Sharp for subtraction of two Matrices. 
            Test Data :
            Input the size of the square matrix (less than 5): 2
            Input elements in the first matrix :
            element - [0],[0] : 5
            element - [0],[1] : 6
            element - [1],[0] : 7
            element - [1],[1] : 8
            Input elements in the second matrix :
            element - [0],[0] : 1
            element - [0],[1] : 2
            element - [1],[0] : 3
            element - [1],[1] : 4
            Expected Output :
            The First matrix is :

            5 6
            7 8
            The Second matrix is :

            1 2
            3 4
            The Subtraction of two matrix is :

            4 4
            4 4
         */

        public static void Execute()
        {
            int size = UtilityMethods.GetValidNumber(1, 5, "Input the size of the square matrix (less than 5)");
            int[,] matrix1 = new int[size, size];
            int[,] matrix2 = new int[size, size];
            

            Console.WriteLine("Input elements in the first matrix:");
            for( int m1x = 0; m1x < size; m1x++ )
            {
                for (int m1y = 0; m1y < size; m1y++)
                {
                    matrix1[m1x, m1y] = UtilityMethods.GetValidAbsoluteNumber($"element - [{m1x}],[{m1y}]");
                }
            }

            Console.WriteLine("Input elements in the second matrix:");
            for (int m2x = 0; m2x < size; m2x++)
            {
                for (int m2y = 0; m2y < size; m2y++)
                {
                    matrix2[m2x, m2y] = UtilityMethods.GetValidAbsoluteNumber($"element - [{m2x}],[{m2y}]");
                }
            }

            Console.WriteLine("The First matrix is: ");
            foreach( var element in matrix1)
            {
                Console.WriteLine($"{element} ");
            }

            //Console.WriteLine();

            Console.WriteLine("The second matrix is: ");
            foreach (var element in matrix2)
            {
                Console.WriteLine($"{element} ");
            }

            Console.WriteLine();

            Console.WriteLine($"The Subtraction of two matrix is: {subtractMatrix(matrix1, matrix2)}");
        }

        private static string subtractMatrix( int[,] matrix1, int[,] matrix2)
        {
            string sumString = "";

            for ( int x = 0; x < matrix1.GetLength(0); x++ )
            {
                for( int y = 0; y < matrix1.GetLength(0); y++ )
                {
                    sumString += Convert.ToString( matrix1[x, y] - matrix2[x, y]) + " ";
                }
            }

            return sumString;
        }
    }

    public static class Exercise_21
    {
        /*
         * 21. Write a program in C# Sharp for multiplication of two square Matrices. 
            Test Data :
            Input the rows and columns of first matrix : 2 2
            Input the rows and columns of second matrix : 2 2
            Input elements in the first matrix :
            element - [0],[0] : 1
            element - [0],[1] : 2
            element - [1],[0] : 3
            element - [1],[1] : 4
            Input elements in the second matrix :
            element - [0],[0] : 5
            element - [0],[1] : 6
            element - [1],[0] : 7
            element - [1],[1] : 8
            Expected Output :
            The First matrix is :

            1 2
            3 4
            The Second matrix is :

            5 6
            7 8
            The multiplication of two matrix is :

            19 22
            43 50
         */

        public static void Execute()
        {
            int matrix1Rows = UtilityMethods.GetValidNumber(1, 5, "Input the number of rows in the first matrix: ");
            int matrix1Cols = UtilityMethods.GetValidNumber(1, 5, "Input the number of columnss in the first matrix: ");
            int matrix2Rows = UtilityMethods.GetValidNumber(1, 5, "Input the number of rows in the second matrix: ");
            int matrix2Cols = UtilityMethods.GetValidNumber(1, 5, "Input the number of columnss in the second matrix: ");

            int[,] matrix1 = new int[matrix1Rows, matrix1Cols];
            int[,] matrix2 = new int[matrix2Rows, matrix2Cols];


            Console.WriteLine("Input elements in the first matrix:");
            for (int m1x = 0; m1x < matrix1Rows; m1x++)//rows
            {
                for (int m1y = 0; m1y < matrix1Cols; m1y++)//cols
                {
                    matrix1[m1x, m1y] = UtilityMethods.GetValidAbsoluteNumber($"element - [{m1x}],[{m1y}]");
                }
            }

            Console.WriteLine("Input elements in the second matrix:");
            for (int m2x = 0; m2x < matrix2Rows; m2x++)
            {
                for (int m2y = 0; m2y < matrix2Cols; m2y++)
                {
                    matrix2[m2x, m2y] = UtilityMethods.GetValidAbsoluteNumber($"element - [{m2x}],[{m2y}]");
                }
            }

            Console.WriteLine("The First matrix is: ");
            foreach (var element in matrix1)
            {
                Console.WriteLine($"{element} ");
            }

            //Console.WriteLine();

            Console.WriteLine("The second matrix is: ");
            foreach (var element in matrix2)
            {
                Console.WriteLine($"{element} ");
            }

            Console.WriteLine();

            Console.WriteLine($"The multiplication of two matrix is: \n {multiplyMatrix(matrix1, matrix2)}");
        }

        private static string multiplyMatrix(int[,] matrix1, int[,] matrix2)
        {
            string multString = "";

            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix1.GetLength(0); y++)
                {
                    multString += Convert.ToString(matrix1[x, y] * matrix2[x, y]) + " ";
                }

                multString += "\n";

            }

            return multString;
        }
    }

    public static class Exercise_22
    {
        /*
         * 22. Write a program in C# Sharp to find transpose of a given matrix. 
            Test Data :
            Input the rows and columns of the matrix : 2 2
            Input elements in the first matrix :
            element - [0],[0] : 1
            element - [0],[1] : 2
            element - [1],[0] : 3
            element - [1],[1] : 4
            Expected Output :
            The matrix is :
                1 2
                3 4

            The Transpose of a matrix is :
                1 3
                2 4
        */

        public static void Execute()
        {
            int rows = UtilityMethods.GetValidAbsoluteNumber("Input the # of rows in the matrix");
            int cols = UtilityMethods.GetValidAbsoluteNumber("Input the # of columns in the matrix");
            int[,] matrix = new int[rows, cols];

            for( int x = 0; x < rows; x++ )
            {
                for( int y = 0; y < cols; y++ )
                {
                    matrix[x, y] = UtilityMethods.GetValidAbsoluteNumber($"element - [{x}],[{y}]: ");
                }
            }

            Console.WriteLine("The matrix is: ");
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    Console.Write($"{matrix[x, y]} ");
                }

                Console.WriteLine();
            }

            int[,] transposedMatrix = transpose(matrix);

            Console.WriteLine("The transpose of the matrix is: ");
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    Console.Write($"{transposedMatrix[x, y]} ");
                }
                Console.WriteLine();
            }

        }

        private static int[,] transpose( int[,] matrix)
        {
            int[,] transposedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            int diagonalPosition = 0;

            for( int x = 0; x < matrix.GetLength(0); x++ )
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    //if (y == diagonalPosition) Console.WriteLine($"{y} Diagonal!");
                    transposedMatrix[y, x] = matrix[x, y];
                }
                diagonalPosition++;
            }

            return transposedMatrix;
        }
    }
}
