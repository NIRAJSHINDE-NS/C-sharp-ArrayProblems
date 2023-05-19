namespace ConsoleApp5
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] array1 = { 1, 3, 5, 7, 9 };
            int[] array2 = { 2, 4, 6, 8, 10 };

            int size = array1.Length;

            // Create a new array to store the merged result
            int[] mergedArray = new int[size * 2];

            int i = 0; // Index for array1
            int j = 0; // Index for array2
            int k = 0; // Index for mergedArray

            // Merge the arrays by comparing elements from both arrays
            while (i < size && j < size)
            {
                if (array1[i] <= array2[j])
                {
                    mergedArray[k] = array1[i];
                    i++;
                }
                else
                {
                    mergedArray[k] = array2[j];
                    j++;
                }
                k++;
            }

            // Copy the remaining elements from array1, if any
            while (i < size)
            {
                mergedArray[k] = array1[i];
                i++;
                k++;
            }

            // Copy the remaining elements from array2, if any
            while (j < size)
            {
                mergedArray[k] = array2[j];
                j++;
                k++;
            }

            // Print the merged array
            Console.WriteLine("Merged array:");
            for (int index = 0; index < mergedArray.Length; index++)
            {
                Console.Write(mergedArray[index] + " ");
            }
        }
    }
}