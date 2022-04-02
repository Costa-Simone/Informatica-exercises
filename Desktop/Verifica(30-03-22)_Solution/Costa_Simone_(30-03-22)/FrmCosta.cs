using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costa_Simone__30_03_22_
{
    public partial class FrmCosta : Form
    {
        string[] candidati = new string[6]
        {
        "Noto",
        "Bogetti",
        "Arese",
        "Grosso",
        "Mellano",
        "Barbero"
        };
        string[] partiti = new string[6]
        {
        "Centro",
        "Sinistra",
        "Centro",
        "Destra",
        "Destra",
        "Sinistra"
        };
        static int[,] m = new int[6, 4];
        static string partVinc = "";
        public FrmCosta()
        {
            InitializeComponent();
        }
        private void FrmCosta_Load(object sender, EventArgs e)
        {
            settaDgvVett(dgvCandidati, candidati, candidati.Length);
            settaDgvVett(dgvPartito, partiti, partiti.Length);
            settaDgvMat(dgvVoti, candidati.Length, partiti.Length);
            visualizzaVett(dgvCandidati, candidati);
            visualizzaVett(dgvPartito, partiti);
            caricaMat(dgvVoti, m);
        }
        private void caricaMat(DataGridView dgvVoti, int[,] m)
        {
            Random rnd = new Random();

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = rnd.Next(0, 11);
                    dgvVoti.Rows[i].Cells[j].Value = m[i, j];
                }
            }
        }
        private void visualizzaVett(DataGridView dgv, string[] dati)
        {
            for (int i = 0; i < dati.Length; i++)
            {
                dgv.Rows[i].Cells[0].Value = dati[i];
            }
        }
        private void settaDgvMat(DataGridView dgv, int length1, int length2)
        {
            dgv.ColumnCount = 4;
            dgv.RowCount = length1;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.None;
            dgv.Height = length1 * 22;
            dgv.Rows[0].Cells[0].Selected = false;
        }
        private void settaDgvVett(DataGridView dgv, string[] dati, int length)
        {
            dgv.ColumnCount = 1;
            dgv.RowCount = length;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.None;
            dgv.Height = length * 22;
            dgv.Rows[0].Cells[0].Selected = false;
        }
        private void btnVincitore_Click(object sender, EventArgs e)
        {
            int contMax = -1;
            int[] punti = new int[3];
            string[] partito = { "Sinistra", "Centro", "Destra" };

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    switch(partiti[i])
                    {
                        case "Sinistra":
                            punti[0] += m[i, j];
                            break;
                        case "Centro":
                            punti[1] += m[i, j];
                            break;
                        case "Destra":
                            punti[2] += m[i, j];
                            break;
                    }
                }
            }

            for (int i = 0; i < punti.Length; i++)
            {
                if (contMax < punti[i])
                {
                    contMax = punti[i];
                    partVinc = partito[i];
                }
            }

            MessageBox.Show("Il partito vincitore è quello di " + partVinc + " con "
                + contMax.ToString() + " voti");
        }
        private void btnSindaco_Click(object sender, EventArgs e)
        {
            int contMax = -1, cont = 0;
            int[] punti = new int[3];
            string[] partito = { "Sinistra", "Centro", "Destra" };
            string sindaco = "";

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    switch (partiti[i])
                    {
                        case "Sinistra":
                            punti[0] += m[i, j];
                            break;
                        case "Centro":
                            punti[1] += m[i, j];
                            break;
                        case "Destra":
                            punti[2] += m[i, j];
                            break;
                    }
                }
            }

            for (int i = 0; i < punti.Length; i++)
            {
                if (contMax < punti[i])
                {
                    contMax = punti[i];
                    partVinc = partito[i];
                }
            }

            contMax = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                if (partiti[i] == partVinc)
                {
                    for (int j = 0; j < m.GetLength(1); j++)
                    {
                        cont += m[i, j];
                    }

                    if (cont > contMax)
                    {
                        contMax = cont;
                        sindaco = candidati[i];
                        cont = 0;
                    }
                }
            }

            MessageBox.Show("Il sindaco è " + sindaco + " del partito di " + partVinc +
                " con voti: " + contMax.ToString());
        }
    }
}
