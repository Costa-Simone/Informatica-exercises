using System;
using System.Diagnostics;

namespace SimulazioneRicerche
{
    class Program
    {
        static Random rnd = new Random();
        static Stopwatch sw = new Stopwatch();
        static void Main(string[] args)
        {
            int n = 500;

            intestazione();

            for (int i = 0; i <= 5; i++)
            {
                int[] a = new int[n];

                ClsVettori.caricaVetRndOrdinatoSenzaRip(a);

                int x = rnd.Next(1, n * 10);

                sw.Start();

                ClsVettori.ricerca_seq3(a, x);

                sw.Stop();
                long seq = sw.Elapsed.Ticks;
                sw.Restart();

                ClsVettori.ricerca_bin(a, x);

                sw.Stop();
                long bin = sw.Elapsed.Ticks;
                sw.Restart();

                int trovato = ClsVettori.ricerca_blocchi(a, x);

                sw.Stop();
                long blo = sw.Elapsed.Ticks;

                scriviValori(n, seq, bin, blo, trovato);

                n *= 10;
            }

            ClsVettori.attesaTasto();
        }
        private static void intestazione()
        {
            Console.WriteLine("\n**** Velocità Ricerca in TICKS ****");
            disegnariga(60);
            Console.WriteLine("\n|" + "N".PadLeft(10)
                + "|" + "SEQ".PadLeft(15)
                + "|" + "BIN".PadLeft(15)
                + "|" + "A BLOCCHI".PadLeft(15)
                );
            disegnariga(60);
        }
        private static void disegnariga(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        private static void scriviValori(int n, long seq, long bin, long blo, int trovato)
        {
            if (trovato == -1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine("\n|" + n.ToString().PadLeft(10)
                + "|" + seq.ToString("N").PadLeft(15)
                + "|" + bin.ToString("N").PadLeft(15)
                + "|" + blo.ToString("N").PadLeft(15)
                );

            Console.ResetColor();
            disegnariga(60);
        }
    }
}
