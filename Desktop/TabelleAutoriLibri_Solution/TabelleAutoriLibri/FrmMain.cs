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
        public struct autore
        {
            public string codAut; //chiave primaria
            public string nominativo;
            public string nazione;
        }
        public struct libro
        {
            public string codLib; //chiave primaria
            public string titolo;
            public string genere;
            public string codAut; //chiave esterna
        }

        libro[] libri = new libro[20];
        autore[] autori = new autore[10];
        int nLibri, nAutori;

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] datiAutori = new string[]
            {
                "A01;Lazzarino;USA",
                "A05;Pelisseri;ITA",
                "A06;Noto;USA",
                "A09;Bogetti;FRA"
            };
            string[] datiLibri = new string[]
            {
                "L01;La luna;amore;A05",
                "L02;Il sole;avventura;A09",
                "L04;I pianeti;amore;A01",
                "L06;Marte;giallo;A06",
                "L11;Giove;amore;A05",
                "L12;Plutone;giallo;A09",
                "L21;Venere;giallo;A06",
                "L34;Vallauri;avventura;A06",
            };

            nAutori = datiAutori.Length;
            nLibri = datiLibri.Length;

            caricaTabellaAutori(autori, datiAutori);
            caricaTabellaLibri(libri, datiLibri);
            settaDgvAutori(autori, dgvAutori);
            settaDgvLibri(libri, dgvLibri);
            settaDgvGeneri(dgvGeneri);
            visualAutori(autori, dgvAutori);
            visualLibri(libri, dgvLibri);
            caricaCmbAutori(autori, cmbAutori);
            caricaCmbNazioni(autori, cmbNazione);
        }
        private void settaDgvGeneri(DataGridView dgv)
        {
            dgv.ColumnCount = 2;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.RowHeadersVisible = false;
            dgv.Columns[0].HeaderText = "Genere";
            dgv.Columns[1].HeaderText = "Numero";
            dgv.AutoResizeColumns();
        }
        private void caricaCmbAutori(autore[] autori, ComboBox cmb)
        {
            for (int i = 0; i < nAutori; i++)
            {
                cmb.Items.Add(autori[i].codAut + " - " + autori[i].nominativo);
            }
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
            if (cmbAutori.SelectedIndex == -1)
            {
                MessageBox.Show("Selezionare un autore");
            }
            else
            {
                string cod = cmbAutori.SelectedItem.ToString();

                cod = cod.Substring(0, 3);

                ordinaLibriAutori(libri);
                rotturaLibriCodAutore(libri, cod);
            }
        }
        private void rotturaLibriCodAutore(libro[] libri, string cod)
        {
            int i = 0;
            bool superato = false;
            string output = "";

            while (!superato && i < nLibri)
            {
                if (libri[i].codAut == cod)
                {
                    output += libri[i].titolo + "\n";
                    i++;
                }
                else
                {
                    if (string.Compare(libri[i].codAut, cod) > 0)
                    {
                        superato = true;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            MessageBox.Show(output);
        }
        private void ordinaLibriAutori(libro[] libri)
        {
            int PosMin;

            for (int i = 0; i <= nLibri - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= nLibri - 1; j++)
                {
                    if (string.Compare(libri[PosMin].codAut, libri[j].codAut) > 0)
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    libro aus = libri[i];
                    libri[i] = libri[PosMin];
                    libri[PosMin] = aus;
                }
            }
        }
        private void btnCercaLibriAutoreNazione_Click(object sender, EventArgs e)
        {
            if (cmbNazione.SelectedIndex == -1)
            {
                MessageBox.Show("Selezionare una nazione!");
            }
            else
            {
                string naz = cmbNazione.SelectedItem.ToString();

                ricercaLibroNazione(autori, libri, naz);
            }
        }
        private void ricercaLibroNazione(autore[] autori, libro[] libri, string naz)
        {
            ordinaLibriAutori(libri);

            string output = "";
            bool superato = false;
            int i = 0;

            while (!superato && i < nAutori)
            {
                if (autori[i].nazione == naz)
                {
                    int j = 0;
                    bool esci = false;

                    while (!esci && j < nLibri)
                    {
                        if (libri[j].codAut == autori[i].codAut)
                        {
                            output += libri[j].titolo + " di " + autori[i].nominativo + "\n";
                            j++;
                        }
                        else
                        {
                            if (string.Compare(libri[j].codAut, autori[i].codAut) > 0)
                            {
                                esci = true;
                            }
                            else
                            {
                                j++;
                            }
                        }
                    }

                    i++;
                }
                else
                {
                    if (string.Compare(autori[i].nazione, naz) > 0)
                    {
                        superato = true;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            MessageBox.Show(output);
        }
        private void caricaCmbNazioni(autore[] autori, ComboBox cmb)
        {
            ordinaAutoriNazione(autori);
            cmb.Items.Add(autori[0].nazione);

            for (int i = 1; i < nAutori; i++)
            {
                if (autori[i].nazione != autori[i - 1].nazione)
                {
                    cmb.Items.Add(autori[i].nazione);
                }
            }
        }
        private void btnContaLibriGeneri_Click(object sender, EventArgs e)
        {
            ordinaLibriGeneri(libri);

            int cont = 0, k = 0;

            dgvGeneri.Rows.Add();

            for (int i = 1; i < nLibri; i++)
            {
                if (libri[i].genere == libri[i - 1].genere)
                {
                    cont++;
                }
                else
                {
                    dgvGeneri.Rows.Add();
                    dgvGeneri.Rows[k].Cells[0].Value = libri[i - 1].genere;
                    dgvGeneri.Rows[k++].Cells[1].Value = cont;
                    cont = 1;
                }
            }

            dgvGeneri.Rows[k].Cells[0].Value = libri[nLibri - 1].genere;
            dgvGeneri.Rows[k].Cells[1].Value = cont;
        }
        private void ordinaLibriGeneri(libro[] libri)
        {
            int PosMin;

            for (int i = 0; i <= nLibri - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= nLibri - 1; j++)
                {
                    if (string.Compare(libri[PosMin].genere, libri[j].genere) > 0)
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    libro aus = libri[i];
                    libri[i] = libri[PosMin];
                    libri[PosMin] = aus;
                }
            }
        }
        private void ordinaAutoriNazione(autore[] autori)
        {
            int PosMin;

            for (int i = 0; i <= nAutori - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= nAutori - 1; j++)
                {
                    if (string.Compare(autori[PosMin].nazione, autori[j].nazione) > 0)
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    autore aus = autori[i];
                    autori[i] = autori[PosMin];
                    autori[PosMin] = aus;
                }
            }
        }
    }
}
