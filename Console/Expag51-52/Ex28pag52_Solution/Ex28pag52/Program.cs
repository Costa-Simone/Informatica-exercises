using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28pag52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nbin;
            double nf=0;

            do
            {
                Console.Write("Inserire numero di bit: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            Console.WriteLine("Inserire il numero binario: ");

            for (int i = n-1; i >= 0; i--)
            {
                do
                {
                    if (!int.TryParse(Console.ReadLine(), out nbin))
                    {
                        Console.WriteLine("Inserire 0 o 1: ");
                        nbin = -1;
                    }
                } while (nbin < 0 || nbin > 1);

                if (nbin==1)
                {
                    nf += Math.Pow(Convert.ToDouble(2), Convert.ToDouble(i));
                }
            }
            Console.WriteLine("Il numero decimale é " + nf.ToString());

            Console.ReadKey();
        }
    }
}
