namespace ConsoleApp5
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 1, 2, 5, 6, 3, 7, 8, 9, 7 };

            // Sort the array to bring duplicates together
            Array.Sort(array);

            Console.WriteLine("Unique elements in the array:");

            // Iterate through the sorted array
            for (int i = 0; i < array.Length; i++)
            {
                // If the current element is the same as the previous element, skip it
                if (i > 0 && array[i] == array[i - 1])
                    continue;

                // Print the unique element
                Console.WriteLine(array[i]);
            }
        }
    }
}