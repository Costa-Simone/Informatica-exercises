using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicercaBinaria
{
    class ClsVettori
    {
        static Random rnd = new Random();
        public static void caricaVetRndOrdinatoSenzaRip(int[]v)
        {
            //variabili locali
            
            int max = 10;

            v[0] = rnd.Next(1, max);

            for (int i = 1; i < v.Length; i++)
            {
                max = v[i - 1] + 1;
                v[i] = rnd.Next(max, max + 10);
            }
        }
        public static void attesaTasto()
        {
            Console.WriteLine("\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        public static void ricerca_bin(int[] v, int x)
        {
            int sup = 0, inf = v.Length - 1;
            int meta;

            do
            {
                meta = (inf + sup) / 2;

                if(v[meta]!=x)
                {
                    if (v[meta] > x)
                    {
                        inf = meta - 1;
                    }
                    else
                    {
                        sup = meta + 1;
                    }
                }
            } while (v[meta]!=x && sup<=inf);

            if(v[meta]==x)
            {
                Console.WriteLine("\nElemento trovato in pos: " + meta.ToString());
            }
            else
            {
                Console.WriteLine("\nElemento non trovato");
            }
        }
        public static void ricerca_blocchi(int[] a, int x)
        {
            bool trovato = false, esci = false;
            int lb = Convert.ToInt32(Math.Sqrt(a.Length));
            int i = lb - 1;

            do
            {
                if (a[i] == x)
                {
                    trovato = true;
                }
                else
                {
                    if (a[i] > x)
                    {
                        i = i + lb;
                    }
                    else
                    {
                        //esamina blocco
                        int j = i - lb + 1;
                        while (a[j] < x && j != i)
                        {
                            j++;
                        }

                        if (a[j] == x)
                        {
                            trovato = true;
                            i = j;
                        }
                        else
                        {
                            esci = true;
                        }
                    }
                }
            } while (!trovato && !esci && i < a.Length);

            if (trovato)
            {
                Console.WriteLine("\nElemento trovato in posizione: " + i.ToString());
            }
            else
            {
                if (esci)
                {
                    Console.WriteLine("\nElemento non trovato!");
                }
                else
                {
                    //ultimo blocco
                    i = i - lb + 1;
                    while (a[i] < x && i != a.Length)
                    {
                        i++;
                    }

                    if (a[i] == x)
                    {
                        Console.WriteLine("\nElemento trovato in posizione: " + i.ToString());
                    }
                    else
                    {
                        Console.WriteLine("\nElemento non trovato!");
                    }
                }
            }
        }
        public static int inputDimensione(string messaggio)
        {
            int n;

            do
            {
                Console.Write(messaggio);
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Devi inserire un numero > 0!");
                }
            }
            while (n <= 0);
            return n;
        }
        public static void stampaVet(int[] v, string nome)
        {
            Console.Write(nome + ": ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i].ToString().PadRight(6));
            }
        }
    }
}
