using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32pag52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            bool esci;

            do
            {
                Console.Write("Inserire n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            if(n % 2 == 0)
            {
                Console.WriteLine("No primo");
            }
            else
            {
                i = 3;
                esci = false;

                do
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("No primo");
                        esci = true;
                    }
                    else
                    {
                        i++;
                    }

                } while (!esci && i != n/2);

                if (!esci)
                {
                    Console.WriteLine("é primo");
                }

            }

            Console.ReadKey();
        }
    }
}
