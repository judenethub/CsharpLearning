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

            (x >= y ? ref x : ref y) = 100;
            Console.WriteLine($"{x}    {y}");
            Console.ReadKey();
        }

    }
}
