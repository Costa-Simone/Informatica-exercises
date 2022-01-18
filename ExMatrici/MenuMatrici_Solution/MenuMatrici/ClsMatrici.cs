using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMatrici
{
    class ClsMatrici
    {
        static Random rnd = new Random();
        internal static void caricaMat(int[,] a, int r, int c)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    a[i, j] = rnd.Next(10, 100);
                }
            }
        }
        internal static int cercaMaxMat(int[,] a, int r, int c)
        {
            int max = int.MinValue;

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }

            return max;
        }
        internal static float mediaDPMat(int[,] a, int r)
        {
            int somma = 0;

            for (int i = 0; i < r; i++)
            {
                somma += a[i, i];
            }

            return (float) somma / r;
        }
        internal static float mediaDSMat(int[,] a, int r)
        {
            int somma = 0;

            for (int i = 0, j = r - 1; i < r; i++)
            {
                somma += a[i, j--];
            }

            return (float)somma / r;
        }
        internal static void stampaMat(int[,] a, int r, int c)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(a[i, j].ToString() + "  ");
                }


               Console.WriteLine();
            }
            
        }
        internal static float mediaCornice(int[,] a, int r, int c)
        {
            int somma = 0;

            for (int i = 0; i < r; i++)
            {
                somma += a[i, 0] + a[i, c - 1];
            }

            for (int j = 1; j < c - 1; j++)
            {
                somma += a[0, j] + a[r - 1, j];
            }

            return (float) somma / (r * 2 + c * 2 - 4);
        }
    }
}
