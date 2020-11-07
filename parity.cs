using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)  {   // является ли число четным



            //int parity = Convert.ToInt32(Console.ReadLine());

            //  int c = parity | 1;
            //   if ((parity + 1) == c )
            //     Console.WriteLine("Четное");
            //   else
            //      Console.WriteLine("нечетное");



            // int c = parity % 2;

            // if(c == 0)
            //     Console.WriteLine("Четное");
            //else
            //    Console.WriteLine("нечетное");

            Console.WriteLine("Введите число для проверки:");
            byte x = Convert.ToByte(Console.ReadLine());
            byte n = (byte)(x << 7);

            if (n == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }









            Console.ReadKey();
        }
    }
}
