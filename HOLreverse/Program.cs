using System;

namespace HOLreverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("  ");

            //Programm kuvab lauset "Hello World!" tagurpidi

            string lause = "Hello World!";

            for (int i = lause.Length - 1; i >= 0; i--)
            {
                Console.Write(lause[i]);
            }
            Console.WriteLine("  ");
        }
    }
}

