using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15pag51
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, pf;

            do
            {
                Console.Write("Inserire il prezzo del prodotto: ");
                p = Convert.ToDouble(Console.ReadLine());
            } while (p <= 0);

            if (p >= 300)
            {
                pf = p - (p * 0.2);
            }
            else if(p>=100 && p<300)
            {
                pf = p - (p * 0.1);
            }
            else
            {
                pf = p - (p * 0.05);
            }

            Console.WriteLine("Il prezzo finale é " + pf.ToString() + " euro");

            Console.ReadKey();
        }
    }
}
