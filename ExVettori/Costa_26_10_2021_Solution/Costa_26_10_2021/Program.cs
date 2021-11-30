using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costa_26_10_2021
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int x, n;
            int[] a;
            
            n = lunghezzaVett();

            a = new int[n];

            caricaVett(a);
            Console.WriteLine("\nStampa del vettore:");
            stampaVett(a);
            Console.WriteLine("\n\nStampa istogramma prima:");
            stampaIsto(a);

            spostaVett(a, n);
            Console.WriteLine("\n\nStampa istogramma dopo:");
            stampaIsto(a);

            Console.ReadKey();
        }
        private static void stampaIsto(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                
                for (int j = 0; j < a[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        private static void spostaVett(int[] a, int n)
        {
            int x, aus;

            do
            {
                Console.Write("\nInserire numero di spostamenti: ");
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    x = -1;
                }
            } while (x <= 0);

            for (int i = 0; i < x; i++)
            {
                aus = a[0];
                for (int j = 0; j < n-1; j++)
                {
                    a[j] = a[j + 1];
                }
                a[n - 1] = aus;
            }

            Console.WriteLine("\nStampa del vettore dopo lo spostamento:");
            stampaVett(a);
        }
        private static void stampaVett(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i].ToString().PadRight(6));
            }
        }
        private static void caricaVett(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 11);
            }
        }
        private static int lunghezzaVett()
        {
            int n;

            do
            {
                Console.Write("Inserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            return n;
        }
    }
}
