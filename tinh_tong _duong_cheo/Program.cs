using System;

namespace tinh_tong__duong_cheo
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] array = new int[3,3];
            Random arr = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = arr.Next(10,20);
                }
            }
            System.Console.WriteLine("mang cuar bo:");
            for (int i = 0; i < array.GetLength(0) ; i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                  System.Console.Write($" {array[i,j]} ");
                }
                System.Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < array.GetLength(0) ; i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                 if(i==j)
                 {
                     sum += array[i,j];
                 }
                }
            }
            System.Console.WriteLine("\n" + sum);
        }
    }
}
