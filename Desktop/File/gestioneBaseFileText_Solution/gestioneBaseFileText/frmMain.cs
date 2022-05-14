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
            settaDgvAutori(dgvAutori);
            caricaCmbAutori("libri.txt", cmbAutori);
        }
        private void settaDgvAutori(DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            dgv.Columns[0].HeaderText = "Codice";
            dgv.Columns[1].HeaderText = "Cognome";
            dgv.Columns[2].HeaderText = "Nome";
            dgv.Columns[3].HeaderText = "Nazione";
            dgv.AutoResizeColumns();
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.Vertical;
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

            sr.Close();

            i = 0;
            sr = new StreamReader("autori.txt");

            while (sr.Peek() > -1) //finche' non finisco file
            {
                s = sr.ReadLine(); //legge una linea del file
                v = s.Split(';');

                scriviSuDgv(i, v, dgvAutori);

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
        private void btnFileLibriAnno_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("libri.txt");
            string[] v = new string[4], libri = new string[10];
            int[] anno = new int[10];
            string libro, s = "";
            int n = 0;

            while (sr.Peek() > -1)
            {
                libro = sr.ReadLine();
                v = libro.Split(';');
                anno[n] = int.Parse(v[2]);
                libri[n++] = v[0];
            }

            sr.Close();
            ordinaLibroAnno(anno, libri, n);
            Array.Resize(ref anno, anno.Length + 1);

            for (int i = 0; i < n; i++)
            {
                s += libri[i] + "\n";

                if (anno[i] != anno[i + 1])
                {
                    StreamWriter sw = new StreamWriter(anno[i].ToString() + ".txt", false);

                    sw.WriteLine(s);
                    sw.Close();

                    s = "";
                }
            }
        }
        private void ordinaLibroAnno(int[] anno, string[] libri, int n)
        {
            int PosMin;

            for (int i = 0; i <= n - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (anno[PosMin] > anno[j])
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    int aus = anno[i];
                    anno[i] = anno[PosMin];
                    anno[PosMin] = aus;

                    string ausS = libri[i];
                    libri[i] = libri[PosMin];
                    libri[PosMin] = ausS;
                }
            }
        }
        private void btnDividiLibriAutore_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("libri.txt");
            string[] v = new string[4], libri = new string[10];
            string[] autori = new string[10];
            string libro, s = "";
            int n = 0;

            while (sr.Peek() > -1)
            {
                libro = sr.ReadLine();
                v = libro.Split(';');
                autori[n] = v[1];
                libri[n++] = v[0];
            }

            sr.Close();
            ordinaLibroAutore(autori, libri, n);
            Array.Resize(ref autori, autori.Length + 1);

            for (int i = 0; i < n; i++)
            {
                s += libri[i] + "\n";

                if (autori[i] != autori[i + 1])
                {
                    StreamWriter sw = new StreamWriter(autori[i].ToString() + ".txt", false);

                    sw.WriteLine(s);
                    sw.Close();

                    s = "";
                }
            }
        }
        private void ordinaLibroAutore(string[] autori, string[] libri, int n)
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

                    aus = libri[i];
                    libri[i] = libri[PosMin];
                    libri[PosMin] = aus;
                }
            }
        }
        private void btnContaLibriAutore_Click(object sender, EventArgs e)
        {
            string autore = cmbAutori.SelectedItem.ToString();

            MessageBox.Show("L'autore " + autore + " ha pubblicato " + contaLibriAutore("libri.txt", autore).ToString() + " libri");
        }
        private int contaLibriAutore(string nf, string autore)
        {
            int cont = 0;

            foreach (string libro in System.IO.File.ReadLines(nf))
            {
                string[] campi = new string[4];

                campi = libro.Split(';');

                if (campi[1] == autore)
                {
                    cont++;
                }
            }

            return cont;
        }
        private void btnLibriNazione_Click(object sender, EventArgs e)
        {
            string nazione = Interaction.InputBox("Inserisci la nazione");

            cercaLibriNazione("autori.txt", "libri.txt", nazione);
        }
        private void cercaLibriNazione(string nfAutori, string nfLibri, string nazione)
        {
            string output = "";

            foreach (string autore in System.IO.File.ReadLines(nfAutori))
            {
                string[] campi = new string[4];

                campi = autore.Split(';');

                if (campi[3] == nazione)
                {
                    output += cercaLibriAutoreCodice(nfLibri, campi[0]);
                }
            }

            MessageBox.Show(output);
        }
        private string cercaLibriAutoreCodice(string nf, string codice)
        {
            string output = "";

            foreach (string libro in File.ReadLines(nf))
            {
                string[] campi = new string[4];

                campi = libro.Split(';');

                if (campi[1] == codice)
                {
                    output += campi[0] + "\n";
                }
            }

            return output;
        }
        private void btnAutorePiuLibri_Click(object sender, EventArgs e)
        {
            string[] autori = new string[100], libriCodAuto = new string[100];
            int nAutori = 0, nLibri = 0, cont = 0, contMax = -1;
            string AutoTop = "";

            foreach (string riga in File.ReadLines("autori.txt"))
            {
                string[] campi = new string[4];

                campi = riga.Split(';');
                autori[nAutori++] = campi[0];
            }

            foreach (string riga in File.ReadLines("libri.txt"))
            {
                string[] campi = new string[4];

                campi = riga.Split(';');
                libriCodAuto[nLibri++] = campi[1];
            }

            libriCodAuto[nLibri] = "ZZ";

            ordinaLibriCodAuto(libriCodAuto, nLibri);

            for (int i = 0; i < nLibri; i++)
            {
                cont++;

                if (libriCodAuto[i] != libriCodAuto[i + 1])
                {
                    if (cont > contMax)
                    {
                        contMax = cont;
                        AutoTop = libriCodAuto[i];
                    }

                    cont = 0;
                }
            }

            MessageBox.Show("L'autore con piu' libri e' " + cercaAutoreCod(AutoTop, "autori.txt") + " con " + contMax + " libri");
        }
        private string cercaAutoreCod(string autoTop, string nf)
        {
            StreamReader sr = new StreamReader(nf);
            bool esci = false;
            string[] campi = new string[4];

            do
            {
                campi = sr.ReadLine().Split(';');

                if (campi[0] == autoTop)
                {
                    esci = true;
                }
            } while (!esci);

            sr.Close();

            return campi[1];
        }
        private void ordinaLibriCodAuto(string[] libriCodAuto, int nLibri)
        {
            int PosMin;

            for (int i = 0; i <= nLibri - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= nLibri - 1; j++)
                {
                    if (string.Compare(libriCodAuto[PosMin], libriCodAuto[j]) > 0)
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    string aus = libriCodAuto[i];
                    libriCodAuto[i] = libriCodAuto[PosMin];
                    libriCodAuto[PosMin] = aus;
                }
            }
        }
        private void btnAutoreNessunLibro_Click(object sender, EventArgs e)
        {
            string[] autori = new string[100], libriCodAuto = new string[100];
            int nAutori = 0, nLibri = 0;
            string nessunLibro = "";

            foreach (string riga in File.ReadLines("autori.txt"))
            {
                string[] campi = new string[4];

                campi = riga.Split(';');
                autori[nAutori++] = campi[0];
            }

            foreach (string riga in File.ReadLines("libri.txt"))
            {
                string[] campi = new string[4];

                campi = riga.Split(';');
                libriCodAuto[nLibri++] = campi[1];
            }

            libriCodAuto[nLibri] = "ZZ";

            ordinaLibriCodAuto(libriCodAuto, nLibri);

            int j = 0;

            for (int i = 0; i < nAutori; i++)
            {
                int cont = 0;

                while (libriCodAuto[j] == autori[i] && j < nLibri)
                {
                    cont++;
                    j++;
                }

                if (cont == 0)
                {
                    nessunLibro += cercaAutoreCod(autori[i], "autori.txt") + " ";
                }
            }

            MessageBox.Show("Gli autori con nessun libro sono: " + nessunLibro);
        }
    }
}
