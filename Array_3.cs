namespace ConsoleApp1
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int arraysize;
            int sum = 0;
            Console.WriteLine("Enter the size of array :");
            arraysize = int.Parse(Console.ReadLine());

            int[] array = new int[arraysize];

            
            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < arraysize; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
                    
            for (int i = 0; i < arraysize; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine("The sum of all elements in the arrays is : " + sum);
        }

    }
}
