using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31pag52
{
    class Program
    {
        static void Main(string[] args)
        {
            int somma;

            Console.WriteLine("I numeri perfetti sono:");

            for (int n = 6; n <= 10000; n++)
            {
                somma = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        somma += i;
                    }
                }

                if (somma == n)
                {
                    Console.Write(n.ToString() + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
