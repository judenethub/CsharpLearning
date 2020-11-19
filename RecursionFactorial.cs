using System;
using System.Globalization;

namespace Loop
{
    class Program
    {
      
        static int Calculate(int a)
        {
            
            if (a == 1) { return 1; }
            else { return a * Calculate(a-1); }

            

        }
        static void Main()
        {
            
            int a = Calculate(5);
            Console.WriteLine(a);

            Console.ReadKey();
        }

    }
}
