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
