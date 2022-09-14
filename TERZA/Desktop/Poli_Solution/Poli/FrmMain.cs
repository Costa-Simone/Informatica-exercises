using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace Poli
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        private void btnSuperEnalotto_Click(object sender, EventArgs e)
        {
            int[] numeri = new int[6];

            caricaNumeri(numeri);
            cercaVincitori(numeri, "giocate.txt");
        }
        private void cercaVincitori(int[] numeri, string nf)
        {
            StreamWriter sw = new StreamWriter("vincite.txt", false);
            bool trovato = false;
            string output = "";
            int[] contatori = new int[5];

            foreach (string giocate in File.ReadLines(nf))
            {
                int cont = 0;
                int[] scommesse = new int[6];
                string[] campi = new string[7];

                campi = giocate.Split(' ');

                for (int i = 0; i < numeri.Length; i++)
                {
                    scommesse[i] = int.Parse(campi[i + 1]);
                }

                for (int i = 0; i < numeri.Length; i++)
                {
                    if (Array.IndexOf(scommesse, numeri[i]) != -1)
                    {
                        cont++;
                    }
                }

                if (cont >= 2)
                {
                    sw.WriteLine(campi[0] + " " + cont);

                    trovato = true;
                    contatori[cont - 2]++;
                }
            }

            sw.Close();

            if (!trovato)
            {
                File.Delete("vincite.txt");
                MessageBox.Show("Nessun vincitore");
            }
            else
            {
                for (int i = 4; i >= 0; i--)
                {
                    output += "Numero di " + (i + 2) + ": " + contatori[i] + "\n";
                }

                MessageBox.Show("File creato\n" + output);
            }
        }
        private void caricaNumeri(int[] numeri)
        {
            for (int i = 0; i < numeri.Length; i++)
            {
                numeri[i] = int.Parse(Interaction.InputBox("Inserisci un valore"));
            }
        }
    }
}
