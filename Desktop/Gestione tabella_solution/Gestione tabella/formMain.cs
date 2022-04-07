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

namespace Gestione_tabella
{
    public partial class formMain : Form
    {
        public struct studente
        {
            public int matricola;
            public string cognome;
            public string nome;
            public string classe;
        }

        public struct valutazione
        {
            public int prog;
            public int voto;
            public string materia;
            public int matricola;//chiave esterna
        }

        string[] datiStudenti = new string[]
        {
            "23;Allasia;Michele;1 INF A",
            "45;Valinotti;Luigi;2 INF A",
            "52;Bogetti;Leonardo;2 INF A",
            "76;Picco;Daniela;1 INF A",
            "99;Bo;Maria;1 INF A",
            "98;Picco;Luisa;3 INF A",
            "80;Allassia;Michela;1 INF A"
        };
        string[] datiValutazioni = new string[]
        {
            "1;7;Italiano;99",
            "2;5;Inglese;99",
            "3;8;Italiano;23",
            "4;4;Informatica;23",
            "5;9;Sistemi;45",
            "6;7;Italiano;80",
            "7;5;Inglese;98",
            "8;8;Italiano;76",
            "9;4;Informatica;23",
            "10;9;Sistemi;45",
            "11;7;Italiano;76",
            "12;5;Inglese;80",
            "13;8;Italiano;98",
            "14;4;Informatica;52",
            "15;9;Sistemi;80"
        };

        studente[] studenti = new studente[10];
        valutazione[] valutazioni = new valutazione[20];
        int numStudenti;
        int numValutazioni;

