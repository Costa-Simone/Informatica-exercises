using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insiemistica
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //esercizi 24 - 25 - 26 pag.85
            int[] a, b, d;
            int k;

            int n = ClsVettori.inputDimensione("Inserisci la lunghezza del vettore a: ");
            a = new int[n];
            int m = ClsVettori.inputDimensione("Inserisci la lunghezza del vettore b: ");
            b = new int[m];
            d = new int[n + 1];

            int[] c = new int[n + m];

            ClsVettori.vettoreDiverso(a);
            ClsVettori.stampaVet(a, a.Length, "\nVettore a");
            ClsVettori.vettoreDiverso(b);
            ClsVettori.stampaVet(b, b.Length, "\nVettore b");
            k = intersezione(a, b, c);

            if (k == 0)
            {
                Console.WriteLine("\n\nIntersezione vuota");
            }
            else
            {
                ClsVettori.stampaVet(c, k, "\n\nVettore intersezione");
            }

            k = differenza(a, b, c);

            ClsVettori.stampaVet(c, k, "\n\nStampa differenza: ");

            k = unione(a, b, c);
            
            ClsVettori.stampaVet(c, k, "\n\nStampa unione: ");

            addizioneVettori(a, b, d);

            ClsVettori.stampaVet(d, n, "\n\nStampa vettore d: ");

            Console.ReadKey();
        }

        private static void addizioneVettori(int[] a, int[] b, int[] d)
        {
            int aus = 0;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                d[i] = a[i] + b[i] + aus;
                
                if (d[i] > 10)
                {
                    aus = d[i] / 10;
                    d[i] = d[i] % 10;
                }
            }
        }
        private static int unione(int[] a, int[] b, int[] c)
        {
            int h;

            for (int i = 0; i < b.Length; i++)
            {
                c[i] = b[i];
            }

            h = b.Length;

            for (int i = 0; i < a.Length; i++)
            {
                int j = 0;
                bool aus = false;

                while (aus == false && j < b.Length)
                {
                    if (a[i] != b[j])
                    {
                        aus = true;
                        c[h++] = a[i];
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            return h;
        }
        private static int differenza(int[] a, int[] b, int[] c)
        {
            int h = 0;

            for (int i = 0; i < a.Length; i++)
            {
                int j = 0;
                bool aus = false;

                while (aus == false && j < b.Length)
                {
                    if (a[i] != b[j])
                    {
                        aus = true;
                        c[h++] = a[i];
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            return h;
        }
        private static int intersezione(int[] a, int[] b, int[] c)
        {
            int h = 0;

            for (int i = 0; i < a.Length; i++)
            {
                int j = 0;
                bool aus = false;

                while (aus == false && j < b.Length)
                {
                    if (a[i] == b[j])
                    {
                        aus = true;
                        c[h++] = a[i];
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            return h;
        }
    }
}
