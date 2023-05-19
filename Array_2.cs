namespace ConsoleApp1
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int arraysize;
            Console.WriteLine("Enter the size of array :");
            arraysize = int.Parse(Console.ReadLine());

            int[] array = new int[arraysize];

            
            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < arraysize; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

           
            Console.WriteLine("Array elements in Reverse order is as follows : ");
            for (int i = arraysize - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }



        }

    }
}
