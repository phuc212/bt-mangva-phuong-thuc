using System;

namespace find_Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int[5];
            Random arr1 = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr1.Next(10,20);
                Console.Write($" {arr[i]} ");
            }
            int min = findMin(arr);
        Console.Write("\n" + min );

        }
        static int findMin(int[] array)
        {
            int min = array[0];
            int index = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < min)
                {
                    min = array[i];
                    index = i + 1;

                }
            }
              return min;
        }
    }
}
