using System;
using System.Globalization;

namespace Loop
{
    class Program
    {


        static void Arr(int[] abc, int i)
        {


            
           // Console.WriteLine(abc[i]);
            if (i < abc.Length-1) Arr(abc, i+1);
            Console.WriteLine(abc[i]);

            //for (int i = abc.Length -1; i >= 0; i--)
            //{
            //    Console.WriteLine(abc[i]);
            //}


        }
        static void Main()
        {
            int[] array = new int[10] { 1,2,3,4,5,6,7,8,9,0 };
            Arr(array, 0);
            

            Console.ReadKey();
        }

    }
}