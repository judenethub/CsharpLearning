using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Введите два числа и знак арифметической операции\nПервое число");
            
            int operand1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Второе число");

            int operand2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Знак");

            string znak = Console.ReadLine();
            Console.Write("Ответ = ");

            switch (znak)
            {

                case "+":
                    {
                        Console.WriteLine(operand1 + operand2);
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine(operand1 - operand2);
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(operand1 * operand2);
                        break;
                    }
                case "/":
                    {
                        if (operand2 != 0)
                            Console.WriteLine(operand1 / operand2);
                        else
                            Console.WriteLine("Нельзя делить на ноль!");

                        break;
                    }
            }





           
            Console.ReadKey();
        }
    }
}
