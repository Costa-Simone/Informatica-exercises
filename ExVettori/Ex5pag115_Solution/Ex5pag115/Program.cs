using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5pag115
{
    class Program
    {
        static string[] nomi = { "Pietro", "Francesco", "Simone", "Alessio", "Filippo", "Andrea", "Demarchi", "Lorenzo", "Matteo", "Antonio" };
        static string[] cognomi = { "Cairo", "Pieretto", "Costa", "Rinaudo", "Di Francesco", "Magnano", "Andrea", "Pilloni", "Calova", "Barbagiovanni" };
        static string[] squadre = { "Valle Po", "Infernotto", "Valle Po", "Infernotto", "Savigliano", "Saluzzo", "Saluzzo", "Valle Po", "Infernotto", "Savigliano" };
        static void Main(string[] args)
        {
            titolo("GIOCATORI E SQUADRE");
            intestazione();
            visualizzaTabella(cognomi, nomi, squadre);
            Esercizio5(nomi, cognomi, squadre);
            Esercizio6(nomi, cognomi, squadre);
            ClsVettori.attesaTasto();
        }
        private static void Esercizio5(string[] nomi, string[] cognomi, string[] squadre)
        {
            Console.Write("Inserisci la squadra per ordinarne i membri: ");
            string crew = Console.ReadLine();

            int k = 0;

            for (int i = 0; i < nomi.Length; i++)
            {
                if (squadre[i] == crew)
                {
                    k++;
                }
            }
            if (k != 0)
            {
                string[] nomi1 = new string[k];
                string[] cognomi1 = new string[k];
                int j = 0;
                for (int i = 0; i < nomi.Length; i++)
                {
                    if (squadre[i] == crew)
                    {
                        nomi1[j] = nomi[i];
                        cognomi1[j++] = cognomi[i];
                    }
                }
                ordinaScambio(cognomi1, nomi1);
                Console.WriteLine();
                visualizzaTabellaMini(cognomi1, nomi1);
            }
            else
            {
                Console.WriteLine("Nessun giocatore con questa squadra trovato");
            }
        }
        private static void Esercizio6(string[] nomi, string[] cognomi, string[] squadre)
        {
            ClsVettori.ordinaSelezione(squadre);

            string[] sq = new string[squadre.Length];
            int[] cont = new int[squadre.Length];

            int contaSquad = ClsVettori.rottureSuSquadre(squadre, sq, cont);
        }
        private static void visualizzaTabellaMini(string[] cognomi1, string[] nomi1)
        {
            for (int i = 0; i < cognomi1.Length; i++)
            {
                scriviValoriMini(cognomi1[i], nomi1[i]);
            }
        }
        private static void scriviValoriMini(string v1, string v2)
        {
            Console.WriteLine("|" + v1.PadRight(25) + "|" + v2.ToString().PadRight(25) + "|");
            disegnaRiga(54);
        }
        internal static void ordinaScambio(string[] cogn1, string[] nom1)
        {
            int i = -1;
            bool scambio;
            do
            {
                i++;
                scambio = false;
                for (int j = nom1.Length - 2; j >= i; j--)
                {
                    if (cogn1[j].CompareTo(cogn1[j + 1]) > 0)
                    {
                        string temp = cogn1[j];
                        cogn1[j] = cogn1[j + 1];
                        cogn1[j + 1] = temp;
                        temp = nom1[j];
                        nom1[j] = nom1[j + 1];
                        nom1[j + 1] = temp;
                        scambio = true;
                    }
                }
            } while (i != nom1.Length - 2 && scambio);
        }
        public static void visualizzaTabella(string[] cognomi, string[] nomi, string[] classi)
        {
            for (int i = 0; i < cognomi.Length; i++)
            {
                scriviValori(cognomi[i], nomi[i], classi[i]);
            }
        }
        private static void titolo(string titolo)
        {
            disegnaRiga(64);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("***".PadRight(15) + titolo + "***".PadLeft(10));
            Console.ResetColor();
            disegnaRiga(64);
        }
        private static void intestazione()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|" + "COGNOME ".PadRight(25) + "|" + "NOME".PadRight(25) + "|" + "SQUADRA".PadRight(10) + "|");
            Console.ResetColor();
            disegnaRiga(64);
        }
        private static void disegnaRiga(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        private static void scriviValori(string cogn, string nom, string cla)
        {
            Console.WriteLine("|" + cogn.PadRight(25) + "|" + nom.ToString().PadRight(25) + "|" + cla.ToString().PadLeft(10) + "|");
            disegnaRiga(64);
        }
    }
}
