using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrutinio
{
    class Program
    {
        static string[] studenti = { "s1", "s2", "s3", "s4", "s5", "s6", "s7", "s8", "s9", "s10" };
        static string[] materie = { "italiano", "storia", "matematica", "inglese", "informatica", "sistemi", "francese" };
        static int[,] voti = new int[studenti.Length, materie.Length];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            ClsScrutinio.caricaMat(voti);
            ClsScrutinio.visualizzaTabella(studenti, materie, voti);

            ClsScrutinio.attesaTasto();
        }
    }
}
