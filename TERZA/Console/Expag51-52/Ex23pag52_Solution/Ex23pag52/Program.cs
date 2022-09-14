using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23pag52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Inserire il valore di n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Devi inserire valore intero");
                    n = -1;
                }
            } while (n <= 0);

            for(int i = 1; i <= n; i ++)
            {
                if(i%2==0)
                {
                    Console.Write(i.ToString().PadRight(10));
                }
            }

            Console.ReadKey();
        }
    }
}
