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
        internal static void caricaVett(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 1000);
            }
        }
        internal static void visualizzaDgv(int[] v, DataGridView dgv)
        {
            for (int i = 0; i < v.Length; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = v[i];
            }
        }
        internal static void prodottoVettoriale(int[] a, int[] b, int[] pv)
        {
            for (int i = 0; i < a.Length; i++)
            {
                pv[i] = a[i] * b[i];
            }
        }
        internal static void prodottoScalare(int[] a, int[] b)
        {
            int ps = 0;

            for (int i = 0; i < a.Length; i++)
            {
                ps += a[i] * b[i];
            }

            MessageBox.Show("Il prodotto scalare e': " + ps.ToString());
        }
    }
}
