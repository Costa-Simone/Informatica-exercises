using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merge
{
    public partial class Form1 : Form
    {
        string[] a = { "Bogetti", "Grosso", "Menardi", "Noto" };
        string[] b = { "Arese", "Jourdan", "Lazzarino", "Pellisseri", "Pieretto" };
        string[] c = new string[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settadgv(dgvA);
            settadgv(dgvB);
            settadgv(dgvC);
        }
        private void settadgv(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ColumnCount = 1;
            dgv.ScrollBars = ScrollBars.None;
            dgv.Rows[0].Cells[0].Selected = false;
        }
        private void btnMerge_Click(object sender, EventArgs e)
        {
            Array.Resize(ref a, a.Length + 1);
            Array.Resize(ref b, b.Length + 1);
            a[a.Length - 1] = "ZZ";
            b[b.Length - 1] = "ZZ";

            int i = 0, j = 0;

            for (int k = 0; k < (a.Length + b.Length) - 2; k++)
            {
                if (string.Compare(a[i], b[j]) > 0)
                {
                    c[k] = b[j++];
                }
                else
                {
                    c[k] = a[i++];
                }
            }
        }
    }
}
