using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere!");
            Console.WriteLine("  ");

            //Programm küsib kasutaja ees- ja perekonnanime
            //Programm kuvab mitu a-tähte on kasutaja ees või perekonnanimes

            Console.WriteLine("Kuidas on teie eesnimi?");
            string eesNimi = Console.ReadLine().ToLower();
            Console.WriteLine("  ");
            Console.WriteLine("Kuidas on teie perekonnanimi?");
            string perekNimi = Console.ReadLine().ToLower();
            Console.WriteLine("  ");

            int aCount = 0;

            for (int i = 0; i < eesNimi.Length; i++)
            {
                Console.WriteLine(eesNimi[i]);
                if (eesNimi[i] == 'a')
                {
                    aCount++;
                }
                
            }

            Console.WriteLine("  ");

            for (int i = 0; i < perekNimi.Length; i++)
            {
                Console.WriteLine(perekNimi[i]);
                if (perekNimi[i] == 'a')
                {
                    aCount++;
                }
            }
            Console.WriteLine("  ");
            Console.WriteLine($"Teie nimes on 'a' tähtesid {aCount} tükki");


        }
    }
}


