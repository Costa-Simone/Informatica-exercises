using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_EsercitazioneVerifica
{
    public partial class FormMDI : Form
    {
        private Figlia1 f1;
        private Figlia2 f2;

        public FormMDI()
        {
            InitializeComponent();
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1 = new Figlia1();

            f1.auto = "";
            f1.sedili = "";
            f1.MdiParent = this;
            f1.Size = new Size(165, 160);
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(10, 10);

            f1.Show();
        }
        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(f1.sedili == "" || f1.auto == "")
            {
                Modale form = new Modale();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    form.Close();
                }

                tssAuto.Text = "";
            }
            else
            {
                f2 = new Figlia2(f1.auto, f1.sedili);

                f2.MdiParent = this;
                f2.Size = new Size(350, 160);
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = new Point(185, 10);

                f2.Show();

                if (f1.auto != "")
                    tssAuto.Text = "La tua auto è una " + $"La tua auto è {f1.auto}";
                    
            }
        }
        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModaleDettagli formDettagli = new ModaleDettagli();

            if (formDettagli.ShowDialog() == DialogResult.OK)
            {
                formDettagli.Close();
            }
        }
        private void FormMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            ModaleEsci formEsci = new ModaleEsci();

            if(formEsci.ShowDialog() != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
