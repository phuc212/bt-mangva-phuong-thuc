using System;

namespace them_phan_tu
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = {3,4,2,4};
            int value;
            int index;
            Console.WriteLine("nhap gia tri can chen");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap vi tri can chen");
             index =Convert.ToInt32(Console.ReadLine());
             Array.Resize(ref array, array.Length + 1);

             for(int j =array.Length-1;j > index;j--)
             {
                 array[j] = array[j-1];
             }
            array[index] = value ;
             Console.Write("\n mang moi \n" );
             for(int j=0; j<array.Length; j++)
             {
                 Console.Write($" {array[j]} ");
             }

        }
    }
}
