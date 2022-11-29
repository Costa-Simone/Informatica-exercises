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
    public partial class Figlia2 : Form
    {
        public Figlia2(string txt1, string txt2)
        {
            InitializeComponent();

            lblScelta.Text = $"Hai selezionato un {txt1} {txt2}";
        }
    }
}
