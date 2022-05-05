﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //NOTA BENE
using Microsoft.VisualBasic;

namespace gestioneBaseFileText
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            settaDgv(dgvLibri);
            caricaCmbAutori("libri.txt", cmbAutori);
        }
        private void caricaCmbAutori(string nf, ComboBox cmb)
        {
            StreamReader sr = new StreamReader(nf);
            string[] autori = new string[10], v = new string[4];
            string libro;
            int n = 0;

            while (sr.Peek() > -1)
            {
                libro = sr.ReadLine();
                v = libro.Split(';');
                autori[n++] = v[1];
            }

            ordinaAutori(autori, n);

            cmb.Items.Add(autori[0]);

            for (int i = 1; i < n; i++)
            {
                if (autori[i] != autori[i - 1])
                {
                    cmb.Items.Add(autori[i]);
                }
            }

            sr.Close();
        }
        private void ordinaAutori(string[] autori, int n)
        {
            int PosMin;

            for (int i = 0; i <= n - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (string.Compare(autori[PosMin], autori[j]) > 0)
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    string aus = autori[i];
                    autori[i] = autori[PosMin];
                    autori[PosMin] = aus;
                }
            }
        }
        private void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            dgv.Columns[0].HeaderText = "Titolo";
            dgv.Columns[1].HeaderText = "Autore";
            dgv.Columns[2].HeaderText = "Anno";
            dgv.Columns[3].HeaderText = "Prezzo";
            dgv.AutoResizeColumns();
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.Vertical;
        }
        private void btnLeggiDaFile_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("libri.txt");
            int i = 0;
            string s;
            string[] v = new string[4]; //per splittare

            while (sr.Peek() > -1) //finche' non finisco file
            {
                s = sr.ReadLine(); //legge una linea del file
                v = s.Split(';');

                scriviSuDgv(i, v, dgvLibri);

                i++;
            }
        }
        private void scriviSuDgv(int i, string[] v, DataGridView dgv)
        {
            dgv.Rows.Add();

            dgv.Rows[i].Cells[0].Value = v[0];
            dgv.Rows[i].Cells[1].Value = v[1];
            dgv.Rows[i].Cells[2].Value = v[2];
            dgv.Rows[i].Cells[3].Value = v[3];
        }
        private void btnScriviSuFile_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("libri.txt", false);
            //false = scovrascrivo il file
            //true = appende nuovi dati
            string s;

            for (int i = 0; i < dgvLibri.RowCount - 1; i++)
            {
                s = "";

                for (int j = 0; j < dgvLibri.ColumnCount; j++)
                {
                    if (j != dgvLibri.ColumnCount - 1)
                    {
                        s += dgvLibri.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        s += dgvLibri.Rows[i].Cells[j].Value;
                    }
                }

                sw.WriteLine(s);
            }

            sw.Close();
        }
        private void btnCercareLibriAutore_Click(object sender, EventArgs e)
        {
            string autore = Interaction.InputBox("Inserisci l'autore da cercare");

            cercaLibriAutore("libri.txt", autore);
        }
        private void cercaLibriAutore(string nf, string autore)
        {
            StreamReader sr = new StreamReader(nf);
            string libro, output = "";
            string[] v = new string[4];

            while (sr.Peek() > -1)
            {
                libro = sr.ReadLine();
                v = libro.Split(';');

                if (v[1] == autore)
                {
                    output += v[0] + "\n";
                }
            }

            MessageBox.Show(output);
            sr.Close();
        }
        private void btnCercareAutoriInputCombo_Click(object sender, EventArgs e)
        {
            string autore = cmbAutori.SelectedItem.ToString();
            StreamReader sr = new StreamReader("libri.txt");
            string libro, output = "";
            string[] v = new string[4];

            while (sr.Peek() > -1)
            {
                libro = sr.ReadLine();
                v = libro.Split(';');

                if (v[1] == autore)
                {
                    output += v[0] + "\n";
                }
            }

            MessageBox.Show(output);
            sr.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string titolo = Interaction.InputBox("Inserisci l'autore da cercare");

            cercaLibriTitolo("libri.txt", titolo);
        }
        private void cercaLibriTitolo(string nf, string titolo)
        {
            StreamReader sr = new StreamReader(nf);
            string libro;
            string[] v = new string[4];

            while (sr.Peek() > -1 && v[0] != titolo)
            {
                libro = sr.ReadLine();
                v = libro.Split(';');
            }

            MessageBox.Show(v[1] + " " + v[2] + " " + v[3]);
            sr.Close();
        }
    }
}