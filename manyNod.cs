using System;
using System.Globalization;

namespace Loop
{
    class Program
    {
      
        static int Calculate(int a, int b)
        {

            while (b != 0)
                b = a % (a = b);  // 30 % ( 12 ) =      
            return a;

            //if (a % b == 0)
            //    return b;
            //else
            //    return Calculate(b, a % b);


            //    if (a != 0)
            //      return a * Dividerst(a - 1);
            //    else
            //          return 1;


            //    if (a < b) 
            //{

            //      Dividerst(a, (b - a));
            //}

            //    else if (a > b) 
            //{
            //      Dividerst(b, a);      
            // }
            //    else {  Console.WriteLine(a); }




            //    int divs = 2, divid =0;

            //do
            //{

            //    if ((a % divs) == 0 && (b % divs) == 0) { divid = divs; }
            //    divs++;

            //}
            //while ((divs <= a / 2) || (divs <= b / 2));

            //Console.WriteLine(divid);


        }
        static void Main()
        {


            Console.WriteLine("Нахождение наибольшего общего делителя двух целых чисел");

            int a = 30, b = 12;

            Console.WriteLine("a = {0}, b = {1}, НОД = {2};", a, b, Calculate(a, b));


            //   int z =  Dividerst(12, 12);
            //       Console.WriteLine(z);

            Console.ReadKey();
        }

    }
}
