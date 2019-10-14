using System;

namespace ConsoleApp5
{
    class Program
    {
        /*
         * Först skriver datorn ut vad användaren ska göra (Gissa ett tal mellan 1-100) 
         * Datorn väljer ett slumpat mellan 1-100
         * Loopen börjar
         * användaren gissar ett tal
         * Antal gissningar ökar +1
         * Antal gissningar skrivs
         * om gissningen > slumpat tal skriv ut "du gissa för högt"
         * om gissninge < slumpat tal skriv ut "du gissa för lågt"
         * om gissningen == slumpat tal skriv ut "grattis du gissa rätt"
         * Loopen avslutar när gissningen = slumpal
         * programmet skriver ut antal gissningar
         * Programmet avslutas
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal mellan 1-100"); 
            Random random = new Random();
            int randomN = random.Next(1, 101);
            int Gissa;
            int Antalgissningar = 0;


            do
            {
                Gissa = int.Parse(Console.ReadLine()); 

                if (Gissa < randomN)
                {
                    Console.WriteLine("Du gissa för lågt, försök igen");
                    Console.Write("Antal gissningar ");
                }
                else if (Gissa > randomN)
                {
                    Console.WriteLine("Du gissa för högt, försök igen");
                    Console.Write("Antal gissningar ");
                }
                Console.WriteLine(++Antalgissningar);
               
            } while (Gissa != randomN);
            

                Console.WriteLine("Grattis du gissade rätt");
            Console.Write("antal gissningar ");
            Console.WriteLine(Antalgissningar++);
        }
    }
}
