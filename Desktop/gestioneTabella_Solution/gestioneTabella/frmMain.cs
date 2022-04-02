using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestioneTabella
{
    public partial class frmMain : Form
    {
        public struct studente
        {
            public int Matricola;
            public string Cognome;
            public string Nome;
            public string Classe;
        }
        studente[] studenti = new studente[10];
        int numStudenti = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            settaDgv(dgvStudenti);
        }

        private void settaDgv(DataGridView dgvStudenti)
        {
            dgvStudenti.ColumnCount = 4;
            dgvStudenti.ScrollBars = ScrollBars.None;
            dgvStudenti.RowHeadersVisible = false;
            dgvStudenti.Columns[0].HeaderText = "MATRICOLA";
            dgvStudenti.Columns[1].HeaderText = "COGNOME";
            dgvStudenti.Columns[2].HeaderText = "NOME";
            dgvStudenti.Columns[3].HeaderText = "CLASSE";
            dgvStudenti.AutoResizeColumns();

        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            if (!controllaCampi())  //verifica che tutti i campi siano selezionati
            {
                MessageBox.Show("Controllare i campi");
            }
            else
            {
                if (!controllaMatricola(numStudenti))
                {
                    MessageBox.Show("Matricola non valida");
                    txtMatricola.Text = "";
                }
                else
                    inserisciRecord(ref numStudenti);
            }
                
        }

        private void inserisciRecord(ref int n)
        {
            dgvStudenti.Rows.Add();
            int nMatricola = int.Parse(txtMatricola.Text);
            dgvStudenti.Rows[n].Cells[0].Value = studenti[n].Matricola = nMatricola;
            dgvStudenti.Rows[n].Cells[1].Value = studenti[n].Cognome = txtNome.Text;
            dgvStudenti.Rows[n].Cells[2].Value = studenti[n].Nome = txtCognome.Text;
            dgvStudenti.Rows[n].Cells[3].Value = studenti[n].Classe = cmbClasse.SelectedItem.ToString();
            n++;
            svuotaCampi();

        }

        private void svuotaCampi()
        {
            txtMatricola.Text = "";
            txtNome.Text = "";
            txtCognome.Text = "";
            cmbClasse.SelectedItem= null;
        }

        private bool controllaMatricola(int n)
        {
            int nMatricola;
            if (!int.TryParse(txtMatricola.Text, out nMatricola))
                return false;
            if (n == 0)
                return true;
            int i = 0;
            while (studenti[i].Matricola!=nMatricola && i!=n-1)
            {
                i++;
            }
            return studenti[i].Matricola != nMatricola;
        }

        private bool controllaCampi()
        {
            return txtMatricola.Text.Length > 0 
                && txtNome.Text.Length > 0 
                && txtCognome.Text.Length > 0 
                && cmbClasse.SelectedItem != null;
             
        }

        private void btnCercaMatricola_Click(object sender, EventArgs e)
        {
            int nMatricola;
            if(!int.TryParse(txtCercaMat.Text, out nMatricola))
            {
                MessageBox.Show("Inserire Una matricola valida");
            }
            else
            {
                togliFiltri();
                int i = 0;
                while (studenti[i].Matricola != nMatricola && i != numStudenti - 1)
                    i++;
                if (studenti[i].Matricola == nMatricola)
                    dgvStudenti.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                else
                    MessageBox.Show("Matricola non trovata");

            }
        }

        private void btnTogliFitro_Click(object sender, EventArgs e)
        {
            togliFiltri();
        }

        private void togliFiltri()
        {
            for (int i = 0; i < numStudenti; i++)
                dgvStudenti.Rows[i].DefaultCellStyle.BackColor = Color.White;
        }

        private void btnRicercaPerClasse_Click(object sender, EventArgs e)
        {
            if (cmbClasse2.SelectedItem == null)
                MessageBox.Show("Inserire una classe valida");
            else
            {
                togliFiltri();
                for (int i = 0; i < numStudenti; i++)
                {
                    if(studenti[i].Classe==cmbClasse2.SelectedItem.ToString())
                    {
                        dgvStudenti.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }

        private void btnOrdinaMatricola_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numStudenti-1; i++)
            {
                int posMin = i;
                for (int j = i+1; j < numStudenti; j++)
                {
                    if(studenti[posMin].Matricola > studenti[j].Matricola)
                    {
                        posMin = j;
                    }
                }
                if(posMin!=i)
                {
                    studente aus = studenti[i];
                    studenti[i] = studenti[posMin];
                    studenti[posMin] = aus;
                }
            }
            scriviDati(dgvStudenti);
        }

        private void scriviDati(DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < numStudenti; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = studenti[i].Matricola;
                dgv.Rows[i].Cells[1].Value = studenti[i].Cognome;
                dgv.Rows[i].Cells[2].Value = studenti[i].Nome;
                dgv.Rows[i].Cells[3].Value = studenti[i].Classe; 
            }
        }
    }
}
