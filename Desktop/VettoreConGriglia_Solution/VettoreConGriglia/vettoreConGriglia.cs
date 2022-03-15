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

namespace vettoreConGriglia
{
    public partial class vettoreConGriglia : Form
    {
        int[] a = new int[10];
        public vettoreConGriglia()
        {
            InitializeComponent();
        }

        private void dgvVettore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vettoreConGriglia_Load(object sender, EventArgs e)
        {
            settaDgv(dgvVettore);
            caricaVet(a);
            stampaVet(a, dgvVettore);
        }

        private void stampaVet(int[] a, DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = a[i];
            }
        }

        private void caricaVet(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 1000);
            }
        }

        private void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 1;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.None;
            
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La media e' "+calcolaMedia(a).ToString());
        }

        private float calcolaMedia(int[] v)
        {
            int somma = 0;

            for (int i = 0; i < v.Length; i++)
                somma += v[i];
            return (float)somma / v.Length;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il massimo e' "+cercaMax(a).ToString());
        }

        private object cercaMax(int[] v)
        {
            int max = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > max)
                    max = v[i];
            }
            return max;
        }

        private void btnContPariDispari_Click(object sender, EventArgs e)
        {
            int pari = contaPari(a);
            MessageBox.Show("Pari: " + pari + "Dispari: " + (a.Length - pari).ToString());
        }

        private int contaPari(int[] v)
        {
            int pari = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 == 0)
                    pari++;
            }
            return pari;
        }

        private void btnInverti_Click(object sender, EventArgs e)
        {
            InvertiVett(a);
            stampaVet(a, dgvVettore);
        }

        private void InvertiVett(int[] v)
        {
            int aus;
            int j=v.Length-1;

            for (int i = 0; i < v.Length/2; i++)
            {
                aus = v[i];
                v[i] = v[j];
                v[j] = aus;
                j--;
            }
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            ordinaSelezione(a);
            stampaVet(a, dgvVettore);
        }

        private void ordinaSelezione(int[] a)
        {
            int posMin;

            for (int i = 0; i <= a.Length-2; i++)
            {
                posMin = i;
                for (int j= i + 1; j <= a.Length-1; j++)
                {
                    if (a[posMin] > a[j])
                        posMin = j;
                }
                if(posMin!=i)
                {
                    int aus = a[i];
                    a[i] = a[posMin];
                    a[posMin] = aus;
                }
            }
        }

        private void btnCercaX_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Interaction.InputBox("Inserisci x: "));
            ricercaSeq(a, x);
        }

        private void ricercaSeq(int[] a, int x)
        {
            int i = 0;

            while (a[i]!= x && i!=a.Length-1)
            {
                i++;
            }
            if (a[i] == x)
                MessageBox.Show("Trovato in posizione: " + i.ToString());
            else
                MessageBox.Show("Elemento non trovato");
        }
    }
}
