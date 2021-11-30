using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n5_5_pag116
{
    class Program
    {
        static string[] cognomi = { "Bogetti", "Noto", "Grosso",
                "Piere", "Cairo", "Migori",
                "Arese", "Cerrato", "Berte", "Simon" };
        static string[] nomi = { "Leo", "Serena", "Denis",
                "Franci", "Pietro", "Andrea",
                "Anna", "Diego", "Tommaso", "Amos" };
        static string[] squadre = { "Milan", "Milan", "Milan",
                 "Juve", "Milan", "Juve",
                 "Juve", "Juve", "Milan", "Milan" };

        static string[] cognomiCopia = new string[cognomi.Length];
        static string[] nomiCopia = new string[cognomi.Length];

        static string[] squadreOrdinate = new string[squadre.Length];

        static void Main(string[] args)
        {
            ClsEsercizio.stampaTab(cognomi, nomi, squadre);

            Console.Write("Inserisci la squadra da cercare: ");
            string sq = Console.ReadLine();

            int numeroTrovati = ClsEsercizio.cercaSquadra(cognomi, nomi, squadre, cognomiCopia, nomiCopia, sq);
            if (numeroTrovati == 0)
            {
                Console.WriteLine("Non ci sono giocatori della squadra cercata");
            }
            else
            {
                ClsEsercizio.ordinaSquadra(cognomiCopia, nomiCopia, numeroTrovati);
                // overload del metodo
                ClsEsercizio.stampaTab(cognomiCopia, nomiCopia, numeroTrovati);
            }

            Console.ReadKey();
            ClsEsercizio.ordinaSquadra(squadre);
            string[] squadreNonDuplicate = new string[squadre.Length];
            int[] numGiocatoriSquadra = new int[squadre.Length];
            int numSquadre = ClsEsercizio.rotturaSuSquadra(squadre, squadreNonDuplicate, numGiocatoriSquadra);

            ClsEsercizio.stampaTab(squadreNonDuplicate, numGiocatoriSquadra, numSquadre);

            Console.ReadKey();
        }
    }
}
