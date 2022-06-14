using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dati n e x interi positivi, visualizzare i primi n multipli di x

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x;

            Console.Write("Inserisci n: ");

            n = int.Parse(Console.ReadLine());

            Console.Write("Inserisci x: ");

            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.Write((n * i) + " ");
            }

            Console.ReadKey();
        }
    }
}
