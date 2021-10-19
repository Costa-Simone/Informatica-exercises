using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21pag52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max = 0;

            Random rnd = new Random();

            do
            {
                Console.Write("Inserire il numero di valori: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Devi inserire un numero positivo");
                }
            } while (n <= 0);

            for(int i=0; i<n; i++)
            {
                int v = rnd.Next(1, 1001);
                if (v > max)
                {
                    max = v;
                }
            }

            Console.WriteLine("Il valore piú grande é " + max.ToString());

            Console.ReadKey();
        }
    }
}
