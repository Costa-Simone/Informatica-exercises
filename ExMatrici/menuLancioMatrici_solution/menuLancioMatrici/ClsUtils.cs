using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuLancioMatrici
{
    class ClsUtils
    {
        /// <summary>
        /// Mette in pausa il programma e attende la pressione di un tasto qualunque per continuare
        /// </summary>
        public static void attesaTasto()
        {
            Console.WriteLine("");
            Console.WriteLine("\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        /// <summary>
        /// Consente di introdurre un numero controllandone la validità, ovvero che sia un numero e che sia > 0
        /// </summary>
        /// <param name="messagge">Il messaggio per l'utente</param>
        /// <returns>restituisce un valore</returns>
        public static int inputDimensione(string messagge)
        {
            int n;
            do
            {
                Console.Write(messagge);
                if (!int.TryParse(Console.ReadLine(), out n))
                    Console.Write("N>0");
            } while (n <= 0);

            return n;
        }
    }
}
