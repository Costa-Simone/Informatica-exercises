using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insiemistica
{
    class ClsVettori
    {
        static Random rnd = new Random();
        /// <summary>
        /// Permette di introdurre un numero controllando che il valore sia maggiore di 0.
        /// </summary>
        /// <param name="messaggio"> Il messaggio per l'utente </param>
        /// <returns> Il numero introdotto </returns>
        public static int inputDimensione(string messaggio)
        {
            int n;

            do
            {
                Console.Write(messaggio);
                if (!int.TryParse(Console.ReadLine(), out n))
                    Console.WriteLine("Devi inserire un numero > 0!");
            } while (n <= 0);

            return n;
        }
        /// <summary>
        /// Permette di caricare un vettore con numeri casuali senza ripetizioni
        /// </summary>
        /// <param name="a"> il vettore da caricare </param>
        /// <param name="min"> il valore minimo </param>
        /// <param name="max"> il valore massimo </param>
        public static void vettoreDiverso(int[] a, int min = 1, int max = 100)
        {
            int aus, j;

            a[0] = rnd.Next(min, max + 1);

            for (int i = 1; i < a.Length; i++)
            {
                do
                {
                    j = 0;

                    aus = rnd.Next(1, 101);

                    while (aus != a[j] && j < i)
                    {
                        j++;
                    }
                } while (a[j] == aus);

                a[i] = aus;
            }
        }
        /// <summary>
        /// Permette di stampare
        /// </summary>
        /// <param name="v"> Il valore da stampare </param>
        /// <param name="n"> il numero di valori da stampare </param>
        /// <param name="nome"> il nome del vettore da scrivere nella descrizione </param>
        public static void stampaVet(int[] v, int n, string nome)
        {
            Console.Write(nome + ": ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i].ToString().PadRight(6));
            }
        }
    }
}
