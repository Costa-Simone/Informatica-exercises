using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data una matrice quadrata dire se è simmetrica (A[i,j]=A[j,i] con i<>j)

namespace Ex16
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[,] m = new int[4, 4];
            int k, h;
            bool esci = false;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = rnd.Next(0, 11);
                }
            }

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j].ToString() + "  ");
                }

                Console.WriteLine();
            }

            k = 0;
            h = 1;

            while (!esci && k != m.GetLength(0) - 1)
            {
                if (h == m.GetLength(0))
                {
                    h = k + 1;
                }

                if (m[k, h] != m[h, k])
                {
                    esci = true;
                }

                k++;
                h++;
            }

            if (!esci)
            {
                Console.WriteLine("\nLa matrice e' simmetrica");
            }
            else
            {
                Console.WriteLine("\nLa matrice non e' simmetrica");
            }

            Console.ReadKey();
        }
    }
}
