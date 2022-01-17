using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9pag150
{
    class Program
    {
        static string[] squadre = { "s1", "s2", "s3", "s4", "s5", "s6", "s7", "s8", "s9", "s10", "s11", "s12", "s13", "s14", "s15", "s16", "s17", "s18", "s19", "s20", "s21", 
                                    "s22", "s23", "s24", "s25", "s26" };
        static string[] risultato = new string[13];
        static string[] squadCasa = new string[13];
        static string[] squadFuori = new string[13];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            ClsSquadre.creaSchedina(squadre, risultato, squadCasa, squadFuori);
            ClsSquadre.Scommesse(squadre, risultato, squadCasa, squadFuori);
            ClsSquadre.puntiCampionato(squadre, risultato, squadCasa, squadFuori);

            Console.ReadKey();
        }
    }
}
