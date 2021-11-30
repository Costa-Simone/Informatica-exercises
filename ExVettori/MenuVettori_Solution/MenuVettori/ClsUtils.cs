using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuVettori
{
    class ClsUtils
    {
        /// <summary>
        /// Mette in pausa il programma e attende la pressione di un tasto
        /// </summary>
        public static void attesaTasto()
        {
            Console.WriteLine("\n\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
        /// <summary>
        /// Consente di introdurre un numero controllandone la validità, ovvero che sia effettivamente un numero e che sia maggiore di 0
        /// </summary>
        /// <param name="messaggio"> Il messaggio per l'utente </param>
        /// <returns> Un valore intero valido (numero maggiore di 0) </returns>
        public static int inputDimensione(string messaggio)
        {
            int n;

            do
            {
                Console.Write(messaggio);
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire numero intero: ");
                    n = -1;
                }
            } while (n <= 0);

            return n;
        }
    }
}
