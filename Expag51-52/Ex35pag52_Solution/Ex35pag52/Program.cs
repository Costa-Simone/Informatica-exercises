using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35pag52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, somma1, somma2;
            
            do
            {
                Console.Write("Inserire n1: ");
                if (!int.TryParse(Console.ReadLine(), out n1))
                {
                    Console.WriteLine("Devi inserire un numero positivo");
                }
            } while (n1 <= 0);

            do
            {
                Console.Write("Inserire n2: ");
                if (!int.TryParse(Console.ReadLine(), out n2))
                {
                    Console.WriteLine("Devi inserire un numero positivo");
                }
            } while (n2 <= 0);

            somma1 = 1;

            for (int i = 2; i <= n1 / 2; i++)
            {
                if (n1 % i == 0)
                {
                    somma1 += i;
                }
            }
            
            somma2 = 1;

            for (int i = 2; i <= n2 / 2; i++)
            {
                if (n2 % i == 0)
                {
                    somma2 += i;
                }
            }

            if (somma1 == n2 && somma2 == n1)
            {
                Console.WriteLine("I numeri sono amichevoli");
            }
            else
            {
                Console.WriteLine("I numeri non sono ammichevoli");
            }

            Console.ReadKey();
        }
    }
}
