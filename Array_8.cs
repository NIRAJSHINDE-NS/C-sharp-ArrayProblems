namespace ConsoleApp5
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 2, 1, 2, 3, 4, 5, 4, 3, 2, 1 };

            int[] frequency = new int[array.Length];

            // Initialize frequency array with zeros
            for (int i = 0; i < array.Length; i++)
            {
                frequency[i] = 0;
            }

            // Count the frequency of each element
            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;

                // Skip if the element is already counted
                if (frequency[i] != 0)
                    continue;

                // Count the frequency of the current element
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        frequency[j] = -1; // Mark the element as counted
                    }
                }

                // Store the frequency of the element
                frequency[i] = count;
            }

            // Print the frequency of each element
            Console.WriteLine("Frequency of each element in the array:");
            for (int i = 0; i < array.Length; i++)
            {
                if (frequency[i] != -1) // Ignore elements already counted
                {
                    Console.WriteLine($"{array[i]}: {frequency[i]}");
                }
            }
        }
    }

}