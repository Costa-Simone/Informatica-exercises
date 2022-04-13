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

namespace GestioneTabella
{
    public partial class FormMain : Form
    {
        public struct Studente
        {
            public int Matricola;
            public string Cognome;
            public string Nome;
            public string Classe;
        }

        public struct Valutazione
        {
            public int Prog;
            public int Voto;
            public string Materia;
            public int Matricola; // chiave esterna
        }

        string[] datiStudenti = new string[]
        {
            "23;Allasia;Michele;1 INF A",
            "45;Valinotti;Luigi;2 INF A",
            "52;Boffa;Riccardo;2 INF A",
            "76;Picco;Daniela;1 INF A",
            "77;Bo;Maria;1 INF A",
            "88;Picco;Luisa;3 INF A",
            "89;Allasia;Michela;1 INF A"
        };

        string[] datiValutazioni = new string[]
        {
            "1;7;Italiano;77",
            "2;5;Inglese;77",
            "3;8;Italiano;23",
            "4;4;Informatica;23",
            "5;9;Sistemi;45",
            "6;10;Italiano;89",
            "7;5;Inglese;88",
            "8;10;Italiano;89",
            "9;4;Informatica;52",
            "10;9;Sistemi;76",
            "11;7;Italiano;52",
            "12;5;Inglese;45",
            "13;8;Italiano;76",
            "14;4;Informatica;45",
            "15;9;Sistemi;52"
        };

        Studente[] studenti = new Studente[10];
        Valutazione[] valutazioni = new Valutazione[20];

        int numStudenti;
        int numValutazioni;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            numStudenti = caricaTabellaStudenti(studenti, datiStudenti);
            settaDgv(dgvStudenti, "studenti");
            scriviDatiStudenti(studenti, dgvStudenti);
            numValutazioni = caricaTabellaValutazioni(valutazioni, datiValutazioni);
            settaDgv(dgvValutazioni, "valutazioni");
            scriviDatiValutazioni(valutazioni, dgvValutazioni);
        }

        private int caricaTabellaStudenti(Studente[] studenti, string[] dati)
        {
            for (int i = 0; i < dati.Length; i++)
            {
                string[] dato = dati[i].Split(';');
                studenti[i].Matricola = int.Parse(dato[0]);
                studenti[i].Cognome = dato[1];
                studenti[i].Nome = dato[2];
                studenti[i].Classe = dato[3];
                cmbMatricola.Items.Add(studenti[i].Matricola + 
                    " - " +
                    studenti[i].Cognome +
                    " " +
                    studenti[i].Nome);
            }
            return dati.Length;
        }

        private int caricaTabellaValutazioni(Valutazione[] valutazioni, string[] dati)
        {
            for (int i = 0; i < dati.Length; i++)
            {
                string[] dato = dati[i].Split(';');
                valutazioni[i].Prog = int.Parse(dato[0]);
                valutazioni[i].Voto = int.Parse(dato[1]);
                valutazioni[i].Materia = dato[2];
                valutazioni[i].Matricola = int.Parse(dato[3]);
            }
            return dati.Length;
        }

        private void settaDgv(DataGridView dgv, string nomeTabella)
        {
            dgv.ColumnCount = 4;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.RowHeadersVisible = false;
            if (nomeTabella == "studenti")
            {
                dgv.Columns[0].HeaderText = "Matricola";
                dgv.Columns[1].HeaderText = "Cognome";
                dgv.Columns[2].HeaderText = "Nome";
                dgv.Columns[3].HeaderText = "Classe";
            }
            else
            {
                dgv.Columns[0].HeaderText = "Prog";
                dgv.Columns[1].HeaderText = "Voto";
                dgv.Columns[2].HeaderText = "Materia";
                dgv.Columns[3].HeaderText = "Matricola";
            }
            dgv.AutoResizeColumns();
        }

