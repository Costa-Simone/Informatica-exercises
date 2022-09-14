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

namespace Esercizio_19
{
    public struct Nome
    {
        public string nominativo;
        public string indirizzo;
        public string cellulare;
    }

    public partial class FormMain : Form
    {
        public static Nome[] nomi = new Nome[100];

        public static string[] datiNomi = new string[]
        {
            "Corneanu George Alexandru,Corso Alessandro Manzoni 88,3202342455",
            "Arese Anna,Via Marco Polo 65,3274246505",
            "Jourdan Daniel,Corso Unione Sovietica 5,3472589954",
            "Mondino Umberto,Via Napoli 2,3349433666",
            "Noto Serena,Corso Milano 31,3661066106",
            "Grosso Denis,Strada Provinciale 89,3921126752",
            "Pieretto Francesco,Via Volpe 7,3497768274",
            "Bertello Tommaso,Viale Bertaldo 9,3349520282",
            "Costa Simone,Via Elica 76,3312342464",
            "Movsesian Aram,Viale Libertà 1,3495661026",
            "Migori Andrea,Via Pascoli 7,3273251480",
            "Garzino Davide,Corso Giulio Cesare 8,3333871022",
            "Lazzarino Paolo,Via Montà 3,3882549939",
            "Cairo Pietro,Valle Franca 6,3381271974",
            "Cerrato Diego,Via Ceratto 9,3664787935",
            "Pelliseri Samuele,Via Volpe 45,3738214567",
            "Pizzorno Edoardo,Corso Langhe 23,3756689121"
        };

        public static int nNomi;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            caricaNomi(dgvRubrica);
        }

        private void caricaNomi(DataGridView dgv)
        {
            caricaTabellaNomi();
            visualizzaTabellaNomi(dgv);
        }

        private void visualizzaTabellaNomi(DataGridView dgv)
        {
            settaDgv(dgv);
            caricaDatiDgv(dgv);
        }

        private void caricaDatiDgv(DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < nNomi; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = nomi[i].nominativo;
                dgv.Rows[i].Cells[1].Value = nomi[i].indirizzo;
                dgv.Rows[i].Cells[2].Value = nomi[i].cellulare;
            }
        }

        private void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 3;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.Columns[0].HeaderText = "Nominativo";
            dgv.Columns[1].HeaderText = "Indirizzo";
            dgv.Columns[2].HeaderText = "Cellulare";
        }

        private void caricaTabellaNomi()
        {
            for (int i = 0; i < datiNomi.Length; i++)
            {
                string[] dati = datiNomi[i].Split(',');
                nomi[i].nominativo = dati[0];
                nomi[i].indirizzo = dati[1];
                nomi[i].cellulare = dati[2];
            }
            nNomi = datiNomi.Length;
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programma terminato");
            Close();
        }

        private void btnInserisciNominativo_Click(object sender, EventArgs e)
        {
            if (txtNominativo.Text != "" && txtIndirizzo.Text != "" && txtCellulare.Text != "")
            {
                inserisciNominativo(txtNominativo.Text, txtIndirizzo.Text, txtCellulare.Text, dgvRubrica);
                svuotaCampi();
            }
            else
                MessageBox.Show("Compilare tutti i campi prima di effettuare l'operazione");
        }

        private void svuotaCampi()
        {
            txtNominativo.Text = "";
            txtIndirizzo.Text = "";
            txtCellulare.Text = "";
            btnInserisciNominativo.Enabled = true;
            btnModificaNominativo.Enabled = true;
            btnSalva.Visible = false;
            btnAnnulla.Visible = false;
            btnVisualizzaNominativo.Enabled = true;
            btnVisualizzaRubricaOrdinata.Enabled = true;
            btnEsci.Enabled = true;
        }

        private void inserisciNominativo(string nominativo, string indirizzo, string cellulare, DataGridView dgv)
        {
            Nome n = new Nome();
            n.nominativo =nominativo;
            n.indirizzo = indirizzo;
            n.cellulare = cellulare;
            nomi[nNomi] = n;
            nNomi++;
            visualizzaTabellaNomi(dgv);
        }

        private void btnModificaNominativo_Click(object sender, EventArgs e)
        {
            Nome nomimativoSelezionato = nomi[dgvRubrica.SelectedRows[0].Index];
            txtNominativo.Text = nomimativoSelezionato.nominativo;
            txtIndirizzo.Text = nomimativoSelezionato.indirizzo;
            txtCellulare.Text = nomimativoSelezionato.cellulare;
            btnInserisciNominativo.Enabled = false;
            btnModificaNominativo.Enabled = false;
            btnVisualizzaNominativo.Enabled = false;
            btnVisualizzaRubricaOrdinata.Enabled = false;
            btnEsci.Enabled = false;
            btnSalva.Visible = true;
            btnAnnulla.Visible = true;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtNominativo.Text != "" && txtIndirizzo.Text != "" && txtCellulare.Text != "")
            {
                modificaNominativo(txtNominativo.Text, txtIndirizzo.Text, txtCellulare.Text, dgvRubrica.SelectedRows[0].Index, dgvRubrica);
                svuotaCampi();
            }
            else
                MessageBox.Show("Compilare tutti i campi prima di effettuare l'operazione");
        }

        private void modificaNominativo(string nominativo, string indirizzo, string cellulare, int index, DataGridView dgv)
        {
            nomi[index].nominativo = nominativo;
            nomi[index].indirizzo = indirizzo;
            nomi[index].cellulare = cellulare;
            visualizzaTabellaNomi(dgv);
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            svuotaCampi();
        }

        private void btnVisualizzaNominativo_Click(object sender, EventArgs e)
        {
            string cellulareInput = Interaction.InputBox("Inserisci il cellulare:");

            cercaNominativo(cellulareInput);
        }

        private void cercaNominativo(string cellulareInput)
        {
            int i = 0;

            while (nomi[i].cellulare != cellulareInput && i < nNomi - 1)
                i++;
            if (nomi[i].cellulare == cellulareInput)
                MessageBox.Show("Il cellulare (" + cellulareInput + ") inserito appartiene a " + nomi[i].nominativo + " residente in " + nomi[i].indirizzo);
            else
                MessageBox.Show("Il cellulare (" + cellulareInput + ") inserito non esiste nella rubrica");
        }

        private void btnVisualizzaRubricaOrdinata_Click(object sender, EventArgs e)
        {
            ordinaNominativi();
            visualizzaTabellaNomi(dgvRubrica);
        }

        private void ordinaNominativi()
        {
            int posmin;
            string aus;

            for (int i = 0; i <= nNomi - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= nNomi - 1; j++)
                {
                    if (string.Compare(nomi[posmin].nominativo, nomi[j].nominativo) > 0)
                        posmin = j;
                }
                if (posmin != i)
                {
                    aus = nomi[i].nominativo;
                    nomi[i].nominativo = nomi[posmin].nominativo;
                    nomi[posmin].nominativo = aus;
                    aus = nomi[i].indirizzo;
                    nomi[i].indirizzo = nomi[posmin].indirizzo;
                    nomi[posmin].indirizzo = aus;
                    aus = nomi[i].cellulare;
                    nomi[i].cellulare = nomi[posmin].cellulare;
                    nomi[posmin].cellulare = aus;
                }
            }
        }
    }
}
