using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Convertire un numero decimale in binario usando un vettore

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] v = new int[8];

            do
            {
                Console.Write("Inserisci il numero decimale: ");

                n = int.Parse(Console.ReadLine());
            } while (n < 0 && n > 128);

            for (int i = 0; i < v.Length; i++)
            {
                v[v.Length - i - 1] = n % 2;
                n /= 2;
            }

            Console.WriteLine("\n");

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i]);
            }

            Console.ReadKey();
        }
    }
}
