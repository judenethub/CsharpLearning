using System;
using System.Globalization;

namespace Loop
{
    class Program
    {
        static void MyReverse(int[] array)
        {
            
            int[] array2 = new int[5]; int j = 0;
            for (int i = array.Length -1; i >= 0; i--)
            {
                array2[j] = array[i];  j++;
            }

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", array2[0], array2[1], array2[2], array2[3], array2[4]);
           


        }

       

        static void Main()
        {
            int[] unreverse = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n\n", unreverse[0], unreverse[1], unreverse[2], unreverse[3], unreverse[4]);
            MyReverse(unreverse);

            Console.ReadKey();
        }

    }
}