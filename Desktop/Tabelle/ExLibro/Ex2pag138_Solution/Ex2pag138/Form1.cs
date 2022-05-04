using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ex2pag138
{
    public partial class Form1 : Form
    {
        static int[] a = new int[3];
        static int[] b = new int[5];
        static int[] c = new int[5 + 3];

        static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            settaDgv(dgvA, a);
            settaDgv(dgvB, b);
            settaDgv(dgvC, c);
            caricaVett(dgvA, a);
            caricaVett(dgvB, b);
        }
        private void caricaVett(DataGridView dgv, int[] dati)
        {
            for (int i = 0; i < dati.Length; i++)
            {
                dati[i] = rnd.Next(0, 20);
                dgv.Rows[i].Cells[0].Value = dati[i];
            }
        }
        private void settaDgv(DataGridView dgv, int[] dati)
        {
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.RowCount = dati.Length;
            dgv.ColumnCount = 1;
            dgv.ScrollBars = ScrollBars.None;
            dgv.Rows[0].Cells[0].Selected = false;
            dgv.Height = dati.Length * 22;
        }
        private void btnIntersezione_Click(object sender, EventArgs e)
        {
            azzeraVett(dgvC, c);

            int k = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        c[k] = a[i];
                        dgvC.Rows[k].Cells[0].Value = c[k++];
                    }
                }
            }
        }
        private void azzeraVett(DataGridView dgvC, int[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = 0;
                dgvC.Rows[i].Cells[0].Value = "";
            }
        }
        private void btnUnione_Click(object sender, EventArgs e)
        {
            azzeraVett(dgvC, c);

            int i = 0, j = 0, k = 0;

            while (k < (a.Length + b.Length))
            {
                if (i < a.Length)
                {
                    c[k] = a[i++];
                    dgvC.Rows[k].Cells[0].Value = c[k++];
                }

                if (j < b.Length)
                {
                    c[k] = b[j++];
                    dgvC.Rows[k].Cells[0].Value = c[k++];
                }
            }
        }
        private void btnDifferenza_Click(object sender, EventArgs e)
        {
            azzeraVett(dgvC, c);

            int k = 0;

            for (int i = 0; i < a.Length; i++)
            {
                int j = 0;
                bool trovato = false;

                while (j < b.Length && !trovato)
                {
                    if (a[i] == b[j++])
                    {
                        trovato = true;
                    }
                }

                if (!trovato)
                {
                    c[k] = a[i];
                    dgvC.Rows[k].Cells[0].Value = c[k++];
                }
            }
        }
    }
}
