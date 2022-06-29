using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Simulare il lancio del dado, generando in modo casuale i numeri dallo 0 al 6, finché viene generato 0. Visualizzare le frequenze assolute dei vari numeri e il numero totale di
// lanci effettuati (escluso lo 0 che serve solo per terminare i lanci)

namespace Ex06
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n, cont = 0;
            int[] freq = new int[6];

            do
            {
                n = rnd.Next(0, 7);

                if (n != 0)
                {
                    freq[n - 1]++;
                    cont++;
                }
            } while (n != 0);

            Console.WriteLine("I lanci sono stati " + cont + " e le frequenze sono:\n");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Il numero " + (i + 1) + " e' apparso " + freq[i] + " volte");
            }

            Console.ReadKey();
        }
    }
}
