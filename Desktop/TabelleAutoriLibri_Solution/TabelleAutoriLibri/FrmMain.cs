using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelleAutoriLibri
{
    public partial class FrmMain : Form
    {
        public struct Autore
        {
            public string codAut; //chiave primaria
            public string nominativo;
            public string nazione;
        }
        public struct Libro
        {
            public string codLib; //chiave primaria
            public string titolo;
            public string genere;
            public string codAut; //chiave esterna
        }

        Autore[] autori = new Autore[10];
        Libro[] libri = new Libro[20];

        public static int numAutori;
        public static int numLibri;

        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            string[] datiAutori = new string[]
            {
                "A01;Lazzarino;USA",
                "A05;Pellisseri;ITA",
                "A06;Noto;USA",
                "A09;Bogetti;FRA"
            };
            string[] datiLibri = new string[]
            {
                "L01;La luna;Amore;A05",
                "L02;Il sole;Avventura;A09",
                "L04;I pianeti;Amore;A01",
                "L06;Marte;Giallo;A06",
                "L11;Giove;Amore;A05",
                "L12;Plutone;Giallo;A09",
                "L21;Venera;Giallo;A06",
                "L34;Vallauri;Avventura;A06",
            };

            numAutori = datiAutori.Length;
            numLibri = datiLibri.Length;

            caricaTabellaAutori(autori, datiAutori);
            caricaTabellaLibri(libri, datiLibri);
        }
        private void caricaTabellaLibri(Libro[] libri, string[] dati)
        {
            string[] v = new string[4];

            for (int i = 0; i < dati.Length; i++)
            {
                v = dati[i].Split(';');
                libri[i].codLib = v[0];
                libri[i].titolo = v[1];
                libri[i].genere = v[2];
                libri[i].codAut = v[3];
            }
        }
        private void caricaTabellaAutori(Autore[] autori, string[] dati)
        {
            string[] v = new string[3];

            for (int i = 0; i < dati.Length; i++)
            {
                v = dati[i].Split(';');
                autori[i].codAut = v[0];
                autori[i].nominativo = v[1];
                autori[i].nazione = v[2];
            }
        }
    }
}
