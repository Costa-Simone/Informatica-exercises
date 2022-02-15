using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1pag150
{
    class ClsEsercizio
    {
        static Random rnd = new Random();
        internal static void creaGruppi(string[] cognomi)
        {
            int x;
            do
            {
                Console.Write("Inserisci il valore di x: ");
                x = Convert.ToInt32(Console.ReadLine());
            } while (x < 3 || x > 5);

            //for (int i = 1; i <= cognomi.Length; i++)
            //{
            //    int r;
            //    do
            //    {
            //        r = rnd.Next(0, cognomi.Length);
            //    } while (cognomi[r] == "ZZ");

            //    Console.Write(cognomi[r] + " ");
            //    cognomi[r] = "ZZ";

            //    if (i % x == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}
            RandomVett(cognomi);

            int turno = 1, cont = -1;

            Console.WriteLine("1^ turno");

            for (int i = 0; i < cognomi.Length; i++)
            {
                cont++;

                if (cont == x)
                {
                    turno++;
                    cont = 0;

                    Console.WriteLine("\n" + turno + "^ turno");
                }

                Console.Write(cognomi[i] + "\t");
            }
        }

        private static void RandomVett(string[] cognomi)
        {
            for (int i = 0; i < cognomi.Length; i++)
            {
                int k;
                string aus;

                k = rnd.Next(0, cognomi.Length);
                aus = cognomi[i];
                cognomi[i] = cognomi[k];
                cognomi[k] = aus;
            }
        }
    }
}
