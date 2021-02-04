using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[25];
             
            for (int i = 0; i < 25; i++)
            {
                arr[i] = i+1;
            }

            for (int i = 0; i < 25; i++) {
                Console.WriteLine($"Element value = {arr[i]}");
            }

            Console.ReadKey(true);
        }
    }
}
