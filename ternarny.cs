using System;
using System.Globalization;

namespace Loop
{
    static class Program
    {

        static void Main()
        {
            
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            x = x % 2 == 0 ?  x : x+1 ;
            y = y % 2 == 0 ? y : y + 1;

            Console.WriteLine($"{x}     {y}");

            string result;
            result = (x + y) % 4 == 0 ? $"Сумма {x} + {y} делится на 4" : $"Сумма {x} + {y} не делится на 4";

            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}
