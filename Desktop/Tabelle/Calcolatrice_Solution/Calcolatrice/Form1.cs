using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class FrmCalcolatrice : Form
    {
        public FrmCalcolatrice()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnPiu_Click(object sender, EventArgs e)
        {
            char operando = '+';

            calcolaRisultato(operando);
        }
        private void btnMeno_Click(object sender, EventArgs e)
        {
            char operando = '-';

            calcolaRisultato(operando);
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            char operando = 'X';

            calcolaRisultato(operando);
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            char operando = '/';

            calcolaRisultato(operando);
        }
        private void calcolaRisultato(char operando)
        {
            double op1 = double.Parse(txtOp1.Text), op2 = double.Parse(txtOp2.Text);
            double ris = 0;

            switch (operando)
            {
                case '+':
                    ris = op1 + op2;
                    break;

                case '-':
                    ris = op1 - op2;
                    break;

                case 'X':
                    ris = op1 * op2;
                    break;

                case '/':
                    ris = op1 / op2;
                    break;

                default:
                    break;
            }

            lblRisultato.Text = ris.ToString();
        }
        private void btnAbilita1_Click(object sender, EventArgs e)
        {
            if (txtOp1.Text == "0") txtOp1.Text = "";

            txtOp1.Enabled = true;
            txtOp2.Enabled = false;
            txtOp1.Focus();
        }
        private void btnAbilita2_Click(object sender, EventArgs e)
        {
            if (txtOp2.Text == "0") txtOp2.Text = "";

            txtOp1.Enabled = false;
            txtOp2.Enabled = true;
            txtOp2.Focus();
        }
        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtOp1.Enabled)
            {
                txtOp1.Text += btn.Text;
            }
            else
            {
                txtOp2.Text += btn.Text;
            }
        }
    }
}
