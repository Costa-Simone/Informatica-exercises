using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_13pag115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] caseEditrici = { "Feltri", "Monda", "Adelphi", "Adelphi", "Feltri", "Feltri", "Monda" };
            string[] nomiLibri = { "Dorian", "princi", "Guerra", "Odisse", "1984", "Il ros", "Faust" };
            string[] generi = { "Horror", "Fantasy", "Triller", "Triller", "Fantasy", "Fantasy", "Horror" };

            stampaTab(caseEditrici, nomiLibri, generi);

            ricercaLibri(caseEditrici, nomiLibri, generi);

            ordinaSelezione(caseEditrici, nomiLibri, generi);
            stampaTab(caseEditrici, nomiLibri, generi);

            ricercaLibri2(caseEditrici, nomiLibri, generi);

            attesaTasto();
        }
        private static void stampaTab(string[] caseEditrici, string[] nomiLibri, string[] generi)
        {
            for (int i = 0; i < nomiLibri.Length; i++)
            {
                Console.Write("Casa editrice: " + caseEditrici[i] + "\t" + " di nome:\t " + nomiLibri[i] + "\t\t genere:\t\t" + generi[i] + "\n");
            }
        }
        public static void attesaTasto()
        {
            Console.WriteLine("\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        public static void ricercaLibri(string[] caseEditrici, string[] nomiLibri, string[] generi)
        {
            Console.WriteLine("\nInserisci la casa editrice: ");
            string editrice = Console.ReadLine();
            Console.WriteLine("\nInserisci il genere: ");
            string genere = Console.ReadLine();

            int cont = 0;

            for (int i = 0; i < caseEditrici.Length; i++)
            {
                if (caseEditrici[i] == editrice && generi[i] == genere)
                {
                    cont++;
                }
            }

            Console.WriteLine("\nIl numero di libri e': " + cont.ToString());
        }
        internal static void ordinaSelezione(string[] caseEditrici, string[] nomiLibri, string[] generi)
        {
            int PosMin;
            string Editrici, nomi, genere;

            for (int i = 0; i <= caseEditrici.Length - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= caseEditrici.Length - 1; j++)
                {
                    if (string.Compare(caseEditrici[PosMin], caseEditrici[j]) > 0)
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    Editrici = caseEditrici[i];
                    nomi = nomiLibri[i];
                    genere = generi[i];
                    caseEditrici[i] = caseEditrici[PosMin];
                    nomiLibri[i] = nomiLibri[PosMin];
                    generi[i] = generi[PosMin];
                    caseEditrici[PosMin] = Editrici;
                    nomiLibri[PosMin] = nomi;
                    generi[PosMin] = genere;
                }
            }
        }
        public static void ricercaLibri2(string[] caseEditrici, string[] nomiLibri, string[] generi)
        {
            Console.WriteLine("\nInserisci la casa editrice: ");
            string editrice = Console.ReadLine();
            Console.WriteLine("\nInserisci il genere: ");
            string genere = Console.ReadLine();

            int i = 0, cont = 0;
            bool superato = false;

            while (!superato && i <= caseEditrici.Length)
            {
                if (caseEditrici[i] == editrice && generi[i] == genere)
                {
                    cont++;
                    i += 1;
                }
                else
                {
                    if (string.Compare(caseEditrici[i], editrice) > 0)
                    {
                        superato = true;
                    }
                    else
                    {
                        i += 1;
                    }
                }
            }

            Console.WriteLine("\nIl numero di libri e': " + cont.ToString());
        }
    }
}
