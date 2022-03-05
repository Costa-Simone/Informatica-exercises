using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndovinaNumero
{
    public partial class FrmIndovina : Form
    {
        int ns;
        int cont;

        public FrmIndovina()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            ns = rnd.Next(1, 100);
            txtNs.Text = ns.ToString();
            cont = 0;
        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
            if (txtTentativo.Text != "")
            {
                int tentativo = Convert.ToInt32(txtTentativo.Text);

                cont++;

                if (tentativo == ns)
                {
                    lblRisposta.Text = "Hai indovinato in " + cont.ToString() + " tentativi!";
                    btnGioca.Enabled = false;
                }
                else
                {
                    if (tentativo > ns)
                    {
                        lblRisposta.Text = "Troppo alto!";
                    }
                    else
                    {
                        lblRisposta.Text = "Troppo basso!";
                    }

                    if (cont == 5)
                    {
                        lblRisposta.Text = "Hai perso! ns = " + ns.ToString();
                        btnGioca.Enabled = false;
                    }

                    txtTentativo.Text = "";
                    txtTentativo.Focus();
                }
            }
            else
            {
                lblRisposta.Text = "Inserisci un valore!";
                txtTentativo.Focus();
            }
        }
    }
}
