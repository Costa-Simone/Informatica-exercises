using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7pag115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] c1 = { "Barbero", "Grosso", "Migori", "Noto" };
            string[] n1 = { "Alberto", "Demis", "Andrea", "Serena" };
            string[] c2 = { "Arese", "Grosso", "Mondino", "Noto", "Pizzo", "Simon" };
            string[] n2 = { "Anna", "Denis", "Alberto", "Incavolata", "Edoardo", "Amos" };
            string[] c = new string[c1.Length + c2.Length];
            string[] n = new string[n1.Length + n2.Length];

            stampaTab(c1, n1, "Tabella 1");
            stampaTab(c2, n2, "\nTabella 2");

            Console.ReadKey();

            mergeBase(c1, n1, c2, n2, c, n);

            stampaTab(c, n, "\nTabella fusione merge base");

            Console.ReadKey();

            mergeTappo(c1, n1, c2, n2, c, n);

            stampaTab(c, n, "\nTabella fusione merge tappo");

            Console.ReadKey();
        }
        private static void mergeTappo(string[] c1, string[] n1, string[] c2, string[] n2, string[] c, string[] n)
        {
            string tappo = "Zzzzz";

            Array.Resize(ref c1, c1.Length + 1);
            Array.Resize(ref c2, c2.Length + 1);
            Array.Resize(ref n1, n1.Length + 1);
            Array.Resize(ref n2, n2.Length + 1);

            c1[c1.Length - 1] = tappo;
            c2[c2.Length - 1] = tappo;
            n1[n1.Length - 1] = tappo;
            n2[n2.Length - 1] = tappo;

            int i = 0, j = 0;
            string s1, s2;

            for (int k = 0; k <= (c1.Length + c2.Length) - 3; k++)
            {
                s1 = c1[i] + n1[i];
                s2 = c2[j] + n2[j];

                if (string.Compare(s1, s2) > 0)
                {
                    c[k] = c2[j];
                    n[k] = n2[j];
                    j++;
                }
                else
                {
                    c[k] = c1[i];
                    n[k] = n1[i];
                    i++;
                }
            }
        }
        private static void mergeBase(string[] c1, string[] n1, string[] c2, string[] n2, string[] c, string[] n)
        {
            int i = 0, j = 0, k = -1;
            string s1, s2;

            do
            {
                k++;
                s1 = c1[i] + n1[i];
                s2 = c2[j] + n2[j];

                if (string.Compare(s1, s2) > 0)
                {
                    c[k] = c2[j];
                    n[k] = n2[j];
                    j++;
                }
                else
                {
                    if (s1 == s2)
                    {
                        c[k] = c1[i];
                        n[k] = n1[i];
                        i++;
                        j++;
                    }
                    else
                    {
                        c[k] = c1[i];
                        n[k] = n1[i];
                        i++;
                    }
                }
            } while (i <= c1.Length - 1 && j <= c2.Length - 1);

            if (i > c1.Length - 1)
            {
                for (int h = j; h <= c2.Length - 1; h++)
                {
                    k++;
                    c[k] = c2[h];
                    n[k] = n2[h];
                }
            }
            else
            {
                for (int h = i; h <= c1.Length - 1; h++)
                {
                    k++;
                    c[k] = c1[h];
                    n[k] = n1[h];
                }
            }
        }
        private static void stampaTab(string[] c, string[] n, string titolo)
        {
            Console.WriteLine(titolo);
            Console.WriteLine();

            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i] + " " + n[i]);
            }
        }
    }
}
