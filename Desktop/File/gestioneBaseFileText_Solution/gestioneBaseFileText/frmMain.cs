using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //NOTA BENE

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
    }
}
