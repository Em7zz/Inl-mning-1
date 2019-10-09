using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal mellan 1-100");
           Random random = new Random();           
           int randomN = random.Next(1, 101);
            int

            int tal1;

            do
            {
                string stNr = Console.ReadLine(); 
                tal1 = int.Parse(stNr);
                if (tal1 < randomN)
                    Console.WriteLine("Du gissa för lågt, försök igen");
                else if (tal1 > randomN)
                    Console.WriteLine("Du gissa för högt, försök igen");

            } while (tal1 != randomN);
            

                Console.WriteLine("Grattis du gissade rätt");
            
        }
    }
}
