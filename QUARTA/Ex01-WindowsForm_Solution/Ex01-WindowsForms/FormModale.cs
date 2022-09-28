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
    public partial class FormModale : Form
    {
        public string nome = "";
        public string cognome = "";

        public FormModale()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            cognome = txtCognome.Text;
        }
        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            nome = "";
            cognome = "";
        }
    }
}
