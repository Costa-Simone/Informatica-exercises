using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n5_5_pag116
{
    class ClsEsercizio
    {
        // Overload del metodo
        public static void stampaTab(string[] c, string[] n, string[] s)
        {
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i] + "\t" + n[i] + "\t(" + s[i] + ")");
            }
        }
        // Overload del metodo
        public static void stampaTab(string[] cogn, string[] nomi, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(cogn[i] + "\t" + nomi[i]);
            }
        }
        public static void stampaTab(string[] sq, int[] cont, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sq[i] + "\t" + cont[i]);
            }
        }
        internal static int cercaSquadra(string[] cognomi, string[] nomi, string[] squadre, string[] cognomiCopia, string[] nomiCopia, string sq)
        {
            // Ricerca sequanziale sui insieme disordinato con duplicati
            int j = 0;
            for (int i = 0; i < squadre.Length; i++)
            {
                if (squadre[i] == sq)
                {
                    cognomiCopia[j] = cognomi[i];
                    nomiCopia[j] = nomi[i];
                    j++;
                }
            }
            return j;
        }
        internal static void ordinaSquadra(string[] cognomiCopia, string[] nomiCopia, int n)
        {
            bool scambio;
            int i = -1;
            do
            {
                i++;
                scambio = false;
                for (int j = n - 2; j >= i; j--)
                {
                    if (cognomiCopia[j].CompareTo(cognomiCopia[j + 1]) > 0)
                    {
                        string aus = cognomiCopia[j];
                        cognomiCopia[j] = cognomiCopia[j + 1];
                        cognomiCopia[j + 1] = aus;
                        aus = nomiCopia[j];
                        nomiCopia[j] = nomiCopia[j + 1];
                        nomiCopia[j + 1] = aus;
                        scambio = true;
                    }
                }
            } while (i != n - 2 && scambio);
        }
        internal static int rotturaSuSquadra(string[] squadre, string[] squadreNonDuplicate, int[] numGiocatoriSquadra)
        {
            int contaSquadre = 0;
            int conta = 1;

            for (int i = 0; i < squadre.Length - 1; i++)
            {
                if (squadre[i] == squadre[i + 1])
                {
                    conta++;
                }
                else
                {
                    squadreNonDuplicate[contaSquadre] = squadre[i];
                    numGiocatoriSquadra[contaSquadre] = conta;
                    conta = 1;
                    contaSquadre++;
                }
            }
            squadreNonDuplicate[contaSquadre] = squadre[squadre.Length - 1];
            numGiocatoriSquadra[contaSquadre] = conta;
            contaSquadre++;

            return contaSquadre;
        }
        internal static void ordinaSquadra(string[] sq)
        {
            for (int i = 0; i < sq.Length - 1; i++)
            {
                int posMin = i;
                for (int j = i + 1; j < sq.Length; j++)
                {
                    if (sq[posMin].CompareTo(sq[j]) > 0)
                    {
                        posMin = j;
                    }
                }
                if (posMin != i)
                {
                    string aus = sq[i];
                    sq[i] = sq[posMin];
                    sq[posMin] = aus;
                }
            }
        }
    }
}
