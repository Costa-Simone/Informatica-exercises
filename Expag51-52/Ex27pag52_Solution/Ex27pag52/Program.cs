using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex27pag52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string output = "";

            do
            {
                Console.Write("Inserire il numero: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Devi inserire numero intero");
                    n = -1;
                }
            } while (n < 0);

            Console.WriteLine("Il numero binario è: ");

            do
            {
                int bin = n % 2;
                output = bin.ToString() + output;
                n = n / 2;
            } while (n != 0);

            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
