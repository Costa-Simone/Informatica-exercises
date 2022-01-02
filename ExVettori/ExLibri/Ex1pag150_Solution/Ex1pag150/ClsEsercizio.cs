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

            int cont = 1;

            for (int i = 0; i <= (cognomi.Length / x); i++)
            {
                Console.WriteLine("\nIl " + cont.ToString() + "^ gruppo é:\n");

                for (int j = 0; j < x; j++)
                {
                    int random, aus = 1;

                    do
                    {
                        aus++;
                        random = rnd.Next(0, cognomi.Length);
                    } while (cognomi[random] == "ZZ" && aus != cognomi.Length);

                    if (cognomi[random] != "ZZ")
                    {
                        Console.Write(cognomi[random] + "\t");
                        cognomi[random] = "ZZ";
                    }
                }

                cont++;
            }
        }
    }
}
