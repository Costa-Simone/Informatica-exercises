using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicercaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ClsVettori.inputDimensione("Inserisci la lunghezza del vettore: ");
            int[] a = new int[n];
            //Ricerca binaria - vettore ORDINATO e SENZA RIPETIZIONI
            ClsVettori.caricaVetRndOrdinatoSenzaRip(a);
            ClsVettori.stampaVet(a, "\nVettore ordinato e senza ripetizioni");
            
            int x = ClsVettori.inputDimensione("\n\nInserisci x da cercare: ");
            
            ClsVettori.ricerca_bin(a, x);
            ClsVettori.attesaTasto();
            //Ricerca a blocchi - vettore ORDINATO e SENZA RIPETIZIONI
            ClsVettori.caricaVetRndOrdinatoSenzaRip(a);
            ClsVettori.stampaVet(a, "\nVettore ordinato e senza ripetizioni");

            x = ClsVettori.inputDimensione("\n\nInserisci x da cercare: ");

            ClsVettori.ricerca_blocchi(a, x);
            ClsVettori.attesaTasto();
        }
    }
}
