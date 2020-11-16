using System;
using System.Globalization;

namespace Loop
{
    class Program
    {
        static void CheckNumber(int a)
        {
            int count = 0;

            if (a > 0) { Console.WriteLine("Число положительное"); }
              else { Console.WriteLine("Число отрицательное"); }



            for (int i = 1; i <= a; i++)
            {
                if ((a % i) == 0) { count++; }
            }

            if (count > 2) { Console.WriteLine("Число не простое"); }
            else { Console.WriteLine("Число простое"); }



            if ((a % 2) == 0) { Console.WriteLine("Делится на 2 без остатка"); }
                  else { Console.WriteLine("Не делится на 2 без остатка"); }
            if ((a % 5) == 0) { Console.WriteLine("Делится на 5 без остатка"); }
                 else { Console.WriteLine("Не делится на 5 без остатка"); }
            if ((a % 3) == 0) { Console.WriteLine("Делится на 3 без остатка"); }
                 else { Console.WriteLine("Не делится на 3 без остатка"); }
            if ((a % 6) == 0) { Console.WriteLine("Делится на 6 без остатка"); }
                else { Console.WriteLine("Не делится на 6 без остатка"); }
            if ((a % 9) == 0) { Console.WriteLine("Делится на 9 без остатка"); }
                else { Console.WriteLine("Не делится на 9 без остатка"); }

        }

        static void Main()
        {
            int num = Convert.ToInt32( Console.ReadLine());
            
            CheckNumber(num);



            Console.ReadKey();
        }

    }
}
