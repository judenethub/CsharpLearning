using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)  {

            int years = Convert.ToInt16(Console.ReadLine()); // года

            /*   if (years>0 && years<5)
                   Console.WriteLine("Премия 10 %");
                   else if(years >= 5 && years < 10)
                       Console.WriteLine("Премия 15 %");
                   else if (years >= 10 && years < 15)
                       Console.WriteLine("Премия 25 %");
                   else if (years >= 15 && years < 20)
                       Console.WriteLine("Премия 35 %");
                   else if (years >= 20 && years < 25)
                       Console.WriteLine("Премия 45 %");
                   else if (years >= 25)
                       Console.WriteLine("Премия 50 %");
               else
                   Console.WriteLine("Вы ввели некорректное число");
            */

            string bonus =  (years > 0 && years < 5) ? "Премия 10 %" : (years >= 5 && years < 10) ? "Премия 15 %" : (years >= 10 && years < 15) ? "Премия 25 %" : (years >= 15 && years < 20) ? "Премия 35 %" : (years >= 20 && years < 25) ? "Премия 45 %" : (years >= 25) ? "Премия 50 %" : "Вы ввели некорректное число";

            Console.WriteLine(bonus);





            Console.ReadKey();
        }
    }
}
