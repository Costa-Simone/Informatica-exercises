using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01_WindowsForms
{
    public partial class F4 : Form
    {
        public F4()
        {
            InitializeComponent();
        }
        public F4(int n)
        {
            InitializeComponent();

            txtParam.Text = n.ToString();
        }
    }
}
