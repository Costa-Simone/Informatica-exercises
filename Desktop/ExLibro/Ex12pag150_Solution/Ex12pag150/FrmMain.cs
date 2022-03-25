using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex12pag150
{
    public partial class FrmMain : Form
    {
        string[] atleti = new string[5] { "a1", "a2", "a3", "a4", "a5" };
        static int c = 5, pos = -1;
        static int[,] prove = new int[5, c];
        static int[] punti = new int[5];
        static Random rnd = new Random();
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            settaDgv(dgvAtleti, atleti.Length, 0);
            settaDgv(dgvClassifica, atleti.Length, 0);
            settaDgv(dgvProve, atleti.Length, c);
            visualizzaDgvVett(dgvAtleti, atleti);
            caricaMat(prove, dgvProve);
        }
        private void caricaMat(int[,] prove, DataGridView dgvProve)
        {
            for (int i = 0; i < prove.GetLength(0); i++)
            {
                for (int j = 0; j < prove.GetLength(1); j++)
                {
                    prove[i, j] = rnd.Next(150, 200);
                    dgvProve.Rows[i].Cells[j].Value = prove[i, j];
                }
            }
        }
        private void visualizzaDgvVett(DataGridView dgvAtleti, string[] atleti)
        {
            for (int i = 0; i < atleti.Length; i++)
            {
                dgvAtleti.Rows[i].Cells[0].Value = atleti[i];
            }
        }
        private void settaDgv(DataGridView dgv, int length, int c)
        {
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ColumnCount = c;
            dgv.RowCount = length;
            dgv.ScrollBars = ScrollBars.None;
            dgv.Rows[0].Cells[0].Selected = false;
            dgv.Height = length * 22;
        }
        private void btnClassificaParziale_Click(object sender, EventArgs e)
        {
            int PosMin, aus;
            string ausS = "";

            if (pos == 4)
            {
                pos = -1;
            }

            pos++;

            for (int i = 0; i <= prove.GetLength(0) - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= prove.GetLength(0) - 1; j++)
                {
                    if (prove[PosMin, pos] < prove[j, pos])
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    aus = prove[i, pos];
                    ausS = atleti[i];
                    prove[i, pos] = prove[PosMin, pos];
                    atleti[i] = atleti[PosMin];
                    atleti[PosMin] = ausS;
                }
            }

            if (pos == 4)
            {
                btnClassificaParziale.Enabled = false;
            }

            visualizzaDgvVett(dgvClassifica, atleti);
        }
        private void btnClassificaTotale_Click(object sender, EventArgs e)
        {
            int PosMin, aus, ausPunti;
            string ausS = "";

            pos = -1;

            for (int k = 0; k < c; k++)
            {
                pos++;

                for (int i = 0; i <= prove.GetLength(0) - 2; i++)
                {
                    PosMin = i;

                    for (int j = i + 1; j <= prove.GetLength(0) - 1; j++)
                    {
                        if (prove[PosMin, pos] < prove[j, pos])
                        {
                            PosMin = j;
                        }
                    }

                    if (PosMin != i)
                    {
                        aus = prove[i, pos];
                        ausS = atleti[i];
                        ausPunti = punti[i];
                        prove[i, pos] = prove[PosMin, pos];
                        atleti[i] = atleti[PosMin];
                        punti[i] = punti[PosMin];
                        prove[PosMin, pos] = aus;
                        atleti[PosMin] = ausS;
                        punti[PosMin] = ausPunti;
                    }
                }

                for (int p = 0; p < punti.Length; p++)
                {
                    punti[p] += c - p;
                }
            }

            for (int i = 0; i <= punti.Length - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= punti.Length - 1; j++)
                {
                    if (punti[PosMin] < punti[j])
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    ausS = atleti[i];
                    ausPunti = punti[i];
                    atleti[i] = atleti[PosMin];
                    punti[i] = punti[PosMin];
                    atleti[PosMin] = ausS;
                    punti[PosMin] = ausPunti;
                }
            }

            visualizzaDgvVett(dgvClassifica, atleti);
        }
    }
}
