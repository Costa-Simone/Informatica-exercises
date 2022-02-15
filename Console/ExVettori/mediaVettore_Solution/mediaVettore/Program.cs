using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaVettore
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("\nInserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            int[] a = new int[n];
            caricaVett(a, n);
            stampaVett(a, n, "Stampa vettore a");
            double media = mediaVettore(a, n);
            Console.WriteLine("\nLa media vale: " + media);

            Console.ReadKey();

        }
        private static double mediaVettore(int[] v, int n)
        {
            int som = 0;
            double media = 0;

            for (int i = 0; i < n; i++)
            {
                som += v[i];
            }
            media = (double)som / n;

            return media;
        }
        static void caricaVett(int[] v, int n)
        {
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1, 11);
            }
        }
        static void stampaVett(int[] v, int n, string name)
        {
            Console.WriteLine("\n" + name + ":");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i].ToString().PadRight(6));
            }
        }
    }
}
