using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n9pag150
{
    class Program
    {
        static Random rnd = new Random();
        static string[] squadre = { "squadra1", "squadra2", "squadra3", "squadra4", "squadra5", "squadra6", "squadra7", "squadra8", "squadra9", "squadra10",
                                "squadra11", "squadra12", "squadra13", "squadra14", "squadra15", "squadra16", "squadra17", "squadra18", "squadra19",
                                "squadra20", "squadra21", "squadra22", "squadra23", "squadra24", "squadra15", "squadra26" };
        static void Main(string[] args)
        {
            RandomizzaVett(squadre);
            Partite(squadre);

            Console.ReadKey();
        }
        private static void Partite(string[] squadre)
        {
            int ris;
            int j = squadre.Length-1;
            for (int i = 0; i < squadre.Length/2; i++)
            {
                ris = rnd.Next(1, 4);
                if (ris == 3)
                {
                    Console.WriteLine(squadre[i] + " Vs " + squadre[j] + "\t x");
                }
                else
                    Console.WriteLine(squadre[i] + " Vs " + squadre[j] + "\t " + ris);
                j--;
            }
        }
        private static void RandomizzaVett(string[] squadre)
        {
            int k;
            string aus = " ";
            for (int i = 0; i < squadre.Length; i++)
            {
                k = rnd.Next(0, squadre.Length);
                aus = squadre[i];
                squadre[i] = squadre[k];
                squadre[k] = aus;

            }
        }
    }
}
