using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dato un vettore di interi di dimensione N, calcolare la somma dei prodotti degli elementi speculari.
// Se N è dispari l’elemento centrale viene moltiplicato per se stesso prima di essere sommato (es. se ho [1,2,3,4,5] si deve calcolare 1*5+2*4+3*3)

namespace Ex13
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = rnd.Next(2, 11), somma = 0;
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(0, 11);
            }

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + "  ");
            }

            for (int i = 0; i < v.Length / 2; i++)
            {
                somma += v[i] * v[v.Length - 1 - i];
            }

            if (n % 2 == 1)
            {
                somma += v[v.Length / 2] * v[v.Length / 2];
            }

            Console.WriteLine("\n\n" + somma);
            Console.ReadKey();
        }
    }
}
