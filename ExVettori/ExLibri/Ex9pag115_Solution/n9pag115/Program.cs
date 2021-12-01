using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n9pag115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = {"Frank","Dodo","Treppa","Gala","Roxi","Huge","Depo","Magna"};
            string[] cognome = { "Pier", "Perassi", "Trecco", "Volpin", "Rossa", "Hussein", "Depetris", "Magnano" };
            string[] citta = { "Barge", "San Martino", "Crocera", "Barge", "San Martino", "Crocera", "Barge", "San Martino" };

            string[] nominativo = new string[nome.Length];
            for (int i = 0; i < nome.Length; i++)
            {
                nominativo[i] = cognome[i] + " " + nome[i];
                Console.Write("Studente: " + nominativo[i] +"\t"+ " della città : " + citta[i]+ "\n");
            }
            ClsVettori.ordinamentoCitta(citta,nominativo);
            Console.WriteLine();
            ClsVettori.ricercaStudentiDataCitta(nominativo, citta);

            // per ogni città contare numero di studenti
            contaStudenti(citta);

            // per ogni città stampare i suoi studenti
            stampaStudenti(cognome, citta);

            // cercare la città con il maggior numero di Studenti(con parimerito)

            // cercare la città con il maggior numero di Studenti(senza parimerito)

            attesaTasto();
        }
        private static void stampaStudenti(string[] cognome, string[] citta)
        {
            Array.Resize(ref citta, citta.Length + 1);
            citta[citta.Length - 1] = "ZZ";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + citta[0]);
            Console.ResetColor();

            for (int i = 0; i < citta.Length - 1; i++)
            {
                if (citta[i] == citta[i + 1])
                {
                    Console.WriteLine("\n" + cognome[i]);
                }
                else
                {
                    Console.WriteLine("\n" + cognome[i]);
                    if (citta[i + 1] != "ZZ")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n" + citta[i + 1]);
                        Console.ResetColor();
                    }
                }
            }
        }
        public static void attesaTasto()
        {
            Console.WriteLine("\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        private static void contaStudenti(string[] citta)
        {
            Array.Resize(ref citta, citta.Length + 1);
            citta[citta.Length - 1] = "ZZ";

            int cont = 1;

            for (int i = 0; i < citta.Length - 1; i++)
            {
                if (citta[i] == citta[i + 1])
                {
                    cont++;
                }
                else
                {
                    Console.WriteLine("\n" + citta[i] + " " + cont.ToString());
                    cont = 1;
                }
            }
        }
    }
}
