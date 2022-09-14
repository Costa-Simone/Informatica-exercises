using System;

namespace Recupero_compito
{
    class Program
    {
        static void scriviMenu()
        {
            Console.Clear();
            Console.WriteLine("*** GESTIONE VETTORI PARALLELI ***");
            Console.WriteLine("\nA => Ordinamento per regione");
            Console.WriteLine("B => Ordinamento per regione/città");
            Console.WriteLine("C => Ordinamento per regione/temperature");
            Console.WriteLine("\nX => ESCI!");
            Console.WriteLine();
        }
        static string[] citta = { "Torino", "Cuneo", "Alessandria", "Vercelli", "Milano",
                "Verona", "Savona", "Genova", "Rovigo", "Pavia", "Sondrio", "Biella", "Ventimiglia", "Asti", "La Spezia","Roma" };
        static int[] temperature = { 15, 18, 14, 12, 20, 21, 14, 17, 16, 20, 24, 12, 11, 15, 16, 25 };
        static string[] regioni = { "Piemonte", "Piemonte", "Piemonte", "Piemonte", "Lombardia", "Veneto", "Liguria", "Liguria", "Veneto",
                "Lombardia", "Lombardia", "Piemonte", "Liguria", "Piemonte", "Liguria","Zazza" };
        static void Main(string[] args)
        {
            char scelta = ' ';
            do
            {
                scriviMenu();
                scelta = Console.ReadKey(true).KeyChar;
                switch (scelta)
                {
                    case 'A':
                    case 'a':
                        ordinaRegione(citta, temperature, regioni);
                        stampaTabCompleta(citta, regioni, temperature);
                        attesaTasto();
                        break;
                    case 'B':
                    case 'b':
                        ordinaRegione(citta, temperature, regioni);
                        ordinaCittaOrTemperatura(citta, temperature, regioni, false);
                        stampaTabCompleta(citta, regioni, temperature);
                        attesaTasto();
                        break;
                    case 'C':
                    case 'c':
                        ordinaRegione(citta, temperature, regioni);
                        ordinaCittaOrTemperatura(citta, temperature, regioni, true);
                        stampaTabCompleta(citta, regioni, temperature);
                        attesaTasto();
                        break;
                    case 'X':
                    case 'x':
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Inserisci una scelta valida\n");
                        Console.BackgroundColor = ConsoleColor.Black;
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
            } while (scelta.ToString().ToUpper() != "X");
        }

        private static void ordinaCittaOrTemperatura(string[] citta, int[] temperature, string[] regioni, bool isTemperatura)
        {
            int parto = 0;
            int cont = 1;
            int posMin;
            string aus;
            int temp;
            Array.Resize(ref regioni, regioni.Length + 1);
            regioni[regioni.Length - 1] = "Zz";

            for (int i = 1; i < regioni.Length; i++)
            {
                if (regioni[i] == regioni[i - 1])
                    cont++;
                else
                {
                    for (int j = parto; j < parto + cont - 1; j++)
                    {
                        posMin = j;
                        for (int h = j + 1; h < parto + cont; h++)
                        {
                            if(isTemperatura)
                            {
                                if (temperature[posMin] > temperature[h])
                                    posMin = h;
                            }
                            else
                            {
                                if (String.Compare(citta[posMin], citta[h]) > 0)
                                    posMin = h;
                            }
                        }
                        if (posMin != j)
                        {
                            aus = citta[j];
                            citta[j] = citta[posMin];
                            citta[posMin] = aus;
                            temp = temperature[j];
                            temperature[j] = temperature[posMin];
                            temperature[posMin] = temp;
                        }
                    }
                    parto += cont;
                    cont = 1;
                }
            }
            Array.Resize(ref regioni, regioni.Length - 1);
        }

        private static void attesaTasto()
        {
            Console.WriteLine("\n(premi un tasto per concludere)");
            Console.ReadKey();
        }

        private static void stampaTabCompleta(string[] citta, string[] regioni, int[] temperature)
        {
            Console.WriteLine(regioni[0]);
            Console.WriteLine("\t" + citta[0] + "\t" + temperature[0] + "\n");
            for (int i = 1; i < regioni.Length; i++)
            {
                if (regioni[i] != regioni[i - 1])
                {
                    Console.WriteLine(regioni[i]);
                }
                Console.WriteLine("\t" + citta[i] + "\t" + temperature[i] + "\n");
            }
        }

        private static void ordinaRegione(string[] citta, int[] temperature, string[] regioni)
        {
            int posMin;
            string aus;
            int temp;

            for (int i = 0; i <= regioni.Length - 2; i++)
            {
                posMin = i;
                for (int j = i + 1; j <= regioni.Length - 1; j++)
                {
                    if (String.Compare(regioni[posMin], regioni[j]) > 0)
                        posMin = j;
                }
                if (posMin != i)
                {
                    aus = regioni[i];
                    regioni[i] = regioni[posMin];
                    regioni[posMin] = aus;
                    aus = citta[i];
                    citta[i] = citta[posMin];
                    citta[posMin] = aus;
                    temp = temperature[i];
                    temperature[i] = temperature[posMin];
                    temperature[posMin] = temp;
                }
            }
        }
    }
}
