using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10_DictionaryNegozio
{
    public partial class Form1 : Form
    {
        public struct Articolo
        {
            public string nomeArticolo;

            public Articolo(string nomeArticolo)
            {
                this.nomeArticolo = nomeArticolo;
            }

            public override string ToString()
            {
                return $"Nome articolo: {nomeArticolo}";
            }
        }

        Dictionary<int, Articolo> dizionarioArticoli = new Dictionary<int, Articolo>();
        int keyArticolo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaArticolo_Click(object sender, EventArgs e)
        {
            Articolo a = new Articolo(txtNome.Text);

            dizionarioArticoli.Add(keyArticolo, a);

            keyArticolo++;
        }
        private void btnNumeroArticoli_Click(object sender, EventArgs e)
        {
            lblNumeroArticoli.Text = $"Numero di articoli: {keyArticolo}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Articolo: {dizionarioArticoli[int.Parse(txtChiave.Text)].nomeArticolo}");
        }
    }
}
