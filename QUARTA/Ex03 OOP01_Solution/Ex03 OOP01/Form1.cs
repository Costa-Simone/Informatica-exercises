using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03_OOP01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaRettangolo_Click(object sender, EventArgs e)
        {
            Rettangolo r;
            int l1 = int.Parse(txtBase.Text), l2 = int.Parse(txtAltezza.Text);

            r = new Rettangolo(l1, l2);

            MessageBox.Show("Creato rettangolo la cui area è: " + r.area());
        }
        private void btnCreaQuadrato_Click(object sender, EventArgs e)
        {
            Rettangolo q;
            int l1 = int.Parse(txtLato.Text);

            q = new Rettangolo(l1);

            MessageBox.Show("Creato quadrato la cui area è: " + q.area());
        }
        private void btnCreaDefault_Click(object sender, EventArgs e)
        {
            Rettangolo qd = new Rettangolo();

            MessageBox.Show("Creata figura la cui area è: " + qd.area());
        }
    }
}
