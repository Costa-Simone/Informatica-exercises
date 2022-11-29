using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostaSimone_04_11_22_
{
    public partial class Figlia1 : Form
    {
        public Figlia1()
        {
            InitializeComponent();

            rbCabinato.Checked = false;
            rbNonCabinato.Checked = false;
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;

            Form1.cab = rdb.Text;
        }
        private void CheckBox_Changed(object sender, EventArgs e)
        {
            Form1.trattore = cmbTrattore.Text;
        }
    }
}
