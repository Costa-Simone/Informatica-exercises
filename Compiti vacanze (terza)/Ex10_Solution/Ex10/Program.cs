using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dati due vettori di uguale dimensione dire se sono uguali (se contengono gli stessi elementi in posizione uguale)

namespace Ex10
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = rnd.Next(3, 11), j = 0;
            int[] v = new int[n];
            int[] v2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(0, 11);
                v2[i] = rnd.Next(0, 11);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + "  ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write(v2[i] + "  ");
            }

            while (j < n && v[j] == v2[j])
            {
                j++;
            }

            if (j != n)
            {
                Console.WriteLine("\n\nI vettori non sono uguali");
            }
            else
            {
                Console.WriteLine("\n\nI vettori sono uguali");
            }

            Console.ReadKey();
        }
    }
}
