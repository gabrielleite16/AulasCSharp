using System;

namespace HelloWorld
{
    class Program
    {
        // Linha única usamos duas barras;
        /*
         para comentários
         com mais de uma linha;
        */
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.WriteLine("What is your football team?");
            var name2 = Console.ReadLine();
            Console.WriteLine($"\nWow, {name2}, is the best football team in Brazil!");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        } // Fim do método Main
    } // Fim da classe Program
} // Fim do namespace HelloWorld
