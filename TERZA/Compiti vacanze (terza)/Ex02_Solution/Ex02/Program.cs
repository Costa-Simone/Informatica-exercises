using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dati dei minuti visualizzare a quante settimane, giorni, ore e minuti corrispondono

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il numero di minuti: ");

            double input = double.Parse(Console.ReadLine());
            
            Console.WriteLine("\nSettimane: " + (input / 60 / 24 / 7) + "\nGiorni: " +  (input / 60 / 24) + "\nOre: " + (input / 60) + "\nMinuti: " + input);

            Console.ReadKey();
        }
    }
}
