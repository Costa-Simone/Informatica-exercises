using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelleAutoriLibri
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public struct autore
        {
            public string codAut; //chiave primaria
            public string nominativo;
            public string nazione;
        }
        autore[] autori = new autore[10];
        int nAutori;
        public struct libro
        {
            public string codLib; //chiave primaria
            public string titolo;
            public string genere;
            public string codAut; //chiave esterna
        }
        libro[] libri = new libro[20];
        int nLibri;
        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] datiAutori = new string[]
            {
                "A01;Lazzarino;USA",
                "A05;Pelisseri;ITA",
                "A06;Noto;USA",
                "A09;Bogetti;FRA"
            };
            nAutori = datiAutori.Length;
            string[] datiLibri = new string[]
            {
                "L01;La luna;amore;A05",
                "L02;Il sole;avventura;A09",
                "L04;I pianeti;amore;A01",
                "L06;Marte;giallo;A06",
                "L11;Giove;amore;A05",
                "L12;Plutone;giallo;A06",
                "L21;Venere;giallo;A06",
                "L34;Vallauri;avventura;A06",
            };
            nLibri = datiLibri.Length;
            caricaTabellaAutori(autori, datiAutori);
            caricaTabellaLibri(libri, datiLibri);
            settaDgvAutori(autori, dgvAutori);
            settaDgvLibri(libri, dgvLibri);
            visualAutori(autori, dgvAutori);
            visualLibri(libri, dgvLibri);
            caricaCmbAutori(autori, cmbAutori);
            caricaCmbNazioni(autori, cmbNazioni);
            settaDgvGeneriLibri(dgvGeneriLibri);
        }

        private void settaDgvGeneriLibri(DataGridView dgv)
        {
            dgv.ColumnCount = 2;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.RowHeadersVisible = false;
            dgv.Columns[0].HeaderText = "Genere";
            dgv.Columns[1].HeaderText = "N° libri";
            dgv.AutoResizeColumns();
            dgv.Visible = false;
        }

        private void caricaCmbNazioni(autore[] autori, ComboBox cmb)
        {
            ordinaAutoriNazione(autori);
            for (int i = 0; i < nAutori; i++)
            {
                if (autori[i].nazione !=
                    autori[i + 1].nazione)
                    cmb.Items.Add(autori[i].nazione);
            }
        }

        private void ordinaAutoriNazione(autore[] autori)
        {
            int posmin;
            autore aus;

            for (int i = 0; i <= nAutori - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= nAutori - 1; j++)
                    if (String.Compare(autori[posmin].nazione,
                        autori[j].nazione) > 0)
                        posmin = j;
                if (posmin != i)
                {
                    aus = autori[i];
                    autori[i] = autori[posmin];
                    autori[posmin] = aus;
                }
            }
        }

        private void caricaCmbAutori(autore[] autori, ComboBox cmb)
        {
            for (int i = 0; i < nAutori; i++)
                cmb.Items.Add(autori[i].codAut+" - "+
                    autori[i].nominativo);
        }

        private void visualLibri(libro[] libri, DataGridView dgv)
        {
            for (int i = 0; i < nLibri; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = libri[i].codLib;
                dgv.Rows[i].Cells[1].Value = libri[i].titolo;
                dgv.Rows[i].Cells[2].Value = libri[i].genere;
                dgv.Rows[i].Cells[3].Value = libri[i].codAut;
            }
        }

        private void visualAutori(autore[] autori, DataGridView dgv)
        {
            for (int i = 0; i < nAutori; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = autori[i].codAut;
                dgv.Rows[i].Cells[1].Value = autori[i].nominativo;
                dgv.Rows[i].Cells[2].Value = autori[i].nazione;
            }
        }

        private void settaDgvLibri(libro[] libri, DataGridView dgv)
        {
            dgv.ColumnCount = 4;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.RowHeadersVisible = false;
            dgv.Columns[0].HeaderText = "CodLibro";
            dgv.Columns[1].HeaderText = "Titolo";
            dgv.Columns[2].HeaderText = "Genere";
            dgv.Columns[3].HeaderText = "CodAutore";
            dgv.AutoResizeColumns();
        }

        private void settaDgvAutori(autore[] autori, DataGridView dgv)
        {
            dgv.ColumnCount = 3;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.RowHeadersVisible = false;
            dgv.Columns[0].HeaderText = "CodAutore";
            dgv.Columns[1].HeaderText = "Nominativo";
            dgv.Columns[2].HeaderText = "Nazione";
            dgv.AutoResizeColumns();
        }

        private void caricaTabellaLibri(libro[] libri, string[] dati)
        {
            string[] v = new string[4];

            for (int i = 0; i < dati.Length; i++)
            {
                v = dati[i].Split(';');
                libri[i].codLib = v[0];
                libri[i].titolo = v[1];
                libri[i].genere = v[2];
                libri[i].codAut = v[3];
            }
        }

        private void caricaTabellaAutori(autore[] autori, string[] dati)
        {
            string[] v = new string[3];

            for (int i = 0; i < dati.Length; i++)
            {
                v = dati[i].Split(';');
                autori[i].codAut = v[0];
                autori[i].nominativo = v[1];
                autori[i].nazione = v[2];
            }
        }

        private void btnCeraLibriAutore_Click(object sender, EventArgs e)
        {
            string cod = cmbAutori.SelectedItem.ToString();
            cod = cod.Substring(0, 3);
            ordinaLibriCodAutore(libri);
            MessageBox.Show(rotturaLibriCodAutore(libri,cod));
        }

        private string rotturaLibriCodAutore(libro[] libri, string cod)
        {
            int i = 0;
            bool superato=false;
            string output = "";

            while(!superato && i<=nLibri-1)
            {
                if(libri[i].codAut==cod)
                {
                    output += libri[i].titolo + "\n";
                    i++;
                }
                else
                {
                    if (String.Compare(libri[i].codAut,
                        cod) > 0)
                        superato = true;
                    else
                        i++;
                }
            }
            return (output);
        }

        private void ordinaLibriCodAutore(libro[] libri)
        {
            int posmin;
            libro aus;

            for (int i = 0; i <= nLibri-2; i++)
            {
                posmin = i;
                for (int j = i+1; j <= nLibri-1; j++)
                    if (String.Compare(libri[posmin].codAut,
                        libri[j].codAut) > 0)
                        posmin = j;
                if(posmin!=i)
                {
                    aus = libri[i];
                    libri[i] = libri[posmin];
                    libri[posmin] = aus;
                }
            }
        }

        private void btnCercaLibriAutoreNazione_Click(object sender, EventArgs e)
        {
            ordinaLibriCodAutore(libri);
            string naz = cmbNazioni.SelectedItem.ToString();
            MessageBox.Show(rottutaNazione(autori, libri, naz));
        }

        private string rottutaNazione(autore[] autori, libro[] libri, string naz)
        {
            bool superato = false;
            int i = 0;
            string output = "";

            while(!superato && i<=nAutori-1)
            {
                if(autori[i].nazione==naz)
                {
                    output += "\n"+autori[i].nominativo + "\n\n";
                    output += rotturaLibriCodAutore(libri,
                        autori[i].codAut);
                    i++;
                }
                else
                {
                    if (String.Compare(autori[i].nazione, naz) > 0)
                        superato = true;
                    else
                        i++;
                }
            }
            return (output);
        }

        private void btnContaLibriGenere_Click(object sender, EventArgs e)
        {
            ordinaLibriGenere(libri);
            contaLibriGenere(libri, dgvGeneriLibri);
        }

        private void contaLibriGenere(libro[] libri, DataGridView dgv)
        {
            int cont = 1;
            int j = 0; //indice per la datagridview

            for (int i = 0; i < nLibri; i++)
            {
                if (libri[i].genere == libri[i + 1].genere)
                    cont++;
                else
                {
                    dgv.Rows.Add();
                    dgv.Rows[j].Cells[0].Value = libri[i].genere;
                    dgv.Rows[j].Cells[1].Value = cont.ToString();
                    j++;
                    cont = 1;
                }
            }
            dgv.Visible = true;   
        }

        private void ordinaLibriGenere(libro[] libri)
        {
            int posmin;
            libro aus;

            for (int i = 0; i <= nLibri - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= nLibri - 1; j++)
                    if (String.Compare(libri[posmin].genere,
                        libri[j].genere) > 0)
                        posmin = j;
                if (posmin != i)
                {
                    aus = libri[i];
                    libri[i] = libri[posmin];
                    libri[posmin] = aus;
                }
            }
        }

        private void btnAutoreScarso_Click(object sender, EventArgs e)
        {
            string[] v = new string[nAutori];

            ordinaLibriCodAutore(libri);
            string codAut = cercaAutoreScarso(libri);
            v = codAut.Split(',');
            for (int i = 0; i < v.Length; i++)
                MessageBox.Show(cercaAutoreCodice(autori, v[i]));
        }

        private string cercaAutoreCodice(autore[] autori, string codAut)
        {
            int i = 0;

            while (autori[i].codAut != codAut)
                i++;
            return autori[i].nominativo;
        }

        private string cercaAutoreScarso(libro[] libri)
        {
            int min = int.MaxValue;
            string codAut="";
            int cont = 0;

            for (int i = 0; i < nLibri; i++)
            {
                cont++;
                if(libri[i].codAut!=libri[i+1].codAut)
                {
                    if (cont < min)
                    {
                        codAut = libri[i].codAut;
                        min = cont;
                    }
                    else
                    {
                        if(cont==min)
                            codAut += "," + libri[i].codAut;
                    }      
                    cont = 0;
                }
            }
            return codAut;
        }
    }
}
