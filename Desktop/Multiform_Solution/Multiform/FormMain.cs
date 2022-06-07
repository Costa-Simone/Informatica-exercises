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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtNumeri.Text, out n))
            {
                FormRisultati fr = new FormRisultati(txtNome.Text, n);
                fr.ShowDialog();
            }
        }
    }
}
