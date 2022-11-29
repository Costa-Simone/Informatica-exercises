using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex12_StackContainer
{
    public partial class Form1 : Form
    {
        public new struct Container
        {
            public int codice;
            public int peso;
            public int tara;

            public Container(int codice, int peso, int tara)
            {
                this.codice = codice;
                this.peso = peso;
                this.tara = tara;
            }

            public override string ToString()
            {
                return $"{codice} - {peso}kg - {tara}kg";
            }
        }

        Stack<Container> stackContainer = new Stack<Container>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungiContainer_Click(object sender, EventArgs e)
        {
            Container c = new Container(int.Parse(txtCodice.Text), int.Parse(txtPeso.Text), int.Parse(txtTara.Text));

            stackContainer.Push(c);
        }
        private void btnEstraiContainer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Container estratto: {stackContainer.Pop().ToString()}");
        }
    }
}
