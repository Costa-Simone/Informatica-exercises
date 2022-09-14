using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6pag66
{
    class Program
    {
        const int max = 100;
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] a = new int[max];
            int[] b = new int[max];
            int[] c = new int[max];
            int n;

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

            prodottoVett(a, b, c, n);

            stampaVett(c, n);

            Console.ReadKey();
        }
        private static void prodottoVett(int[] a, int[] b, int[] c, int n)
        {
            for (int i = 0; i < n; i++)
            {
                c[i] = a[i] * b[i];
            }
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
                Console.WriteLine("Il " + i.ToString() + "^ del vettore é: " + v[i].ToString());
            }
        }
        
    }
}
