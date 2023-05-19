using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 2, 9, 1, 7, 4, 6 };

        // Initialize max and min with the first element of the array
        int max = array[0];
        int min = array[0];

        // Find the maximum and minimum elements
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }

            if (array[i] < min)
            {
                min = array[i];
            }
        }

        // Print the maximum and minimum elements
        Console.WriteLine("Maximum element: " + max);
        Console.WriteLine("Minimum element: " + min);
    }
}
