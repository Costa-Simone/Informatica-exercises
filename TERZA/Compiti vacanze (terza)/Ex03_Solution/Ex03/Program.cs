using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data un’ora sotto forma di reale (8.30) calcolare a quanti secondi corrisponde (devi ottenere la parte intera con Int)

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci l'ora: ");

            string input = Console.ReadLine();
            string[] campi = input.Split('.');
            int sec = int.Parse(campi[1]) * 60 + int.Parse(campi[0]) * 60 * 60;

            Console.WriteLine("\nLe " + input + " corrispondono a " + sec + " secondi");

            Console.ReadKey();
        }
    }
}
