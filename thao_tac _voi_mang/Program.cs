using System;

namespace thao_tac__voi_mang
{
    class Program
    {
        static void Main(string[] args)
        {
            // int [] numbers = new int[5];
            //  numbers[0] = 2;
            //  numbers[1] = 5;
            //  numbers[2] = 9;
            //  numbers[3] = 6;
            //  numbers[4] = 7;
            // Console.WriteLine(numbers[0]);
            // Console.WriteLine(numbers[2]);
            // Console.WriteLine(numbers[3]);
            // int total = 0;
            // for(int i = 0; i < numbers.Length; i++ ){
            //     total += numbers[i];
            // }
            // Console.WriteLine(total.ToString());
        int [] numbers = new int[5];
          Random arr = new Random();
        for(int i =0; i < numbers.Length; i++ ){
          numbers[i] = arr.Next(1,11);
          Console.Write($" {numbers[i]} - ");
        }

        }
    }
}
