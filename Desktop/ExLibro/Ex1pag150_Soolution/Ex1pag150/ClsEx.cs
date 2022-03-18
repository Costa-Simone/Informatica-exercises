using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ex1pag150
{
    internal class ClsEx
    {
        static Random rnd = new Random();
        internal static void creaTurni(string[] cognomi, DataGridView dgv)
        {
            for (int i = 0; i < 4; i++)
            {
                dgv.Rows[i].Cells[0].Value = "";
            }

            int x, turno = 0, cont = 0;
            string[] aus = new string[cognomi.Length];
            Array.Copy(cognomi, aus, aus.Length);

            do
            {
                x = Convert.ToInt32(Interaction.InputBox("Inserisci il numero degli studenti per turno: "));
            } while (x < 3 || x > 5);

            RandomVett(aus);

            for (int i = 0; i < cognomi.Length; i++)
            {
                if (cont == x)
                {
                    cont = 0;
                    turno++;
                }

                dgv.Rows[turno].Cells[0].Value += aus[i] + " ";

                cont++;
            }
        }
        private static void RandomVett(string[] aus)
        {
            for (int i = 0; i < aus.Length; i++)
            {
                int k = rnd.Next(0, aus.Length);
                string copia;

                copia = aus[i];
                aus[i] = aus[k];
                aus[k] = copia;
            }
        }
    }
}
