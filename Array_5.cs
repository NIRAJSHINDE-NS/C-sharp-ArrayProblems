namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size, count = 0;

            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            int[] IntArray = new int[size];

            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < size; i++)
            {
                IntArray[i] = int.Parse(Console.ReadLine());
            }

            
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (IntArray[i] == IntArray[j])
                    {
                        count = count + 1;
                    }
                }

            }

            Console.WriteLine("Count of Duplicate elements in array : " + count);
        }
    }
}
