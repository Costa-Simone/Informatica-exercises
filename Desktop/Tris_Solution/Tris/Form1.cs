using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tris
{
    public partial class FrmTris : Form
    {
        int turn, contaMosse;
        int[,] m = new int[3, 3];

        public FrmTris()
        {
            InitializeComponent();
        }
        private void FrmTris_Load(object sender, EventArgs e)
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        /*
         turn 1 --> O BLUE --> 
         turn 2 --> X RED --> 
         */
        private void btnGioca_Click(object sender, EventArgs e)
        {
            turn = 1;
            contaMosse = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = 0;
                }
            }

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.BackColor = SystemColors.Control;
            btn2.BackColor = SystemColors.Control;
            btn3.BackColor = SystemColors.Control;
            btn4.BackColor = SystemColors.Control;
            btn5.BackColor = SystemColors.Control;
            btn6.BackColor = SystemColors.Control;
            btn7.BackColor = SystemColors.Control;
            btn8.BackColor = SystemColors.Control;
            btn9.BackColor = SystemColors.Control;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int n = Convert.ToInt32(btn.Name.Substring(btn.Name.Length - 1, 1));

            contaMosse++;

            switch(n)
            {
                case 1:
                    if (turn == 1)
                    {
                        m[0, 0] = 1;
                    }
                    else
                    {
                        m[0, 0] = 2;
                    }
                    break;

                case 2:
                    if (turn == 1)
                    {
                        m[0, 1] = 1;
                    }
                    else
                    {
                        m[0, 1] = 2;
                    }
                    break;

                case 3:
                    if (turn == 1)
                    {
                        m[0, 2] = 1;
                    }
                    else
                    {
                        m[0, 2] = 2;
                    }
                    break;

                case 4:
                    if (turn == 1)
                    {
                        m[1, 0] = 1;
                    }
                    else
                    {
                        m[1, 0] = 2;
                    }
                    break;

                case 5:
                    if (turn == 1)
                    {
                        m[1, 1] = 1;
                    }
                    else
                    {
                        m[1, 1] = 2;
                    }
                    break;

                case 6:
                    if (turn == 1)
                    {
                        m[1, 2] = 1;
                    }
                    else
                    {
                        m[1, 2] = 2;
                    }
                    break;

                case 7:
                    if (turn == 1)
                    {
                        m[2, 0] = 1;
                    }
                    else
                    {
                        m[2, 0] = 2;
                    }
                    break;

                case 8:
                    if (turn == 1)
                    {
                        m[2, 1] = 1;
                    }
                    else
                    {
                        m[2, 1] = 2;
                    }
                    break;

                case 9:
                    if (turn == 1)
                    {
                        m[2, 2] = 1;
                    }
                    else
                    {
                        m[2, 2] = 2;
                    }
                    break;
            }

            if (turn == 1)
            {
                btn.Text = "O";
                btn.Enabled = false;
                btn.BackColor = Color.Blue;
                turn = 0;
            }
            else
            {
                btn.Text = "X";
                btn.Enabled = false;
                btn.BackColor = Color.Red;
                turn = 1;
            }

            if (controlla(m, turn))
            {
                if (turn == 1)
                {
                    MessageBox.Show("Partita vinta da 0");
                }
                else
                {
                    MessageBox.Show("Partita vinta da X");
                }
            }
            else if(contaMosse == 9)
            {
                MessageBox.Show("Partita patta");
            }
        }
        private bool controlla(int[,] m, int turn)
        {
            throw new NotImplementedException();
        }
    }
}
