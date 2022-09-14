using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stringhe
{
    public partial class FrmStringhe : Form
    {
        public FrmStringhe()
        {
            InitializeComponent();
        }
        private void FrmStringhe_Load(object sender, EventArgs e)
        {

        }
        private void btnDaStringaANumero_Click(object sender, EventArgs e)
        {
            //inserite stringa numero, fanne la somma dei singoli numeri
            //Es --> "725" allora visualizzo 14
            string s = txtInput.Text;
            int n;

            if (txtInput.Text == "")
            {
                MessageBox.Show("Devi inserire una stringa numerica");
                txtInput.Focus();
            }
            else
            {
                if (!int.TryParse(s, out n))
                {
                    MessageBox.Show("Devi inserire stringa numerica");
                    txtInput.Text = "";
                    txtInput.Focus();
                }
                else
                {
                    int len = s.Length, somma = 0;
                    string output = s + " = ";

                    for (int i = 0; i < len; i++)
                    {
                        n = Convert.ToInt32(s.Substring(i, 1));
                        somma += n;

                        if (i == len - 1)
                        {
                            output += n.ToString() + " = ";
                        }
                        else
                        {
                            output += n.ToString() + " + ";
                        }
                    }

                    output += somma.ToString();
                    MessageBox.Show(output);
                }
            }
        }
        private void btnStringaPalindroma_Click(object sender, EventArgs e)
        {
            string s = txtInput.Text, s1, s2;
            int i, j;

            if (txtInput.Text == "")
            {
                MessageBox.Show("Devi inserire una stringa numerica");
                txtInput.Focus();
            }
            else
            {
                i = 0;
                j = s.Length - 1;

                do
                {
                    s1 = s.Substring(i, 1);
                    s2 = s.Substring(j, 1);

                    if (s1 == s2)
                    {
                        i++;
                        j--;
                    }
                } while (s1 == s2 && i <= j);

                if (s1 != s2)
                {
                    MessageBox.Show("La stringa non è palindroma");
                }
                else
                {
                    MessageBox.Show("La stringa è palindroma");
                }
            }
        }
        private void btnInvertiStringa_Click(object sender, EventArgs e)
        {
            string s = txtInput.Text, aus = "";

            if (txtInput.Text == "")
            {
                MessageBox.Show("Devi inserire una stringa numerica");
                txtInput.Focus();
            }
            else
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    aus += s.Substring(i, 1);
                }

                MessageBox.Show("La stringa invertita è: " + aus);
            }
        }
    }
}
