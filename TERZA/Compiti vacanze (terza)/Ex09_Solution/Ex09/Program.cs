using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dato un vettore di 10 numeri interi, sommare fra loro gli elementi di posizione pari e fra loro quelli di posizione dispari.
// Calcolare anche l’ampiezza dell’intervallo dei valori (differenza tra il numero maggiore e il minore).

namespace Ex09
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] v = new int[10];
            int posPar = 0, posDis = 0, min = 101, max = -1;

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(0, 101);

                Console.Write(v[i] + "  ");
            }

            for (int i = 0; i < v.Length; i++)
            {
                if (i % 2 == 0)
                {
                    posPar += v[i];
                }
                else
                {
                    posDis += v[i];
                }

                if (v[i] < min)
                {
                    min = v[i];
                }
                if (v[i] > max)
                {
                    max = v[i];
                }
            }

            Console.WriteLine("\n\nLa somma nelle posizione pari vale " + posPar + ", e nelle dispari vale " + posDis);
            Console.WriteLine("L'ampiezza dell'intervallo vale: " + (max - min));
            Console.ReadKey();
        }
    }
}
