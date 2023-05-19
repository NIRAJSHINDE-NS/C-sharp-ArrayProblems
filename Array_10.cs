namespace ConsoleApp5
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Create separate arrays for odd and even integers
            int[] oddArray = new int[array.Length];
            int[] evenArray = new int[array.Length];

            int oddCount = 0;
            int evenCount = 0;

            // Separate odd and even integers
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) // Even number
                {
                    evenArray[evenCount] = array[i];
                    evenCount++;
                }
                else // Odd number
                {
                    oddArray[oddCount] = array[i];
                    oddCount++;
                }
            }

            // Resize the arrays to remove unused elements
            Array.Resize(ref oddArray, oddCount);
            Array.Resize(ref evenArray, evenCount);

            // Print the separated arrays
            Console.WriteLine("Odd integers:");
            foreach (int odd in oddArray)
            {
                Console.Write(odd + " ");
            }

            Console.WriteLine("\n\nEven integers:");
            foreach (int even in evenArray)
            {
                Console.Write(even + " ");
            }
        }
    }


}