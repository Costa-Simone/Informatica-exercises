using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02_FormMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriFiglia1_Click(object sender, EventArgs e)
        {
            Figlia1 f1 = new Figlia1();

            f1.MdiParent = this;
            f1.Size = new Size(200, 250);
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(0, 40);

            f1.Show();

            tsslInfo.Text = "Aperta finestra figlia 1";
        }
        private void btnApriFiglia2_Click(object sender, EventArgs e)
        {
            Figlia2 f2 = new Figlia2();

            f2.MdiParent = this;
            f2.Size = new Size(200, 250);
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(205, 40);

            f2.Show();

            tsslInfo.Text = "Aperta finestra figlia 2";
        }
        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ModaleEsci form = new ModaleEsci();

            tsslInfo.Text = "";

            if (form.ShowDialog() != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
