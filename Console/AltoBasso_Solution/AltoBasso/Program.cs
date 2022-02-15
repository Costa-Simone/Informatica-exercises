using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltoBasso
{
    class Program
    {
        static void Main(string[] args)
        {
            char scelta;
            int nMax = 0, nTent = 0, nS, conta, t;

            Random rnd = new Random();

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*** GIOCO ALTO-BASSO ***\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1) Livello FACILE (1..100)");
                Console.WriteLine("2) Livello MEDIO (1..500)");
                Console.WriteLine("3) Livello DIFFICILE (1..1000)");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("0) Esci ");

                Console.Write("\nScegli il livello del gioco: ");
                scelta = Console.ReadKey().KeyChar;

                switch (scelta)
                {
                    case '1':
                        nMax = 100;
                        nTent = 5;
                        break;
                    case '2':
                        nMax = 500;
                        nTent = 8;
                        break;
                    case '3':
                        nMax = 1000;
                        nTent = 10;
                        break;
                    case '0':
                        Console.WriteLine("\n\nGrazie per aver giocato!\n");
                        break;
                    default:
                        Console.WriteLine("\n\nScelta non valida, riprovare!\n");
                        break;
                }

                if (scelta == '1' || scelta == '2' || scelta == '3')
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\nInizia il gioco con intervallo 1.." + nMax.ToString() + "\n\n");

                    nS = rnd.Next(1, nMax + 1);
                    conta = 0;
                    
                    do
                    {
                        conta++;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("\nTentativo" + conta.ToString() + ":");

                        do
                        {
                            int.TryParse(Console.ReadLine(), out t);
                            if (t <= 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("Devi inserire un numero > 0!");
                                Console.BackgroundColor = ConsoleColor.Black;
                            }
                            
                        } while (t <= 0);

                        if (t == nS)
                        {
                            Console.WriteLine("Bravo! Hai indovinato in " + conta.ToString() + " tentativi");
                        }
                        
                        if (t > nS)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Tentativo troppo ALTO!");
                        }
                        else if(t < nS)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Tentativo troppo BASSO!");
                        }
                        
                        if (conta == nTent && t != nS)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nHai perso!");
                            Console.WriteLine("Il numero segreto era: " + nS.ToString());
                        }

                    } while (conta != nTent && t != nS);
                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadKey();
                Console.Clear();

            } while (scelta != '0');

        }
    }
}
