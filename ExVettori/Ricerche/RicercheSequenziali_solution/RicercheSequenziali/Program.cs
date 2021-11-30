using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicercheSequenziali
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ClsVettori.inputDimensione("Inserisci la lunghezza del vettore: ");
            int[] a = new int[n];
            //caso 1 - vettore DISORDINATO e SENZA RIPETIZIONI
            ClsVettori.caricaVetRndSenzaRip(a);
            ClsVettori.stampaVet(a, "Vettore disordinato e senza ripetizioni");
            
            int x = ClsVettori.inputDimensione("\nInserisci x da cercare: ");
            
            ClsVettori.ricerca_seq1(a, x);
            ClsVettori.attesaTasto();
            //caso 2 - vettore DISORDINATO e CON RIPETIZIONI
            ClsVettori.caricaVet(a);
            ClsVettori.stampaVet(a, "Vettore disordinato e con ripetizioni");
            
            x = ClsVettori.inputDimensione("\nInserisci x da cercare: ");
            
            ClsVettori.ricerca_seq2(a, x);
            ClsVettori.attesaTasto();
            //caso 3 - vettore ORDINATO e SENZA RIPETIZIONI
            ClsVettori.caricaVetRndOrdinatoSenzaRip(a);
            ClsVettori.stampaVet(a, "Vettore ordinato e senza ripetizioni");
            
            x = ClsVettori.inputDimensione("\nInserisci x da cercare: ");
            
            ClsVettori.ricerca_seq3(a, x);
            ClsVettori.attesaTasto();
            //caso 4 - vettore ORDINATO e CON RIPETIZIONI
            ClsVettori.caricaVetRndOrdinatoConRipet(a);
            ClsVettori.stampaVet(a, "Vettore ordinato e con ripetizioni");

            x = ClsVettori.inputDimensione("\nInserisci x da cercare: ");
            
            ClsVettori.ricerca_seq4(a, x);
            ClsVettori.attesaTasto();
        }
    }
}
