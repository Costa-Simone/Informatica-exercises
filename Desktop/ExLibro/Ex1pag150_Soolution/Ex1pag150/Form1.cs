using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1pag150
{
    public partial class FrmMain : Form
    {
        static string[] cognomi = { "c1", "c2", "c3", "c4", "c5", "c6", "c7", "c8", "c9", "c10" };
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            settaDgv(cognomi, dgvStudenti, cognomi.Length);
            settaDgv(cognomi, dgvTurni, 4);
            caricaDgv(cognomi, dgvStudenti);
        }
        private void caricaDgv(string[] dati, DataGridView dgv)
        {
            for (int i = 0; i < dati.Length; i++)
            {
                dgv.Rows[i].Cells[0].Value = dati[i];
            }
        }
        private void settaDgv(string[] dati, DataGridView dgv, int length)
        {
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ColumnCount = 1;
            dgv.RowCount = length;
            dgv.ScrollBars = ScrollBars.None;
            dgv.Height = length * 20;
            dgv.Width = 100;
        }
        private void btnTurni_Click(object sender, EventArgs e)
        {
            ClsEx.creaTurni(cognomi, dgvTurni);
        }
    }
}
