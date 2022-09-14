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
using System.IO;

namespace Esercizio_18
{
    public partial class FormMain : Form
    {
        public static int nMaterie = 8;

        static Random rnd = new Random();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            settaDgv(dgvElementi);
        }

        private void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.None;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.Columns[0].HeaderText = "Materia";
            dgv.Columns[1].HeaderText = "Voto Orale";
            dgv.Columns[2].HeaderText = "Voto Scritto";
            dgv.Columns[3].HeaderText = "Voto Pratico";
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programma terminato");
            Close();
        }

        private void btnCaricaMaterie_Click(object sender, EventArgs e)
        {
            caricaFileMaterie();
            visualizzaFileMaterie(dgvElementi);
            btnCaricaVoti.Enabled = true;
            btnMediaMateriaX.Enabled = false;
            btnMediaTotale.Enabled = false;
            btnMedieCrescenteMinMax.Enabled = false;
        }

        private void visualizzaFileMaterie(DataGridView dgv)
        {
            int i = 0;

            dgv.Rows.Clear();
            foreach (string dato in File.ReadLines("Dati.txt"))
            {
                dgv.Rows.Add();
                dgv.Rows[i++].Cells[0].Value = dato;
            }
        }

        private void caricaFileMaterie()
        {
            string mat = "";
            StreamWriter sw = new StreamWriter("Dati.txt", false);

            for (int i = 0; i < nMaterie; i++)
            {
                mat = Interaction.InputBox("Inserisci il nome della " + (i + 1) + "° materia: ");
                sw.WriteLine(mat);
            }
            sw.Close();
        }

        private void btnCaricaVoti_Click(object sender, EventArgs e)
        {
            caricaDatiDgv(dgvElementi);
            stampaDgvSuFile(dgvElementi, "Dati.txt");
            btnMediaMateriaX.Enabled = true;
            btnMediaTotale.Enabled = true;
            btnMedieCrescenteMinMax.Enabled = true;
        }

        private void stampaDgvSuFile(DataGridView dgv, string name)
        {
            StreamWriter sw = new StreamWriter(name, false);

            for (int i = 0; i < nMaterie; i++)
            {
                sw.WriteLine(dgv.Rows[i].Cells[0].Value + ";" + dgv.Rows[i].Cells[1].Value + ";" +
                    dgv.Rows[i].Cells[2].Value + ";" + dgv.Rows[i].Cells[3].Value);
            }
            sw.Close();
        }

        private void caricaDatiDgv(DataGridView dgv)
        {
            for (int i = 0; i < nMaterie; i++)
            {
                dgv.Rows[i].Cells[1].Value = rnd.Next(3, 11);
                dgv.Rows[i].Cells[2].Value = rnd.Next(3, 11);
                dgv.Rows[i].Cells[3].Value = rnd.Next(3, 11);
            }
        }

        private void btnMediaMateriaX_Click(object sender, EventArgs e)
        {
            string materia = Interaction.InputBox("Inserisci la materia da ricercare:");
            float mediaMateria = 0;

            mediaMateria = cercaMateria(materia, "Dati.txt");
            if (mediaMateria == 0)
                MessageBox.Show("La materia inserita non esiste");
            else
                MessageBox.Show("La media della materia " + materia + " è " + mediaMateria.ToString());
        }

        private float cercaMateria(string materia, string name)
        {
            int somma = 0;
            float media = 0;
            string[] campi = new string[4];

            foreach (string dato in File.ReadLines(name))
            {
                campi = dato.Split(';');
                if (campi[0] == materia)
                {
                    somma = int.Parse(campi[1]) + int.Parse(campi[2]) + int.Parse(campi[3]);
                    media = (float)somma / 3;
                }
            }
            return media;
        }

        private void btnMediaTotale_Click(object sender, EventArgs e)
        {
            int somma = 0;
            float mediaTot = 0;
            int cntVoti = 0;
            string[] campi = new string[4];

            foreach (string dato in File.ReadLines("Dati.txt"))
            {
                campi = dato.Split(';');
                somma += int.Parse(campi[1]) + int.Parse(campi[2]) + int.Parse(campi[3]);
                cntVoti += 3;
            }
            mediaTot = (float)somma / cntVoti;
            MessageBox.Show("La media totale delle materie è " + mediaTot.ToString());
        }

        private void btnMedieCrescenteMinMax_Click(object sender, EventArgs e)
        {
            float[] medie = new float[nMaterie];
            string[] materie = new string[nMaterie];
            int somma = 0;
            float media = 0;
            string output = "";
            string[] campi = new string[4];
            int pos = 0;

            foreach (string dato in File.ReadLines("Dati.txt"))
            {
                campi = dato.Split(';');
                somma = int.Parse(campi[1]) + int.Parse(campi[2]) + int.Parse(campi[3]);
                media = (float)somma / 3;
                medie[pos] = media;
                materie[pos] = campi[0];
                pos++;
            }
            cercaMin(medie, materie);
            cercaMax(medie, materie);
            ordinaMedieCrescente(medie, materie);
            for (int i = 0; i < medie.Length; i++)
            {
                output += materie[i] + " --> " + medie[i].ToString() + "\n";
            }
            MessageBox.Show("CLASSIFICA DELLE MEDIE:\n\n" + output);
        }

        private void ordinaMedieCrescente(float[] medie, string[] materie)
        {
            int posmin;
            float aus;
            string temp;

            for (int i = 0; i <= medie.Length - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= medie.Length - 1; j++)
                {
                    if (medie[posmin] > medie[j])
                        posmin = j;
                }
                if (posmin != i)
                {
                    aus = medie[i];
                    medie[i] = medie[posmin];
                    medie[posmin] = aus;
                    temp = materie[i];
                    materie[i] = materie[posmin];
                    materie[posmin] = temp;
                }
            }
        }

        private void cercaMax(float[] medie, string[] materie)
        {
            float max = float.MinValue;
            string matMax = "";

            for (int i = 0; i < medie.Length; i++)
            {
                if (medie[i] > max)
                {
                    max = medie[i];
                    matMax = materie[i];
                }
            }
            MessageBox.Show("La materia con la media più alta è " + matMax + " con una media di " + max.ToString());
        }

        private void cercaMin(float[] medie, string[] materie)
        {
            float min = float.MaxValue;
            string matMin = "";

            for (int i = 0; i < medie.Length; i++)
            {
                if (medie[i] < min)
                {
                    min = medie[i];
                    matMin = materie[i];
                }
            }
            MessageBox.Show("La materia con la media più bassa è " + matMin + " con una media di " + min.ToString());
        }
    }
}
