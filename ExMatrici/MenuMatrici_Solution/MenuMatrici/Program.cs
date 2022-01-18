using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMatrici
{
    class Program
    {
        private static void scriviMenu()
        {
            Console.Clear();
            Console.WriteLine("*** GESTIONE MATRICI ***");
            Console.WriteLine("\nA) => Cerca max");
            Console.WriteLine("\nB) => Media valori diagonale principale ");
            Console.WriteLine("\nC) => Media valori diagonale secondaria ");
            Console.WriteLine("\nD) => Media valori cornice");
            Console.WriteLine("\nX) => Esci ");
            Console.WriteLine("-------------------------------------------------------");
        }
        static void Main(string[] args)
        {
            char scelta = ' ';
            int[,] a = new int[10, 10];
            int r = 5, c = 5;

            ClsMatrici.caricaMat(a, r, c);

            do
            {
                scriviMenu();

                Console.WriteLine();
                ClsMatrici.stampaMat(a, r, c);

                scelta = Console.ReadKey(true).KeyChar;

                switch (scelta)
                {
                    case 'A':
                    case 'a':
                        Console.WriteLine("\n\nIl valore massimo vale " + ClsMatrici.cercaMaxMat(a, r, c));
                        ClsUtils.attesaTasto();
                        break;

                    case 'B':
                    case 'b':
                        Console.WriteLine("\nLa media della diagonale principale e' " + ClsMatrici.mediaDPMat(a, r).ToString());
                        ClsUtils.attesaTasto();
                        break;

                    case 'C':
                    case 'c':
                        Console.WriteLine("\nLa media della diagonale secondaria e' " + ClsMatrici.mediaDSMat(a, r).ToString());
                        ClsUtils.attesaTasto();
                        break;

                    case 'D':
                    case 'd':
                        Console.WriteLine("\nLa media della cornice e' " + ClsMatrici.mediaCornice(a, r, c).ToString());
                        ClsUtils.attesaTasto();
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
    }
}
