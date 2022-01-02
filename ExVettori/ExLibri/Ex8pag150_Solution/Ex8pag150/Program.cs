using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8pag150
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] numeri = new int[100];
            int[] aus = new int[100];

            caricaVett(numeri);
            azzeraVett(aus);
            contaValori(numeri, aus);
            stampaNumeri(aus);

            Console.ReadKey();
        }
        private static void caricaVett(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 100);
            }
        }
        internal static void azzeraVett(int[] aus)
        {
            for (int i = 0; i < aus.Length; i++)
            {
                aus[i] = 0;
            }
        }
        internal static void contaValori(int[] numeri, int[] aus)
        {
            for (int i = 1; i < numeri.Length; i++)
            {
                aus[numeri[i]]++;
            }
        }
        internal static void stampaNumeri(int[] aus)
        {
            for (int i = 0; i < aus.Length; i++)
            {
                Console.Write("Lo " + i.ToString() + " é apparso:\t " + aus[i] + " volte" + "\n");
            }
        }
    }
}
