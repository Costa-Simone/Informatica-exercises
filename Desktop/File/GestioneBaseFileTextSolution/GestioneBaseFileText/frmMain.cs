using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  //NOTA BENE
using Microsoft.VisualBasic;

namespace GestioneBaseFileText
{
    public partial class frmMain : Form
    {
        public struct aus
        {
            public string codEditore;
            public string codAutore;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            settaDgvLibri(dgvLibri);
            caricaCmbAutori("Libri.txt", cmbAutori);
            settaDgvAutori(dgvAutori);
            settaDgvEditori(dgvEditori);
            caricaCmbEditori("Editori.txt", cmbEditori);
        }

        private void caricaCmbEditori(string nf, ComboBox cmb)
        {
            int n = 0;
            StreamReader sr = new StreamReader(nf);

            string editore;
            string[] campi = new string[4]; //per splittare
            while (sr.Peek() > -1) // finchè non è finito il file (EOF)
            {
                editore = sr.ReadLine(); //legge una linea dal file (EOL)
                campi = editore.Split(';');
                cmb.Items.Add(campi[0] + "-" + campi[1]);
            }
            sr.Close();
           
        }

        private void settaDgvEditori(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            dgv.Columns[0].HeaderText = "CODICE";
            dgv.Columns[1].HeaderText = "EDITORE";
            dgv.Columns[2].HeaderText = "CITTA'";
            dgv.Columns[3].HeaderText = "NAZIONE";
            dgv.AutoResizeColumns();
        }

        private void settaDgvAutori(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            dgv.Columns[0].HeaderText = "CODICE";
            dgv.Columns[1].HeaderText = "COGNOME";
            dgv.Columns[2].HeaderText = "NOME";
            dgv.Columns[3].HeaderText = "NAZIONE";
            dgv.AutoResizeColumns();
        }

        private void caricaCmbAutori(string nf, ComboBox cmb)
        {
            string[] autori = new string[10];
            int n = 0;
            StreamReader sr = new StreamReader(nf);

            string libro;
            string[] campi = new string[4]; //per splittare
            while (sr.Peek() > -1) // finchè non è finito il file (EOF)
            {
                libro = sr.ReadLine(); //legge una linea dal file (EOL)
                campi = libro.Split(';');
                autori[n++] = campi[1];
            }
            sr.Close();
            ordinaAutori(autori, n);
            caricaComboAutori(autori, n, cmb);
        }

        private void caricaComboAutori(string[] autori, int n, ComboBox cmb)
        {
            for (int i = 0; i < n; i++)
            {
                if (autori[i] != autori[i + 1])
                    cmb.Items.Add(autori[i]);
            }
        }

        private void ordinaAutori(string[] autori, int nAutori)
        {
            int posmin;
            string aus;

            for (int i = 0; i <= nAutori - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= nAutori - 1; j++)
                    if (String.Compare(autori[posmin], autori[j]) > 0)
                        posmin = j;
                if (posmin != i)
                {
                    aus = autori[i];
                    autori[i] = autori[posmin];
                    autori[posmin] = aus;
                }
            }
        }

        private void settaDgvLibri(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            dgv.Columns[0].HeaderText = "TITOLO";
            dgv.Columns[1].HeaderText = "AUTORE";
            dgv.Columns[2].HeaderText = "ANNO";
            dgv.Columns[3].HeaderText = "EDITORE";
            dgv.AutoResizeColumns();
        }

        private void btnLeggiDaFile_Click(object sender, EventArgs e)
        {
            caricaFile("Libri.txt", dgvLibri);
            caricaFile("Autori.txt", dgvAutori);
            caricaFile("Editori.txt", dgvEditori);
        }

        private void caricaFile(string nf, DataGridView dgv)
        {
            StreamReader sr = new StreamReader(nf);

            int i = 0;
            string s;
            string[] v = new string[4]; //per splittare
            dgv.Rows.Clear();
            while (sr.Peek() > -1) // finchè non è finito il file (EOF)
            {
                s = sr.ReadLine(); //legge una linea dal file (EOL)
                v = s.Split(';');
                scriviSuDgv(i, v, dgv);
                i++;
            }
            sr.Close();
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
            StreamWriter sw = new StreamWriter("Libri.txt", false);
            //false --> sovrascrivo il file o locrea
            //true --> appende i nuovi dati al file o lo crea
            string s;
            for (int i = 0; i < dgvLibri.RowCount - 1; i++)
            {
                s = "";
                for (int j = 0; j < dgvLibri.ColumnCount; j++)
                {
                    if (j != dgvLibri.ColumnCount - 1)
                        s += dgvLibri.Rows[i].Cells[j].Value + ";";
                    else
                        s += dgvLibri.Rows[i].Cells[j].Value;
                }
                sw.WriteLine(s);
            }
            sw.Close();
            MessageBox.Show("File salvato");
        }

