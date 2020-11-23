using System;
using System.Globalization;

namespace Loop
{
    class Program
    {
        static int Summa(int[] array, int i = 0)
        {
            if (i == array.Length)
            { return 0; }
            else
            {
                return array[i] + Summa(array, i+1);
            }
        }

       

        static void Main()
        {
            Console.Write("Ведите число элементов в массиве    ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]);

            }

            int smaller = array[0], bigger = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > bigger) { bigger = array[i]; }
                else if (array[i] < smaller) { smaller = array[i]; }

            }
            Console.WriteLine(" наибольшее ---->  {0},   наименьшее ----> {1}", bigger, smaller);



            Summa(array);
            Console.WriteLine("Сумма элементов -----> {0}", Summa(array));
            Console.WriteLine("Среднее арифметическое -----> {0}", Summa(array)/n);
            Console.Write("Нечетные  --->  ");
            for (int i = 0; i < array.Length; i++)
            {
                 if (array[i] % 2 != 0) { Console.Write("{0}   ", array[i]); }
            }
            














            Console.ReadKey();
        }

    }
}