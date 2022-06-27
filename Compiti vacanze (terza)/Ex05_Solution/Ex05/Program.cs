using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Convertire un numero binario in decimale

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 0;

            Console.Write("Inserisci il numero binario su 8 bit: ");

            string s = Console.ReadLine();

            for (int i = 0; i < 8; i++)
            {
                if (s[i] == '1')
                {
                    n += Math.Pow(2, i);
                }
            }

            Console.WriteLine("Il numero binario convertito e' " + n);

            Console.ReadKey();
        }
    }
}
