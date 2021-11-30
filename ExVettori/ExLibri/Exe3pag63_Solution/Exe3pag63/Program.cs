using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe3pag63
{
    class Program
    {
        const int max = 100;
        static void Main(string[] args)
        {
            int[] a = new int[max];
            int n;
            double somma = 0;

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
                Console.Write("Inserisci il valore in posizione " + i.ToString() + ":");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                somma += a[i];
            }

            Console.WriteLine("La media vale: " + (somma / n).ToString());

            Console.ReadKey();
        }
    }
}
