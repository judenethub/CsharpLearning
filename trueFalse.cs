using System;
using System.Globalization;

namespace Loop
{
    class Program
    {
        static void Main()
        {

            bool pensioner = false, zanyatost = false, job = true ;
            
            

            bool subsidiya = (pensioner ^ zanyatost ^ job) & ( pensioner & zanyatost ^ job );
            Console.WriteLine(subsidiya);
            Console.ReadKey();
        }

    }
}
