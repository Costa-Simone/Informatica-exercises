using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dati n e x interi positivi, visualizzare le prime n potenze di x

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci n: ");

            int n = int.Parse(Console.ReadLine());

            Console.Write("Inserisci x: ");

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(x, i));
            }

            Console.ReadKey();
        }
    }
}
