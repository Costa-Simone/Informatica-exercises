using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costa_07_12_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] candidati ={"Esposito","Minniti","Conte","Cantone","Barbero", "Cortese","Borghese","Gandolfo","Servetti","Polidoro"};
            string[] liste ={"Scuola mia","Bene a scuola","Troppa scuola","Scuola mia","Bene a scuola","Scuola mia","Troppa scuola","Scuola mia","Troppa scuola","Bene a scuola"};
            int[] voti = { 3, 8, 5, 8, 8, 3, 1, 0, 5, 8, 5, 3, 8, 4, 5 };
            int[] contaVoti = new int[candidati.Length];

            ClsVerifica.azzeraVett(contaVoti);

            ClsVerifica.contaVoti(voti, contaVoti);

            ClsVerifica.ordinaCandidati(candidati, liste, contaVoti);

            Console.WriteLine("Lista candidati: ");
            ClsVerifica.stampaTab(candidati, liste, contaVoti);

            Console.WriteLine("\nEletti:\n");
            ClsVerifica.stampaEletti(candidati, contaVoti);

            ClsVerifica.ordinaListe(candidati, liste, contaVoti);

            Console.WriteLine("\nVoti di lista:\n ");
            ClsVerifica.contaVotiListe(liste, contaVoti);

            ClsVerifica.attesaTasto();
        }
    }
}
