using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 2, 9, 1, 7, 4, 6 };

        // Sort the array in descending order
        Array.Sort(array);
        Array.Reverse(array);

        // Print the sorted array
        Console.WriteLine("Sorted array in descending order:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
