using System;
using System.Globalization;

namespace Loop
{
    class Program
    {
        static void Main()
        {

            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string result = $"Hello {surname} {name}!\nIt`s a good day today! ";
            Console.WriteLine(result);
            
            Console.ReadKey();
        }

    }
}