using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = index * index;         
            
            }

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            
            
            
            
            
            
        }
    }
}
