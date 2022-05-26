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

namespace Ricorsione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnFattoriale_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Interaction.InputBox("Inserisci n"));

            MessageBox.Show("Il fattoriale di " + n + " è " + fatt(n));
        }
        private int fatt(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * fatt(n - 1);
            }
        }
        private void btnProdotto_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Interaction.InputBox("Inserisci il moltiplicando"));
            int b = int.Parse(Interaction.InputBox("Inserisci il moltiplicatore"));

            MessageBox.Show("Il prodotto di " + a + " per " + b + " è " + prod(a, b));
        }
        private int prod(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            else
            {
                return a + prod(a, b - 1);
            }
        }
        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Interaction.InputBox("Inserisci il moltiplicando"));

            MessageBox.Show("L' " + n + "simo valore di Fibonacci è " + fib(n));
        }
        private int fib(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }
    }
}
