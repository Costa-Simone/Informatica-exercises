using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5pag65
{
    class Program
    {
        const int max = 100;

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] a = new int[max];
            int[] b = new int[max];
            int n, ps = 0;

            do
            {
                Console.Write("Inserisci la lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Input errato!");
                    n = -1;
                }
            } while (n <= 0 || n > max);

            caricaVett(a, n);
            caricaVett(b, n);

            for (int i = 0; i < n; i++)
            {
                ps += (a[i] * b[i]);
            }

            Console.WriteLine("Il prodotto scalare vale: " + ps.ToString());

            Console.WriteLine("Stampa vettore a: ");
            stampaVett(a, n);
            Console.WriteLine("Stampa vettore b: ");
            stampaVett(b, n);

            Console.ReadKey();
        }

        static void caricaVett(int[] v, int n)
        {
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1, 11);
            }
        }

        static void stampaVett(int[] v, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(v[i].ToString());
            }
        }
    }
}
