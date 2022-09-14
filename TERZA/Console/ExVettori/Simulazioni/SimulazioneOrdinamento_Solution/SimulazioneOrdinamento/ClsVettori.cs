using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulazioneOrdinamento
{
    class ClsVettori
    {
        static Random rnd = new Random();
        public static void attesaTasto()
        {
            Console.WriteLine("\n\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        public static int inputDimensione(string messaggio)
        {
            int n;

            do
            {
                Console.Write(messaggio);
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Devi inserire un numero > 0!");
                }
            }
            while (n <= 0);
            return n;
        }
        internal static void ordinaScambio(int[] a, ref long passi, ref long confronti, ref long scambi)

        {
            int i = -1, aus;
            bool scambio;

            do
            {
                passi++;
                i++;
                scambio = false;

                for (int j = a.Length - 2; j >= i; j--)
                {
                    confronti++;
                    if (a[j] > a[j + 1])
                    {
                        scambi++;
                        aus = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = aus;
                        scambio = true;
                    }
                }
            } while (i != a.Length - 2 && scambio);
        }
        internal static void ordinaSelezione(int[] a, ref long passi, ref long confronti, ref long scambi)
        {
            int PosMin, aus;

            for (int i = 0; i <= a.Length-2; i++)
            {
                passi++;
                PosMin = i;

                for (int j = i + 1; j <= a.Length-1; j++)
                {
                    confronti++;
                    if (a[PosMin] > a[j])
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    scambi++;
                    aus = a[i];
                    a[i] = a[PosMin];
                    a[PosMin] = aus;
                }
            }
        }
        public static void stampaVet(int[] v, string nome)
        {
            Console.Write(nome + ": ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i].ToString().PadRight(6));
            }
        }
        public static void caricaVet(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
                v[i] = rnd.Next(1, 100000);
        }
    }
}
