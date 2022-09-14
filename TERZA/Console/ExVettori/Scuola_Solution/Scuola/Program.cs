using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    class Program
    {
        static string[] cognomi = { "Bogetti", "Noto", "Grosso", "Pieretto", "Cairo", "Migori", "Arese", "Cerrato", "Bertello", "Simon" };
        static string[] nomi = { "Leonardo", "Serena", "Pietro", "Francesco", "Pietro", "Andrea", "Anna", "Diego", "Tommaso", "Amos" };
        static string[] classi = { "1A", "2A", "3A", "1A", "2B", "3B", "1A", "1B", "3A", "1B" };
        static void Main(string[] args)
        {


            titolo("GESTIONE SCUOLA");
            intestazione();

            visualizzaTabella(cognomi, nomi, classi);

            menu();
        }
        private static void menu()
        {
            char scelta;

            do
            {
                Console.WriteLine("*** SCEGLI UNA FUNZIONE ***");
                Console.WriteLine("\nA) => Data una classe cercarne gli studenti");
                Console.WriteLine("\nB) => Ordinamento in base alla classe ");
                Console.WriteLine("\nC) =>  ");
                Console.WriteLine("\nD) => Ricerca di uno studente dati cognome e nome ");
                Console.WriteLine("\nX) => Esci ");

                scelta = Console.ReadKey(true).KeyChar;

                switch (scelta)
                {
                    case 'A':
                    case 'a':
                        ClsEsercizi.cercaStudentiClasse(cognomi, nomi, classi);
                        attesaTasto();
                        break;

                    case 'B':
                    case 'b':
                        ClsEsercizi.ordinaPerClassi(cognomi, nomi, classi);
                        intestazione();
                        visualizzaTabella(cognomi, nomi, classi);
                        attesaTasto();
                        break;

                    case 'C':
                    case 'c':
                        ClsEsercizi.cercaStudentiClasseOrdinata(cognomi, nomi, classi);
                        attesaTasto();
                        break;

                    case 'D':
                    case 'd':
                        ClsEsercizi.cercaStudenteDatiCognomeNome(cognomi, nomi, classi);
                        attesaTasto();
                        break;

                    case 'X':
                    case 'x':

                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Inserisci una scelta valida!\n");
                        Console.BackgroundColor = ConsoleColor.Black;
                        System.Threading.Thread.Sleep(1000);                        //mette in pausa il programma per 1 sec
                        break;
                }
            } while (scelta.ToString().ToUpper() != "X");
        }
        private static void visualizzaTabella(string[] cognomi, string[] nomi, string[] classi)
        {
            for (int i = 0; i < cognomi.Length; i++)
            {
                scriviValori(cognomi[i], nomi[i], classi[i]);
            }
        }
        private static void titolo(string testoTitolo)
        {
            disegnariga(65);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|".PadRight(24) + testoTitolo + "|".PadLeft(25));
            Console.ResetColor();
            disegnariga(64);
        }
        private static void intestazione()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|" + "COGNOME".PadRight(25)
                + "|" + "NOME".PadRight(25)
                + "|" + "CLASSE".PadRight(10) + "|"
                );
            Console.ResetColor();
            disegnariga(65);
        }
        private static void disegnariga(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        private static void scriviValori(string cogn, string nome, string cla)
        {
            Console.WriteLine("\n|" + cogn.PadRight(25)
                + "|" + nome.PadRight(25)
                + "|" + cla.PadRight(10)
                );

            Console.ResetColor();
            disegnariga(65);
        }
        public static void attesaTasto()
        {
            Console.WriteLine("\n\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
    }
}
