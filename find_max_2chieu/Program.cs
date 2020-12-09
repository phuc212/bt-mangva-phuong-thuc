using System;

namespace find_max_2chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
                {1,2,3},
                {2,3,4},
                {6,7,8}
            }; 
            int max = array[0,0];
            for (int i = 0; i < array.GetLength(0);i++)
            {
               for(int j =0; j<array.GetLength(1); j++)
               {
                   if(array[i,j]>max)
                   {
                       max = array[i,j];
                   }
               } 
            }
            System.Console.WriteLine(max);
        }
    }
}
