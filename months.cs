using System;


namespace ConsoleApp1
{
    class Program
    {
        public static void Main(String[] args)
        {
             string[] month = {"January","February","March","April","May","June","July","August","September","October","November","December"};
            int i = 0;
            while (i < month.Length)
            {
                string userMonth = Console.ReadLine();
                if (userMonth == month[i])
                {
                    i++;
                    Console.WriteLine("ok");
                }
                else
                {
                    if (i == 4 & userMonth != month[5]) { Console.WriteLine("Finish"); break; }
                    Console.WriteLine("try again");
                    continue;

                }

            }
            




            
            Console.ReadKey();
        }
    }
}