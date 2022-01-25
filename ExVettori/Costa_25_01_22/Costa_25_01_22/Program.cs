using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costa_25_01_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studenti = { "Servetti", "Vaschetto", "Vaschetto", "Cambieri", "Servetti", "Barbero", "Barbero", "Servetti", 
                "Vaschetto", "Vaschetto", "Cambieri", "Servetti", "Barbero", "Barbero" };
            string[] materie = { "Storia", "Matematica", "Informatica", "Inglese", "Matematica", "Inglese", "Storia", "Informatica",
                "Inglese", "Matematica", "Inglese", "Storia", "Matematica", "Matematica" };
            int[] voti = new int[studenti.Length];

            ClsVerifica.assegnaVoti(voti);
            //ClsVerifica.stampaTab(studenti, voti, materie);
            ClsVerifica.ordinaStudenti(studenti, materie, voti);
            ClsVerifica.stampaTab(studenti, voti, materie);
            ClsVerifica.calcolaMedia(studenti, materie, voti);

            Console.ReadKey();
        }
    }
}
