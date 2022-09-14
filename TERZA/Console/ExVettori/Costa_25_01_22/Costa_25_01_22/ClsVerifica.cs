using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costa_25_01_22
{
    class ClsVerifica
    {
        static Random rnd = new Random();
        internal static void ordinaStudenti(string[] studenti, string[] materie, int[] voti)
        {
            int PosMin, voto;
            string studente, materia;

            for (int i = 0; i <= studenti.Length - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= studenti.Length - 1; j++)
                {
                    if (string.Compare(studenti[PosMin], studenti[j]) > 0)
                    {
                        PosMin = j;
                    }
                }

               if (PosMin != i)
               {
                    studente = studenti[i];
                    materia = materie[i];
                    voto = voti[i];
                    studenti[i] = studenti[PosMin];
                    materie[i] = materie[PosMin];
                    voti[i] = voti[PosMin];
                    studenti[PosMin] = studente;
                    materie[PosMin] = materia;
                    voti[PosMin] = voto;
               }
            }
       
        }
        internal static void calcolaMedia(string[] studenti, string[] materie, int[] voti)
        {
            Array.Resize(ref studenti, studenti.Length + 1);
            Array.Resize(ref materie, materie.Length + 1);
            Array.Resize(ref voti, voti.Length + 1);
            studenti[studenti.Length - 1] = "ZZ";
            materie[studenti.Length - 1] = "ZZ";

            Console.Write("\nInserisci materia: ");
            string materia = Convert.ToString(Console.ReadLine());

            int cont = 0;
            float media = 0;
            string aus = studenti[0];

            for (int i = 0; i < studenti.Length; i++)
            {
                if (studenti[i] == aus)
                {
                    if (materie[i] == materia)
                    {
                        media += voti[i];
                        cont++;
                    }
                }
                else
                {
                    if (cont != 0)
                    {
                        Console.WriteLine(studenti[i - 1] + ": media voto " + (media / cont).ToString());
                    }
                    else
                    {
                        Console.WriteLine(studenti[i - 1] + ": nessun voto");
                    }
                    
                    aus = studenti[i];
                    cont = 0;
                    media = 0;
                }
            }
        }
        internal static void stampaTab(string[] studenti, int[] voti, string[] materie)
        {
            for (int i = 0; i < studenti.Length; i++)
            {
                Console.Write("Studente: " + studenti[i] + "\t" + "di voto:\t " + voti[i] + "\t\t" + "della materia:\t " + materie[i] + "\n");
            }
        }
        internal static void assegnaVoti(int[] voti)
        {
            for (int i = 0; i < voti.Length; i++)
            {
                voti[i] = rnd.Next(0, 11);
            }
        }
    }
}
