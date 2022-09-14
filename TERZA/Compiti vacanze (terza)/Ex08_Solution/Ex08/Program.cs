using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data una stringa e un carattere visualizzare quante volte il carattere è contenuto nella stringa.

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci la stringa: ");

            string s = Console.ReadLine().ToLower();

            Console.Write("Insrisci il carattere da cercare: ");

            char c = char.Parse(Console.ReadLine().ToLower());
            int cont = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    cont++;
                }
            }

            Console.WriteLine("\nIl carattere " + c + " appare " + cont + " volte");
            Console.ReadKey();
        }
    }
}
