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

namespace ExSquadre
{
    public partial class FrmMain : Form
    {
        static string[] atleti = new string[]
            {
                "AA", "BB", "CC", "DD", "EE", "FF",  "GG", "HH", "II", "LL","MM", "NN","OO", "PP", "QQ", "RR", "SS", "TT","UU", "VV", "ZZ"};
        static string[] nazioni = new string[]
                    {
                "ITA", "FRA", "GBR", "USA", "USA", "GBR", "ITA", "FRA", "GBR", "USA", "ITA", "ITA","ITA", "FRA", "GBR", "USA", "ITA", "FRA", "USA", "USA", 
                        "USA"};
        static string[] team = new string[]
                    {
                "T2", "T5", "T4", "T2", "T4", "T3", "T3", "T1", "T1", "T2", "T5", "T4", "T4", "T1", "T3", "T3", "T5", "T4","T2", "T5", "T4" };
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            settaDgv(atleti, dgvAtleti);
            settaDgv(nazioni, dgvNazioni);
            settaDgv(team, dgvTeam);
            visualizzaDgv(dgvAtleti, atleti);
            visualizzaDgv(dgvNazioni, nazioni);
            visualizzaDgv(dgvTeam, team);
        }
        private void visualizzaDgv(DataGridView dgv, string[] dati)
        {
            for (int i = 0; i < dati.Length; i++)
            {
                dgv.Rows[i].Cells[0].Value = dati[i];
            }
        }
        private void settaDgv(string[] dati, DataGridView dgv)
        {
            dgv.ColumnCount = 1;
            dgv.RowCount = dati.Length;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.Height = dati.Length * 22;
            dgv.ScrollBars = ScrollBars.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgv.DefaultCellStyle.SelectionForeColor = dgv.DefaultCellStyle.ForeColor;
        }
        private void btnTopSquadre_Click(object sender, EventArgs e)
        {
            int PosMin, cont = 0, contMax = -1;
            string ausS, teamMax = "";

            for (int i = 0; i <= team.Length - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= team.Length - 1; j++)
                {
                    if (string.Compare(team[PosMin], team[j]) > 0)
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    ausS = team[i];
                    team[i] = team[PosMin];
                    team[PosMin] = ausS;

                    ausS = atleti[i];
                    atleti[i] = atleti[PosMin];
                    atleti[PosMin] = ausS;

                    ausS = nazioni[i];
                    nazioni[i] = nazioni[PosMin];
                    nazioni[PosMin] = ausS;
                }
            }

            visualizzaDgv(dgvAtleti, atleti);
            visualizzaDgv(dgvNazioni, nazioni);
            visualizzaDgv(dgvTeam, team);

            string naz = Interaction.InputBox("Inserisci nazione: ");

            if (nazioni[0] == naz)
            {
                cont++;
            }

            for (int i = 1; i < team.Length; i++)
            {
                if (team[i] == team[i - 1])
                {
                    if (nazioni[i] == naz)
                    {
                        cont++;
                    }
                }
                else
                {
                    if (cont > contMax)
                    {
                        contMax = cont;
                        teamMax = team[i - 1];

                        if (nazioni[i] == naz)
                        {
                            cont = 1;
                        }
                        else
                        {
                            cont = 0;
                        }
                    }
                }
            }

            lblTopSquadre.Text = "team " + teamMax.ToString() + " (" + contMax.ToString() + " atleti)";
        }
    }
}
