using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trisDinamico
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();

                    btn.Name = "btn" + i + j;
                    btn.Font = new Font("Calibri", 16);
                    btn.Width = 100;
                    btn.Height = 100;
                    btn.Top = i * btn.Height + 10;
                    btn.Left = j * btn.Width + 10;
                    btn.Enabled = false;

                    this.Controls.Add(btn);
                }
            }
            // creazione bottone gioca
            Button btnGioca = new Button();

            btnGioca.Text = "GIOCA";
            btnGioca.Font = new Font("Calibri", 18);
            btnGioca.Name = "btnGioca";
            btnGioca.Width = 300;
            btnGioca.Height = 50;
            btnGioca.Left = 10;
            btnGioca.Top = 360;
            btnGioca.Click += BtnGioca_Click;

            this.Controls.Add(btnGioca);
        }
        private void BtnGioca_Click(object sender, EventArgs e)
        {
            foreach (Button btn in this.Controls)
            {
                btn.Enabled = true;
            }
        }
    }
}
