using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data una matrice di interi M*N ad elementi disgiunti, cercare il massimo e il minimo assoluto

namespace Ex14
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = rnd.Next(2, 6), m = rnd.Next(2, 6), k = 0, min = 101, max = -1;
            int[] aus = new int[n * m];
            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int v;

                    do
                    {
                        v = rnd.Next(0, 101);
                    } while (Array.IndexOf(aus, v) != -1);

                    aus[k++] = v;
                    mat[i, j] = v;
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < min)
                    {
                        min = mat[i, j];
                    }
                    if (mat[i, j] > max)
                    {
                        max = mat[i, j];
                    }
                }
            }

            Console.WriteLine("\n\nIl minimo vale " + min + " mentre in massimo vale " + max);

            Console.ReadKey();
        }
    }
}
