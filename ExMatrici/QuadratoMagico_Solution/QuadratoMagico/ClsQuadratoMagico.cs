using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadratoMagico
{
    class ClsQuadratoMagico
    {
        static Random rnd = new Random();
        internal static void caricaMat(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = 5;
                }
            }
        }
        internal static bool verificaQuadratoMagico(int[,] q)
        {
            int somma = 0;
            bool esci = false;

            somma = ClsQuadratoMagico.sommaDPMat(q);

            if (ClsQuadratoMagico.sommaDSMat(q) != somma)
            {
                esci = true;
            }
            else
            {
                int i = 0, j = 0;

                do
                {
                    if (ClsQuadratoMagico.sommaRigaIesimaMat(q, i) != somma || ClsQuadratoMagico.sommaColJesimaMat(q, j) != somma)
                    {
                        esci = true;
                    }
                    else
                    {
                        i++;
                        j++;
                    }

                } while (!esci && i < q.GetLength(0) && j < q.GetLength(1));
            }

            return !esci;
        }
        internal static void stampaMat(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j].ToString() + "  ");
                }

                Console.WriteLine();
            }
        }
        internal static int sommaDPMat(int[,] m)
        {
            int somma = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                somma += m[i, i];
            }

            return somma;
        }
        internal static int sommaDSMat(int[,] m)
        {
            int somma = 0;
            int j = m.GetLength(0) - 1;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                somma += m[i, j--];
            }

            return somma;
        }
        internal static int sommaRigaIesimaMat(int[,] m, int i)
        {
            int som = 0;

            for (int j = 0; j < m.GetLength(1); j++)
            {
                som += m[i, j];
            }

            return som;
        }
        internal static int sommaColJesimaMat(int[,] m, int j)
        {
            int som = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                som += m[i, j];
            }

            return som;
        }
    }
}
