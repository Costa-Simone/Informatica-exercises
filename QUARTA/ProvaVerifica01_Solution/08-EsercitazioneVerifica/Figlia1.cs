using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_EsercitazioneVerifica
{
    public partial class Figlia1 : Form
    {
        ComboBox cmbAuto;
        CheckBox chkPelle, chkStoffa;

        public string auto, sedili;


        public Figlia1()
        {
            InitializeComponent();
        }

        private void Figlia1_CheckControl(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            if (chk.Checked == true)
            {
                sedili = chk.Text;

                if (chk.Name == "ckbPelle")
                {
                    ckbStoffa.Checked = false;
                }

                if (chk.Name == "ckbStoffa")
                {
                    ckbPelle.Checked = false;
                }
            }
            else
            {
                auto = "";
            }
        }

        private void Figlia1_ChangeValue(object sender, EventArgs e)
        {
            ComboBox chk = (ComboBox)sender;

            auto = chk.Text;
        }
    }
}
