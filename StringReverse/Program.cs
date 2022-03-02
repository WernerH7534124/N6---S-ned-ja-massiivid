using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere!");
            Console.WriteLine("  ");

            //Programm kuvab kasutaja eesnime tagurpidi

            Console.WriteLine("Kuidas on teie eesnimi?");
            string eesNimi = Console.ReadLine();

            for(int i = eesNimi.Length-1; i>=0; i--)
            {
                Console.Write(eesNimi[i]);
                
            }      
        }
    }
}
