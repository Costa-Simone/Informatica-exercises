using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05_QuadratoFactoryEcc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFactory_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Proviamo con lato = 5");

                Quadrato q = Quadrato.creaQuadrato(5);

                MessageBox.Show("Oggetto creato");
                MessageBox.Show("Proviamo ora con lato = 0");

                Quadrato q1 = Quadrato.creaQuadrato(0);

                MessageBox.Show("Sarà andato a buon fine?");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORE!!");
            }
        }
        private void btnSingleton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creazione primo oggetto Singleton");

            Singleton s1 = Singleton.getInstance();

            MessageBox.Show("Contatore: " + s1.valContatore);

            MessageBox.Show("Creazione secondo oggetto Singleton");

            Singleton s2 = Singleton.getInstance();

            MessageBox.Show("Contatore: " + s2.valContatore);
        }
        private void btnIndexed_Click(object sender, EventArgs e)
        {
            Indexed ind = new Indexed(10);

            for (int i = 0; i < 9; i++)
            {
                ind[i] = i.ToString();
            }

            string s = "";

            for (int i = 0; i < 10; i++)
            {
                s += $"ind[{i}] = " + ind[i] + "\n";
            }

            MessageBox.Show(s);
        }
    }
}
