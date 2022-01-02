using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1pag150
{
    class Program
    {
        static string[] cognomi = { "c1", "c2", "c3", "c4", "c5", "c6", "c7", "c8", "c9", "c10" };
        static void Main(string[] args)
        {
            ClsEsercizio.creaGruppi(cognomi);

            Console.ReadKey();
        }
    }
}
