using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14pag51
{
	class Program
	{
		static void Main(string[] args)
		{
			int g;

			double m, mp;

            do
            {
                Console.Write("Inserire l'ammontare della multa: ");
                m = Convert.ToDouble(Console.ReadLine());
            } while (m <= 0);

            do
            {
                Console.Write("Inserire il numero dei giorni: ");
                g = Convert.ToInt32(Console.ReadLine());
            } while (g <= 0);

            mp = m;

			if (g >= 14)
			{
				mp = (m * 0.3) + m;
			}
			else if (g >= 7)
			{
				mp = (m * 0.1) + m;
			}

			Console.WriteLine("L'ammontare finale della multa é " + mp.ToString() + " euro");
            
			Console.ReadKey();
		}
	}
}
