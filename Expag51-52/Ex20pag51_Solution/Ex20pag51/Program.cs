using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20pag51
{
    class Program
    {
        static void Main(string[] args)
        {
            int g;
            double m;

            do
            {
                Console.Write("Inserisci il numero di giorni: ");
                string stInput = Console.ReadLine();
                if(!int.TryParse(stInput, out g))
                {
                    Console.WriteLine("Devi inserire numero intero");
                    g = -1;
                }
            } while (g <= 0);

            if(g > 15)
            {
                m = (g - 15) * 0.20;
                Console.WriteLine("La multa é di " + m.ToString("0.00") + " euro");
            }
            else
            {
                Console.WriteLine("Non c'é nessuna multa");
            }

            Console.ReadKey();
        }
    }
}