        private void btnCercaLibriAutoreInput_Click(object sender, EventArgs e)
        {
            string autore = Interaction.InputBox("Inserisci l'autore da cercare");
            cercaLibriAutoreInput("Libri.txt", autore);
        }

        private void cercaLibriAutoreInput(string nf, string autore)
        {
            string libro;
            string[] campi = new string[4];
            string output = "";
            StreamReader sr = new StreamReader(nf);
            while (sr.Peek() > -1)
            {
                libro = sr.ReadLine();
                campi = libro.Split(';');
                if (campi[1] == autore)
                    output += campi[0] + " ";
            }
            sr.Close();
            if (output == "")
                MessageBox.Show("Non ci sono libri");
            else
                MessageBox.Show(output);
        }

        private void btnCercaLibriAutoreCombo_Click(object sender, EventArgs e)
        {
            string autore = cmbAutori.SelectedItem.ToString();
            cercaLibriAutoreInput("Libri.txt", autore);
        }

        private void btnCercaLibroTitolo_Click(object sender, EventArgs e)
        {
            string titolo = Interaction.InputBox("Inserisci il titolo da cercare");
            cercaLibroTitoloInput("Libri.txt", titolo);
        }

        private void cercaLibroTitoloInput(string nf, string titolo)
        {
            //suppogo titoli tutti diversi
            string libro;
            string[] campi = new string[4];
            bool trovato = false;
            StreamReader sr = new StreamReader(nf);
            while (sr.Peek() > -1 && !trovato)
            {
                libro = sr.ReadLine();
                campi = libro.Split(';');
                if (campi[0] == titolo)
                {
                    MessageBox.Show(libro);
                    trovato = true;
                }
            }
            sr.Close();
            if (!trovato)
                MessageBox.Show("Titolo non trovato");
        }

        private void btnDividiFile_Click(object sender, EventArgs e)
        {
            //divido i libri in 2 file chiamati file2005.txt
            //e file 2025.txt
            StreamReader sr = new StreamReader("Libri.txt");
            StreamWriter sw2005 = new StreamWriter("file2005.txt", false);
            StreamWriter sw2025 = new StreamWriter("file2025.txt", false);
            string libro;
            string[] campi = new string[4];
            while (sr.Peek() > -1)
            {
                libro = sr.ReadLine();
                campi = libro.Split(';');
                if (campi[2] == "2005")
                    sw2005.WriteLine(libro);
                else
                    sw2025.WriteLine(libro);
            }
            sw2005.Close();
            sw2025.Close();
            sr.Close();
        }

        private void btnDidiviLibriAutore_Click(object sender, EventArgs e)
        {
            //divido i libri in + file chiamati file_nomeAutore.txt
            string[] autori = new string[100];
            string[] singoli = new string[100];
            int i = 0;
            string libro;
            string[] campi = new string[4];
            StreamReader sr = new StreamReader("Libri.txt");
            while (sr.Peek() > -1)
            {
                libro = sr.ReadLine();
                campi = libro.Split(';');
                autori[i++] = campi[1];
            }
            sr.Close();
            ordinaAutori(autori, i);
            int n = singoliAutori(autori, i, singoli);
            dividiFileAutore(singoli, n);
        }

        private void dividiFileAutore(string[] singoli, int n)
        {
            string nf;
            string libro;
            string[] campi = new string[4];
            for (int i = 0; i < n; i++)
            {
                StreamReader sr = new StreamReader("Libri.txt");
                nf = "file_" + singoli[i] + ".txt";
                StreamWriter sw = new StreamWriter(nf, false);
                while (sr.Peek() > -1)
                {
                    libro = sr.ReadLine();
                    campi = libro.Split(';');
                    if (campi[1] == singoli[i])
                        sw.WriteLine(libro);
                }
                sr.Close();
            }
        }

        private int singoliAutori(string[] autori, int n, string[] singoli)
        {
            int j = 0;

            for (int i = 0; i < n; i++)
            {
                if (autori[i] != autori[i + 1])
                    singoli[j++] = autori[i];
            }
            return j;
        }

        private void btnContaLibriAutore_Click(object sender, EventArgs e)
        {
            string autore = cmbAutori.SelectedItem.ToString();

            MessageBox.Show("L'autore " + autore +
                " ha pubblicato " +
                contaLibriAutore("Libri.txt", autore).ToString() +
                " libri");
        }

        private int contaLibriAutore(string nf, string autore)
        {
            int cont = 0;
            string[] campi = new string[4];
            StreamReader sr = new StreamReader(nf);

            foreach (string libro in File.ReadLines(nf))
            {
                campi = libro.Split(';');
                if (campi[1] == autore)
                    cont++;
            }
            sr.Close();
            return cont;
        }

