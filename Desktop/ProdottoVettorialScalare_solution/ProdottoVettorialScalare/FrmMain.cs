using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdottoVettorialScalare
{
    public partial class FrmMain : Form
    {
        int[] a = new int[10];

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            settaDgv(dgvA);
            settaDgv(dgvB);
            settaDgv(dgvC);
            ClsVettore.caricaVett(a);
        }

        private void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 1;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.None;

        }
    }
}
