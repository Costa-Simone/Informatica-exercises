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
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }
        public Dialog(string[] mem)
        {
            InitializeComponent();
            Label lbl = new Label();

            lbl.Location = new Point(200, 0);
            lbl.Height = 50;

            for (int i = 0; i < mem.Length; i++)
            {
                lbl.Text += mem[i] + "\n";
                lbl.Height += 50;
            }

            this.Controls.Add(lbl);
        }
    }
}
