﻿using System;
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
            string[] citta = { "Barge", "San Ma", "Crocera", "Barge", "San Ma", "Crocera", "Barge", "San Ma" };
            int[] eta = { 23, 45, 12, 76, 16, 29, 18, 65 };

            string[] nominativo = new string[nome.Length];
            for (int i = 0; i < nome.Length; i++)
            {
                nominativo[i] = cognome[i] + " " + nome[i];
                Console.Write("Studente: " + nominativo[i] +"\t"+ " della città : " + citta[i] + "\t di età: " + eta[i] + "\n");
            }
            ClsVettori.ordinamentoCitta(citta,nominativo, eta);
            Console.WriteLine();
            ClsVettori.ricercaStudentiDataCitta(nominativo, citta);

            // per ogni città contare numero di studenti
            contaStudenti(citta);

            // per ogni città stampare i suoi studenti
            stampaStudenti(cognome, citta);

            // cercare la città con il maggior numero di Studenti(senza parimerito)
            contaStudentiMaggiori(citta);

            // cercare la città con il maggior numero di Studenti(parimerito)
            contaStudentiMaggiori2(citta);

            // calcolare media dell'età degli studenti di una città in ingresso
            Console.WriteLine("\nInserisci la città: ");
            string city = Console.ReadLine();
            Console.WriteLine("\nLa media dell'età degli studenti di " + city + " è " + mediaStudenti(eta, citta, city));

            // per ogni città calcolare media dell'età
            calcolaMediaTutteCitta(eta, citta);

            attesaTasto();
        }
        private static void calcolaMediaTutteCitta(int[] eta, string[] citta)
        {
            Array.Resize(ref citta, citta.Length + 1);
            citta[citta.Length - 1] = "ZZ";

            int cont = 1;
            double somma = 0;

            for (int i = 0; i < citta.Length - 1; i++)
            {
                if (citta[i] == citta[i + 1])
                {
                    cont++;
                    somma += eta[i];
              
                }
                else
                {
                    somma += eta[i];
                    Console.WriteLine("\n" + citta[i] + "\t" + (somma / cont).ToString());
                    cont = 1;
                    somma = 0;
                }
            }
        }
        private static double mediaStudenti(int[] eta, string[] citta, string city)
        {
            double somma = 0;

            int i = 0;
            bool superato = false;
            int cont = 0;

            while (!superato && i <= citta.Length - 1)
            {
                if (citta[i] == city)
                {
                    cont++;
                    somma += eta[i];
                    i++;
                }
                else
                {
                    if (citta[i].CompareTo(city) > 0)
                    {
                        superato = true;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            return somma/cont;
        }
        private static void contaStudentiMaggiori2(string[] citta)
        {
            Array.Resize(ref citta, citta.Length + 1);
            citta[citta.Length - 1] = "ZZ";

            int cont = 1, max = 0;
            string city= null;

            for (int i = 0; i < citta.Length - 1; i++)
            {
                if (citta[i] == citta[i + 1])
                {
                    cont++;
                }
                else
                {
                    if (cont > max)
                    {
                        max = cont;
                        city = citta[i] + ", ";
                    }
                    else
                    {
                        if (cont == max)
                        {
                            city += citta[i] + " ";
                        }
                    }

                    cont = 1;
                }
            }

            Console.WriteLine("\nLa città con più studenti è " + city);
        }
        private static void contaStudentiMaggiori(string[] citta)
        {
            Array.Resize(ref citta, citta.Length + 1);
            citta[citta.Length - 1] = "ZZ";

            int cont = 1, max = 0;
            string city = null;

            for (int i = 0; i < citta.Length - 1; i++)
            {
                if (citta[i] == citta[i + 1])
                {
                    cont++;
                }
                else
                {
                    if (cont > max)
                    {
                        max = cont;
                        city = citta[i];
                    }
                    cont = 1;
                }
            }

            Console.WriteLine("\nLa città con più studenti è " + city);
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