        private void btnLibriNazione_Click(object sender, EventArgs e)
        {
            string nazione = Interaction.InputBox
                ("Inserisci la nazione");
            cercaLibriNazione("Autori.txt", "Libri.txt", nazione);
        }

        private void cercaLibriNazione(string autori, string libri, string nazione)
        {
            string[] campi = new string[4];
            string output = "";

            foreach (string autore in File.ReadLines(autori))
            {
                campi = autore.Split(';');
                if (campi[3] == nazione)
                    output += cercaLibriAutoreCodice(libri, campi[0]);
            }
            if (output == "")
                MessageBox.Show("Nessun libro");
            else
                MessageBox.Show(output);
        }

        private string cercaLibriAutoreCodice(string libri, string codice)
        {
            string[] campi = new string[4];
            string output = "";

            foreach (string libro in File.ReadLines(libri))
            {
                campi = libro.Split(';');
                if (campi[1] == codice)
                    output += campi[0] + "\n";
            }
            return output;
        }

        private void btnAutorePiuLibri_Click(object sender, EventArgs e)
        {
            string[] codici = new string[100];
            int n = caricaVetAusCodAutori("Libri.txt", codici);
            ordinaAutori(codici, n);
            string codice=cercaAutorePiuLibri(codici, n);
            cercaAutore(codice, "Autori.txt");
        }

        private void cercaAutore(string codice, string nf)
        {
            bool trovato = false;
            string libro;
            string[] campi = new string[4];
            StreamReader sr = new StreamReader(nf);
            while (sr.Peek() > -1 && !trovato)
            {
                libro = sr.ReadLine();
                campi = libro.Split(';');
                if (campi[0] == codice)
                {
                    MessageBox.Show(campi[1]);
                    trovato = true;
                }
            }
            sr.Close();
        }

        private string cercaAutorePiuLibri(string[] codici, int n)
        {
            string codice = "";
            int max = 0;
            int cont = 0;

            for (int i = 0; i < n; i++)
            {
                if (codici[i] == codici[i + 1])
                    cont++;
                else
                {
                    cont++;
                    if(cont>max)
                    {
                        max = cont;
                        codice = codici[i];
                    }
                    cont = 0;
                }
            }
            return codice;
        }

        private int caricaVetAusCodAutori(string nf, string[] codici)
        {
            int n = 0;
            string[] campi = new string[4];

            foreach (string libro in File.ReadLines(nf))
            {
                campi = libro.Split(';');
                codici[n++] = campi[1];
            }
            return n;
        }

        private void btnCercaAutoreSenzaLibri_Click(object sender, EventArgs e)
        {
            string[] codici = new string[100];
            int n = caricaVetAusCodAutori("Libri.txt", codici);
            ordinaAutori(codici, n);
            string[] singoli = new string[100];
            int nSingoli=ricavaCodiciAutori(codici, n, singoli);
            int nAutori = File.ReadAllLines("Autori.txt").Length;
            trovaDifferenzaCodici(singoli, nSingoli, nAutori);
        }

        private void trovaDifferenzaCodici(string[] singoli, int nSingoli, int nAutori)
        {
            int i = 0;
            string codice = "A01";
            while(i<nAutori && singoli[i]==codice)
            {
                i++;
                if (i < 9)
                    codice = "A0" + (i + 1);
                else
                    codice = "A" + i;
            }
            if (i == nAutori)
                MessageBox.Show("Nessun autore ha scritto 0 libri");
            else
                MessageBox.Show(codice);
        }

        private int ricavaCodiciAutori(string[] codici, int n, string[] singoli)
        {
            int j=0;

            for (int i = 0; i < n; i++)
            {
                if (codici[i] != codici[i + 1])
                     singoli[j++] = codici[i];
            }
            return j;
        }

        private void btnLibriAutoreEditore_Click(object sender, EventArgs e)
        {
            string nome = Interaction.InputBox
                ("Inserisci l'autore");
            string codAutore = cercaCodice("Autori.txt",nome);
            if (codAutore == "")
                MessageBox.Show("Autore non trovato");
            else
            {
                nome = Interaction.InputBox
                ("Inserisci l'editore");
                string codEditore = cercaCodice("Editori.txt", nome);
                if (codEditore == "")
                    MessageBox.Show("Editore non trovato");
                else
                    cercaLibriAutoreEditore("Libri.txt", codAutore, codEditore);
            }
        }

        private void cercaLibriAutoreEditore(string nf, string codAutore, string codEditore)
        {
            string[] campi = new string[4];
            string output = "";

            foreach (string libro in File.ReadLines(nf))
            {
                campi = libro.Split(';');
                if (campi[1] == codAutore &&
                    campi[3] == codEditore)
                    output += campi[0] + "\n";
            }
            if (output == "")
                MessageBox.Show("Nessun libro trovato");
            else
                MessageBox.Show(output);
        }

