using System;
using System.Globalization;

namespace Loop
{
    class Program
    {
        static void Sum(int a, int b)
        {
            Console.WriteLine("{0} + {1}  = {2}", a, b, (a + b));
        }
        static void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1}  = {2}", a, b, (a - b));
        }
        static void Mul(int a, int b)
        {
            Console.WriteLine("{0} * {1}  = {2}", a, b, (a * b));
        }
        static void Div(int a, int b)
        {
            if (b != 0)
            { Console.WriteLine("{0} / {1}  = {2}", a, b, (a / b)); }
            else
            { Console.WriteLine("На ноль делить нельзя!"); }

        }

        static void Main()
        {
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знак");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Sum(a, b);
                    break;
                case "-":
                    Sub(a, b);
                    break;
                case "*":
                    Mul(a, b);
                    break;
                case "/":
                    Div(a, b);
                    break;
                default:
                    Console.WriteLine("Вы не ввели знак");
                    break;
            }




            Console.ReadKey();
        }

    }
}
