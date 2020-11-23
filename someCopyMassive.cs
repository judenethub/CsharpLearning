using System;
using System.Globalization;

namespace Loop
{
    class Program
    {
        static int[] SubArray(int[] array, int index, int count)
        {

            int[] array2 = new int[count];
            for (int i = 0; i < count; i++)
            {

                
                if (index < array.Length) {array2[i] = array[index];  index++; } 
                else { array2[i] = 1;  }
            }
            return array2;
        }

       

        static void Main()
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 4 };
            int[] array2 = SubArray(array, 5, 14);

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
            
            Console.ReadKey();
        }

    }
}