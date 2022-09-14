using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinamenti
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ClsVettori.inputDimensione("Inserisci dimensione del vettore: ");
            int[] a = new int[n];

            ClsVettori.caricaVet(a);
            ClsVettori.stampaVet(a, "\nVettore disordinato: ");
            ClsVettori.ordinaSelezione(a);
            ClsVettori.stampaVet(a, "\nVettore ordinato: ");

            ClsVettori.caricaVet(a);
            ClsVettori.stampaVet(a, "\n\nVettore disordinato: ");
            ClsVettori.ordinaScambio(a);
            ClsVettori.stampaVet(a, "\nVettore ordinato con scambio: ");

            ClsVettori.attesaTasto();
        }
    }
}