        public formMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            numStudenti = caricaTabellaStudenti(studenti, datiStudenti);
            settaDgv(dgvStudenti, "studenti");
            scriviDatiStudenti(studenti, dgvStudenti);
            numValutazioni = caricaTabellaValutazioni(valutazioni, datiValutazioni);
            settaDgv(dgvValutazioni, "voti");
            scriviDatiValutazioni(valutazioni, dgvValutazioni);
        }
        private void scriviDatiValutazioni(valutazione[] valutazioni, DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < numValutazioni; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = valutazioni[i].prog;
                dgv.Rows[i].Cells[1].Value = valutazioni[i].voto;
                dgv.Rows[i].Cells[2].Value = valutazioni[i].materia;
                dgv.Rows[i].Cells[3].Value = valutazioni[i].matricola;
            }
        }
        private int caricaTabellaValutazioni(valutazione[] valutazioni, string[] datiValutazioni)
        {
            for (int i = 0; i < datiValutazioni.Length; i++)
            {
                string[] dato = datiValutazioni[i].Split(';');
                valutazioni[i].prog = int.Parse(dato[0]);
                valutazioni[i].voto = int.Parse(dato[1]);
                valutazioni[i].materia = dato[2];
                valutazioni[i].matricola = int.Parse(dato[3]);
            }
            return datiValutazioni.Length;
        }
        private int caricaTabellaStudenti(studente[] studenti, string[] dati)
        {
            for (int i = 0; i < dati.Length; i++)
            {
                string[] dato = dati[i].Split(';');
                studenti[i].matricola = int.Parse(dato[0]);
                studenti[i].cognome = dato[1];
                studenti[i].nome = dato[2];
                studenti[i].classe = dato[3];
                cmbMatricola.Items.Add(studenti[i].matricola + "-" + studenti[i].cognome + " " + studenti[i].nome);
            }
            return dati.Length;
        }
        private void settaDgv(DataGridView dgv, string nome)
        {
            dgv.ColumnCount = 4;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.RowHeadersVisible = false;
            if (nome == "studenti")
            {
                dgv.Columns[0].HeaderText = "Matricola";
                dgv.Columns[1].HeaderText = "Cognome";
                dgv.Columns[2].HeaderText = "Nome";
                dgv.Columns[3].HeaderText = "Classe";
            }
            else
            {
                dgv.Columns[0].HeaderText = "Progressivo";
                dgv.Columns[1].HeaderText = "Voto";
                dgv.Columns[2].HeaderText = "Materia";
                dgv.Columns[3].HeaderText = "Matricola";

            }
            dgv.AutoResizeColumns();

        }
        private void btnInserisciStudente_Click(object sender, EventArgs e)
        {
            if (!controllaCampi("studenti"))
                MessageBox.Show("Controllare i campi");
            else
            {
                if (!controllaMatricola(numStudenti))
                {
                    MessageBox.Show("Matricola non valida");
                    txtMatricola.Text = "";
                }
                else
                {
                    inserisciStudente(ref numStudenti);
                }
            }
        }
        private void inserisciStudente(ref int n)
        {
            dgvStudenti.Rows.Add();
            int nMatricola = int.Parse(txtMatricola.Text);

            dgvStudenti.Rows[n].Cells[0].Value = studenti[n].matricola = nMatricola;
            dgvStudenti.Rows[n].Cells[1].Value = studenti[n].nome = txtCognome.Text;
            dgvStudenti.Rows[n].Cells[2].Value = studenti[n].cognome = txtNome.Text;
            dgvStudenti.Rows[n].Cells[3].Value = studenti[n].classe = cmbClasse.SelectedItem.ToString();
            cmbMatricola.Items.Add(studenti[n].matricola + "-" + studenti[n].cognome + " " + studenti[n].nome);
            n++;
            svuotaCampiStudente();
        }
        private void svuotaCampiStudente()
        {
            txtMatricola.Text = "";
            txtNome.Text = "";
            txtCognome.Text = "";
            cmbClasse.SelectedIndex = -1;
        }
        private bool controllaMatricola(int n)
        {

            int nMatricola;
            if (!int.TryParse(txtMatricola.Text, out nMatricola)) return false;
            if (n == 0) return true;
            int i = 0;
            while (studenti[i].matricola != nMatricola && i != n - 1)
                i++;
            return studenti[i].matricola != nMatricola;
        }
        private bool controllaCampi(string nomeTabella)
        {
            if (nomeTabella == "studenti")
                return txtMatricola.Text.Length > 0 && txtNome.Text.Length > 0 && txtCognome.Text.Length > 0 && cmbClasse.SelectedItem != null;
            else
                return numVoto.Value != 0 && cmbMateria.SelectedItem != null && cmbMatricola.SelectedItem != null;
        }
        private void btnCercaMatricola_Click(object sender, EventArgs e)
        {
            int nMatricola;
            if (!int.TryParse(txtCercaMatricola.Text, out nMatricola))
            {
                MessageBox.Show("Inserire una matricola valida");
            }
            else
            {
                togliFiltri();
                int i = 0;
                while (studenti[i].matricola != nMatricola && i != numStudenti - 1)
                    i++;
                if (studenti[i].matricola == nMatricola)
                    dgvStudenti.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                else
                    MessageBox.Show("Matricola non trovata");
            }
        }
        private void btnTogliFiltro_Click(object sender, EventArgs e)
        {
            togliFiltri();
        }
        private void togliFiltri()
        {
            for (int i = 0; i < numStudenti; i++)
            {
                dgvStudenti.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void btnCercaClasse_Click(object sender, EventArgs e)
        {

            if (cmbCercaClasse.SelectedItem == null)
                MessageBox.Show("Inserisci una classe valida");
            else
            {
                togliFiltri();
                for (int i = 0; i < numStudenti; i++)
                {
                    if (studenti[i].classe == cmbCercaClasse.SelectedItem.ToString())
                    {
                        dgvStudenti.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }
        private void btnOrdinaMatricola_Click(object sender, EventArgs e)
        {
            studente aus;
            for (int i = 0; i <= numStudenti - 2; i++)
            {
                int posmin = i;
                for (int j = i + 1; j <= numStudenti - 1; j++)
                {
                    if (studenti[posmin].matricola > studenti[j].matricola)
                        posmin = j;
                }
                if (posmin != i)
                {
                    aus = studenti[i];
                    studenti[i] = studenti[posmin];
                    studenti[posmin] = aus;
                }
            }
            scriviDatiStudenti(studenti, dgvStudenti);
        }
        private void scriviDatiStudenti(studente[] studenti, DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < numStudenti; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = studenti[i].matricola;
                dgv.Rows[i].Cells[1].Value = studenti[i].cognome;
                dgv.Rows[i].Cells[2].Value = studenti[i].nome;
                dgv.Rows[i].Cells[3].Value = studenti[i].classe;
            }
        }
        private void btnOrdinaCognome_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= numStudenti - 2; i++)
            {
                int posmin = i;
                for (int j = i + 1; j <= numStudenti - 1; j++)
                {
                    if (String.Compare(studenti[posmin].cognome, studenti[j].cognome) > 0)
                        posmin = j;
                    else if (String.Compare(studenti[posmin].cognome, studenti[j].cognome) == 0)
                    {
                        if (String.Compare(studenti[posmin].nome, studenti[j].nome) > 0)
                            posmin = j;
                    }

                }
                if (posmin != i)
                {
                    studente aus = studenti[i];
                    studenti[i] = studenti[posmin];
                    studenti[posmin] = aus;
                }
            }
            scriviDatiStudenti(studenti, dgvStudenti);
        }
        private void btnInserisciVoto_Click(object sender, EventArgs e)
        {
            if (!controllaCampi("valutazione"))
                MessageBox.Show("Controllare i campi");
            else
            {
                inserisciValutazione(ref numValutazioni);

            }
        }
        private void inserisciValutazione(ref int n)
        {
            dgvValutazioni.Rows.Add();

            dgvValutazioni.Rows[n].Cells[0].Value = valutazioni[n].prog = n + 1;
            dgvValutazioni.Rows[n].Cells[1].Value = valutazioni[n].voto = (int)numVoto.Value;
            dgvValutazioni.Rows[n].Cells[2].Value = valutazioni[n].materia = cmbMateria.SelectedItem.ToString();
            int m = Convert.ToInt32(cmbMatricola.SelectedItem.ToString().Substring(0, 2));
            valutazioni[n].matricola = m;
            dgvValutazioni.Rows[n].Cells[3].Value = m.ToString();
            n++;
            svuotaCampiValutazioni();
        }
        private void svuotaCampiValutazioni()
        {
            numVoto.Text = "";
            cmbMateria.SelectedItem = null;
            cmbMatricola.SelectedItem = null;
        }
        private void btnMediaVotiStudente_Click(object sender, EventArgs e)
        {
            string nominativo = Interaction.InputBox("Inserisci nominativo dello studente");
            //ordinamento per cognome 
            for (int i = 0; i <= numStudenti - 2; i++)
            {
                int posmin = i;
                for (int j = i + 1; j <= numStudenti - 1; j++)
                {
                    if (String.Compare(studenti[posmin].cognome, studenti[j].cognome) > 0)
                        posmin = j;
                    else if (String.Compare(studenti[posmin].cognome, studenti[j].cognome) == 0)
                    {
                        if (String.Compare(studenti[posmin].nome, studenti[j].nome) > 0)
                            posmin = j;
                    }

                }
                if (posmin != i)
                {
                    studente aus = studenti[i];
                    studenti[i] = studenti[posmin];
                    studenti[posmin] = aus;
                }
            }

            //esercizio
            int matr = cercaCognome(nominativo, studenti);
            if (matr == -1)
                MessageBox.Show("studente non trovato, ERRORE");
            else
            {
                double media = calcolaMediaStudente(matr, valutazioni);
                if (media != -1)
                    MessageBox.Show("La media è " + media.ToString());
                else
                    MessageBox.Show("Non ha voti");
            }

        }
        private double calcolaMediaStudente(int matr, valutazione[] valutazioni)
        {
            valutazione aus;
            for (int k = 0; k <= numValutazioni - 2; k++)
            {
                int posmin = k;
                for (int j = k + 1; j <= numValutazioni - 1; j++)
                {
                    if (valutazioni[posmin].matricola > valutazioni[j].matricola)
                        posmin = j;
                }
                if (posmin != k)
                {
                    aus = valutazioni[k];
                    valutazioni[k] = valutazioni[posmin];
                    valutazioni[posmin] = aus;
                }
            }
            int i = 0;
            bool sup = false;
            bool trov = false;
            double somma = 0;
            int cont = 0;
            while (!sup && i <= numValutazioni - 1)
            {
                if (valutazioni[i].matricola == matr)
                {
                    cont++;
                    somma += valutazioni[i].voto;
                    trov = true;
                    i++;
                }
                else
                {
                    if (valutazioni[i].matricola > matr)
                        sup = true;
                    else
                        i++;
                }
            }
            if (trov)
                return somma / cont;
            else
                return -1;

        }
        private int cercaCognome(string nominativo, studente[] studenti)
        {
            int i = 0;
            string aus = studenti[0].cognome + " " + studenti[0].nome;
            while (String.Compare(aus, nominativo) < 0 && i != studenti.Length)
            {
                i++;
                aus = studenti[i].cognome + " " + studenti[i].nome;
            }
            if (aus == nominativo)
                return studenti[i].matricola;
            else
                return -1;
        }
        private void btnMediaMaggiore_Click(object sender, EventArgs e)
        {

            //ordinamento per matricola
            valutazione aus;
            for (int i = 0; i <= numValutazioni - 2; i++)
            {
                int posmin = i;
                for (int j = i + 1; j <= numValutazioni - 1; j++)
                {
                    if (valutazioni[posmin].matricola > valutazioni[j].matricola)
                        posmin = j;
                }
                if (posmin != i)
                {
                    aus = valutazioni[i];
                    valutazioni[i] = valutazioni[posmin];
                    valutazioni[posmin] = aus;
                }
            }
            //media più alta
            int cnt = 0;
            int somma = 0, mat = 0;
            double max = int.MinValue, media;
            int ausi = valutazioni[0].matricola;

            for (int i = 0; i < numValutazioni; i++)
            {
                if (ausi == valutazioni[i].matricola)
                {
                    cnt++;
                    somma += valutazioni[i].voto;
                }
                else
                {
                    media = somma / cnt;

                    if (media > max)
                    {
                        max = media;
                        mat = valutazioni[i - 1].matricola;
                    }

                    somma = valutazioni[i].voto;
                    cnt = 1;
                    ausi = valutazioni[i].matricola;
                }
            }

            ricercaStudente(mat);
        }
        private void ricercaStudente(int mat)
        {
            int i = 0;
            while (studenti[i].matricola != mat && i != numStudenti - 1)
                i++;
            if (studenti[i].matricola == mat)
            {
                string nominativo = studenti[i].cognome + " " + studenti[i].nome;
                MessageBox.Show("lo studente con la media più alta è " + nominativo);
            }
        }
        private void btnMateriaPiuInsuff_Click(object sender, EventArgs e)
        {
            string aus;

            for (int i = 0; i <= numValutazioni - 2; i++)
            {
                int posmin = i;

                for (int j = i + 1; j <= numValutazioni - 1; j++)
                {
                    if (string.Compare(valutazioni[posmin].materia, valutazioni[j].materia) > 0)
                        posmin = j;
                }
                if (posmin != i)
                {
                    aus = valutazioni[i].materia;
                    valutazioni[i].materia = valutazioni[posmin].materia;
                    valutazioni[posmin].materia = aus;
                }
            }

            double cont = 0;
            double max = int.MinValue;
            string ausi = valutazioni[0].materia, mat = "";

            for (int i = 0; i < numValutazioni; i++)
            {
                if (ausi == valutazioni[i].materia)
                {
                    if (valutazioni[i].voto < 6)
                    {
                        cont++;
                    }
                }
                else
                {
                    if (cont > max)
                    {
                        max = cont;
                        mat = valutazioni[i - 1].materia;
                    }

                    if (valutazioni[i].voto < 6)
                    {
                        cont = 1;
                    }
                    else
                    {
                        cont = 0;
                    }

                    ausi = valutazioni[i].materia;
                }
            }

            MessageBox.Show("La materia con maggior insufficienze e' " + mat);
        }
    }
}
