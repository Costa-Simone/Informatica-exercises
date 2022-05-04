using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneTabella
{
    public partial class FrmAus : Form
    {
        public FrmAus()
        {
            InitializeComponent();
        }

        private void FrmAus_Load(object sender, EventArgs e)
        {
            settaDgv(dgvMedieStudenti);
            caricaDgv(dgvMedieStudenti, FormMain.medie, FormMain.numStudenti);
        }

        private void caricaDgv(DataGridView dgv, double[] medie, int numStudenti)
        {
            for (int i = 0; i < numStudenti; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = FormMain.studenti[i].Cognome;
                dgv.Rows[i].Cells[1].Value = FormMain.studenti[i].Nome;
                dgv.Rows[i].Cells[2].Value = FormMain.medie[i];
            }
        }

        private void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 3;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.RowHeadersVisible = false;
            dgv.Columns[0].HeaderText = "Cognome";
            dgv.Columns[1].HeaderText = "Nome";
            dgv.Columns[2].HeaderText = "Media";
            dgv.AutoResizeColumns();
        }
    }
}
