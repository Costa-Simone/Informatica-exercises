using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n12pag150
{
    class Program
    {
        static string[] atleti = { "atl1", "atl2", "atl3", "atl4", "atl5" };
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int c;
            
            Console.Write("Inserisci il numero di prove ");
            c = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[atleti.Length, c];

            caricaMat(a);
            stampaMat(a,atleti);
            classificaParziale(a, atleti); //classifica per ogni prova
            classificaTotale(a, atleti,c); //classifica totale

            Console.ReadKey();
        }
        private static void classificaTotale(int[,] a, string[] atleti,int c)
        {
            int[] cont= new int[c];
            azzeraVet(cont);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    cont[j] += a[i, j];
                }
            }
            classificaTot(cont, atleti);
        }
        private static void classificaTot(int[] a, string[] atleti)
        {
            int aus;
            string atl;
            for (int i = 0; i < a.Length-1; i++)
            {
                int posMin = i;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[posMin] < a[i])
                        posMin = j;
                }
                if(posMin!=i)
                {
                    aus = a[i];
                    a[i] = a[posMin];
                    a[posMin] = aus;
                    atl = atleti[i];
                    atleti[i] = atleti[posMin];
                    atleti[posMin] = atl;
                }
            }
            Console.WriteLine("Classifica totale");
            stampaClassifica(atleti);
        }
        private static void azzeraVet(int[] cont)
        {
            for (int i = 0; i < cont.Length; i++)
            {
                cont[i] = 0;
            }
        }
        private static void classificaParziale(int[,] a, string[] atleti)
        {
            int aus;
            string atl;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                for (int i = 0; i < a.GetLength(0)-1; i++)
                {
                    int posMin = i;
                    for (int k=i+1; k < a.GetLength(0); k++)
                    {
                        if (a[posMin, j] < a[k, j])
                            posMin = k;
                    }
                    if(posMin!=i)
                    {
                        aus = a[i, j];
                        a[i, j] = a[posMin, j];
                        a[posMin, j] = aus;
                        atl = atleti[i];
                        atleti[i] = atleti[posMin];
                        atleti[posMin] = atl;
                    }
                 
                }
                Console.Write("Classifica prova " + (j + 1) + "\n");
                stampaClassifica(atleti);
            }
        }
        private static void stampaClassifica(string[] atleti)
        {
            for (int i = 0; i < atleti.Length; i++)
            {
                Console.Write(atleti[i] + "\n");
            }
            Console.WriteLine();
        }
        private static void stampaMat(int[,] a,string[] v)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write(v[i]);
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("\t "+a[i, j]);
                }
                Console.WriteLine();
            }
        }
        private static void caricaMat(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(1, 10);
                }
            }
        }
    }
}
