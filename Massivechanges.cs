using System;
using System.Globalization;

namespace Loop
{
    class Program
    {

        static void NotMain(ref int[] array, int value)
        {
            int[] array2 = new int[array.Length + 1];

            for (int i = 0; i < array2.Length ; i++)
            {
                if(i == 0) 
                {
                    array2[i] = value;
                }
                else
                {
                    array2[i] = array[i-1];
                }
            }
            array = array2;
        }
      //static void SubArray(ref int[] array)
      // {
      //      int[] array2 = new int[array.Length+1];
      //      for (int i = 0; i < array2.Length ; i++)
      //      {
      //          if(i == array.Length) { array2[i] = 1; }
      //          else
      //          { array2[i] = array[i]; }
                
      //      }
      //      array = array2;
      // }






        static void Main()
        {
            int[] array = new int[5] {7, 4, 6, 3, 9};

            Console.WriteLine("{0}  {1}  {2}  {3}  {4}", array[0], array[1], array[2], array[3], array[4] );
            NotMain(ref array, 5);

           // SubArray(ref array);
           Console.WriteLine("{0}  {1}  {2}  {3}  {4} {5}", array[0], array[1], array[2], array[3], array[4], array[5]);
            Console.ReadKey();
        }

    }
}