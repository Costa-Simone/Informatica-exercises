using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex04_Squadra_calcio
{
    public partial class Form1 : Form
    {
        Squadra sqA, sqB, sqC;

        public Form1()
        {
            InitializeComponent();

            btnCreaA.Click += btnVisualizza;
            btnCreaB.Click += btnVisualizza;
            btnCreaC.Click += btnVisualizza;
            btnPareggiaA.Click += btnVisualizza;
            btnPareggiaB.Click += btnVisualizza;
            btnPareggiaC.Click += btnVisualizza;
            btnVinceA.Click += btnVisualizza;
            btnVinceB.Click += btnVisualizza;
            btnVinceC.Click += btnVisualizza;
        }

        private void btnCreaA_Click(object sender, EventArgs e)
        {
            sqA = new Squadra("Atlante", txtSquadraA.Text, 0, 0, 0);
            txtPunteggioA.Text = (sqA.vinte * 3 + sqA.pareggiate * 1).ToString();
        }
        private void btnCreaB_Click(object sender, EventArgs e)
        {
            sqB = new Squadra("Macedonia", txtSquadraB.Text, 0, 0, 0);
            txtPunteggioB.Text = (sqB.vinte * 3 + sqB.pareggiate * 1).ToString();
        }
        private void btnCreaC_Click(object sender, EventArgs e)
        {
            sqC = new Squadra("Virtus", txtSquadraC.Text, 0, 0, 0);
            txtPunteggioC.Text = (sqC.vinte * 3 + sqC.pareggiate * 1).ToString();
        }
        private void btnVinceA_Click(object sender, EventArgs e)
        {
            sqA.vinte++;
            // txtPunteggioA.Text = (sqA.vinte * 3 + sqA.pareggiate * 1).ToString();
        }
        private void btnVinceB_Click(object sender, EventArgs e)
        {
            sqB.vinte++;
           //txtPunteggioB.Text = (sqB.vinte * 3 + sqB.pareggiate * 1).ToString();
        }
        private void btnVinceC_Click(object sender, EventArgs e)
        {
            sqC.vinte++;
            //txtPunteggioC.Text = (sqC.vinte * 3 + sqC.pareggiate * 1).ToString();
        }
        private void btnPareggiaA_Click(object sender, EventArgs e)
        {
            sqA.pareggiate++;
            //txtPunteggioA.Text = (sqA.vinte * 3 + sqA.pareggiate * 1).ToString();
        }
        private void btnPareggiaB_Click(object sender, EventArgs e)
        {
            sqB.pareggiate++;
            //txtPunteggioB.Text = (sqB.vinte * 3 + sqB.pareggiate * 1).ToString();
        }
        private void btnPareggiaC_Click(object sender, EventArgs e)
        {
            sqC.pareggiate++;
        }

        private void btnVisualizza(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            switch (b.Text)
            {
                case "Crea A":
                case "A Vince":
                case "Pareggia A":
                    txtPunteggioA.Text = (sqA.vinte * 3 + sqA.pareggiate * 1).ToString();
                    break;

                case "Crea B":
                case "B Vince":
                case "Pareggia B":
                    txtPunteggioB.Text = (sqB.vinte * 3 + sqB.pareggiate * 1).ToString();
                    break;

                case "Crea C":
                case "C Vince":
                case "Pareggia C":
                    txtPunteggioC.Text = (sqC.vinte * 3 + sqC.pareggiate * 1).ToString();
                    break;
            }
        }
    }
}
