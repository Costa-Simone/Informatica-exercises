using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30pag52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, somma = 0;

            Random rnd = new Random();

            do
            {
                n = rnd.Next(1, 100);
                Console.WriteLine(n.ToString());
                for (int i = 1; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        somma += i;
                    }
                }
            } while (somma!=n);

            Console.WriteLine(somma.ToString()   + " è un numero perfetto");

            Console.ReadKey();
        }
    }
}
