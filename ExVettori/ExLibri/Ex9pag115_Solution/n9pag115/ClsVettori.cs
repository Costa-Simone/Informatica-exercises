using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n9pag115
{
    class ClsVettori
    {
        public static void ordinamentoCitta(string[] citta, string[] nominativo)
        {
            int i = -1;
            bool scambio;
            string city;
            string name;

            do
            {
                i++;
                scambio = false;
                for (int j = citta.Length - 2; j >= i; j--)
                {
                    if (string.Compare(citta[j], citta[j + 1])>0)
                    {
                        city = citta[j];
                        name = nominativo[j];
                        citta[j] = citta[j + 1];
                        nominativo[j] = nominativo[j + 1];
                        citta[j + 1] = city;
                        nominativo[j + 1] = name;
                        scambio = true;
                    }
                }

            } while (i != citta.Length - 2 && scambio);
        }
        internal static void ricercaStudentiDataCitta(string[] nominativo, string[] citta)
        {
            Console.Write("Inserisci la città : ");
            string ct = Console.ReadLine();
            string stOut = "";
            int i = 0;
            bool trovato = false;
            bool superato = false;
            int cont = 0;
            while (!superato && i <= citta.Length - 1)
            {
                if (citta[i] == ct)
                {
                    stOut += nominativo[i] +"\n";
                    trovato = true;
                    i++;
                    cont++;
                }
                else
                {
                    if (citta[i].CompareTo(ct) > 0)
                    {
                        superato = true;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            if (!trovato)
            {
                Console.WriteLine("\nCittà non trovata!");
            }
            else
            {
                Console.WriteLine("\nStudenti provenienti da " + ct+" sono: "+cont);
                Console.WriteLine("\n" + stOut);
            }
        }
    }
}
