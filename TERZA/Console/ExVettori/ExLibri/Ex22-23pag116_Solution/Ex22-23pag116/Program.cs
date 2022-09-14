using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22_23pag116
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            string[] cantanti = { "c1", "c2", "c3", "c4", "c5", "c6", "c7" };
            string[] canzoni = { "can1", "can2", "can3", "can4", "can5", "can6", "can7" };
            int[] punteggio = new int[7];

            caricaVett(punteggio);
            
            stampaTab(cantanti, canzoni, punteggio);

            ordinaCantanti(cantanti, canzoni, punteggio);

            Console.WriteLine("\nLa classifica é:\n");

            stampaTab(cantanti, canzoni, punteggio);

            Console.WriteLine("\nI cantanti vincitori:");

            topCantanti(cantanti, canzoni, punteggio);

            attesaTasto();
        }
        private static void topCantanti(string[] cantanti, string[] canzoni, int[] punteggio)
        {
            int i = punteggio.Length - 2;
            bool cambio = false;

            Console.WriteLine("\n" + cantanti[punteggio.Length - 1] + " " + canzoni[punteggio.Length - 1]);

            while (!cambio && i >= 0)
            {
                if (punteggio[i] != punteggio[i + 1])
                {
                    cambio = true;
                }
                else
                {
                    Console.WriteLine("\n" + cantanti[i] + canzoni[i]);
                }

                i--;
            }
        }
        private static void ordinaCantanti(string[] cantanti, string[] canzoni, int[] punteggio)
        {
            int PosMin, aus;
            string cantante, canzone;

            for (int i = 0; i <= punteggio.Length - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= punteggio.Length - 1; j++)
                {
                    if (punteggio[PosMin] > punteggio[j])
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    aus = punteggio[i];
                    cantante = cantanti[i];
                    canzone = canzoni[i];
                    punteggio[i] = punteggio[PosMin];
                    cantanti[i] = cantanti[PosMin];
                    canzoni[i] = canzoni[PosMin];
                    punteggio[PosMin] = aus;
                    cantanti[PosMin] = cantante;
                    canzoni[PosMin] = canzone;
                }
            }
        }
        static void caricaVett(int[] punteggio)
        {
            for (int i = 0; i < punteggio.Length; i++)
            {
                punteggio[i] = rnd.Next(1, 100);
            }
        }
        public static void attesaTasto()
        {
            Console.WriteLine("\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        private static void stampaTab(string[] cantanti, string[] canzoni, int[] punteggio)
        {
            for (int i = 0; i < punteggio.Length; i++)
            {
                Console.Write("Cantanti: " + cantanti[i] + "\t" + " con la canzone:\t " + canzoni[i] + "\t\t con voti:\t\t" + punteggio[i] + "\n");
            }
        }
    }
}
