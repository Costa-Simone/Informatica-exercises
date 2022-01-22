using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuLancioMatrici
{
    class ClsMatrici
    {
        internal static void caricaMat(int[,] m, int r, int c)
        {
            Random rnd = new Random();
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    m[i, j] = rnd.Next(10, 100);
                }
            }
        }
        internal static int cercaMaxMat(int[,] m, int r, int c)
        {
            int max = int.MinValue;

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (m[i, j] > max)
                    {
                        max = m[i, j];
                    }
                }
            }
            //Console.WriteLine("Il numero più grande è: " + max);
            return max;
        }
        internal static float mediaDPMat(int[,] m, int r)
        {
            int som = 0;
            for (int i = 0; i < r; i++)
            {
                som += m[i, i]; //nota bene
            }

            return (float)som / r;
        }
        internal static float mediaDSMat(int[,] m, int r)
        {
            int som = 0;
            int j = r - 1;
            for (int i = 0; i < r; i++)
            {
                som += m[i, j--]; //nota bene
            }
                
            return (float)som / r;
        }
        internal static void stampaMat(int[,] m, int r, int c)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(m[i, j].ToString() + "  ");
                }
                    
                Console.WriteLine();
            }
        }
        internal static float mediaCornMat(int[,] m, int r, int c)
        {
            int som = 0;
            for (int i = 0; i < r; i++)
            {
                som += m[i, 0] + m[i, c - 1]; //nota bene
            }

            for (int j = 1; j < c-1; j++)
            {
                som += m[0, j] + m[r - 1, j]; //nota bene
            }

            return (float)som / (r*2+ c*2 -4);
        }
        internal static int sommaRigaIesimaMat(int[,] m, int c)
        {
            int som = 0;

            Console.Write("Inserisci il numero della riga: ");
            int i = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < c; j++)
            {
                som += m[i, j];
            }
                
            return som;
        }
        internal static int sommaColJesimaMat(int[,] m, int r)
        {
            int som = 0;

            Console.Write("Inserisci il numero della colonna: ");
            int i = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < r; j++)
            {
                som += m[i, j];
            }
                
            return som;
        }
        internal static int ContaXMat(int[,] m, int r, int c)
        {
            int cont = 0;

            Console.Write("Inserisci x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (m[i, j] == x)
                    {
                        cont++;
                    }
                }  
            }

            return cont;
        }
        internal static int sommaDPMat(int[,] m, int r)
        {
            int somma = 0;

            for (int i = 0; i < r; i++)
            {
                somma+=m[i, i];
            }

            return somma;
        }
        internal static int sommaDSMat(int[,] m, int r)
        {
            int somma = 0;
            int j = r - 1;

            for (int i = 0; i < r; i++)
            {
                somma += m[i, j--];
            }

            return somma;
        }
        internal static bool elementiUguali(int[,] a, int r, int c)
        {
            bool esci = false;
            int x = a[0, 0], i = 0, j = 0;

            while (!esci && i != r)
            {
                if (a[i, j] == x)
                {
                    if (j == c - 1)
                    {
                        i++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
                else
                {
                    esci = true;
                }
            }

            return !esci;
        }
        internal static bool elementiOrdinati(int[,] a, int r, int c)
        {
            bool esci = false;
            int prec = a[0, 0], i = 0, j = 1;

            while (!esci && i != r)
            {
                if (a[i, j] >= prec)
                {
                    prec = a[i, j];

                    if (j == c - 1)
                    {
                        i++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
                else
                {
                    esci = true;
                }
            }

            return !esci;
        }
        internal static bool unitariaMat(int[,] a, int r, int c)
        {
            int i = 0, j = 0;
            bool esci = false;

            while (!esci && i != r)
            {
                if (i == j)
                {
                    if (a[i, j] == 1)
                    {
                        if (j == r - 1)
                        {
                            i++;
                            j = 0;
                        }
                        else
                        {
                            j++;
                        }
                    }
                    else
                    {
                        esci = true;
                    }
                }
                else
                {
                    if (a[i, j] == 0)
                    {
                        if (j == r - 1)
                        {
                            i++;
                            j = 0;
                        }
                        else
                        {
                            j++;
                        }
                    }
                    else
                    {
                        esci = true;
                    }
                }
            }

            return !esci;
        }
        internal static bool croceCentraleMat(int[,] a, int r, int c)
        {
            int i = 0, j = 0;
            bool esci = false;

            while (!esci && i != r)
            {
                if (i == r / 2 || j ==  r/ 2)
                {
                    if (a[i, j] == 1)
                    {
                        if (j == r - 1)
                        {
                            i++;
                            j = 0;
                        }
                        else
                        {
                            j++;
                        }
                    }
                    else
                    {
                        esci = true;
                    }
                }
                else
                {
                    if (a[i, j] == 0)
                    {
                        if (j == r - 1)
                        {
                            i++;
                            j = 0;
                        }
                        else
                        {
                            j++;
                        }
                    }
                    else
                    {
                        esci = true;
                    }
                }
            }

            return !esci;
        }
        internal static bool elementiUguali2Mat(int[,] a, int[,] b, int r, int c)
        {
            bool esci = false;
            int i = 0, j = 0;

            while (!esci && i != r)
            {
                if (a[i, j] == b[i, j])
                {
                    if (j == c - 1)
                    {
                        i++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
                else
                {
                    esci = true;
                }
            }

            return !esci;
        }
    }
}
