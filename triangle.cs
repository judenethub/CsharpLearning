using System;
using System.Globalization;

namespace Loop
{
    static class Program
    {
        static void Main()
        {
            double x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToInt32(Console.ReadLine());
            double z = Convert.ToInt32(Console.ReadLine());
            
            if ((x < (y + z)) && (y < (x + z)) && (z < (x + y)))
            {
                Console.Write("треугольник ");
                if (Math.Pow(x,2) + Math.Pow(y,2) == Math.Pow(z,2) | Math.Pow(x, 2) + Math.Pow(z, 2) == Math.Pow(y, 2) | Math.Pow(y, 2) + Math.Pow(z, 2) == Math.Pow(x, 2))
                {
                    Console.Write(" прямоугольный");
                }
                if ( x == y && y == z)
                {
                    Console.Write(" равносторонний");
                }
                if ( (x == y & z != x) | (x == z & y != x) | (z == y & z != x))
                {
                    Console.Write(" равнобедренный");
                }
                Console.WriteLine(y);

            }
            else
            {
                Console.WriteLine("треугольник НЕ существует");
            }
            

            Console.ReadKey();
        }

    }
}
