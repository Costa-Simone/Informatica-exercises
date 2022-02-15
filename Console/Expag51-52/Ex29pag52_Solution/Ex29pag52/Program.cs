using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex29pag52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("Inserire n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero");
                    n = -1;
                }
            } while (n < 0);

            Console.Write("I fattori sono: ");

            Console.Write(1.ToString() + " ");

            for (int i = 2; i <= n/2; i++)
            {
                if (n%i==0)
                {
                    Console.Write(i.ToString() + " ");
                }
            }

            Console.WriteLine(n.ToString());

            Console.ReadKey();
        }
    }
}
