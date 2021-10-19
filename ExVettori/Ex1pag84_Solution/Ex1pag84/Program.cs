using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1pag84
{
    class Program
    {
        const int max = 100;
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] a = new int[max];
            int[] b = new int[max];
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

            copiaVett(a, b, n);

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
                Console.WriteLine("Il " + i.ToString() + "^ del vettore é: " + v[i].ToString());
            }
        }
        private static void copiaVett(int[] a, int[] b, int n)
        {
            for (int i = 0; i < n; i++)
            {
                b[i] = a[i];
            }
        }
    }
}
