using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex09_CollectionLibri
{
    public partial class Form1 : Form
    {
        List<Libro> listaLibri = new List<Libro>();
        Dictionary<int, Libro> dizionarioLibri = new Dictionary<int, Libro>();
        int keyLibro = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisciLibro_Click(object sender, EventArgs e)
        {
            Libro l = new Libro(txtTitolo.Text, txtAutore.Text);

            listaLibri.Add(l);
        }
        private void btnCercaTitoloLibro_Click(object sender, EventArgs e)
        {
            Libro ris = listaLibri.Find(bf => bf.titolo == txtTitolo.Text);

            MessageBox.Show($"E' stato trovato il libro:\n{ris.ToString()}");
        }
        private void btnCercaAutoreLibro_Click(object sender, EventArgs e)
        {
            List<Libro> elencoLibri = new List<Libro>();
            string s = "";

            elencoLibri = listaLibri.FindAll(bf => bf.autore == txtAutore.Text);

            foreach (var book in elencoLibri)
            {
                s += $"Titolo: {book.titolo} - Autore: {book.autore}\n";
            }
            //for (int i = 0; i < elencoLibri.Count; i++)
            //{
            //    Libro book = elencoLibri[i];

            //    s += $"Titolo: {book.titolo} - Autore: {book.autore}\n";
            //}

            MessageBox.Show(s);
        }
        private void btnInserisciDizionario_Click(object sender, EventArgs e)
        {
            Libro l = new Libro(txtTitolo.Text, txtAutore.Text);

            dizionarioLibri.Add(keyLibro, l);

            keyLibro++;
        }
        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            foreach (var key in dizionarioLibri.Keys)
            {
                MessageBox.Show($"Chiave: {key.ToString()}");
            }

            foreach (var l in dizionarioLibri.Values)
            {
                MessageBox.Show($"Libro: {l.titolo} - Autore: {l.autore}");
            }
        }
    }
}
