using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prodotti
{
    public partial class FrmMain : Form
    {
        public struct categoria
        {
            public string tipo;
            public float punteggio;
        }
        public struct nazione
        {
            public string nome;
            public float punteggio;
        }

        categoria[] categorie = new categoria[20];
        nazione[] nazioni = new nazione[20];

        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        private void btnCercaMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il prodotto vincente è " + prodottoVincente("prodotti.txt"));

            int nCategorie = caricaCategorie(categorie, "prodotti.txt");
            int nNazioni = caricaNazioni(nazioni, "prodotti.txt");

            ordina(nazioni, nNazioni);
            stampaClassifica(nazioni, nNazioni);
            ordina(categorie, nCategorie);
            stampaClassifica(categorie, nCategorie);
        }
        private void stampaClassifica(nazione[] nazioni, int nNazioni)
        {
            throw new NotImplementedException();
        }
        private void ordina(nazione[] nazioni, int nNazioni)
        {
            
        }
        private string prodottoVincente(string nf)
        {
            string[] campi = new string[9];
            float totale, max = 0;
            string prodotto = "";

            foreach (string categoria in File.ReadLines(nf))
            {
                campi = categoria.Split(' ');
                totale = calcolaTotale(campi);

                if (totale > max)
                {
                    max = totale;
                    prodotto = campi[0] + " " + campi[1] + "-" + max.ToString();
                }
            }

            return prodotto;
        }
        private int caricaNazioni(nazione[] nazioni, string v)
        {
            string[] campi = new string[9], aus = new string[20];
            int i = 0;
            float totale;

            foreach (string nazione in File.ReadLines(v))
            {
                campi = nazione.Split(' ');
                totale = calcolaTotale(campi);

                if (i == 0)
                {
                    nazioni[i].nome = campi[3];
                    aus[i] = campi[3];
                    nazioni[i++].punteggio = totale;
                }
                else if (Array.IndexOf(aus, campi[3]) == -1)
                {
                    aus[i] = campi[1];
                    nazioni[i].punteggio = totale;
                    nazioni[i++].nome = campi[3];
                }
            }

            return i;
        }
        private int caricaCategorie(categoria[] categorie, string v)
        {
            string[] campi = new string[9], aus = new string[20];
            int i = 0;
            float totale;

            foreach (string categoria in File.ReadLines(v))
            {
                campi = categoria.Split(' ');
                totale = calcolaTotale(campi);

                if (i == 0)
                {
                    categorie[i].tipo = campi[1];
                    aus[i] = campi[1];
                    categorie[i++].punteggio = totale;
                }
                else if (Array.IndexOf(aus, campi[1]) == -1)
                {
                    aus[i] = campi[1];
                    categorie[i].punteggio = totale;
                    categorie[i++].tipo = campi[1];
                }
            }

            return i;
        }
        private float calcolaTotale(string[] campi)
        {
            float[] v = new float[5];
            float max, min, totale = 0;

            for (int i = 0; i < 5; i++)
            {
                v[i] = float.Parse(campi[i + 4]);
            }

            max = v.Max();
            min = v.Min();

            for (int i = 0; i < 5; i++)
            {
                totale += v[i];
            }

            return totale - max - min;
        }
    }
}