        private void btnInserisciStudente_Click(object sender, EventArgs e)
        {
            if (!controllaCampi("studenti"))
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
                {
                    inserisciStudente(ref numStudenti);
                }
            }
        }

        private void inserisciStudente(ref int n)
        {
            dgvStudenti.Rows.Add();
            int nMatricola = int.Parse(txtMatricola.Text);
            dgvStudenti.Rows[n].Cells[0].Value = studenti[n].Matricola = nMatricola;
            dgvStudenti.Rows[n].Cells[1].Value = studenti[n].Nome = txtNome.Text;
            dgvStudenti.Rows[n].Cells[2].Value = studenti[n].Cognome = txtCognome.Text;
            dgvStudenti.Rows[n].Cells[3].Value = studenti[n].Classe = cmbClasse.SelectedItem.ToString();
            cmbMatricola.Items.Add(studenti[n].Matricola +
                    " - " +
                    studenti[n].Cognome +
                    " " +
                    studenti[n].Nome);
            n++;
            svuotaCampiStudenti();
        }

        private void svuotaCampiStudenti()
        {
            txtMatricola.Text = "";
            txtNome.Text = "";
            txtCognome.Text = "";
            cmbClasse.SelectedItem = null;
        }

        private bool controllaMatricola(int n)
        {
            int nMatricola;
            if (!int.TryParse(txtMatricola.Text, out nMatricola)) return false;
            if (n == 0) return true;
            int i = 0;
            while (studenti[i].Matricola != nMatricola && i != n - 1)
                i++;
            return studenti[i].Matricola != nMatricola;
        }

        private bool controllaCampi(string nomeTabella)
        {
            if (nomeTabella == "studenti")
            {
                return txtMatricola.Text.Length > 0 &&
                txtNome.Text.Length > 0 &&
                txtCognome.Text.Length > 0 &&
                cmbClasse.SelectedItem != null;
            }
            else
            {
                return numVoto.Value != 0 &&
                cmbMateria.SelectedItem != null &&
                cmbMatricola.SelectedItem != null;
            }
            
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
                while (studenti[i].Matricola != nMatricola && i != numStudenti - 1)
                    i++;
                if (studenti[i].Matricola == nMatricola)
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
                dgvStudenti.Rows[i].DefaultCellStyle.BackColor = Color.White;
        }

        private void btnCercaClasse_Click(object sender, EventArgs e)
        {
            if (cmbRicercaClasse.SelectedItem == null)
            {
                MessageBox.Show("Inserire una classe valida");
            }
            else
            {
                togliFiltri();
                for (int i = 0; i < numStudenti; i++)
                {
                    if (studenti[i].Classe == cmbRicercaClasse.SelectedItem.ToString())
                    {
                        dgvStudenti.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }

        private void btnOrdinaMatricola_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= numStudenti - 2; i++)
            {
                int posMin = i;
                for (int j = i + 1; j <= numStudenti - 1; j++)
                {
                    if (studenti[posMin].Matricola > studenti[j].Matricola)
                    {
                        posMin = j;
                    }
                }
                if (posMin != i)
                {
                    Studente aus = studenti[i];
                    studenti[i] = studenti[posMin];
                    studenti[posMin] = aus;
                }
            }
            scriviDatiStudenti(studenti, dgvStudenti);
        }

        private void scriviDatiStudenti(Studente[] stud, DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < numStudenti; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = stud[i].Matricola;
                dgv.Rows[i].Cells[1].Value = stud[i].Cognome;
                dgv.Rows[i].Cells[2].Value = stud[i].Nome;
                dgv.Rows[i].Cells[3].Value = stud[i].Classe;
            }
        }

        private void scriviDatiValutazioni(Valutazione[] valut, DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < numValutazioni; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = valut[i].Prog;
                dgv.Rows[i].Cells[1].Value = valut[i].Voto;
                dgv.Rows[i].Cells[2].Value = valut[i].Materia;
                dgv.Rows[i].Cells[3].Value = valut[i].Matricola;
            }
        }

        private void btnOrdinaCognome_Click(object sender, EventArgs e)
        {
            ordinaCognome(studenti);
            scriviDatiStudenti(studenti, dgvStudenti);
        }

        private void ordinaCognome(Studente[] studenti)
        {
            for (int i = 0; i <= numStudenti - 2; i++)
            {
                int posMin = i;
                for (int j = i + 1; j <= numStudenti - 1; j++)
                {
                    if (string.Compare(studenti[posMin].Cognome, studenti[j].Cognome) > 0)
                    {
                        posMin = j;
                    }
                    else if (string.Compare(studenti[posMin].Cognome, studenti[j].Cognome) == 0)
                    {
                        if (string.Compare(studenti[posMin].Nome, studenti[j].Nome) > 0)
                        {
                            posMin = j;
                        }
                    }
                }
                if (posMin != i)
                {
                    Studente aus = studenti[i];
                    studenti[i] = studenti[posMin];
                    studenti[posMin] = aus;
                }
            }
        }
        private void btnInserisciVoto_Click(object sender, EventArgs e)
        {
            if (!controllaCampi("valutazione"))
            {
                MessageBox.Show("Controllare i campi");
            }
            else
            {
                inserisciValutazione(ref numValutazioni);
            }
        }

        private void inserisciValutazione(ref int n)
        {
            dgvValutazioni.Rows.Add();
            dgvValutazioni.Rows[n].Cells[0].Value = valutazioni[n].Prog = n + 1;
            dgvValutazioni.Rows[n].Cells[1].Value = valutazioni[n].Voto = (int)numVoto.Value;
            dgvValutazioni.Rows[n].Cells[2].Value = valutazioni[n].Materia = cmbMateria.SelectedItem.ToString();
            int m = Convert.ToInt32(cmbMatricola.SelectedItem.ToString().Substring(0, 2));
            valutazioni[n].Matricola = m;
            dgvValutazioni.Rows[n].Cells[3].Value = m.ToString();
            n++;
            svuotaCampiValutazioni();
        }

        private void svuotaCampiValutazioni()
        {
            numVoto.Text = "3";
            cmbMateria.SelectedItem = null;
            cmbMatricola.SelectedItem = null;
        }

        private void btnMediaVotiStudente_Click(object sender, EventArgs e)
        {
            string nominativo = Interaction.InputBox("Inserisci il nominativo dello studente", "INPUT");

            ordinaCognome(studenti);
            int matr = cercaCognome(nominativo, studenti);
            if (matr == -1)
                MessageBox.Show("Studente non trovato", "Errore");
            else
            {
                double media = calcolaMediaStudente(matr, valutazioni);
                if(media==-1)
                    MessageBox.Show("Lo studente non ha voti", "Attenzione");
                else
                    MessageBox.Show(media.ToString());
            }
        }

        private double calcolaMediaStudente(int matr, Valutazione[] valutazioni)
        {
            ordinaValutazioniMatricola(valutazioni);
            int i = 0;
            bool trovato = false;
            bool superato = false;
            double somma = 0;
            int cont = 0;

            while(!superato && i<=numValutazioni-1)
            {
                if(valutazioni[i].Matricola==matr)
                {
                    somma += valutazioni[i].Voto;
                    cont++;
                    trovato = true;
                    i++;
                }
                else
                {
                    if (valutazioni[i].Matricola > matr)
                        superato = true;
                    else
                        i++;
                }
            }
            if(trovato)
                return somma/cont;
            else
                return -1;
        }

        private void ordinaValutazioniMatricola(Valutazione[] valutazioni)
        {
            int posMin;

            for (int i = 0; i <= numValutazioni - 2; i++)
            {
                posMin = i;
                for (int j = i + 1; j <= numValutazioni - 1; j++)
                {
                    if (valutazioni[posMin].Matricola > valutazioni[j].Matricola)
                        posMin = j;
                }
                if (posMin != i)
                {
                    Valutazione aus = valutazioni[i];
                    valutazioni[i] = valutazioni[posMin];
                    valutazioni[posMin] = aus;
                }
            }
        }

        private int cercaCognome(string nominativo, Studente[] studenti)
        {
            int i = 0;
            string aus = studenti[0].Cognome + " " + studenti[0].Nome;
            while(String.Compare(aus,nominativo)<0 && i!=studenti.Length)
            {
                i++;
                aus = studenti[i].Cognome + " " + studenti[i].Nome;
            }
            if (aus == nominativo)
                return studenti[i].Matricola;
            else
                return -1;
        }

        private void btnStudenteMediaMax_Click(object sender, EventArgs e)
        {
            ordinaValutazioniMatricola(valutazioni);
            calcolaMediaMaxStudente(valutazioni, studenti);
        }

        private void calcolaMediaMaxStudente(Valutazione[] valutazioni, Studente[] studenti)
        {
            double max = 0;
            int matrMax=0;
            double somma;
            int cont;
            double media;

            somma = valutazioni[0].Voto;
            cont = 1;
            for (int i = 0; i < numValutazioni; i++)
            {
                if (valutazioni[i].Matricola == valutazioni[i + 1].Matricola)
                {
                    somma += valutazioni[i + 1].Voto;
                    cont++;
                }
                else //se rompo la chiave
                {
                    media = somma / cont;
                    if (media > max)
                    {
                        max = media;
                        matrMax = valutazioni[i].Matricola;
                    }
                    somma = valutazioni[i + 1].Voto;
                    cont = 1;
                }
            }
            media = somma / cont;
            if (media > max)
            {
                max = media;
                matrMax = valutazioni[numValutazioni].Matricola;
            }
            MessageBox.Show("Media massima: " + max.ToString());
            MessageBox.Show("Studente: " + cercaStudenteMatr(studenti, matrMax));
        }

        private string cercaStudenteMatr(Studente[] studenti, int matr)
        {
            int i = 0;

            while (studenti[i].Matricola != matr)
                i++;
            return studenti[i].Cognome + " " + studenti[i].Nome;
        }

        private void btnMateriaPiuInsuff_Click(object sender, EventArgs e)
        {
            ordinaValutazioniMaterie(valutazioni);
            cercaMateriaPiùInsuff(valutazioni,numValutazioni);

        }

        private void cercaMateriaPiùInsuff(Valutazione[] valutazioni,int numValutazioni)
        {
            int max = 0;
            string materiaMax = "";
            int cont;

            if(valutazioni[0].Voto < 6)
                cont = 1;
            else
                cont = 0;
            for (int i = 0; i < numValutazioni; i++)
            {
                if (valutazioni[i].Materia == valutazioni[i + 1].Materia)
                {
                    if(valutazioni[i].Voto<6)
                        cont++;
                }
                else //se rompo la chiave
                {
                    if (cont > max)
                    {
                        max = cont;
                        materiaMax = valutazioni[i].Materia;
                    }
                    if (valutazioni[i+1].Voto < 6)
                        cont = 1;
                    else
                        cont = 0;
                }
            }
            if (cont > max)
            {
                max = cont;
                materiaMax = valutazioni[numValutazioni].Materia;
            }
            MessageBox.Show("Materia: " + materiaMax+
                "con "+max.ToString()+" insufficienze");
        }

        private void ordinaValutazioniMaterie(Valutazione[] valutazioni)
        {
            int posMin;

            for (int i = 0; i <= numValutazioni - 2; i++)
            {
                posMin = i;
                for (int j = i + 1; j <= numValutazioni - 1; j++)
                {
                    if (String.Compare(valutazioni[posMin].Materia,valutazioni[j].Materia)>0)
                        posMin = j;
                }
                if (posMin != i)
                {
                    Valutazione aus = valutazioni[i];
                    valutazioni[i] = valutazioni[posMin];
                    valutazioni[posMin] = aus;
                }
            }
        }

        private void btnMediaVotiClasse_Click(object sender, EventArgs e)
        {
            string classe = Interaction.InputBox("Inserisci la classe", "INPUT");

            if (ricercaClasse(classe, cmbClasse))
            {
                ordinaStudentiClasse(studenti);
                ordinaValutazioniMatricola(valutazioni);
                calcolaMediaClasse(classe, studenti, valutazioni);
            }      
            else
                MessageBox.Show("NON Trovata");
        }

        private void calcolaMediaClasse(string classe, Studente[] studenti, Valutazione[] valutazioni)
        {
            double sommaVoti = 0;
            int contVoti = 0;
            int i = 0;
            bool superato = false;
            int matr;

            while(!superato&&i<=numStudenti-1)
            {
                if(studenti[i].Classe==classe)
                {
                    matr = studenti[i].Matricola;
                    sommaVoti += rotturaValutazione(valutazioni, matr, ref contVoti);
                    //vado a prendere la matricola dello
                    //studente e poi passo alla
                    //tabella valutazioni ordinata in base alla matricola
                    //facendo un'altra rottura di chiave
                    i++;
                }
                else
                {
                    if (String.Compare(studenti[i].Classe, classe) > 0)
                        superato = true;
                    else
                        i++;
                }
            }
            MessageBox.Show("La media della classe " + classe +
                " è: " + sommaVoti / contVoti);
        }

        private double rotturaValutazione(Valutazione[] valutazioni, int matr, ref int contVoti)
        {
            int i = 0;
            bool superato=false;
            double somma = 0;

            while(!superato && i<=numValutazioni-1)
            {
                if(valutazioni[i].Matricola==matr)
                {
                    somma += valutazioni[i].Voto;
                    contVoti++;
                    i++;
                }
                else
                {
                    if (valutazioni[i].Matricola > matr)
                        superato = true;
                    else
                        i++;
                }
            }
            return somma;
        }

        private void ordinaStudentiClasse(Studente[] studenti)
        {
            int posMin;

            for (int i = 0; i <= numStudenti - 2; i++)
            {
                posMin = i;
                for (int j = i + 1; j <= numStudenti - 1; j++)
                {
                    if (string.Compare(studenti[posMin].Classe, studenti[j].Classe) > 0)
                        posMin = j;
                }
                if (posMin != i)
                {
                    Studente aus = studenti[i];
                    studenti[i] = studenti[posMin];
                    studenti[posMin] = aus;
                }
            }
        }

        private bool ricercaClasse(string classe, ComboBox cmb)
        {
            bool trovato = false;

            foreach (var item in cmb.Items)
            {
                if (item.ToString() == classe)
                    trovato = true;
            }
            return trovato;
        }

        private void btnMediaVotiMateria_Click(object sender, EventArgs e)
        {
            string materia = Interaction.InputBox("Inserisci la materia", "INPUT");

            if (ricercaMateria(materia, cmbMateria))
            {
                ordinaValutazioniMaterie(valutazioni);
                double media = rotturaValutazioniMateria(valutazioni, materia);
                if (media == 0)
                    MessageBox.Show("Non ci sono voti");
                else
                    MessageBox.Show("La media dei voti di " + materia
                        + " è: " + media.ToString());
            }
            else
                MessageBox.Show("Materia NON trovata");
        }

        private double rotturaValutazioniMateria(Valutazione[] valutazioni, string materia)
        {
            int i = 0;
            bool superato = false;
            double sommaVoti = 0;
            int contVoti = 0;

            while(!superato && i<=numValutazioni-1)
            {
                if(valutazioni[i].Materia==materia)
                {
                    sommaVoti += valutazioni[i].Voto;
                    contVoti++;
                    i++;
                }
                else
                {
                    if (String.Compare(valutazioni[i].Materia, materia) > 0)
                        superato = true;
                    else
                        i++;
                }
            }
            return sommaVoti / contVoti;
        }

        private bool ricercaMateria(string materia, ComboBox cmb)
        {
            bool trovato = false;

            foreach (var item in cmb.Items)
            {
                if (item.ToString() == materia)
                    trovato = true;
            }
            return trovato;
        }
    }
}
