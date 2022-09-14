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
            int n;

            Console.Write("Inserisci il valore di n: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] numeri = new int[n];
            int[] aus = new int[100];

            caricaVett(numeri);
            contaValori(numeri, aus);
            stampaNumeri(aus);

            Console.ReadKey();
        }
        private static void caricaVett(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, 100);
            }
        }
        internal static void contaValori(int[] numeri, int[] aus)
        {
            for (int i = 0; i < numeri.Length; i++)
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
