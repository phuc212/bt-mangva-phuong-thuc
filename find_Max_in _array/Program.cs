using System;

namespace find_Max_in__array
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int [] array;
        //    int size;
        //    do
        //    {
        //        Console.WriteLine("enter a size");
        //        size = Int32.Parse(Console.ReadLine());
        //        if(size > 20)
        //        Console.WriteLine("you should not exceed 20");

        //    }while (size > 20);
        //    array = new int[size];
        //     int i = 0;
        //     while(i < array.Length)
        //     {
        //         System.Console.WriteLine("enter element" + (i + 1) + ": ");
        //         array[i] = Int32.Parse(Console.ReadLine());
        //         i++;
        //     }
        //     System.Console.WriteLine("property list: ");
        //     for(int j= 0; j < array.Length; j++)
        //     {
        //         Console.Write( $" {array[j]} \n" );
        //     }
        //     int max = array[0];
        //     int index = 1;
        //     for( int j = 0; j < array.Length; j++)
        //     {
        //         if(array[j] > max )
        //         {
        //           max = array[j];
        //             index = j + 1;
        //         }
        //     }
        //      Console.WriteLine("The largest property value in the list is " + max + " ,at position " + index);
            int [] array = new int[20];
            Random arr = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = arr.Next(10,50);
                Console.Write($" {array[i]} " );
            }
            int max = array[0];
            int index = 1;
            for( int j = 0; j < array.Length; j++)
            {
                if(array[j] > max)
                {
                    max = array[j];
                    index = j + 1;
                }
            }
            Console.WriteLine("\nthe largest property value in the list is " + max + " and at positiom " + index );
        }
    }
}
