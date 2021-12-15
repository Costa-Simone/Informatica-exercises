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

            ClsAnimali.attesaTasto();
        }
    }
}
