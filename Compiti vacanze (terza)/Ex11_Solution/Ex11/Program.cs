using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data una successione di caratteri dire se è in ordine alfabetico crescente o no (es. a,h,t è in ordine, mentre s, g, h, l no)

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci i caratteri suddivisi da ,: ");

            int pos = 1;
            string s = Console.ReadLine();
            string[] v = s.Split(',');

            while (pos < v.Length && string.Compare(v[pos], v[pos - 1]) > 0)
            {
                pos++;
            }

            if (pos != v.Length)
            {
                Console.WriteLine("\n\nI caratteri non sono in ordine alfabetico");
            }
            else
            {
                Console.WriteLine("\n\nI caratteri sono in ordine alfabetico");
            }

            Console.ReadKey();
        }
    }
}
