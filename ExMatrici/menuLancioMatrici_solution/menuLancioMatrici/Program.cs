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
            Console.WriteLine("N => Verifica se la matrice quadrata è unitaria");
            Console.WriteLine("O => Verifica se la matrice contiene una croce centrale di 1 e 0 in altre posizioni");
            Console.WriteLine("P => Verifica se elementi di due matrici sono uguali");
            Console.WriteLine("Q => Contare quanti elementi hanno uguali in sequenza due matrici (rxc)");
            Console.WriteLine("R => Somma righe di una matrice in un vettore");
            Console.WriteLine("S => Somma colonne di una matrice in un vettore");
            Console.WriteLine("T => Verifica se matrice e' fatta da 1,2,3,... in sequenza");
            Console.WriteLine("U => Verifica se matrice e' fatta da tutti 1 prima riga, tutti 2 seconda riga,...");
            Console.WriteLine("V => Somma in 2 vettori elementi righe, colonne e DP con 2 for");
            Console.WriteLine("W => Somma elementi sopra e sotto la DP");
            Console.WriteLine("Z => Verifica se media dei triangoli DP sono uguali");
            Console.WriteLine("X => ESCI");
        }
        static void Main(string[] args)
        {
            int[,] a = new int[10, 10], b = new int[10, 10]; //dichiarazione matrice
            int r=5, c=5; //ordine matrice
            char scelta = ' ';

            ClsMatrici.caricaMat(a, r, c);
            ClsMatrici.caricaMat(b, r, c);
           
            do
            { 
                scriviMenu();
                
                Console.WriteLine("\nStampa matrice a");
                ClsMatrici.stampaMat(a, r, c);
                Console.WriteLine("\nStampa matrice b");
                ClsMatrici.stampaMat(b, r, c);

                scelta = Console.ReadKey(true).KeyChar;

                switch (scelta)
                {
                    case 'A':  //Cerca MAX
                    case 'a':
                        Console.WriteLine("\nIl numero massimo vale " + ClsMatrici.cercaMaxMat(a,r,c));

                        ClsUtils.attesaTasto();
                        break;

                    case 'B':  //Media valori diagonale pincipale
                    case 'b':
                        Console.WriteLine("\nLa media della DP è " + ClsMatrici.mediaDPMat(a, r));

                        ClsUtils.attesaTasto();
                        break;
                    case 'C':  // Media valori diagonale secondaria
                    case 'c':
                        Console.WriteLine("\nLa media della DS è " + ClsMatrici.mediaDSMat(a, r));

                        ClsUtils.attesaTasto();
                        break;

                    case 'D':  //Media valori cornice
                    case 'd':
                        Console.WriteLine("\nLa media della cornice è " + ClsMatrici.mediaCornMat(a, r,c));

                        ClsUtils.attesaTasto();
                        break;

                    case 'E':  //Somma riga i-esima
                    case 'e':
                        Console.WriteLine("\nLa somma della riga i-esima è " + ClsMatrici.sommaRigaIesimaMat(a, c));

                        ClsUtils.attesaTasto();
                        break;

                    case 'F':  //Somma colonna j-esima
                    case 'f':
                        Console.WriteLine("\nLa somma della colonna j-esima è " + ClsMatrici.sommaColJesimaMat(a, r));

                        ClsUtils.attesaTasto();
                        break;

                    case 'G':  //Conta occorrenze X
                    case 'g':
                        Console.WriteLine("\nIl valore X compare " + ClsMatrici.ContaXMat(a, r, c)+" volte ");

                        ClsUtils.attesaTasto();
                        break;

                    case 'H':  //Verifica somma riga I e colonne J UGUALI
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

                    case 'I':  // Verifica somma DP = a somma DS
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

                    case 'L':  //Verifica se tutti gli elementi sono uguali nella matrice
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

                    case 'M':  //Verifica se gli elementi sono ordinati in modo crescente
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

                    case 'N':  //Verifica se la matrice quadrata è unitaria
                    case 'n':
                        if (ClsMatrici.unitariaMat(a, r, c))
                        {
                            Console.WriteLine("\nMatrice unitaria");
                        }
                        else
                        {
                            Console.WriteLine("\nMatrice non unitaria");
                        }

                        ClsUtils.attesaTasto();
                        break;

                    case 'O':  // Verifica se la matrice contiene una croce centrale di 1 e 0 in altre posizioni
                    case 'o':
                        if (ClsMatrici.croceCentraleMat(a, r, c))
                        {
                            Console.WriteLine("\nHa la croce di 1");
                        }
                        else
                        {
                            Console.WriteLine("\nNon ha la croce di 1");
                        }

                        ClsUtils.attesaTasto();
                        break;

                    case 'P':  // Verifica se elementi di due matrici sono uguali
                    case 'p':
                        if (ClsMatrici.elementiUguali2Mat(a, b, r, c))
                        {
                            Console.WriteLine("\nLe matrici sono uguali");
                        }
                        else
                        {
                            Console.WriteLine("\nLe matrici non sono uguali");
                        }

                        ClsUtils.attesaTasto();
                        break;

                    case 'Q':  //Contare quanti elementi hanno uguali in sequenza due matrici (rxc)
                    case 'q':
                        int cont = ClsMatrici.elementiUgualiCons(a, b, r, c);
                        Console.WriteLine("\nLe matrici hanno " + cont.ToString() + " elementi uguali");

                        ClsUtils.attesaTasto();
                        break;

                    case 'R':  //Somma righe di una matrice in un vettore
                    case 'r':
                        ClsMatrici.copiaSommaRigheVett(a, r, c);

                        ClsUtils.attesaTasto();
                        break;

                    case 'S':  //Somma colonne di una matrice in un vettore
                    case 's':
                        ClsMatrici.copiaSommaColonneVett(a, r, c);

                        ClsUtils.attesaTasto();
                        break;

                    case 'T':  //Verifica se matrice e' fatta da 1,2,3,... in sequenza
                    case 't':
                        if (ClsMatrici.elementiInSequenza(a, r, c))
                        {
                            Console.Write("\nElementi in sequenza");
                        }
                        else
                        {
                            Console.Write("\nElementi non in sequenza");
                        }

                        ClsUtils.attesaTasto();
                        break;

                    case 'U':  //Verifica se matrice e' fatta da tutti 1 prima riga, tutti 2 seconda riga,...
                    case 'u':
                        if (ClsMatrici.elementiRigaInSequenza(a, r, c))
                        {
                            Console.Write("\nRighe in sequenza");
                        }
                        else
                        {
                            Console.Write("\nRighe non in sequenza");
                        }

                        ClsUtils.attesaTasto();
                        break;

                    case 'V':  //Somma in 2 vettori elementi righe, colonne e DP con 2 for
                    case 'v':
                        ClsMatrici.sommaIn2VetRigheColonne2For(a, r, c);

                        ClsUtils.attesaTasto();
                        break;

                    case 'W':  //Somma elementi sopra e sotto la DP
                    case 'w':
                        ClsMatrici.sommaSopraESottoDP(a, r, c);

                        ClsUtils.attesaTasto();
                        break;

                    case 'Z':  //Verifica se media dei triangoli DP sono uguali
                    case 'z':
                        if (ClsMatrici.mediaSommaSopraESottoDP(a, r, c))
                        {
                            Console.WriteLine("\nLe medie sono uguali");
                        }
                        else
                        {
                            Console.WriteLine("\nLe medie sono diverse");
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
