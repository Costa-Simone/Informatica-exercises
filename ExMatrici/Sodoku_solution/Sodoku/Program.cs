using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodoku
{
    internal class Program
    {
        const int r = 4;
        static int[,] s = new int[r, r] { { 4, 0, 2, 0 }, { 0, 2, 4, 3 }, { 2, 1, 3, 0 }, { 0, 4, 0, 2 } };
        static void Main(string[] args)
        {
            stampaMat(s, r);
            do
            {

                ///INSERISCO UN NUOVO NUMERO 
                inserisciNumero(s, r);
                stampaMat(s,r);
            } while (!finito(s));
            
            Console.WriteLine("HO FINITO");
            Console.ReadKey();
                
        }

        private static void inserisciNumero(int[,] s, int r)
        {
            int i = 0, j = 0;
            bool esci = false;
            

            while(!esci)
            {
                if(s[i,j]==0)
                //elaboro cella vuota e verifico se posso inserire un numero 
                {
                    
                    if(contaVuoteRiga(s, r, i) == 1)
                    {
                        
                        s[i, j] = cercaNumeroRiga(s, r, i);
                        esci = true;
                    }
                    else
                    {
                        if(contaVuoteColonna(s, r, j) == 1)
                        {
                            //metti numero
                            
                            s[i, j] = cercaNumeroColonna(s, r, j);
                            esci = true;
                        }
                        else
                        {
                            if (contaVuoteQuadrato(s, r, j, i) == 1)
                            {
                                //metti numero
                                s[i, j] = cercaNumeroQuadrato(s, r, j, i);
                                esci = true;
                            }
                            //else if (contaVuoteQuadrato(s, r, j, i) == 0)
                            //    esci = true;
                        }
                    }
                }
                if(!esci)
                {
                    if (j == r - 1)
                    {
                        i++;
                        j = 0;
                    }
                    else
                        j++;
                }
                if (i == r )
                    esci = true;
            }
        }

        private static int cercaNumeroQuadrato(int[,] s, int r, int j, int i)
        {
            int cont = 1;
            bool trovato = false;


            if (i >= 2)
                i = 2;
            else
                i = 0;
            if (j >= 2)
                j = 2;
            else
                j = 0;
            do
            {
                int h = i, k =j ;
                while (h != i + 2 && s[h, k] != cont)
                {
                    if (k == j + 2)
                    {
                        h++;
                        k = j;
                    }
                    else
                        k++;
                }
                if(h==i+2)
                    trovato = true;
                else
                    cont++;
            } while (!trovato);
            return cont;
            
        }

        private static int cercaNumeroColonna(int[,] s, int r, int j)
        {
            int cont = 1;
            bool trovato = false;
            do
            {
                
                int i = 0;
                while(i<r && s[i, j] != cont)
                {
                    i++;
                }
                if(i==r)
                    trovato=true;
                else
                    cont++;
            } while (!trovato);
            return cont;
        }

        private static int cercaNumeroRiga(int[,] s, int r, int i)
        {

            int cont = 1;
            bool trovato = false;
            do
            {
                int j = 0;
                while (j < r && s[i, j] != cont)
                {
                    j++;
                }
                if (j == r)
                    trovato = true;
                else
                    cont++;
            } while (!trovato);
            return cont;
           
        }

       

        private static int contaVuoteQuadrato(int[,] s, int r, int j, int i)
        {
            int cont = 0;
            int radice1, radice2,potenza;
            potenza = r * r;
            radice1 = (int)Math.Sqrt(potenza);
            
            if((radice1*radice1)==potenza)
            {
                i = i - (i % radice1);
                j= j - (j % radice1);
            }
            //else
            //{
            //    j = j - (j)
            //}

            //if (i >= 2)
            //    i = 2;
            //else
            //    i = 0;
            //if (j >= 2)
            //    j = 2;
            //else
            //    j = 0;
            for (int h = i; h < i+2; h++)
            {
                for (int k = j; k < j+2; k++)
                {
                    if (s[h, k] == 0)
                        cont++;
                }
            }
            return cont;
        }

        private static int contaVuoteColonna(int[,] s, int r, int j)
        {
            int cont=0;
            for (int i = 0; i < r; i++)
            {
                if (s[i, j] == 0)
                    cont++;
            }
            return cont;
        }

        private static int contaVuoteRiga(int[,] s, int r, int i)
        {
            int cont = 0;
            for (int j = 0; j < r; j++)
            {
                if (s[i, j] == 0)
                    cont++;
            }
            return cont;
        }

        private static void stampaMat(int[,] s, int r)
        {
            Console.Clear();
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                    Console.Write(s[i, j].ToString() + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static bool finito(int[,] s)
        {
            int i = 0;
            int j = 0;
            bool esci = false;

            while(!esci && i<r)
            {
                if (s[i, j] != 0)
                {
                    if (j == r - 1)
                    {
                        i++;
                        j = 0;
                    }
                    else
                        j++;
                }
                else
                    esci = true;
            }
            return !esci;
        }
    }
}
