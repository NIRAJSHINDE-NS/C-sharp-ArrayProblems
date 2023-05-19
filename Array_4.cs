namespace ConsoleApp1
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int size;

            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

          
            int[] Array_First1 = new int[size];
            int[] Array_Second2 = new int[size];

            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < size; i++)
            {
                Array_First1[i] = int.Parse(Console.ReadLine());
            }

            
            Console.WriteLine("First Array Elements : ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(Array_First1[i]);
            }

            
            for (int i = 0; i < size; i++)
            {
                Array_Second2[i] = Array_First1[i];
            }

          
            Console.WriteLine("Second Array Elements : ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(Array_Second2[i]);
            }
        }
    }
}