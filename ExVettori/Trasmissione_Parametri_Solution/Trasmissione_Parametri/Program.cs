using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trasmissione_Parametri
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 45, b = 88;

            Console.WriteLine("Prima del richiamo scambio_val. a=" + a + " b=" + b);
            scambio_val(a, b);
            Console.WriteLine("Dopo del richiamo scambio_val. a=" + a + " b=" + b);

            Console.WriteLine("\n\nPrima del richiamo scambio_ref. a=" + a + " b=" + b);
            scambio_ref(ref a, ref b);
            Console.WriteLine("Dopo del richiamo scambio_ref. a=" + a + " b=" + b);

            Console.ReadKey();
        }
        private static void scambio_val(int x, int y)
        {
            //i PF x e y, cosi come aus, sono tutti variabili locali
            int aus;

            aus = x;
            x = y;
            y = aus;
        }
        private static void scambio_ref(ref int x, ref int y)
        {
            //i PF x e y, cosi come aus, sono tutti variabili locali
            int aus;

            aus = x;
            x = y;
            y = aus;
        }
    }
}
