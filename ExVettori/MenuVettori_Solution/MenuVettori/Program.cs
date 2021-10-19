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
                        cercaMax();

                        break;

                    case 'B':
                    case 'b':
                        copiaVett();

                        break;

                    case 'C':
                    case 'c':
                        copiaInvVett();

                        break;

                    case 'D':
                    case 'd':
                        invertiVett();

                        break;

                    case 'E':
                    case 'e':
                        prodottoScalare();
                        break;

                    case 'F':
                    case 'f':
                        prodottoVettoriale();
                        break;

                    case 'G':
                    case 'g':
                        ordinamentoVett();
                        break;

                    case 'H':
                    case 'h':
                        contaOccorrenze();
                        break;

                    case 'I':
                    case 'i':
                        sommaDispPar();
                        break;

                    case 'L':
                    case 'l':
                        elementiUguali();
                        break;

                    case 'M':
                    case 'm':
                        Console.WriteLine("\n\nIl prodotto scalare vale " + prodottoScalareFunzione().ToString());
                        Console.ReadKey();
                        break;

                    case 'N':
                    case 'n':
                        medieVettori();
                        break;

                    case 'O':
                    case 'o':
                        specularitaVettore();
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
        static void caricaVett(int[] v, int n)
        {
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1, 11);
            }
        }
        static void stampaVett(int[] v, int n, string name)
        {
            Console.WriteLine("\n" + name + ":");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i].ToString().PadRight(6));
            }
        }
        private static void cercaMax()
        {
            Console.Clear();
            int[] a;
            int n, massimo = int.MinValue;

            do
            {
                Console.Write("\nInserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            a = new int[n];

            caricaVett(a, n);
            stampaVett(a, n, "Stampa vettore a");

            for (int i = 0; i < n; i++)
            {
                if (a[i] > massimo)
                {
                    massimo = a[i];
                }
            }

            Console.WriteLine("\nIl massimo è " + massimo);
            Console.WriteLine("(premi un tasto per continuare)");
            Console.ReadKey();
        }
        static void copiaVett()
        {
            Console.Clear();
            int[] a, b;
            int n;

            do
            {
                Console.Write("\nInserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            a = new int[n];
            b = new int[n];

            caricaVett(a, n);
            stampaVett(a, n, "Stampa vettore a");

            for (int i = 0; i < n; i++)
            {
                b[i] = a[i];
            }

            stampaVett(b, n, "Stampa vettore b");
            Console.WriteLine("\n\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        private static void copiaInvVett()
        {
            Console.Clear();
            int[] a, b;
            int n, aus;

            do
            {
                Console.Write("\nInserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            a = new int[n];
            b = new int[n];

            caricaVett(a, n);
            stampaVett(a, n, "Stampa vettore a");

            for (int i = n-1; i >= 0; i--)
            {
                b[i] = a[n - i - 1];
            }

            stampaVett(b, n, "Stampa vettore b");
            Console.WriteLine("\n\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        private static void invertiVett()
        {
            Console.Clear();
            int[] a;
            int n, aus;

            do
            {
                Console.Write("\nInserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            a = new int[n];

            caricaVett(a, n);
            stampaVett(a, n, "Stampa vettore a");

            for (int i = 0, j = n - 1; i <= j; i++, j--)
            {
                aus = a[j];
                a[j] = a[i];
                a[i] = aus;
            }

            stampaVett(a, n, "Stampa vettore a invertito");
            Console.WriteLine("\n\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        private static void prodottoScalare()
        {
            Console.Clear();
            int[] a, b;
            int n, ps = 0;

            do
            {
                Console.Write("\nInserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            a = new int[n];
            b = new int[n];

            caricaVett(a, n);
            caricaVett(b, n);
            stampaVett(a, n, "Stampa vettore a");
            stampaVett(b, n, "Stampa vettore b");

            for (int i = 0; i < n; i++)
            {
                ps += a[i] * b[i];
            }

            Console.WriteLine("\n\n" +
                "Il prodotto scalare è " + ps);

            Console.WriteLine("\n\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        private static void prodottoVettoriale()
        {
            Console.Clear();
            int[] a, b, c;
            int n;

            do
            {
                Console.Write("\nInserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            a = new int[n];
            b = new int[n];
            c = new int[n];

            caricaVett(a, n);
            caricaVett(b, n);
            stampaVett(a, n, "Stampa vettore a");
            stampaVett(b, n, "Stampa vettore b");

            for (int i = 0; i < n; i++)
            {
                c[i] = a[i] * b[i];
            }

            stampaVett(c, n, "Stampa vettore c");
            Console.WriteLine("\n\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        private static void ordinamentoVett()
        {
            Console.Clear();
            int[] a;
            int n, i = 0;

            do
            {
                Console.Write("\nInserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            a = new int[n];

            caricaVett(a, n);
            stampaVett(a, n, "Stampa vettore a");

            int cont = 0;

            while (cont == 0 && i < n-1)
            {
                if (a[i] > a[i + 1])
                {
                    cont = 1;
                }

                i++;

            }
           
            if (cont == 0)
            {
                Console.WriteLine("\nIl vettore è ordinato");
            }
            else
            {
                Console.WriteLine("\nIl vettore non è ordinato");
            }

            Console.WriteLine("\n\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        private static void contaOccorrenze()
        {
            Console.Clear();
            int[] a;
            int n, x, cont = 0;

            do
            {
                Console.Write("\nInserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

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

            caricaVett(a, n);
            stampaVett(a, n, "Stampa vettore a");

            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    cont++;
                }
            }

            Console.WriteLine("\n\nIl valore è apparso " + cont + " volte");
            Console.WriteLine("\n\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        private static void sommaDispPar()
        {
            Console.Clear();
            int[] a;
            int n, sommaPar = 0, sommaDisp = 0;

            do
            {
                Console.Write("\nInserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            a = new int[n];

            caricaVett(a, n);
            stampaVett(a, n, "Stampa vettore a");

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
        private static void elementiUguali()
        {
            Console.Clear();
            int[] a;
            int n, aus = 0, i = 1;

            do
            {
                Console.Write("\nInserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            a = new int[n];

            caricaVett(a, n);
            stampaVett(a, n, "Stampa vettore a");

            do
            {
                if (a[0] != a[i])
                {
                    aus = 1;
                }
                else
                {
                    i++;
                }
            } while (aus == 0 && i < n - 1);
            
            if (aus == 0)
            {
                Console.WriteLine("\nIl vettore è uguale");
            }
            else
            {
                Console.WriteLine("\nIl vettore non è uguale");
            }

            Console.WriteLine("\n\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        private static int prodottoScalareFunzione()
        {
            Console.Clear();
            int[] a, b;
            int n, ps = 0;

            do
            {
                Console.Write("\nInserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            a = new int[n];
            b = new int[n];

            caricaVett(a, n);
            caricaVett(b, n);
            stampaVett(a, n, "Stampa vettore a");
            stampaVett(b, n, "Stampa vettore b");

            for (int i = 0; i < n; i++)
            {
                ps += a[i] * b[i];
            }
            
            return ps;
        }
        private static void medieVettori()
        {
            Console.Clear();
            int[] a, b;
            int n, mediaA = 0, mediaB = 0;

            do
            {
                Console.Write("\nInserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            a = new int[n];
            b = new int[n];

            caricaVett(a, n);
            stampaVett(a, n, "Stampa vettore a");
            caricaVett(b, n);
            stampaVett(b, n, "Stampa vettore b");

            for (int i = n - 1; i >= 0; i--)
            {
                mediaA += a[i];
                mediaB += b[i];
            }

            Console.WriteLine("\n\nLa media di a é " + mediaA + ", mentre la media di b é " + mediaB);

            if (mediaA == mediaB)
            {
                Console.WriteLine("\n\nLe due medie sono uguali");
            }
            else
            {
                Console.WriteLine("\n\nLe due medie non sono uguali");
            }

            Console.WriteLine("\n\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        private static void specularitaVettore()
        {
            Console.Clear();
            int[] a;
            int n, aus = 0, i = 0;

            do
            {
                Console.Write("\nInserire lunghezza del vettore: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            a = new int[n];

            caricaVett(a, n);
            stampaVett(a, n, "Stampa vettore a");

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
    }
}
