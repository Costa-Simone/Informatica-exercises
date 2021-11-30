using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuVettori
{

    class ClsVettori
    {
        static Random rnd = new Random();
        /// <summary>
        /// Esegue il caricamento di un vettore con numeri casuali compresi tra min e max
        /// </summary>
        /// <param name="v"> Il vettore da caricare. </param>
        /// <param name="min"> Il valore minimo (incluso); se non fornito sarà inizializzato ad 1 </param>
        /// <param name="max"> Il valore massimo (incluso); se non fornito sarà inizializzato ad 10 </param>
        public static void caricaVett(int[] v, int min = 1, int max = 10)
        {
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(min, max + 1);
            }
        }
        /// <summary>
        /// Esegue il caricamento di un vettore con numeri inseriti manualmente compresi tra min e max
        /// </summary>
        /// <param name="v"> Il vettore da caricare. </param>
        public static void caricaVettManuale(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine("\nInserire il " + i + "^ valore: ");
                v[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void stampaVett(int[] v, string name)
        {
            Console.WriteLine("\n" + name + ":");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i].ToString().PadRight(6));
            }
        }
        public static void caricaVettOrdinato()
        {
            Console.Clear();
            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: ");

            a = new int[n];

            do
            {
                Console.Write("\nInserire il 1^ valore del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out a[0]))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    a[0] = -1;
                }
            } while (a[0] <= 0);

            for (int i = 1; i < a.Length; i++)
            {
                do
                {
                    do
                    {
                        Console.Write("\nInserire il " + (i + 1) + "^ valore del vettore: ");
                        if (!int.TryParse(Console.ReadLine(), out a[i]))
                        {
                            Console.WriteLine("Inserire numero intero: ");
                            a[i] = -1;
                        }
                    } while (a[i] <= 0);

                } while (a[i] <= a[i - 1]);
            }

            ClsVettori.stampaVett(a, "Stampa vettore a");
        }
        public static void caricaVettRandomOrdinato()
        {
            Console.Clear();
            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: ");

            a = new int[n];

            a[0] = rnd.Next(1, 1001);

            for (int i = 1; i < a.Length; i++)
            {
                do
                {
                    a[i] = rnd.Next(1, 1001);

                } while (a[i] < a[i - 1]);
            }

            ClsVettori.stampaVett(a, "Stampa vettore a");
        }
        public static void caricaVettRandomOrdinatoDisgiunto()
        {
            Console.Clear();

            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: ");

            a = new int[n];

            a[0] = rnd.Next(1, 101);

            for (int i = 1; i < a.Length; i++)
            {
                a[i] = rnd.Next(a[i - 1] + 1, a[i - 1] + 101);
            }

            ClsVettori.stampaVett(a, "Stampa vettore a");
        }
    }
}
