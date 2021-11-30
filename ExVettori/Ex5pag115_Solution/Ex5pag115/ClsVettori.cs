using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5pag115
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
        internal static void rottureSuSquadre(string[] squadre, string[] sq, int[] cont)
        {
            int conta = 1, contaSquad = 0;

            for (int i = 0; i < squadre.Length; i++)
            {
                if (squadre[i] == squadre[i + 1])
                {
                    conta++;
                }
                else
                {
                    sq[contaSquad] = squadre[i];
                    cont[contaSquad] = conta;
                    conta = 1;
                }
            }
            sq[contaSquad] = squadre[squadre.Length - 1];
            cont.Append(conta);
        }
        internal static void ordinaScambio(int[] a)
        {
            int i = -1, aus;
            bool scambio;

            do
            {
                i++;
                scambio = false;

                for (int j = a.Length - 2; j >= i; j--)
                {
                    if (a[j] > a[j + 1])
                    {
                        aus = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = aus;
                        scambio = true;
                    }
                }
            } while (i != a.Length - 2 && scambio);
        }
        internal static void ordinaSelezione(string[] c)
        {
            int PosMin;
            string aus;

            for (int i = 0; i <= c.Length - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= c.Length - 1; j++)
                {
                    if (string.Compare(c[PosMin], c[j]) > 0)
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    aus = c[i];
                    c[i] = c[PosMin];
                    c[PosMin] = aus;
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
                v[i] = rnd.Next(1, 10);
        }
        public static void caricaVettRandomOrdinatoDisgiunto(int[] v)
        {
            v[0] = rnd.Next(1, 101);

            for (int i = 1; i < v.Length; i++)
            {
                v[i] = rnd.Next(v[i - 1] + 1, v[i - 1] + 101);
            }
        }
        public static void stampaTab(string[] c, string[] n, string titolo)
        {
            Console.WriteLine();

            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i] + " " + n[i]);
            }
        }
    }
}
