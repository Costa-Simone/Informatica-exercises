using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Convertire numero intero random tra 1 e 1000, in numero romano

namespace Ex12pag51
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, u, d, c;

            Random rnd = new Random();

            n = rnd.Next(1, 1000);

            Console.Write("Il numero è: " + n.ToString() + ", ");

            n = n % 1000;
            c = n / 100;
            n = n % 100;
            d = n / 10;
            n = n % 10;
            u = n / 1;

            if(n == 1000)
            {
                Console.Write("M");
            }

            switch(c)
            {
                case 1: Console.Write("C");
                    break;
                case 2: Console.Write("CC");
                    break;
                case 3: Console.Write("CCC");
                    break;
                case 4: Console.Write("CD");
                    break;
                case 5: Console.Write("D");
                    break;
                case 6: Console.Write("DC");
                    break;
                case 7: Console.Write("DCC");
                    break;
                case 8: Console.Write("DCCC");
                    break;
                case 9: Console.Write("CM");
                    break;
            }

            switch (d)
            {
                case 1:
                    Console.Write("X");
                    break;
                case 2:
                    Console.Write("XX");
                    break;
                case 3:
                    Console.Write("XXX");
                    break;
                case 4:
                    Console.Write("XL");
                    break;
                case 5:
                    Console.Write("L");
                    break;
                case 6:
                    Console.Write("LX");
                    break;
                case 7:
                    Console.Write("LXX");
                    break;
                case 8:
                    Console.Write("LXXX");
                    break;
                case 9: Console.Write("XC");
                    break;
            }

            switch (u)
            {
                case 1:
                    Console.Write("I");
                    break;
                case 2:
                    Console.Write("II");
                    break;
                case 3:
                    Console.Write("III");
                    break;
                case 4:
                    Console.Write("IV");
                    break;
                case 5:
                    Console.Write("V");
                    break;
                case 6:
                    Console.Write("VI");
                    break;
                case 7:
                    Console.Write("VII");
                    break;
                case 8:
                    Console.Write("VIII");
                    break;
                case 9: Console.Write("IX");
                    break;
            }

            Console.ReadKey();
        }
    }
}
