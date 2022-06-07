using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform
{
    public partial class FormRisultati : Form
    {
        int numeriDaGenerare = 0;
        Random rnd = new Random();

        public FormRisultati(string nome, int n)
        {
            InitializeComponent();
            lblNome.Text = "Ciao " + nome;
            numeriDaGenerare = n;
        }

        private void btnGenera_Click(object sender, EventArgs e)
        {
            int somma = 0;
            lblTotale.Text = "TOT: ";
            lbxNumeri.Items.Clear();
            for (int i = 0; i < numeriDaGenerare; i++)
            {
                int num = rnd.Next(1, 101);
                lbxNumeri.Items.Add(num);
                somma += num;
            }
            lblTotale.Text += somma;
        }
    }
}
