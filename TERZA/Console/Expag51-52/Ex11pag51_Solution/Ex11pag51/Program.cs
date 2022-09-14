using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11pag51
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, u, d, c, m, aus;

            do
            {
                Console.Write("Inserire un numero tra 1 e 9999: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n<1 || n>9999);

            m = n / 1000;
            aus = n % 1000;
            c = aus / 100;
            aus = aus % 100;
            d = aus / 10;
            aus = aus % 10;
            u = aus / 1;

            Console.WriteLine("Le unità sono " + u.ToString());
            Console.WriteLine("Le decine sono " + d.ToString());
            Console.WriteLine("Le centinaia sono " + c.ToString());
            Console.WriteLine("Le migliaia sono " + m.ToString());

            Console.ReadKey();
        }
    }
}
