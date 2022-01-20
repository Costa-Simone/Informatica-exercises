using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuLancioMatrici
{
    class Program
    {

        private static void scriviMenu()
        {
            Console.Clear();
            Console.WriteLine("*** GESTIONE MATRICI ***\n");
            Console.WriteLine("\nA => Cerca MAX");
            Console.WriteLine("B => Media valori diagonale pincipale");
            Console.WriteLine("C => Media valori diagonale secondaria");
            Console.WriteLine("D => Media valori cornice");
            Console.WriteLine("E => Somma riga i-esima");
            Console.WriteLine("F => Somma colonna j-esima");
            Console.WriteLine("G => Conta occorrenze X");
            Console.WriteLine("H => Verifica somma riga I e colonne J UGUALI");
            Console.WriteLine("I => Verifica somma DP = a somma DS");
            Console.WriteLine("L => Verifica se tutti gli elementi sono uguali nella matrice");
            Console.WriteLine("M => Verifica se gli elementi sono ordinati in modo crescente");
            Console.WriteLine("\nX => ESCI \n");
        }
        static void Main(string[] args)
        {
            int[,] a = new int[10, 10]; //dichiarazione matrice
            int r=5, c=5; //ordine matrice
            char scelta = ' ';

            ClsMatrici.caricaMat(a, r, c);
           
            do
            { 

                scriviMenu();
                ClsMatrici.stampaMat(a, r, c);
                scelta = Console.ReadKey(true).KeyChar;
                switch (scelta)
                {
                    case 'A':
                    case 'a':
                        Console.WriteLine("\nIl numero massimo vale " + ClsMatrici.cercaMaxMat(a,r,c));

                        ClsUtils.attesaTasto();
                        break;

                    case 'B':
                    case 'b':
                        Console.WriteLine("\nLa media della DP è " + ClsMatrici.mediaDPMat(a, r));

                        ClsUtils.attesaTasto();
                        break;
                    case 'C':
                    case 'c':
                        Console.WriteLine("\nLa media della DS è " + ClsMatrici.mediaDSMat(a, r));

                        ClsUtils.attesaTasto();
                        break;

                    case 'D':
                    case 'd':
                        Console.WriteLine("\nLa media della cornice è " + ClsMatrici.mediaCornMat(a, r,c));

                        ClsUtils.attesaTasto();
                        break;

                    case 'E':
                    case 'e':
                        Console.WriteLine("\nLa somma della riga i-esima è " + ClsMatrici.sommaRigaIesimaMat(a, c));

                        ClsUtils.attesaTasto();
                        break;

                    case 'F':
                    case 'f':
                        Console.WriteLine("\nLa somma della colonna j-esima è " + ClsMatrici.sommaColJesimaMat(a, r));

                        ClsUtils.attesaTasto();
                        break;

                    case 'G':
                    case 'g':
                        Console.WriteLine("\nIl valore X compare " + ClsMatrici.ContaXMat(a, r, c)+" volte ");

                        ClsUtils.attesaTasto();
                        break;

                    case 'H':
                    case 'h':
                        if(ClsMatrici.sommaRigaIesimaMat(a,c)== ClsMatrici.sommaColJesimaMat(a, r))
                        {
                            Console.WriteLine("\nLe somme sono uguali");
                        }
                        else
                        {
                            Console.WriteLine("\nLe somme sono diverse");
                        }
                            
                        ClsUtils.attesaTasto();
                        break;

                    case 'I':
                    case 'i':
                        if (ClsMatrici.sommaDPMat(a, c) == ClsMatrici.sommaDSMat(a, r))
                        {
                            Console.WriteLine("\nLe somme sono uguali");
                        }
                        else
                        {
                            Console.WriteLine("\nLe somme sono diverse");
                        }
                            
                        ClsUtils.attesaTasto();
                        break;

                    case 'L':
                    case 'l':
                        if (ClsMatrici.elementiUguali(a, r, c))
                        {
                            Console.WriteLine("\nElementi tutti uguali");
                        }
                        else
                        {
                            Console.WriteLine("\nElementi diversi");
                        }

                        ClsUtils.attesaTasto();
                        break;

                    case 'M':
                    case 'm':
                        if (ClsMatrici.elementiOrdinati(a, r, c))
                        {
                            Console.WriteLine("\nElementi ordinati");
                        }
                        else
                        {
                            Console.WriteLine("\nElementi non ordinati");
                        }

                        ClsUtils.attesaTasto();
                        break;

                    case 'X':
                    case 'x':
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInserisci una scelta valida\n");
                        Console.BackgroundColor = ConsoleColor.Black;
                        //Mette in pausa il programma per 1 secondo
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
            } while (scelta.ToString().ToUpper() != "X");

        }
    }
}
