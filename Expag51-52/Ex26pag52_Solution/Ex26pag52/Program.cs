using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26pag52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nf=1;

            do
            {
                Console.Write("Inserire n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero");
                    n = -1;
                }
            } while (n <= 0);

            Console.Write("Il fattoriale di " + n.ToString() + " è ");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i.ToString());
                if (i!=n)
                {
                    Console.Write("*");
                }
                nf = nf * i;
            }

            Console.Write("=" + nf.ToString());

            Console.ReadKey();
        }
    }
}
