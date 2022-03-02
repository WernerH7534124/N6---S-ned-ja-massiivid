using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere!");
            Console.WriteLine(" ");

            //Programm ennustab, mis juhtub homme kasutajaga (Random)

            string[] predictions = { "võidad loteriiga", "kukud auku", "leiad armastuse", "tuleb hea päev", "annab Apple su kohtusse", "saad klaveriga vastu pead"};

            Console.WriteLine("Tahad teada, mis sinuga homme juhtub?");
            Console.WriteLine(" ");

            Random rnd = new Random();
            int userChoice = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Homme {predictions[userChoice]}!");

            Console.WriteLine(" ");

            Console.WriteLine("Tule varsti jälle!");

        }
    }
}
