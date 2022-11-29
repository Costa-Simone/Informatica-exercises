using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex11_QueueProntoSoccorso
{
    public partial class Form1 : Form
    {
        public struct Paziente
        {
            public string nome;
            public int eta;
            public string colore;
            public int temperatura;

            public Paziente(string nome, int eta, string colore, int temperatura)
            {
                this.nome = nome;
                this.eta = eta;
                this.colore = colore;
                this.temperatura = temperatura;
            }

            public override string ToString()
            {
                return $"{nome} - {eta} - {colore}";
            }
        }

        Queue<Paziente> codaPazientiRossi = new Queue<Paziente> ();
        Queue<Paziente> codaPazientiGialli = new Queue<Paziente> ();
        Queue<Paziente> codaPazientiVerdi = new Queue<Paziente> ();
        Queue<Paziente> codaPazientiBianchi = new Queue<Paziente> ();
        public int temperaturaMax = -1;
        public int temperaturaMin = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaPaziente_Click(object sender, EventArgs e)
        {
            Paziente p = new Paziente(txtNome.Text, int.Parse(txtEta.Text), txtColore.Text, int.Parse(txtTemperatura.Text));

            switch (txtColore.Text)
            {
                case "Rosso":
                    codaPazientiRossi.Enqueue(p);
                    break;

                case "Giallo":
                    codaPazientiGialli.Enqueue(p);
                    break;

                case "Verde":
                    codaPazientiVerdi.Enqueue(p);
                    break;

                case "Bianco":
                    codaPazientiBianchi.Enqueue(p);
                    break;
            }

            if (int.Parse(txtTemperatura.Text) < temperaturaMin)
            {
                temperaturaMin = int.Parse(txtTemperatura.Text);
            }

            if (int.Parse(txtTemperatura.Text) > temperaturaMax)
            {
                temperaturaMax = int.Parse(txtTemperatura.Text);
            }
        }
        private void btnTemperatureMinMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Valore massimo: {temperaturaMax} - Valroe minimo: {temperaturaMin}");
        }
        private void btnProssimoPaziente_Click(object sender, EventArgs e)
        {
            if (codaPazientiRossi.Count != 0)
            {
                lblProssimoPaziente.Text = $"Prossimo paziente: {codaPazientiRossi.Dequeue().ToString()}";
            }
            else if (codaPazientiGialli.Count != 0)
            {
                lblProssimoPaziente.Text = $"Prossimo paziente: {codaPazientiGialli.Dequeue().ToString()}";
            }
            else if (codaPazientiVerdi.Count != 0)
            {
                lblProssimoPaziente.Text = $"Prossimo paziente: {codaPazientiVerdi.Dequeue().ToString()}";
            }
            else if(codaPazientiBianchi.Count != 0)
            {
                lblProssimoPaziente.Text = $"Prossimo paziente: {codaPazientiBianchi.Dequeue().ToString()}";
            }
            else
            {
                lblProssimoPaziente.Text = $"Prossimo paziente: nessuno";
            }
        }
    }
}
