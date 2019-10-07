using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal mellan 1-100");

            string stNr = Console.ReadLine();
            int tal1 = int.Parse(stNr);
            if (tal1 < 2)
                Console.WriteLine("Du gissa för lågt, försök igen");           
            else if (tal1 > 2)
                Console.WriteLine("Du gissa för högt, försök igen");
            else
                Console.WriteLine("Grattis du gissade rätt");

        }
    }
}
