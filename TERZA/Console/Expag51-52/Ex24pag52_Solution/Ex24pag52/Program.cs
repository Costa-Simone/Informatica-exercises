using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24pag52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            do
            {
                Console.Write("Inserire n1: ");
                if (!int.TryParse(Console.ReadLine(), out n1))
                {
                    Console.WriteLine("Inserire numero intero");
                    n1 = -1;
                }
            } while (n1 < 0);

            do
            {
                Console.Write("Inserire n2: ");
                if (!int.TryParse(Console.ReadLine(), out n2))
                {
                    Console.WriteLine("Inserire numero intero");
                    n2 = -1;
                }
            } while (n2 < 0 || n2 < n1);

            for (int i = n1; i < n2; i++)
            {
                if (i%2==1)
                {
                    Console.Write(i.ToString().PadRight(10));
                }
            }

            Console.ReadKey();
        }
    }
}
