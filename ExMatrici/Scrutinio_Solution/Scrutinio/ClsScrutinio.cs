using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrutinio
{
    class ClsScrutinio
    {
        static Random rnd = new Random();
        internal static void caricaMat(int[,] voti)
        {
            for (int i = 0; i < voti.GetLength(0); i++)
            {
                for (int j = 0; j < voti.GetLength(1); j++)
                {
                    voti[i, j] = rnd.Next(0, 11);
                }
            }
        }
        public static void attesaTasto()
        {
            Console.WriteLine("");
            Console.WriteLine("\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        internal static void visualizzaTabella(string[] studenti, string[] materie, int[,] voti)
        {
            stampaRiga(63, 12);

            Console.Write("".PadLeft(12));

            for (int j = 0; j < materie.Length; j++)
            {
                Console.Write("|" + materie[j].Substring(0, 3));
            }

            Console.Write("| MEDIA ");
            Console.Write("| RISULTATO ");
            Console.Write("| DA RIPARARE |");
            Console.WriteLine();
            stampaRiga(75, 0);
            
            for (int i = 0; i < voti.GetLength(0); i++)
            {
                int somma = 0, contaInsufficienze = 0;

                Console.Write("|" + studenti[i].PadRight(11) + "|");

                for (int j = 0; j < voti.GetLength(1); j++)
                {
                    somma += voti[i, j];
                    scriviVoto(voti[i, j], false);
                    if (voti[i, j] < 6) contaInsufficienze++;
                }
                double media = (double)somma / materie.Length;

                scriviVoto(media, true);
                scriviRisultato(contaInsufficienze, voti, materie, i);
                Console.WriteLine();
                stampaRiga(75, 0);
            }
        }
        private static void scriviRisultato(int numInsufficienze, int[,] voti, string[] materie, int i)
        {
            string ripara = "";

            if (numInsufficienze > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("RESPINTO".PadLeft(11));
            }
            else if (numInsufficienze == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("PROMOSSO".PadLeft(11));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("RIMANDATO".PadLeft(11));
                ripara = cercaMaterie(voti, materie, i);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|");
            Console.Write(ripara.PadRight(13) + "|");
        }
        private static string cercaMaterie(int[,] voti, string[] materie, int i)
        {
            string ripara = "";

            for (int j = 0; j < materie.Length; j++)
            {
                if (voti[i, j] < 6) ripara += materie[j].Substring(0, 3) + " ";
            }

            return ripara;
        }
        private static void scriviVoto(double v, bool isDouble)
        {
            if (v < 5) Console.ForegroundColor = ConsoleColor.Red;
            else if(v >= 5 && v < 6) Console.ForegroundColor = ConsoleColor.Yellow;
            else Console.ForegroundColor = ConsoleColor.Green;
            if (isDouble) Console.Write(v.ToString("0.00").PadLeft(7));
            else Console.Write(v.ToString().PadLeft(3));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|");
        }
        private static void stampaRiga(int nChar, int offset)
        {
            Console.Write("".PadLeft(offset));
            Console.Write("".PadLeft(nChar, '-'));
            Console.WriteLine();
        }
        public static void scriviMenu()
        {
            Console.Clear();
            Console.WriteLine("*** GESTIONE MATRICI ***\n");
            Console.WriteLine("\nA => Cerca MAX");
            Console.WriteLine("B => Media valori diagonale pincipale");
            Console.WriteLine("X => ESCI");
        }
    }
}
