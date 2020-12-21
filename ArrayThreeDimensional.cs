using System;


namespace ConsoleApp1
{
    class Program
    {
        public static void Main(String[] args)
        {
            string[,,,] biblio = new string[3, 5, 10, 10];
            biblio[0, 3, 8, 5] = "Буратино";
            biblio[1, 2, 6, 1] = "Пеппа";
            biblio[2, 4, 1, 3] = "CLR";
            int k = 0;

            string userWant = Console.ReadLine();

            string[] all = new string[20];
            for (int w = 0; w < biblio.GetLength(0); w++)
            {
                for (int z = 0; z < biblio.GetLength(1); z++)
                {
                    for (int y = 0; y < biblio.GetLength(2); y++)
                    {
                        for (int x = 0; x < biblio.GetLength(3); x++)
                        {
                            if (biblio[w, z, y, x] == userWant)
                            {
                                Console.WriteLine( $"Книга {userWant} находится в {w}  кмнате  на {z} стеллаже  на {y} полке {x} слева  ");
                            }
                            if (biblio[w,z,y,x] != null & biblio[w, z, y, x] != userWant) 
                            {
                                
                                    all[k] = biblio[w, z, y, x];
                                    k++;
                                
                            }

                        }
                    }
                }
            }
            Console.WriteLine("\nТакже имеются книги:\n");
            for (int w = 0; w < all.Length; w++)
            {
                Console.WriteLine(all[w]);
            }


            Console.ReadKey();
        }
    }
}
