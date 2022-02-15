using System;
using System.Diagnostics;

namespace SimulazioneOrdinamento
{
    class Program
    {
        static Random rnd = new Random();
        static Stopwatch sw = new Stopwatch();
        static void Main(string[] args)
        {
            int n = 500;

            titolo("(su insieme disordinato) ");

            for (int i = 0; i <= 2; i++)
            {
                intestazione(n);

                int[] a = new int[n];
                int[] b = new int[n];

                long selPassi = 0, selConfronti = 0, selScambi = 0;
                long selTicks;

                long scaPassi = 0, scaConfronti = 0, scaScambi = 0;
                long scaTicks;

                ClsVettori.caricaVet(a);
                a.CopyTo(b, 0);

                sw.Start();

                ClsVettori.ordinaSelezione(a, ref selPassi, ref selConfronti, ref selScambi);

                sw.Stop();
                selTicks = sw.Elapsed.Ticks;
                sw.Restart();

                ClsVettori.ordinaScambio(b, ref scaPassi, ref scaConfronti, ref scaScambi);

                sw.Stop();
                scaTicks = sw.Elapsed.Ticks;

                scriviValori("Numero di passi", selPassi, scaPassi);
                scriviValori("Numero di confronti", selConfronti, scaConfronti);
                scriviValori("Numero di scambi", selScambi, scaScambi);
                scriviValori("Ticks impiegato", selTicks, scaTicks);

                n *= 10;
            }

            ClsVettori.attesaTasto();
            Console.Clear();

            n = 500;

            titolo("(su insieme parzialmente ordinato) ");

            for (int i = 0; i <= 2; i++)
            {
                intestazione(n);

                int[] a = new int[n];
                int[] b = new int[n];

                long selPassi = 0, selConfronti = 0, selScambi = 0;
                long selTicks;

                long scaPassi = 0, scaConfronti = 0, scaScambi = 0;
                long scaTicks;

                ClsVettori.caricaVet(a);
                ClsVettori.ordinaSelezione(a, ref selPassi, ref selConfronti, ref selScambi);
                a.CopyTo(b, 0);

                a[n - 1] = rnd.Next(1, 100000);
                b[n - 1] = rnd.Next(1, 100000);

                sw.Start();

                ClsVettori.ordinaSelezione(a, ref selPassi, ref selConfronti, ref selScambi);

                sw.Stop();
                selTicks = sw.Elapsed.Ticks;
                sw.Restart();

                ClsVettori.ordinaScambio(b, ref scaPassi, ref scaConfronti, ref scaScambi);

                sw.Stop();
                scaTicks = sw.Elapsed.Ticks;

                scriviValori("Numero di passi", selPassi, scaPassi);
                scriviValori("Numero di confronti", selConfronti, scaConfronti);
                scriviValori("Numero di scambi", selScambi, scaScambi);
                scriviValori("Ticks impiegato", selTicks, scaTicks);

                n *= 10;
            }

            ClsVettori.attesaTasto();
        }
        private static void titolo(string sottotitolo)
        {
            disegnariga(65);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|".PadRight(13) + " Confronto tra algoritmi di ordinamento" + "|".PadLeft(13));
            Console.WriteLine("|".PadRight(32 - sottotitolo.Length / 2) + sottotitolo + "|".PadLeft(32 - sottotitolo.Length / 2));
            Console.ResetColor();
            disegnariga(65);
        }
        private static void intestazione(int n)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|" + ("Ordinamento di " + n.ToString("N0") + " elementi").PadLeft(30)
                + "|" + "PER SELEZIONE".PadLeft(15)
                + "|" + "PER SCAMBIO".PadLeft(15)
                );
            Console.ResetColor();
            disegnariga(65);
        }
        private static void disegnariga(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        private static void scriviValori(string desc, long sel, long scambio)
        {
            Console.WriteLine("\n|" + desc.PadLeft(30)
                + "|" + sel.ToString("N0").PadLeft(15)
                + "|" + scambio.ToString("N0").PadLeft(15)
                );

            Console.ResetColor();
            disegnariga(65);
        }
    }
}
