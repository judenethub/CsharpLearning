using System;
using System.Globalization;

namespace Loop
{
    class Program
    {
        static void Main()  // умопомрачительный  ромб
        {

            /*  for (int i = 0; i < 5; i++)
              {
                  for(int j = 0; j < 10; j++)
                  {
                      Console.Write("*");
                  }
                  Console.Write("\n");
              }
            */


            for (int j = 0; j < 14; j++)
            {

                switch (j)
                {
                    case 0:
                        for (int i = 0; i < 8; i++) { Console.Write(" "); }
                            Console.Write("*\n");
                        break;
                    case 1:
                        for (int i = 0; i < 7; i++) { Console.Write(" "); }
                        Console.Write("***\n");
                        break;
                    case 3:
                        for (int i = 0; i < 6; i++) { Console.Write(" "); }
                        Console.Write("*****\n");
                        break;
                    case 4:
                        for (int i = 0; i < 5; i++) { Console.Write(" "); }
                        Console.Write("*******\n");
                        break;
                    case 5:
                        for (int i = 0; i < 4; i++) { Console.Write(" "); }
                        Console.Write("*********\n");
                        break;
                    case 6:
                        for (int i = 0; i < 3; i++) { Console.Write(" "); }
                        Console.Write("***********\n");
                        break;
                    case 7:
                        for (int i = 0; i < 2; i++) { Console.Write(" "); }
                        Console.Write("*************\n");
                        break;
                    case 8:
                        for (int i = 0; i < 3; i++) { Console.Write(" "); }
                        Console.Write("***********\n");
                        break;
                    case 9:
                        for (int i = 0; i < 4; i++) { Console.Write(" "); }
                        Console.Write("*********\n");
                        break;
                    case 10:
                        for (int i = 0; i < 5; i++) { Console.Write(" "); }
                        Console.Write("*******\n");
                        break;
                    case 11:
                        for (int i = 0; i < 6; i++) { Console.Write(" "); }
                        Console.Write("*****\n");
                        break;
                    case 12:
                        for (int i = 0; i < 7; i++) { Console.Write(" "); }
                        Console.Write("***\n");
                        break;
                    case 13:
                        for (int i = 0; i < 8; i++) { Console.Write(" "); }
                        Console.Write("*\n");
                        break;

                       
                }







                
            }
                // Delay.
                Console.ReadKey();

        }
    }

}