using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costa_02_11_22_
{
    public partial class Form1 : Form
    {
        RichTextBox rtb;
        private int FWidth = 800;
        private int FHeight = 600;
        public bool stopW = false;
        public bool FChar = false;
        public string[] mem = new string[100];
        public int memI = 0;

        public int[,] dim = new int[2, 6];

        public struct btnPos
        {
            public string Content;
            public bool FirstChar;
            public bool LastChar;
            public btnPos(string content, bool firstChar = false, bool lastChar = false)
            {
                this.Content = content;
                this.FirstChar = firstChar;
                this.LastChar = lastChar;
            }
            public override string ToString()
            {
                return Content.ToString();
            }
        }
        public btnPos[,] buttons =
        {
            {new btnPos("7"), new btnPos("8"), new btnPos("9")},
            {new btnPos("4"), new btnPos("5"), new btnPos("6")},
            {new btnPos("1"), new btnPos("2"), new btnPos("3")},
            {new btnPos("#", false, true), new btnPos("0"), new btnPos("+", true)}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = FWidth;
            this.Height = FHeight;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Parte02();
        }

        private void Parte02()
        {
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                Button myButton = new Button();
                
                myButton.Width = 100;
                myButton.Height = 50;
                dim[0, i] = rnd.Next(0, FWidth - 100);
                dim[1, i] = rnd.Next(400, FHeight - 50);
                myButton.Location = new Point(dim[0, i], dim[1, i]);

                switch (i)
                {
                    case 0:
                        myButton.Text = $"Parte{(i + 3)}";
                        myButton.Click += Parte3_Ex;
                        break;

                    case 1:
                        myButton.Text = $"Parte{(i + 3)}";
                        myButton.Click += Parte4_Ex;
                        break;

                    case 2:
                        myButton.Text = $"Parte{(i + 3)}";
                        myButton.Click += Parte5_Ex;
                        break;

                    case 3:
                        myButton.Text = $"Parte{(i + 3)}";
                        myButton.Click += Parte6_Ex;
                        break;

                    case 4:
                        myButton.Text = $"Parte{(i + 3)}";
                        myButton.Click += Parte7_Ex;
                        break;

                    case 5:
                        myButton.Text = "FAC";
                        myButton.Click += FAC_Click;
                        break;
                }


                this.Controls.Add(myButton);
            }
        }

        private void FAC_Click(object sender, EventArgs e)
        {
            Dialog frmM = new Dialog(mem);

            if (frmM.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Parte7_Ex(object sender, EventArgs e)
        {
            Button btn = new Button();

            btn.Width = 150;
            btn.Height = 50;
            btn.Location = new Point((FWidth / 2), 250);
            btn.Text = "MEMORIZZA";
            btn.Click += Memorizza_Click;

            this.Controls.Add(btn);
        }

        private void Memorizza_Click(object sender, EventArgs e)
        {
            if (rtb != null && memI < mem.Length)
            {
                mem[memI] = rtb.Text;
                rtb.Text = "";
                FChar = false;
                stopW = false;

                memI++;
            }
        }
        private void Parte6_Ex(object sender, EventArgs e)
        {
            rtb = new RichTextBox();

            rtb.Location = new Point(FWidth / 2, 0);
            rtb.Width = 150;
            rtb.Height = 50;
            rtb.Text = "";

            this.Controls.Add(rtb);
        }
        private void Parte5_Ex(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                foreach (var control in this.Controls)
                {
                    if (control is Button)
                    {
                        Button btn = (Button)control;

                        if (btn.Tag != null)
                        {
                            this.Controls.Remove(btn);
                        }
                    }
                }
            }
        }
        private void Parte4_Ex(object sender, EventArgs e)
        {
            int lar = 50, alt = 50;
            int posX = FWidth / 2;
            int posY = 50;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();

                    btn.Text = buttons[i, j].ToString();
                    btn.Location = new Point(posX, posY);
                    posX += lar;
                    btn.Width = lar;
                    btn.Height = alt;
                    btn.Tag = buttons[i, j];
                    btn.Click += Tastierino_Click;

                    this.Controls.Add(btn);
                }

                posX = FWidth / 2;
                posY += alt;
            }
        }
        private void Tastierino_Click(object sender, EventArgs e)
        {
            if (rtb != null)
            {
                Button btn = (Button)sender;
                btnPos btnStruct = (btnPos)btn.Tag;

                if (btnStruct.FirstChar && rtb.Text == "" && !FChar)
                {
                    rtb.Text += btn.Text;
                }
                else if(btnStruct.LastChar && !stopW)
                {
                    rtb.Text += btn.Text;
                    stopW = true;
                }
                else if (!stopW && !btnStruct.FirstChar)
                {
                    rtb.Text += btn.Text;
                }

                FChar = true;
            }
        }
        private void Parte3_Ex(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    int x = dim[0, i];
                    int y = dim[0, j];
                }
            }
        }
    }
}
