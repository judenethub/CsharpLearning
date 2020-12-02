using System;
using System.Globalization;

namespace Loop
{
    class Program
    {
        static void Main()
        {
            char rand = Convert.ToChar(Console.ReadLine());  

            int mask = 216;

            char changed = Convert.ToChar(rand ^ mask);

            char unchanged = Convert.ToChar(changed ^ mask);



            Console.WriteLine($"{rand} меняется маской {mask} на {changed} и обратно  становится {unchanged}   ");


            Console.ReadKey();
        }

    }
}
