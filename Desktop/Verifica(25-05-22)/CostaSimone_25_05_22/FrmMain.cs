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
using Microsoft.VisualBasic;

namespace CostaSimone_25_05_22
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cantante = Interaction.InputBox("Inserisci il cantante: ");
            StreamWriter sw = new StreamWriter("nuovo.txt", false);
            StreamReader cantanti = new StreamReader("canzoni.txt");
            bool superato = false;
            int cdTot = 0;
            string output = "";

            sw.WriteLine("CD venduti dal " + cantante + ":");
            

            while(cantanti.Peek() > 0 && !superato)
            {
                string[] campi = new string[4];

                campi = cantanti.ReadLine().Split(',');

                if (string.Compare(campi[2], cantante) <= 0)
                {
                    if (campi[2] == cantante)
                    {
                        StreamReader sr = new StreamReader("cd.txt");
                        string[] campiCD = new string[4];
                        bool trovato = false;

                        while (sr.Peek() > 0 && !trovato)
                        {
                            campiCD = sr.ReadLine().Split(',');

                            if (campiCD[0] == campi[3])
                            {
                                output += campiCD[1] + ", " + campiCD[2] + "\n";
                                cdTot += int.Parse(campiCD[2]);
                                trovato = true;
                            }
                        }

                        sr.Close();
                    }
                }
                else
                {
                    superato = true;
                }
            }

            sw.WriteLine(output);
            sw.WriteLine("totale = " + cdTot.ToString() + " copie");
            sw.Close();
            cantanti.Close();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            caricaCmb(cmbCantanti);
        }
        private void caricaCmb(ComboBox cmbCantanti)
        {
            string[] cant = new string[50];
            int i = 0;

            foreach (string cantanti in File.ReadLines("canzoni.txt"))
            {
                string[] campi = cantanti.Split(',');

                bool presente = cercaCantante(cant, campi[2], i);

                if (!presente)
                {
                    cmbCantanti.Items.Add(campi[2]);
                    cant[i++] = campi[2];
                }
            }
        }
        private bool cercaCantante(string[] cant, string v, int pos)
        {
            bool pres = false;

            for (int i = 0; i < pos; i++)
            {
                if (v == cant[i])
                {
                    pres = true;
                }
            }

            return pres;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cmbCantanti.SelectedIndex != -1)
            {
                string cantante = cmbCantanti.SelectedItem.ToString();
                StreamWriter sw = new StreamWriter("nuovo.txt", false);
                StreamReader cantanti = new StreamReader("canzoni.txt");
                bool superato = false;
                int cdTot = 0;
                string output = "";

                sw.WriteLine("CD venduti dal " + cantante + ":");


                while (cantanti.Peek() > 0 && !superato)
                {
                    string[] campi = new string[4];

                    campi = cantanti.ReadLine().Split(',');

                    if (string.Compare(campi[2], cantante) <= 0)
                    {
                        if (campi[2] == cantante)
                        {
                            StreamReader sr = new StreamReader("cd.txt");
                            string[] campiCD = new string[4];
                            bool trovato = false;

                            while (sr.Peek() > 0 && !trovato)
                            {
                                campiCD = sr.ReadLine().Split(',');

                                if (campiCD[0] == campi[3])
                                {
                                    output += campiCD[1] + ", " + campiCD[2] + "\n";
                                    cdTot += int.Parse(campiCD[2]);
                                    trovato = true;
                                }
                            }

                            sr.Close();
                        }
                    }
                    else
                    {
                        superato = true;
                    }
                }

                sw.WriteLine(output);
                sw.WriteLine("totale = " + cdTot.ToString() + " copie");
                sw.Close();
                cantanti.Close();
            }
            else
            {
                MessageBox.Show("Inserire cantante via combo");
            }

        }
    }
}
