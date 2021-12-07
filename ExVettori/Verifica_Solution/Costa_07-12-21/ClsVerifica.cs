using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costa_07_12_21
{
    class ClsVerifica
    {
        public static void stampaTab(string[] candidati, string[] liste, int[] contaVoti)
        {
            for (int i = 0; i < candidati.Length; i++)
            {
                Console.Write("Candidato: " + candidati[i] + "\t" + "di lista:\t " + liste[i] + "\t\t" + "con voti:\t " + contaVoti[i] +"\n");
            }
        }
        internal static void ordinaCandidati(string[] candidati, string[] liste, int[] contaVoti)
        {
            int PosMin, aus;
            string candidato, lista;

            for (int i = 0; i <= candidati.Length - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= candidati.Length - 1; j++)
                {
                    if (contaVoti[PosMin] < contaVoti[j])
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    candidato = candidati[i];
                    lista = liste[i];
                    aus = contaVoti[i];
                    candidati[i] = candidati[PosMin];
                    liste[i] = liste[PosMin];
                    contaVoti[i] = contaVoti[PosMin];
                    candidati[PosMin] = candidato;
                    liste[PosMin] = lista;
                    contaVoti[PosMin] = aus;
                }
            }
        }
        internal static void attesaTasto()
        {
            Console.WriteLine("\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        internal static void contaVotiListe(string[] liste, int[] contaVoti)
        {
            Array.Resize(ref liste, liste.Length + 1);
            Array.Resize(ref contaVoti, contaVoti.Length + 1);
            liste[liste.Length - 1] = "ZZ";
            contaVoti[contaVoti.Length - 1] = -1;

            int cont = contaVoti[0];

            for (int i = 1; i < liste.Length; i++)
            {
                if (liste[i] == liste[i - 1])
                {
                    cont+=contaVoti[i];
                }
                else
                {
                    Console.WriteLine(liste[i - 1] + ": voti " + cont.ToString());
                    cont = contaVoti[i];
                }
            }
        }
        internal static void ordinaListe(string[] candidati, string[] liste, int[] contaVoti)
        {
            int PosMin, aus;
            string candidato, lista;

            for (int i = 0; i <= liste.Length - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= candidati.Length - 1; j++)
                {
                    if (string.Compare(liste[PosMin], liste[j]) > 0)
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    candidato = candidati[i];
                    lista = liste[i];
                    aus = contaVoti[i];
                    candidati[i] = candidati[PosMin];
                    liste[i] = liste[PosMin];
                    contaVoti[i] = contaVoti[PosMin];
                    candidati[PosMin] = candidato;
                    liste[PosMin] = lista;
                    contaVoti[PosMin] = aus;
                }
            }
        }
        internal static void stampaEletti(string[] candidati, int[] contaVoti)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(candidati[i] + " con " + contaVoti[i] + " voti" + "\n");
            }
        }
        internal static void azzeraVett(int[] contaVoti)
        {
            for (int i = 0; i < contaVoti.Length; i++)
            {
                contaVoti[i] = 0;
            }
        }
        internal static void contaVoti(int[] voti, int[] contaVoti)
        {
            for (int i = 0; i < voti.Length; i++)
            {
                contaVoti[voti[i]]++;
            }
        }
    }
}
