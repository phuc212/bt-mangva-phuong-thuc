using System;

namespace xoa_phan_tu
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] array = {1,1,2,3,2,2};
           int value;
            System.Console.WriteLine("nhap phan tu de xoa: ");
            value = Int32.Parse(Console.ReadLine());
            int i=0;
            int count = 0;
            while(i < array.Length)
            {
                if(array[i]==value)
                {
                    for(int j= i; j < array.Length-1;j++ )
                    {
                        array[j] = array[j + 1];
                    }
                    i = 0;
                    count++;
                }else
                i++;
            }
            // System.Console.WriteLine(count);
            Array.Resize(ref array, array.Length - count);
            foreach (var item in array)
            {
                Console.Write($" {item} ");
            }
        }
    }
}
