using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4pag84
{
    class Program
    {
        const int max = 100;
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] a = new int[max];
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

            stampaVett(a, n);

            MinAndMaxVett(a, n);

            Console.ReadKey();
        }
        private static void MinAndMaxVett(int[] a, int n)
        {
            int min = max, massimo = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
                else if (a[i] > massimo)
                {
                    massimo = a[i];
                }
            }

            Console.WriteLine("Il minimo é " + min.ToString() + " e il massimo é " + massimo.ToString());
        }
        static void caricaVett(int[] v, int n)
        {
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1, 100);
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
