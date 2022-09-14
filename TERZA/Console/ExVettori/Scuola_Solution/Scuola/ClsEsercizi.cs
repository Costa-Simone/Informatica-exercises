using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    class ClsEsercizi
    {
        public static void cercaStudentiClasse(string[] cognomi, string[] nomi, string[] classi)
        {
            Console.Write("Inserisci la classe da cercare: ");
            string cl = Console.ReadLine(), stOut="";

            for (int i = 0; i < classi.Length; i++)
            {
                if (classi[i] == cl)
                {
                    stOut += cognomi[i] + " " + nomi[i] + "\n";
                }
            }

            if (stOut == "")
            {
                Console.WriteLine("\nClasse non trovato!");
            }
            else
            {
                Console.WriteLine("\nStudenti della classe " + cl.ToString());
                Console.WriteLine("\n" + stOut);
            }
        }
        internal static void ordinaPerClassi(string[] cognomi, string[] nomi, string[] classi)
        {
            int posMin;

            for (int i = 0; i <= classi.Length - 2; i++)
            {
                posMin = i;

                for (int j = i + 1; j <= classi.Length - 1; j++)
                {
                    if (classi[posMin].CompareTo(classi[j]) > 0)
                    {
                        posMin = j;
                    }
                }

                if (posMin != i)
                {
                    string temp = cognomi[i];
                    cognomi[i] = cognomi[posMin];
                    cognomi[posMin] = temp;
                    temp = nomi[i];
                    nomi[i] = nomi[posMin];
                    nomi[posMin] = temp;
                    temp = classi[i];
                    classi[i] = classi[posMin];
                    classi[posMin] = temp;
                }
            }
        }
        internal static void cercaStudentiClasseOrdinata(string[] cognomi, string[] nomi, string[] classi)
        {
            Console.Write("Inserisci la classe da cercare: ");
            string cl = Console.ReadLine(), stOut = "";
            int i = 0;
            bool  superato = false, trovato = false;

            while (!superato && i <= classi.Length - 1)
            {
                if (classi[i] == cl)
                {
                    stOut += cognomi[i] + " " + nomi[i] + "\n";
                    trovato = true;
                    i++;
                }
                else
                {
                    if (classi[i].CompareTo(cl) > 0)
                    {
                        superato = true;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            if (!trovato)
            {
                Console.WriteLine("\nElemento non trovato!");
            }
            else
            {
                Console.WriteLine("\nStudenti della classe " + cl.ToString());
                Console.WriteLine("\n" + stOut);
            }
        }
        internal static void cercaStudenteDatiCognomeNome(string[] cognomi, string[] nomi, string[] classi)
        {
            Console.Write("Inserisci il cognome da cercare: ");
            string cogn = Console.ReadLine();
            Console.Write("Inserisci il nome da cercare: ");
            string nom = Console.ReadLine();
            int i = 0;

            while (cognomi[i] != cogn || nomi[i] != nom && i != cognomi.Length -1)
            {
                i++;
            }

            if (cognomi[i] == cogn && nomi[i] == nom)
            {
                Console.WriteLine("\nStudente trovato in classe " + classi[i] + "\n");
            }
            else
            {
                Console.WriteLine("\nStudente non trovato");
            }
        }
    }
}
