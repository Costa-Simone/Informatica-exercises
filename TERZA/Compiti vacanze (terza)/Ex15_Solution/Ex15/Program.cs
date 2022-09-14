using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Data una matrice quadrata dire se è unitaria (è composta da tutti 0, tranne per la diagonale principale che è di tutti 1) (usare una funzione che restituisce un boolean)

namespace Ex15
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = rnd.Next(2, 6);
            int[,] m = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    m[i, j] = rnd.Next(0, 2);

                    Console.Write(m[i, j] + " ");
                }

                Console.WriteLine();
            }

            if (controllaMatriceUnitaria(m))
            {
                Console.WriteLine("\n\nLa matrica e' unitaria");
            }
            else
            {
                Console.WriteLine("\n\nLa matrica non e' unitaria");
            }

            Console.ReadKey();
        }

        private static bool controllaMatriceUnitaria(int[,] m)
        {
            bool unitaria = true;
            int i = 0, j = 0;

            while ((i < m.GetLength(0) && j < m.GetLength(0)) && unitaria)
            {
                if (j == m.GetLength(0))
                {
                    i++;
                    j = 0;
                }

                if (i != j)
                {
                    if (m[i, j] == 1)
                    {
                        unitaria = false;
                    }
                }
                else
                {
                    if (m[i, j] == 0)
                    {
                        unitaria = false;
                    }
                }

                j++;
            }

            return unitaria;
        }
    }
}
