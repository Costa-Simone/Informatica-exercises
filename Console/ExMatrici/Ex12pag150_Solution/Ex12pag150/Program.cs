using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12pag150
{
    class Program
    {
        static string[] atleti = { "atl1", "atl2", "atl3", "atl4", "atl5" };
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            const int nSalti = 5;
            int[,] salti = new int[nSalti, atleti.Length];
            int[] punti = new int[atleti.Length];
            string[] copia = new string[atleti.Length];

            Array.Copy(atleti, copia, atleti.Length);

            caricaMat(salti);

            for (int i = 0; i < nSalti; i++)
            {
                classifica(salti, atleti, i, copia, punti);
            }

            Console.ReadKey();
        }
        private static void classifica(int[,] salti, string[] atleti, int colonna, string[] copia, int[] punti)
        {
            ordina(salti, colonna, atleti, copia);
            assegnaPunti(copia, punti, atleti);
            stampaClassifica(atleti, punti, colonna);
            stampaAtleti(atleti);
        }
        private static void stampaClassifica(string[] atleti, int[] punti, int colonna)
        {
            ordinaPunti(atleti, punti);

            Console.WriteLine("Prova n " + colonna.ToString());
            for (int i = 0; i < atleti.Length; i++)
            {
                Console.WriteLine(atleti[i] + "\t con punti: " + punti[i].ToString() + "\n");
            }
        }
        private static void ordinaPunti(string[] atleti, int[] punti)
        {
            int PosMin, aus;
            string atleta;

            for (int i = 0; i <= atleti.Length - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j < atleti.Length - 1; j++)
                {
                    if (punti[PosMin] < punti[j])
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    aus = punti[i];
                    atleta = atleti[i];
                    punti[i] = punti[PosMin];
                    atleti[i] = atleti[PosMin];
                    punti[PosMin] = aus;
                    atleti[PosMin] = atleta;
                }
            }
        }
        private static void assegnaPunti(string[] copia, int[] punti, string[] atleti)
        {
            for (int i = 0; i < copia.Length; i++)
            {
                int pos = cerca(copia[i], atleti);

                punti[pos] += 5 - i;
            }
        }
        private static int cerca(string v, string[] atleti)
        {
            int i = 0;

            while (atleti[i] != v)
            {
                i++;
            }

            return i;
        }
        private static void ordina(int[,] salti, int colonna, string[] atleti, string[] copia)
        {
            int PosMin, aus;
            string atleta;

            for (int i = 0; i <= salti.GetLength(1) - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j < salti.GetLength(1) - 1; j++)
                {
                    if (salti[PosMin, colonna] < salti[j, colonna])
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    aus = salti[i, colonna];
                    atleta = copia[i];
                    salti[i, colonna] = salti[PosMin, colonna];
                    copia[i] = copia[PosMin];
                    salti[PosMin, colonna] = aus;
                    copia[PosMin] = atleta;
                }
            }
        }
        private static void stampaAtleti(string[] atleti)
        {

        }
        public static void caricaMat(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = rnd.Next(200, 250);
                }
            }
        }
    }
}
