using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    internal class Program
    {
        public struct Pagelle
        {
            public string Materia;
            public int Orale;
            public int Scritto;
            public int Pratico;
            public int Media;
        }
        public static Pagelle[] pagella = new Pagelle[8];

        private static void scriviMenu()
        {
            Console.Clear();
            Console.WriteLine("*** GESTIONE MATRICI ***\n");
            Console.WriteLine("1 => ESCI");
            Console.WriteLine("2 => CARICA LE MATERIE");
            Console.WriteLine("3 => CARICA I VOTI");
            Console.WriteLine("4 => VISUALIZZA LA MEDIA DELLA MATERIE X");
            Console.WriteLine("5 => VISUALIZZA LA MEDIA TOTALE");
            Console.WriteLine("6 => VISUALIZZA LE MEDIE IN ORDINE CRESCENTE, IL MIN E IL MAX");
        }
        static void Main(string[] args)
        {
            char scelta = ' ';

            do
            {
                scriviMenu();

                scelta = Console.ReadKey(true).KeyChar;

                switch (scelta)
                {
                    case '2':  //CARICA LE MATERIE
                        ex02(pagella);
                        break;

                    case '3':  //CARICA I VOTI
                        ex03(pagella);
                        break;
                }
            } while (scelta.ToString() != "1");
        }
        private static void ex03(Pagelle[] pagella)
        {
            Console.WriteLine();

            Console.WriteLine("Inserisci l")
        }
        private static void ex02(Pagelle[] pagella)
        {
            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                Console.Write("Inserisci il nome della " + (i + 1) + "^ materia: ");
                pagella[i].Materia = Console.ReadLine();
            }
        }
    }
}
