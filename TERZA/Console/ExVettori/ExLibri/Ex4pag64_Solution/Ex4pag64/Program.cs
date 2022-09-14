using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4pag64
{
    class Program
    {
        const int max = 100;
        static void Main(string[] args)
        {
            int[] a = new int[max];
            int n;
            int massimo = int.MinValue;
            Random rnd = new Random();

            do
            {
                Console.Write("Inserisci la lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Input errato!");
                    n = -1;
                }
            } while (n <= 0 || n > max);

            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1, 1000);
            }

            for (int i = 0; i < n; i++)
            {
                if (a[i] > massimo)
                {
                    massimo = a[i];
                }
            }

            Console.WriteLine("Il massimo vale: " + massimo.ToString());

            Console.ReadKey();
        }
    }
}
