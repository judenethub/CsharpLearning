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
            if (x > y) { (x, y) = (y, x); }
            while (x != y - 1) { x++; if (x % 2 != 0) { Console.WriteLine(x); } }

           // if (x < y) { while (x != y - 1) { x++; if (x % 2 != 0) { Console.WriteLine(x); } } }
            //else if (x > y) { while (x != y + 1) { x--; if (x % 2 != 0) { Console.WriteLine(x); } } }
           // else { Console.WriteLine("равны"); }

            Console.ReadKey();
        }

    }
}
