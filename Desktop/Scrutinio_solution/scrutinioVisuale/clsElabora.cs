using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace scrutinioVisuale
{
    class clsElabora
    {
        internal static void visualizzaMediaStudenti(string[] studenti, int[,] voti, string stud)
        {
            int pos = posStudente(studenti, stud);
            if (pos == -1)
            {
                MessageBox.Show("studente non trovato");
            }
            else
            {
                MessageBox.Show("Media voti: " + calcolaMedia(voti, pos));
            }
        }
        private static float calcolaMedia(int[,] voti, int pos)
        {
            float media = 0;

            for (int i = 0; i < voti.GetLength(1); i++)
            {
                media += voti[pos, i];
            }

            media = media / voti.GetLength(1);

            return media;
        }
        private static int posStudente(string[] studenti, string stud)
        {
            int i = 0;

            while (i < studenti.Length)
            {
                if (studenti[i].ToLower() == stud.ToLower())
                {
                    return i;
                }
                else
                {
                    i++;
                }
            }

            return (-1);
        }
        internal static void visualizzaRisultati(DataGridView dgvStudenti, int[,] voti)
        {
            float insuf = 0;

            for (int i = 0; i < voti.GetLength(0); i++)
            {
                insuf = 0;

                for (int j = 0; j < voti.GetLength(1); j++)
                {
                    if (voti[i, j] < 6)
                    {
                        insuf++;
                    }
                }

                if (insuf > 3)
                {
                    dgvStudenti.Rows[i].Cells[0].Style.BackColor = Color.Red;
                }
                else if (insuf > 0)
                {
                    dgvStudenti.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                }
                else
                {
                    dgvStudenti.Rows[i].Cells[0].Style.BackColor = Color.Green;
                }
            }
        }
        internal static void mediaMateria(int[,] voti, string[] materie, int pos)
        {
            float somma = 0;

            for (int i = 0; i < voti.GetLength(0); i++)
            {
                somma += voti[i, pos];
            }

            MessageBox.Show("La media di " + materie[pos] + " è: " + somma / voti.GetLength(0));
        }
        internal static void mediaMaggiore(string[] studenti, int[,] voti)
        {
            int mediaMax = -1, somma = 0, contStud = -1;

            for (int i = 0; i < voti.GetLength(0); i++)
            {
                for (int j = 0; j < voti.GetLength(1); j++)
                {
                    somma += voti[i, j];
                }

                if (somma > mediaMax)
                {
                    mediaMax = somma;
                    contStud = i;
                }
            }

            mediaMax = mediaMax / voti.GetLength(1);

            MessageBox.Show("Lo studente con la media maggiore e' " + studenti[contStud] + " con: " + mediaMax);
        }
    }
}
