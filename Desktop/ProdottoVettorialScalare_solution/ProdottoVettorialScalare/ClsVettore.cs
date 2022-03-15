using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdottoVettorialScalare
{
    class ClsVettore
    {
        public void stampaVet(int[] a, DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = a[i];
            }
        }

        public void caricaVet(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 1000);
            }
        }
    }
}
