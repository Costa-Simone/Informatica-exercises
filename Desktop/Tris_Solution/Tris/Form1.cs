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
        int cont = 0;

        public FrmTris()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (cont % 2 == 0)
            {
                btn.Text = "O";
                btn.Enabled = false;
            }
            else
            {
                btn.Text = "X";
                btn.Enabled = false;
            }

            cont++;
        }
        private void btnGioca_Click(object sender, EventArgs e)
        {
            cont = 0;

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
        }
    }
}
