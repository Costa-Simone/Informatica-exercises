using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24pag116
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animali = { "cane", "gatto", "leone", "lupo", "iena" };
            string[] specie = {"canino", "felino", "felino", "canino", "canino" };

            ClsAnimali.ordinaAnimali(animali, specie);
            ClsAnimali.stampaTab(animali, specie);

            Console.Write("\nInserisci l'animale: ");
            string a = Console.ReadLine();

            ClsAnimali.cercaAnimaleBinaria(animali, specie, a);

            ClsAnimali.ordinaSpecie(animali, specie);
            ClsAnimali.stampaTab(animali, specie);

            ClsAnimali.cercaSpeciePiu(specie);

            Console.Write("\nInserisci la specie: ");
            string s = Console.ReadLine();

            int cont = ClsAnimali.contaSpecie(specie, s);
            if (cont == 0)
            {
                Console.WriteLine("\nNon ci sono animali di quella specie");
            }
            else
            {
                Console.WriteLine("\nCi sono " + cont.ToString() + " animali");
            }

            Console.Write("\nInserisci l'animale: ");
            a = Console.ReadLine();

            if ((s = specie[ClsAnimali.ricercaSeqAnimale(animali, a)]) == "-1")
            {
                Console.WriteLine("\nAnimale non trovato");
            }
            else
            {
                ClsAnimali.animaleSpecie(animali, specie, s, a);
            }

            ClsAnimali.attesaTasto();
        }
    }
}
