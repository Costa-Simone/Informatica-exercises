using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadratoMagico
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] q = new int[4, 4];

            ClsQuadratoMagico.caricaMat(q);

            Console.WriteLine("Stampa della matrice:\n");
            ClsQuadratoMagico.stampaMat(q);
            if (ClsQuadratoMagico.verificaQuadratoMagico(q))
            {
                Console.WriteLine("\nE' un quadrato magico");
            }
            else
            {
                Console.WriteLine("\nNon e' un quadrato magico");
            }

            Console.ReadKey();
        }
    }
}
