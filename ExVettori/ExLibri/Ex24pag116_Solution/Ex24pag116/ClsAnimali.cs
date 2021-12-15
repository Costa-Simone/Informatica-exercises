using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24pag116
{
    class ClsAnimali
    {
        public static void stampaTab(string[] animali, string[] specie)
        {
            for (int i = 0; i < animali.Length; i++)
            {
                Console.Write("Animale: " + animali[i] + "\t" + "di specie:\t " + specie[i] + "\n");
            }
        }
        internal static void ordinaAnimali(string[] animali, string[] specie)
        {
            int i = -1;
            string aus;
            bool scambio;

            do
            {
                i++;
                scambio = false;

                for (int j = animali.Length - 2; j >= i; j--)
                {
                    if (string.Compare(animali[j], animali[j + 1]) > 0)
                    {
                        aus = animali[j];
                        animali[j] = animali[j + 1];
                        animali[j + 1] = aus;
                        aus = specie[j];
                        specie[j] = specie[j + 1];
                        specie[j + 1] = aus;
                        scambio = true;
                    }
                }
            } while (i != animali.Length - 2 && scambio);
        }
        internal static void cercaSpeciePiu(string[] specie)
        {
            Array.Resize(ref specie, specie.Length + 1);
            specie[specie.Length - 1] = "ZZ";

            int cont = 1, max = 0;
            string spec = "";

            for (int i = 1; i < specie.Length; i++)
            {
                if (specie[i] == specie[i - 1])
                {
                    cont++;
                }
                else
                {
                    if (cont > max)
                    {
                        max = cont;
                        spec = specie[i - 1];
                    }
                    cont = 1;
                }
            }

            Console.WriteLine("\nLa specie con più animale è: " + spec);
        }
        internal static void ordinaSpecie(string[] animali, string[] specie)
        {
            int PosMin;
            string aus;

            for (int i = 0; i <= specie.Length - 2; i++)
            {
                PosMin = i;

                for (int j = i + 1; j <= specie.Length - 1; j++)
                {
                    if (string.Compare(specie[PosMin], specie[j]) > 0)
                    {
                        PosMin = j;
                    }
                }

                if (PosMin != i)
                {
                    aus = specie[i];
                    specie[i] = specie[PosMin];
                    specie[PosMin] = aus;
                    aus = animali[i];
                    animali[i] = animali[PosMin];
                    animali[PosMin] = aus;
                }
            }
        }
        internal static void cercaAnimaleBinaria(string[] animali, string[] specie, string a)
        {
            int meta, sup = 0, inf = animali.Length - 1;

            do
            {
                meta = (inf + sup) / 2;

                if (animali[meta] != a)
                {
                    if (string.Compare(animali[meta], a) > 0)
                    {
                        inf = meta - 1;
                    }
                    else
                    {
                        sup = meta + 1;
                    }
                }
            } while (animali[meta] != a && sup <= inf);

            if (animali[meta] == a)
            {
                Console.WriteLine("\nAnimale di specie: " + specie[meta] + "\n");
            }
            else
            {
                Console.WriteLine("\nAnimale non trovato");
            }
        }
        internal static void attesaTasto()
        {
            Console.WriteLine("\n(premi un tasto per continuare)");
            Console.ReadKey();
        }
    }
}
