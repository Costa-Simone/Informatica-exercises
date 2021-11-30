using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmiDiFusione
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ClsVettori.inputDimensione("Inserire dimensione del vettore a: "), m = ClsVettori.inputDimensione("\nInserisci dimensione del vettore b: ");

            int[] a = new int[n];
            int[] b = new int[m];
            int[] c = new int[n + m];

            ClsVettori.caricaVettRandomOrdinatoDisgiunto(a);
            ClsVettori.caricaVettRandomOrdinatoDisgiunto(b);

            ClsVettori.stampaVet(a, "Stampa vettore a");
            ClsVettori.stampaVet(b, "\nStampa vettore b");

            ClsVettori.mergeBase(a, b, c);

            ClsVettori.stampaVet(c, "\n\nRisultato fusione:");

            ClsVettori.attesaTasto();
        }
    }
}
