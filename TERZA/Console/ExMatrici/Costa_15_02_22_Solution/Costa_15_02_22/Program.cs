using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costa_15_02_22
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.Write("Inserire il valore di r: ");
            int r = Convert.ToInt32(Console.ReadLine());

            int[,] m = new int[r, r];
            int[,] m2 = new int[r, r];

            caricaMat(m);
            stampaMat(m);

            if (diagonaleDominante(m) == true)
            {
                Console.WriteLine("\nLa matrice è con la diagonale dominante");
            }
            else
            {
                Console.WriteLine("\nLa matrice non è con la diagonale dominante");
            }

            Console.WriteLine("\n-------------------------------------------------------------------");

            Console.Write("\nInserisci numero di valori che vuoi inserire nella matrice di Fibonacci: ");
            int x = Convert.ToInt32(Console.ReadLine());

            caricaSopraDPFibonacci(m2, x);
            stampaMat(m2);

            Console.ReadKey();
        }
        private static void caricaSopraDPFibonacci(int[,] m, int x)
        {
            int i = 0, j = i + 1, aus = 0, aus2 = 1;

            for (int k = 0; k < x; k++)
            {
                if (k == 0)
                {
                    m[i, j] = aus;
                }
                else if (k == 1)
                {
                    m[i, j] = aus2;
                }
                else
                {
                    m[i, j] = aus + aus2;
                    aus = aus2;
                    aus2 = m[i, j];
                }

                if (j == m.GetLength(1) - 1)
                {
                    i++;
                    j = i + 1;
                }
                else
                {
                    j++;
                }
            }
        }
        private static void stampaMat(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j].ToString() + "\t");

                    if (j == m.GetLength(1) - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
        private static bool diagonaleDominante(int[,] m)
        {
            int i = 0, j = 0;
            bool esci = false;

            while (!esci && i < m.GetLength(0))
            {
                if (m[i, i] < sommaRiga(m, i))
                {
                    esci = true;
                }

                i++;
            }

            return !esci;
        }
        private static void caricaMat(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = rnd.Next(1, 11);
                }
            }
        }
        private static int sommaRiga(int[,] m, int i)
        {
            int somma = 0;

            for (int j = 0; j < m.GetLength(0); j++)
            {
                if (m[i, j] != m[i, i])
                {
                    somma += m[i, j];
                }
            }

            return somma;
        }
    }
}
 