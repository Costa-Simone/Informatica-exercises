using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaSimone_04_11_22_
{
    public partial class Form1 : Form
    {
        public static Figlia1 f1;
        public static Figlia2 f2;
        public static string trattore;
        public static string cab;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriFiglia1_Click(object sender, EventArgs e)
        {
            f1 = new Figlia1();

            trattore = "";
            cab = "";
            sLbl.Text = "";
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(10, 10);
            f1.Width = 200;
            f1.Height = 200;
            f1.MdiParent = this;

            f1.Show();
        }
        private void btnApriFiglia2_Click(object sender, EventArgs e)
        {
            if (trattore == "" || cab == "")
            {
                ModaleScelta fMod = new ModaleScelta();

                fMod.StartPosition = FormStartPosition.CenterParent;

                if (fMod.ShowDialog() == DialogResult.OK)
                {
                    fMod.Close();
                }

                sLbl.Text = "";
            }
            else
            {
                f2 = new Figlia2(trattore, cab);

                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = new Point(300, 10);
                f2.Width = 300;
                f2.Height = 200;
                f2.MdiParent = this;
                sLbl.Text = $"Si è selezionato un {trattore} {cab}";

                f2.Show();
            }
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            ModaleClose fC = new ModaleClose();

            fC.StartPosition = FormStartPosition.CenterParent;

            if (fC.ShowDialog() == DialogResult.OK)
            {
                fC.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void Esci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Info_Click(object sender, EventArgs e)
        {
            ModaleInfo fI = new ModaleInfo();

            fI.StartPosition = FormStartPosition.CenterParent;

            if (fI.ShowDialog() == DialogResult.OK)
            {
                fI.Close();
            }
        }
    }
}
