using System;
using System.Globalization;

namespace Loop
{
    static class Program
    {

        static void Main()
        {

            Console.Write("Длина массива   ");

            int a = Convert.ToInt32(Console.ReadLine()), b=0 ;
            int[] arr = new int[a];
            while(b < arr.Length)
            {
                Console.WriteLine($"придумайте {b} -й элемент");
                arr[b] = Convert.ToInt32(Console.ReadLine());
                b++;
            }
            Console.WriteLine("получился массив ");
           
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 1; j <= arr.Length - i; j++)
                {
                    if (arr[j - 1] < arr[j])
                    {
                        (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);
                    }
                } 
                
            }

            Console.WriteLine("отсортированный получился массив ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Array.Resize(ref arr, a+1);

            Console.WriteLine("Добавь последний элемент");
            arr[arr.Length -1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("окончательный массив ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }

    }
}
