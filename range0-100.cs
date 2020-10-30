using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)    //  Угадывание диапазона числа от 1 до 100
        {

            Console.WriteLine("Введите число от 1 до 100");
            int number = Convert.ToInt32(Console.ReadLine());

                if (number>0 & number<100)

                     {
                         string  c = number < 15 ? "0 - 15" : number < 30 ? "15 - 30" : number < 50 ? "30-50" : "50 - 100";
                         Console.WriteLine(c);
                     }

                else
                     {
                         Console.WriteLine("Вы ввели неправильное число");
                     }

         Console.ReadKey();
        }
    }
}