        private string cercaCodice(string nf, string nome)
        {
            string codice = "";
            bool trovato = false;
            string s;
            string[] campi = new string[4];

            StreamReader sr = new StreamReader(nf);
            while(sr.Peek()>-1 && !trovato)
            {
                s = sr.ReadLine();
                campi = s.Split(';');
                if (campi[1] == nome)
                {
                    trovato = true;
                    codice = campi[0];
                }       
            }
            sr.Close();
            return codice;
        }

        private void btnCercaAutoriEditore_Click(object sender, EventArgs e)
        {
            //tabella ausiliaria per caricare
            //codEditore e CodAutore
            //su cui fare ordinamento in base a CodEditore
            //e poi rottura di chiave
            aus[] tabAus = new aus[100];

            string nome = Interaction.InputBox
                ("Inserisci l'editore");
            string codEditore = cercaCodice("Editori.txt", nome);
            if (codEditore == "")
                MessageBox.Show("Editore non trovato");
            else
            {
                int n=creaTabellaAusiliaria("Libri.txt",tabAus);
                ordinaTabellaAusiliaria(tabAus,n);
                rotturaTabellaAusiliaria(tabAus, n, codEditore);
            }

        }

        private void rotturaTabellaAusiliaria(aus[] t, int n, string codice)
        {
            int i = 0;
            bool trovato = false;
            bool superato = false;
            while(!superato && i<=n-1)
            {
                if(t[i].codEditore==codice)
                {
                    //cerca autore con codAutore
                    cercaAutore(t[i].codAutore,"Autori.txt");
                    trovato = true;
                    i++;
                }
                else
                {
                    if (String.Compare(t[i].codEditore, codice) > 0)
                        superato = true;
                    else
                        i++;
                }
            }
            if (!trovato)
                MessageBox.Show("Nessun autore");
        }

        private void ordinaTabellaAusiliaria(aus[] t, int n)
        {
            //ordino in base al campo codEditore
            int posmin;
            aus temp;

            for (int i = 0; i <= n-2; i++)
            {
                posmin = i;
                for (int j = i+1; j <= n-1; j++)
                    if (String.Compare(t[posmin].codEditore,
                        t[j].codEditore) > 0)
                        posmin = j;
                if(posmin!=i)
                {
                    temp = t[i];
                    t[i] = t[posmin];
                    t[posmin] = temp;
                }
            }
        }

        private int creaTabellaAusiliaria(string nf, aus[] t)
        {
            string[] campi = new string[4];
            int i = 0;

            foreach(string Libro in File.ReadLines(nf))
            {
                campi = Libro.Split(';');
                t[i].codEditore = campi[3];
                t[i].codAutore = campi[1];
                i++;
            }
            return i;
        }

        private void btnCreaFileEditore_Click(object sender, EventArgs e)
        {
            string codeditore = cmbEditori.SelectedItem.ToString();
            if (codeditore == "")
                MessageBox.Show("Seleziona un editore");
            else
            {
                codeditore = cmbEditori.SelectedItem.ToString().Substring(0,2);
                creaFileLibriEditore("Libri.txt", codeditore);

            }
        }

        private void creaFileLibriEditore(string nf, string codeditore)
        {
            aus[] tabAus= new aus[100]; //tabella ausiliaria
            string[] campi = new string[4];
            int i = 0;

            foreach(string libro in File.ReadLines(nf))
            {
                campi = libro.Split(';');
                tabAus[i].codEditore = campi[3];
                tabAus[i++].codAutore = campi[0];
            }
            ordinaTabellaAusiliaria(tabAus, i);
            rotturaTabellaAusiliariaCodeditore(tabAus, i, codeditore);
        }

        private void rotturaTabellaAusiliariaCodeditore(aus[] t, int n, string codice)
        {
            int i = 0;
            bool trovato = false;
            bool superato = false;
            string nf = cmbEditori.SelectedItem.ToString().Substring(3);
            StreamWriter sw = new StreamWriter(nf, false);
            while (!superato && i <= n - 1)
            {
                if (t[i].codEditore == codice)
                {

                    sw.WriteLine(t[i].codAutore);
                    sw.Flush();
                    trovato = true;
                    i++;
                }
                else
                {
                    if (String.Compare(t[i].codEditore, codice) > 0)
                        superato = true;
                    else
                        i++;
                }
            }
            sw.Close();
            if (!trovato)
            {
                MessageBox.Show("Nessun libro pubblicato");
                File.Delete(nf);
            }
            else
                MessageBox.Show("FILE CREATO");
               
           
        }
    }
}
