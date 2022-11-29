using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex06_Ereditarieta01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMannaro_Click(object sender, EventArgs e)
        {
            Mannaro m = new Mannaro(5);

            MessageBox.Show("I punti sono: " + m.punti);
            MessageBox.Show("Valore Proprio: " + m.valoreProprio());
            MessageBox.Show("Valore Padre: " + m.valorePadre());
            MessageBox.Show("Valore totale: " + m.valoreTotale());
        }
    }
}
