using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caricaTabellaDichiarazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct cantante
        {
            public string codCantante; //chiave primaria
            public string nominativo;
            public string tipo; //"solista" "gruppo"
            public string nazione;
            public int totVenduti;
        }
        cantante[] cantanti = new cantante[10];
        public struct canzone
        {
            public int codCanzone; //progressivo chiave primaria
            public string titolo;
            public string genere; //"rock" "rap" "pop"
            public string codCantante; // chiave esterna
            public int venduti;
        }
        canzone[] canzoni = new canzone[30];
        int nCantanti, nCanzoni;
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] cant = new string[] {"C01 Ferro solista ITA",
                                          "C03 Fedez gruppo ITA",
                                          "C10 Sheeran solista ING",
                                          "C11 U2 gruppo IRL",
                                          "C14 Michielin solista ITA"};
            nCantanti = cant.Length;

            string[] recCantante = new string[4];
            for (int i = 0; i < cant.Length; i++)
            {
                recCantante = cant[i].Split(' ');
                cantanti[i].codCantante = recCantante[0];
                cantanti[i].nominativo = recCantante[1];
                cantanti[i].tipo = recCantante[2];
                cantanti[i].nazione = recCantante[3];
            }
            string[] canz = new string[] {"Tit1 pop C03 0",
                                          "Tit7 rock C14 3600",
                                          "Tit9 pop C11 2000",
                                          "Tit56 rap C11 1500",
                                          "Tit78 pop C10 3400",
                                          "Tit34 rap C01 200",
                                          "Tit2 pop C03 0",
                                          "Tit22 pop C03 200",
                                          "Tit3 rock C10 2300",
                                          "Tit11 pop C14 1200",
                                          "Tit12 rock C11 1000",
                                          "Tit19 rock C14 900"};
            nCanzoni = canz.Length;

            string[] recCanzone = new string[4];
            for (int i = 0; i < canz.Length; i++)
            {
                recCanzone = canz[i].Split(' ');
                canzoni[i].codCanzone = i;
                canzoni[i].titolo = recCanzone[0];
                canzoni[i].genere = recCanzone[1];
                canzoni[i].codCantante = recCanzone[2];
                canzoni[i].venduti = Convert.ToInt32(recCanzone[3]);
            }
            settaDgv(dgvClassifica);
        }
        private void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 2;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.RowHeadersVisible = false;
            dgv.Columns[0].HeaderText = "Cantante";
            dgv.Columns[1].HeaderText = "Venduti";
        }
        //Visualizzare in una griglia la classifica dei cantanti in base al venduto totale delle loro canzoni. 
        private void btnEsercizio_Click(object sender, EventArgs e)
        {
            dgvClassifica.Rows.Clear();
            ordinaCantantiCod(cantanti);
            ordinaCanzoniCantante(canzoni);
            rotturaChiaveVendutiCantante(canzoni, cantanti);
            ordinaVenduti(cantanti);
            stampaClassifica(cantanti, dgvClassifica);
        }
        private void ordinaCantantiCod(cantante[] cantanti)
        {
            int PosMin;

            for (int i = 0; i <= nCantanti - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= nCantanti - 1; j++)
                {
                    if (string.Compare(cantanti[PosMin].codCantante, cantanti[j].codCantante) > 0)
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    cantante aus = cantanti[i];
                    cantanti[i] = cantanti[PosMin];
                    cantanti[PosMin] = aus;
                }
            }
        }
        private void stampaClassifica(cantante[] cantanti, DataGridView dgv)
        {
            for (int i = 0; i < nCantanti; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = cantanti[i].nominativo;
                dgv.Rows[i].Cells[1].Value = cantanti[i].totVenduti;
            }
        }
        private void ordinaVenduti(cantante[] cantanti)
        {
            int PosMin;

            for (int i = 0; i <= nCantanti - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= nCantanti - 1; j++)
                {
                    if (cantanti[PosMin].totVenduti < cantanti[j].totVenduti)
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    cantante aus = cantanti[i];
                    cantanti[i] = cantanti[PosMin];
                    cantanti[PosMin] = aus;
                }
            }
        }
        private void rotturaChiaveVendutiCantante(canzone[] canzoni, cantante[] cantanti)
        {
            int cont = 0;

            for (int i = 0; i < nCanzoni; i++)
            {
                cont += canzoni[i].venduti;

                if (canzoni[i].codCantante != canzoni[i + 1].codCantante)
                {
                    int posiz = cercaCantante(canzoni[i].codCantante);

                    cantanti[posiz].totVenduti = cont;
                    cont = 0;
                }
            }
        }
        private int cercaCantante(string codCantante)
        {
            int i = 0;

            while (cantanti[i].codCantante != codCantante)
            {
                i++;
            }

            return i;
        }
        private void btnClassificaParimerito_Click(object sender, EventArgs e)
        {
            dgvClassifica.Rows.Clear();
            ordinaCanzoniCantante(canzoni);
            double[] vendutiTot = new double[nCantanti];
            rotturaChiaveVendutiCantante(canzoni, cantanti);
            ordinaVenduti(cantanti);
            stampaClassificaParimerito(cantanti, dgvClassifica);
        }
        private void stampaClassificaParimerito(cantante[] cantanti, DataGridView dgv)
        {
            int j = 0;

            dgv.Rows.Add();
            dgv.Rows[j].Cells[0].Value = cantanti[0].nominativo;
            dgv.Rows[j].Cells[1].Value = cantanti[0].totVenduti;

            for (int i = 1; i < nCantanti; i++)
            {
                if (cantanti[i].totVenduti == cantanti[i - 1].totVenduti)
                {
                    dgv.Rows[j].Cells[0].Value += ", " + cantanti[i].nominativo;
                }
                else
                {
                    dgv.Rows.Add();
                    j++;
                    dgv.Rows[j].Cells[0].Value = cantanti[i].nominativo;
                    dgv.Rows[j].Cells[1].Value = cantanti[i].totVenduti;
                }
            }
        }
        private void ordinaCanzoniCantante(canzone[] canzoni)
        {
            int PosMin;

            for (int i = 0; i <= nCanzoni - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= nCanzoni - 1; j++)
                {
                    if (string.Compare(canzoni[PosMin].codCantante, canzoni[j].codCantante) > 0)
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    canzone aus = canzoni[i];
                    canzoni[i] = canzoni[PosMin];
                    canzoni[PosMin] = aus;
                }
            }
        }
    }
}
