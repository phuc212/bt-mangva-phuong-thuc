using System;

namespace dao_nguoc_phan_tu_mang
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] array = new int[20];
           Random arr = new Random();
           int temp ;
           int [] newarray = new int[20];
            for(int i = 0; i< array.Length; i++)
            {
                array[i] = arr.Next(1,21);
                System.Console.Write($" {array[i]} ");
            }
            for(int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
                newarray[i] = array[j];
            }
            array = newarray;
            Console.WriteLine("\nreverse array: " );
           foreach (var value in array)
           {
               Console.Write($" {value} ");
           }

        }
    }
}
