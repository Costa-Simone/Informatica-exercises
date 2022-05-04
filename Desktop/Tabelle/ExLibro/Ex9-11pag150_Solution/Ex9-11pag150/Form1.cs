using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex9_11pag150
{
    public partial class FrmMain : Form
    {
        static string[] squadre = { "s1", "s2", "s3", "s4", "s5", "s6", "s7", "s8", "s9", "s10", "s11", "s12", "s13", "s14", "s15", "s16", "s17", 
            "s18", "s19", "s20", "s21", "s22", "s23", "s24", "s25", "s26" };
        static string[] risultato = new string[13];
        static string[] squadCasa = new string[13];
        static string[] squadFuori = new string[13];
        static Random rnd = new Random();
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            settaDgv(dgvSquadre, squadre.Length);
            settaDgv(dgvPunti, squadre.Length);
            settaDgv(dgvPartite, squadre.Length / 2);
            settaDgv(dgvRisultato, squadre.Length / 2);
            visualizzaDgv(dgvSquadre, squadre);

            for (int i = 0; i < squadre.Length; i++)
            {
                dgvPunti.Rows.Add();
            }
        }
        private void visualizzaDgv(DataGridView dgv, string[] dati)
        {
            for (int i = 0; i < dati.Length; i++)
            {
                dgv.Rows.Add(dati[i]);
            }
        }
        private void settaDgv(DataGridView dgv, int length)
        {
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ColumnCount = 1;
            dgv.ScrollBars = ScrollBars.None;
            dgv.Rows[0].Cells[0].Selected = false;
            dgv.Height = length * 22;
        }
        private void btnTurno_Click(object sender, EventArgs e)
        {
            ClsSquadre.creaSchedina(squadre, dgvPartite, dgvRisultato, risultato, squadCasa, squadFuori);
        }
        private void btnCampionato_Click(object sender, EventArgs e)
        {
            ClsSquadre.creaCampionato(squadre, dgvPartite, dgvRisultato, dgvSquadre, risultato, squadCasa, squadFuori, dgvPunti);
        }
    }
}
