using System;


namespace ConsoleApp1
{
    class Program
    {
        public static void Main(String[] args)
        {
             string[,,] biblio = new string[5, 10, 10];
            biblio[1, 5, 8] = "Буратино";
            biblio[3, 6, 2] = "Алиса";
            biblio[4, 4, 0] = "Шапка";
            Console.WriteLine("Название книги");
            string userBook = Console.ReadLine();

            for (int z = 0; z < biblio.GetLength(0); z++)
            {
                for (int y = 0; y < biblio.GetLength(1); y++)
                {
                    for (int x = 0; x < biblio.GetLength(2); x++)
                    {
                        if (biblio[z, y, x] == userBook )
                        {
                            Console.WriteLine($"книга {userBook} находится на {z} стеллаже, {y} полке и {x} слева ");
                        }
                    }
                }
            }






            Console.ReadKey();
        }
    }
}