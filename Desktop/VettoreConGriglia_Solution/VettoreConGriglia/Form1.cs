using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VettoreConGriglia
{
    public partial class FrmVettoreConGriglia : Form
    {
        int[] a = new int[10];

        public FrmVettoreConGriglia()
        {
            InitializeComponent();
        }
        private void FrmVettoreConGriglia_Load(object sender, EventArgs e)
        {
            settaDgv(DgvVettore);
            caricaVett(a);
            stampaVet(a, DgvVettore);
        }
        private void stampaVet(int[] v, DataGridView dgv)
        {
            for (int i = 0; i < v.Length; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = v[i];
            }
        }
        private void caricaVett(int[] v)
        {
            Random rnd = new Random();

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(1, 1000);
            }
        }
        private void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 1;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
        }
    }
}
