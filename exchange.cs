using System;
using System.Globalization;

namespace Loop
{
    class Program
    {   
        static void Converter(double a, double b)
        {
            Console.WriteLine("{0} рублей по курсу {1} стоят {2}", a, b, (a * b));
        }

        static void Main()
        {
            Console.WriteLine("Напишите сумму");
            double conver = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Напишите курс");
            double exchange = Convert.ToDouble(Console.ReadLine());
            Converter(conver, exchange);


            Console.ReadKey();
        }

    }
}
