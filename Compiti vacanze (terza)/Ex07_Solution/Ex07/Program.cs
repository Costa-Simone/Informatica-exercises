using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data una stringa di caratteri, invertirne il contenuto (PIPPO diventa OPPIP)

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci la stringa: ");

            char[] s = Console.ReadLine().ToCharArray();

            Array.Reverse(s);

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
