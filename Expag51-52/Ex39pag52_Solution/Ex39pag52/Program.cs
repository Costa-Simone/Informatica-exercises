using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex39pag52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nt, t=1;
            do
            {
                Console.Write("Inserire n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero");
                    n = -1;
                }
            } while (n <= 0);

            for (int i = 2; i <= n+1; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(t.ToString().PadRight(10));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(i.ToString().PadRight(10));
                t += i;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(t.ToString().PadRight(10));
            }

            Console.ReadKey();
        }
    }
}
