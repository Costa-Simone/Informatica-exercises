using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9pag150
{
    class ClsSquadre
    {
        static Random rnd = new Random();
        internal static void creaSchedina(string[] squadre, string[] risultato, string[] squadCasa, string[] squadFuori)
        {
            int[] aus = new int[26];
            
            Console.WriteLine("Stampa schedina:");

            for (int i = 0; i < (squadre.Length / 2); i++)
            {
                int s1, s2, ris;

                do
                {
                    s1 = rnd.Next(0, 26);
                } while (aus[s1] == 1);

                aus[s1] = 1;

                do
                {
                    s2 = rnd.Next(0, 26);
                } while (aus[s2] == 1);

                aus[s2] = 1;

                aus[s1] = 1;
                aus[s2] = 1;

                squadCasa[i] = squadre[s1];
                squadFuori[i] = squadre[s2];

                ris = rnd.Next(1, 4);

                if (ris == 3)
                {
                    risultato[i] = "x";
                }
                else
                {
                    risultato[i] = ris.ToString();
                }

                Console.WriteLine("\n" + squadCasa[i] + " vs " + squadFuori[i] + " = " + risultato[i]);
            }
        }
        internal static void puntiCampionato(string[] squadre, string[] risultato, string[] squadCasa, string[] squadFuori)
        {
            int[] punteggio = new int[26];

            for (int j = 0; j < 5; j++)
            {
                ClsSquadre.creaSchedina(squadre, risultato, squadCasa, squadFuori);

                for (int i = 0; i < risultato.Length; i++)
                {
                    int s;
                    if (risultato[i] == "1")
                    {
                        string squad = squadCasa[i];
                        s = cercaSquadra(squadre, squad);
                        punteggio[s] += 3;
                    }
                    else if (risultato[i] == "2")
                    {
                        string squad = squadFuori[i];
                        s = cercaSquadra(squadre, squad);
                        punteggio[s] += 3;
                    }
                    else
                    {
                        string squad = squadCasa[i];
                        s = cercaSquadra(squadre, squad);
                        punteggio[s]++;
                        squad = squadFuori[i];
                        s = cercaSquadra(squadre, squad);
                        punteggio[s]++;
                    }
                }
            }

            ClsSquadre.ordinaSquadre(squadre, punteggio);

            Console.WriteLine("\nStampa tabella");

            for (int i = 0; i < squadre.Length; i++)
            {
                Console.WriteLine("\n" + squadre[i] + " con punti: " + punteggio[i]);
            }

        }
        private static int cercaSquadra(string[] squadre, string squad)
        {
            int sup = 0, inf = squadre.Length - 1;
            int meta;

            do
            {
                meta = (inf + sup) / 2;

                if (squadre[meta] != squad)
                {
                    if (string.Compare(squadre[meta], squad) > 0)
                    {
                        inf = meta - 1;
                    }
                    else
                    {
                        sup = meta + 1;
                    }
                }
            } while (squadre[meta] != squad && sup <= inf);

            return meta;
        }
        internal static void Scommesse(string[] squadre, string[] risultato, string[] squadCasa, string[] squadFuori)
        {
            int cont = 0;
            bool aus = false;
            string[] scommesse = new string[13];

            Console.WriteLine("\nStampa totocalcio");

            for (int i = 0; i < 13; i++)
            {
                int ris = rnd.Next(1, 4);

                if (ris == 3)
                {
                    scommesse[i] = "x";
                }
                else
                {
                    scommesse[i] = ris.ToString();
                }

                Console.WriteLine("\n" + squadCasa[i] + " vs " + squadFuori[i] + " = " + scommesse[i]);
            }

            while(cont < 13 && !aus)
            {
                if (risultato[cont] != scommesse[cont])
                {
                    aus = true;
                }

                cont++;
            }

            if (aus)
            {
                Console.WriteLine("\nNon hai fatto 13!");
            }
            else
            {
                Console.WriteLine("\nHai fatto 13!");
            }
        }
        internal static void ordinaSquadre(string[] squadre, int[] punteggio)
        {
            int PosMin, aus;
            string squad;

            for (int i = 0; i <= squadre.Length - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= squadre.Length - 1; j++)
                {
                    if (punteggio[PosMin] < punteggio[j])
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    squad = squadre[i];
                    aus = punteggio[i];
                    squadre[i] = squadre[PosMin];
                    punteggio[i] = punteggio[PosMin];
                    squadre[PosMin] = squad;
                    punteggio[PosMin] = aus;
                }
            }
        }
    }
}
