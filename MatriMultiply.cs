using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размерность 1 массива");
            int num1 = Convert.ToInt32(Console.ReadLine()), num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Размерность 2 массива");
            int num3 = Convert.ToInt32(Console.ReadLine()), num4 = Convert.ToInt32(Console.ReadLine());
            int[,] arrayOne = new int[num1, num2], arrayTwo = new int[num3, num4];
            int[,] arrayThree = new int[num1, num4];

            if (num2 == num3)
            {
                for (int i = 0; i < arrayOne.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayOne.GetLength(1); j++)
                    {
                        Console.WriteLine($"строка {i},  cтолбец {j}");
                        arrayOne[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                for (int i = 0; i < arrayTwo.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayTwo.GetLength(1); j++)
                    {
                        Console.WriteLine($"строка {i},  cтолбец {j}");
                        arrayTwo[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Первая матрица");
                for (int i = 0; i < arrayOne.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayOne.GetLength(1); j++)
                    {
                        Console.Write(arrayOne[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("Вторая матрица");
                for (int i = 0; i < arrayTwo.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayTwo.GetLength(1); j++)
                    {
                        Console.Write(arrayTwo[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("Результирующая");

                for (int i = 0; i < num1; i++)
                {
                    for (int k = 0; k < num4; k++)
                    {
                        for (int j = 0; j < num2; j++)
                        {

                            arrayThree[i, k] += arrayOne[i, j] * arrayTwo[j, k];

                        }
                        Console.WriteLine();
                    }
                }




                for (int i = 0; i < num1; i++)
                {
                    for (int j = 0; j < num4; j++)
                    {
                        Console.Write($"  {arrayThree[i, j]}   ");
                    }
                    Console.WriteLine();
                }



            }
            else
            {
                Console.WriteLine("Матрицы невозможно умножить");
            }












            Console.ReadKey();

        }
    }
}
