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
    public partial class F5 : Form
    {
        TextBox txt;

        public F5()
        {
            InitializeComponent();
        }
        public F5(TextBox txt)
        {
            InitializeComponent();

            this.txt = txt;
        }

        private void btnAzzera_Click(object sender, EventArgs e)
        {
            txt.Text = "";
        }
        private void btnLeggi_Click(object sender, EventArgs e)
        {
            if (txt == null)
            {
                MessageBox.Show("Non e' stato passato l'oggetto txtMessaggio");
            }
            else
            {
                MessageBox.Show("Messaggio inviato: " + txt.Text);
            }
        }
        private void btnFormFiglia_Click(object sender, EventArgs e)
        {
            FormFiglia figlia = new FormFiglia();

            this.AddOwnedForm(figlia);
            figlia.Show();
        }
    }
}
