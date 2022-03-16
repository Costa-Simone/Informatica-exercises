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
        int[] b = new int[10];
        int[] pv = new int[10];

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
            ClsVettore.caricaVett(b);
            ClsVettore.visualizzaDgv(a, dgvA);
            ClsVettore.visualizzaDgv(b, dgvB);
        }
        private void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 1;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.None;
        }
        private void btnProdottoVettoriale_Click(object sender, EventArgs e)
        {
            ClsVettore.prodottoVettoriale(a, b, pv);
            ClsVettore.visualizzaDgv(pv, dgvC);
        }
        private void btnProdottoScalare_Click(object sender, EventArgs e)
        {
            ClsVettore.prodottoScalare(a, b);
        }
    }
}
