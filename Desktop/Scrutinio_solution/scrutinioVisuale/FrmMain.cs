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

namespace scrutinioVisuale
{
    public partial class FrmMain : Form
    {
        Random rnd = new Random();
        static string[] studenti = {"Migori", "Menardi", "Noto", "Pieretto", "Bogetti",
                                    "Grosso", "Di Folco", "Olivero", "Pizzorno", "Cairo"};
        static string[] materie = {"Italiano", "Storia", "Matematica", "Inglese",
                                    "Informatica", "Sistemi", "Francese"};
        static int[,] voti = new int[studenti.Length, materie.Length];

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            settaDgv(dgvStudenti, studenti.Length, 1);
            settaDgv(dgvMaterie, 1, materie.Length);
            settaDgv(dgvVoti, studenti.Length, materie.Length);
            caricaDgvStud(studenti, dgvStudenti);
            caricaDgvMaterie(materie, dgvMaterie);
            caricaDgvVoti(voti, dgvVoti);
            caricaCmbMaterie(materie, cmbMediaMaterie);
          
        }
        private void caricaCmbMaterie(string[] materie, ComboBox cmbMediaMaterie)
        {
            for (int i = 0; i < materie.Length; i++)
            {
                cmbMediaMaterie.Items.Add(materie[i]);
            }

            cmbMediaMaterie.SelectedIndex = 0;
        }
        private void caricaDgvVoti(int[,] dati, DataGridView dgv)
        {
            for (int i = 0; i < dati.GetLength(0); i++)
            {
                for (int j = 0; j < dati.GetLength(1); j++)
                {
                    int n = rnd.Next(4, 10);
                    dgv.Rows[i].Cells[j].Value = n;
                    dati[i, j] = n;

                    if (voti[i, j] < 5)
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
                    else if (voti[i, j] < 6)
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Green;
                    }
                    dgv.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                    dgv.Rows[i].Cells[j].Selected = false;
                }
            }
        }
        private void caricaDgvMaterie(string[] dati, DataGridView dgv)
        {
            for (int i = 0; i < dati.Length; i++)
            {
                dgv.Rows[0].Cells[i].Value = dati[i];
            }
        }
        private void caricaDgvStud(string[] dati, DataGridView dgv)
        {
            for (int i = 0; i < dati.Length; i++)
            {        
              dgv.Rows[i].Cells[0].Value = dati[i];  
            }
        }
        private void settaDgv(DataGridView dgv, int r, int c)
        {
            dgv.ColumnCount = c;
            dgv.RowCount = r;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgv.DefaultCellStyle.SelectionForeColor = dgv.DefaultCellStyle.ForeColor;
        }
        private void btnMediaStudente_Click(object sender, EventArgs e)
        {
            string stud = Interaction.InputBox("Inserisci lo sudente");
            clsElabora.visualizzaMediaStudenti(studenti, voti, stud);
        }
        private void btnScrutinio_Click(object sender, EventArgs e)
        {
            clsElabora.visualizzaRisultati(dgvStudenti, voti);

            dgvStudenti.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgvStudenti.Rows[0].Cells[0].Selected = false;
        }
        private void cmbMediaMaterie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnMediaMateria_Click(object sender, EventArgs e)
        {
            clsElabora.mediaMateria(voti, materie, cmbMediaMaterie.SelectedIndex);
        }
        private void btnMediaMaggiore_Click(object sender, EventArgs e)
        {
            clsElabora.mediaMaggiore(studenti, voti);
        }
    }
}
