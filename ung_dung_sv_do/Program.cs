using System;

namespace ung_dung_sv_do
{
    class Program
    {
        static void Main(string[] args)
        {
           int size;
           int [] array;
           do
           {
               Console.WriteLine("enter a size");
               size = Int32.Parse(Console.ReadLine());
               if(size > 30)
               Console.WriteLine("you shoud not exceed 30");

           }while(size > 30);
           array = new int[size];
           int i = 0;
           while(i < array.Length)
           {
               Console.WriteLine("enter a mark for student" + (i + 1) + ": ");
               array[i] = Int32.Parse(Console.ReadLine());
               i++;
           }
           int count = 0;
           Console.WriteLine("list of mark: ");
           for(int j = 0; j < array.Length; j++)
           {
               Console.WriteLine(array[j] + "\t");
               if(array[j] >= 5 && array[j] <= 10)
               count++;
           }
           Console.WriteLine("\n the numbers of students passing the exam is " + count);
        }
    }
}
