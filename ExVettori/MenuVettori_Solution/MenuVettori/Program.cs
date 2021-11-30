using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuVettori
{
    class Program
    {
        static Random rnd = new Random();
        private static void scriviMenu()
        {
            Console.Clear();
            Console.WriteLine("*** GESTIONE VETTORI ***");
            Console.WriteLine("\nA) => Cerca max");
            Console.WriteLine("\nB) => Copia di Vettori ");
            Console.WriteLine("\nC) => Copia di Vettori Invertita ");
            Console.WriteLine("\nD) => Inverti Vettore su se stesso" + " ");
            Console.WriteLine("\nE) => Prodotto Scalare di Vettori ");
            Console.WriteLine("\nF) => Prodotto Vettoriale ");
            Console.WriteLine("\nG) => Verifica ordinamento in un Vettore ");
            Console.WriteLine("\nH) => Contare numero di occorrenze in un Vettore ");
            Console.WriteLine("\nI) => Somma numeri Pari e Dispari in un Vettore ");
            Console.WriteLine("\nL) => Elemento uguali in un Vettore ");
            Console.WriteLine("\nM) => Prodotto Scalare Funzione ");
            Console.WriteLine("\nN) => Medie due Vettori uguali ");
            Console.WriteLine("\nO) => Vettore speculare ");
            Console.WriteLine("\nP) =>  ");
            Console.WriteLine("\nQ) => Vettore diverso ");
            Console.WriteLine("\nS) => Caricare vettore manualmente ordinato ");
            Console.WriteLine("\nT) => Caricare vettore casualmente ordinato ");
            Console.WriteLine("\nU) => Caricare vettore casualmente ordinato disgiunto ");
            Console.WriteLine("\nV) => Sposta vettore di una posizione a destra ");
            Console.WriteLine("\nW) => Vettore fibonacci ");
            Console.WriteLine("\nY) => Eliminazione della posizione X di un Vettore ");
            Console.WriteLine("\nX) => Esci ");
            Console.WriteLine("-------------------------------------------------------");
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
                    case 'A':
                    case 'a':
                        Console.WriteLine("\n\nIl valore massimo vale " + cercaMax().ToString());
                        ClsUtils.attesaTasto();
                        break;

                    case 'B':
                    case 'b':
                        copiaVett();
                        ClsUtils.attesaTasto();
                        break;

                    case 'C':
                    case 'c':
                        copiaInvVett();
                        ClsUtils.attesaTasto();
                        break;

                    case 'D':
                    case 'd':
                        invertiVett();
                        ClsUtils.attesaTasto();
                        break;

                    case 'E':
                    case 'e':
                        prodottoScalare();
                        ClsUtils.attesaTasto();
                        break;

                    case 'F':
                    case 'f':
                        prodottoVettoriale();
                        ClsUtils.attesaTasto();
                        break;

                    case 'G':
                    case 'g':
                        Console.WriteLine(ordinamentoVett() ? "\nIl vettore è ordinato" : "\nIl vettore non è ordinato");
                        ClsUtils.attesaTasto();
                        break;

                    case 'H':
                    case 'h':
                        Console.WriteLine("\n\nIl numero di occorrenze sono: " + contaOccorrenze().ToString());
                        ClsUtils.attesaTasto();
                        break;

                    case 'I':
                    case 'i':
                        sommaDispPar();
                        ClsUtils.attesaTasto();
                        break;

                    case 'L':
                    case 'l':
                        Console.WriteLine("\n\nGli elementi del vettore sono " + (elementiUguali() == true ? "uguali" : "diversi"));
                        ClsUtils.attesaTasto();
                        break;

                    case 'M':
                    case 'm':
                        Console.WriteLine("\n\nIl prodotto scalare vale " + prodottoScalareFunzione().ToString());
                        ClsUtils.attesaTasto();
                        break;

                    case 'N':
                    case 'n':
                        Console.WriteLine("\n\nI due vettori hanno le medie " + (medieVettori() ? "uguali" : "diverse"));
                        ClsUtils.attesaTasto();
                        break;

                    case 'O':
                    case 'o':
                        specularitaVettore();
                        ClsUtils.attesaTasto();
                        break;

                    case 'P':
                    case 'p':
                        Console.WriteLine("\n\nLa media del vettore vale " + calcolaMedia().ToString());
                        ClsUtils.attesaTasto();
                        break;

                    case 'Q':
                    case 'q':
                        vettoreDiverso();
                        ClsUtils.attesaTasto();
                        break;

                    case 'S':
                    case 's':
                        ClsVettori.caricaVettOrdinato();
                        ClsUtils.attesaTasto();
                        break;

                    case 'T':
                    case 't':
                        ClsVettori.caricaVettRandomOrdinato();
                        ClsUtils.attesaTasto();
                        break;

                    case 'U':
                    case 'u':
                        ClsVettori.caricaVettRandomOrdinatoDisgiunto();
                        ClsUtils.attesaTasto();
                        break;

                    case 'V':
                    case 'v':
                        spostaVettDestra();
                        ClsUtils.attesaTasto();
                        break;

                    case 'W':
                    case 'w':
                        vettFibonacci();
                        ClsUtils.attesaTasto();
                        break;

                    case 'Y':
                    case 'y':
                        eliminazioneX();
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
        private static int cercaMax()
        {
            Console.Clear();
            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: "), massimo = int.MinValue;

            a = new int[n];
            ClsVettori.caricaVett(a, 1, 15);
            ClsVettori.stampaVett(a, "Stampa vettore a");

            for (int i = 0; i < n; i++)
            {
                if (a[i] > massimo)
                {
                    massimo = a[i];
                }
            }

            return massimo;
        }
        static void copiaVett()
        {
            Console.Clear();
            int[] a, b;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: ");

            a = new int[n];
            b = new int[n];

            ClsVettori.caricaVett(a);
            ClsVettori.stampaVett(a, "Stampa vettore a");

            for (int i = 0; i < n; i++)
            {
                b[i] = a[i];
            }

            ClsVettori.stampaVett(b, "Stampa vettore b");
        }
        private static void copiaInvVett()
        {
            Console.Clear();
            int[] a, b;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: ");

            a = new int[n];
            b = new int[n];

            ClsVettori.caricaVett(a);
            ClsVettori.stampaVett(a, "Stampa vettore a");

            for (int i = n-1; i >= 0; i--)
            {
                b[i] = a[n - i - 1];
            }

            ClsVettori.stampaVett(b, "Stampa vettore b");
        }
        private static void invertiVett()
        {
            Console.Clear();
            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: "), aus;

            a = new int[n];

            ClsVettori.caricaVett(a);
            ClsVettori.stampaVett(a, "Stampa vettore a");

            for (int i = 0, j = n - 1; i <= j; i++, j--)
            {
                aus = a[j];
                a[j] = a[i];
                a[i] = aus;
            }

            ClsVettori.stampaVett(a, "Stampa vettore a invertito");
        }
        private static void prodottoScalare()
        {
            Console.Clear();
            int[] a, b;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: "), ps = 0;

            a = new int[n];
            b = new int[n];

            ClsVettori.caricaVett(a);
            ClsVettori.caricaVett(b);
            ClsVettori.stampaVett(a, "Stampa vettore a");
            ClsVettori.stampaVett(b, "Stampa vettore b");

            for (int i = 0; i < n; i++)
            {
                ps += a[i] * b[i];
            }

            Console.WriteLine("\n\n" + "Il prodotto scalare è " + ps);
        }
        private static void prodottoVettoriale()
        {
            Console.Clear();
            int[] a, b, c;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: ");

            a = new int[n];
            b = new int[n];
            c = new int[n];

            ClsVettori.caricaVett(a);
            ClsVettori.caricaVett(b);
            ClsVettori.stampaVett(a, "Stampa vettore a");
            ClsVettori.stampaVett(b, "Stampa vettore b");

            for (int i = 0; i < n; i++)
            {
                c[i] = a[i] * b[i];
            }

            ClsVettori.stampaVett(c, "Stampa vettore c");
        }
        private static bool ordinamentoVett()
        {
            Console.Clear();
            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: "), i = 0;

            a = new int[n];

            ClsVettori.caricaVett(a);
            ClsVettori.stampaVett(a, "Stampa vettore a");

            int cont = 0;

            while (cont == 0 && i < n-1)
            {
                if (a[i] > a[i + 1])
                {
                    cont = 1;
                }

                i++;
            }
            return cont == 0;
        }
        private static int contaOccorrenze()
        {
            Console.Clear();
            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: "), x, cont = 0;

            do
            {
                Console.Write("\nInserire valore da cercare: ");
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    x = -1;
                }
            } while (x <= 0);

            a = new int[n];

            ClsVettori.caricaVett(a);
            ClsVettori.stampaVett(a, "Stampa vettore a");

            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    cont++;
                }
            }

            return cont;
        }
        private static void sommaDispPar()
        {
            Console.Clear();
            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: "), sommaPar = 0, sommaDisp = 0;

            a = new int[n];

            ClsVettori.caricaVett(a);
            ClsVettori.stampaVett(a, "Stampa vettore a");

            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sommaPar += a[i];
                }
                else
                {
                    sommaDisp += a[i];
                }
            }

            Console.WriteLine("\n\nLa somma dei valori pari è " + sommaPar + ", mentre quella dei dispari è " + sommaDisp);
            Console.WriteLine("\n\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        private static bool elementiUguali()
        {
            Console.Clear();
            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: "), i = 1;
            bool aus = true;

            a = new int[n];

            ClsVettori.caricaVett(a);
            ClsVettori.stampaVett(a, "Stampa vettore a");

            do
            {
                if (a[0] != a[i])
                {
                    aus = false;
                }
                else
                {
                    i++;
                }
            } while (aus == true && i < n - 1);

            return aus;
        }
        private static int prodottoScalareFunzione()
        {
            Console.Clear();
            int[] a, b;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: "), ps = 0;

            a = new int[n];
            b = new int[n];

            ClsVettori.caricaVett(a);
            ClsVettori.caricaVett(b);
            ClsVettori.stampaVett(a, "Stampa vettore a");
            ClsVettori.stampaVett(b, "Stampa vettore b");

            for (int i = 0; i < n; i++)
            {
                ps += a[i] * b[i];
            }
            
            return ps;
        }
        private static bool medieVettori()
        {
            Console.Clear();
            int[] a, b;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: ");

            a = new int[n];
            b = new int[n];

            ClsVettori.caricaVett(a);
            ClsVettori.stampaVett(a, "Stampa vettore a");
            ClsVettori.caricaVett(b);
            ClsVettori.stampaVett(b, "Stampa vettore b");

            return mediaVett(a) == mediaVett(b);
        }
        private static double mediaVett(int[] a)
        {
            int som = 0;

            for (int i = 0; i < a.Length; i++)
            {
                som += a[i];
            }

            return (double)som / a.Length;
        }
        private static void specularitaVettore()
        {
            Console.Clear();
            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: "), aus = 0, i = 0;

            a = new int[n];

            ClsVettori.caricaVett(a);
            ClsVettori.stampaVett(a, "Stampa vettore a");

            do
            {
                if (a[i] != a[n - i - 1])
                {
                    aus = 1;
                }
                else
                {
                    i++;
                }
            } while (aus == 0 && i <= n / 2);

            if (aus == 0)
            {
                Console.WriteLine("\n\nIl vettore è speculare");
            }
            else
            {
                Console.WriteLine("\n\nIl vettore non è speculare");
            }

            Console.WriteLine("\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        private static double calcolaMedia()
        {
            Console.Clear();
            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: ");

            a = new int[n];

            ClsVettori.caricaVett(a);
            ClsVettori.stampaVett(a, "Stampa vettore a");

            return mediaVett(a);
        }
        private static void vettoreDiverso()
        {
            Console.Clear();
            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: "), aus, j;

            a = new int[n];

            a[0] = rnd.Next(1, 101);

            for (int i = 1; i < a.Length; i++)
            {
                do
                {
                    j = 0;

                    aus = rnd.Next(1, 101);

                    while (aus != a[j] && j < i)
                    {
                        j++;
                    }
                } while (a[j] == aus);

                a[i] = aus;
            }

            ClsVettori.stampaVett(a, "Stampa vettore a");
        }
        private static void spostaVettDestra()
        {
            Console.Clear();
            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: "), aus;

            a = new int[n];

            ClsVettori.caricaVett(a);

            ClsVettori.stampaVett(a, "Stampa vettore a prima");

            aus = a[n-1];
            
            for (int i = n-1; i >= 1; i--)
            {
                a[i] = a[i - 1];
            }

            a[0] = aus;

            ClsVettori.stampaVett(a, "Stampa vettore a dopo");
        }
        private static void vettFibonacci()
        {
            Console.Clear();
            
            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: ");

            a = new int[n];

            a[0] = 0;
            a[1] = 1;

            for (int i = 2; i < n; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
            }

            ClsVettori.stampaVett(a, "Stampa vettore");
        }
        private static void eliminazioneX()
        {
            Console.Clear();
            int[] a;
            int n = ClsUtils.inputDimensione("Inserire lunghezza del vettore: "), x;

            do
            {
                Console.Write("Inserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    x = -1;
                }
            } while (x <= 0 && x >= n);

            a = new int[n];

            ClsVettori.caricaVett(a);
            ClsVettori.stampaVett(a, "Stampa vettore prima");

            for (int i = x - 1; i < n - 1; i++)
            {
                a[i] = a[i + 1];
            }

            Console.WriteLine("\nStampa vettore dopo:");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(a[i].ToString().PadRight(6));
            }
        }
    }
}
