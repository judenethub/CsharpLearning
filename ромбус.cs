using System;
using System.Globalization;

namespace Loop
{
    class Program
    {
        static void Main()  //  ромбик
        {

            int x = 10,k = x,s = 1;

            for (int a=0; a < x + x + 1; a++)
            {
                    
                if (a<x)
                {   
                    for(int i=0; i<k; i++)
                    {
                        Console.Write(" ");
                    }
                    
                    for (int j = 0; j < s; j++)
                    {
                        Console.Write("*");
                    }

                    k--;
                    s += 2;
                    Console.Write("\n");
                }
                else
                {
                   
                    for (int i = 0; i < k; i++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < s; j++)
                    {
                        Console.Write("*");
                    }

                    s-=2;
                    k++;


                    Console.Write("\n");

                }
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            /*

            Console.WriteLine("Введите первое число:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int y = Convert.ToInt32(Console.ReadLine());

            int z = 1;



            for (int i = 0; i < (x + x + 1); i++)
            {
                if (i < x)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("*");
                    }
                    y -= 1;
                    z += 2;
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("*");
                    }
                    y += 1;
                    z -= 2;
                    Console.WriteLine();
                }
            }

            */











            /* int k = 19, m = 19;
            string z = "*", y = "**";

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" ");   
                }

                Console.Write(z);
                Console.Write("\n");
                if (i < k/2) { m--; z += y; }
                else { m++; }


            }



          int h = 19; string c = " ", d = " ";
          for (int a=19; a>0; a--)
          {

             for (int x=0; x<h; x++)
             {
                  Console.Write("*");
             }

              Console.WriteLine();
              Console.Write(c);
              h -= 2;
              c += d;


          }*/




            Console.ReadKey();
        }
           
    }
}
