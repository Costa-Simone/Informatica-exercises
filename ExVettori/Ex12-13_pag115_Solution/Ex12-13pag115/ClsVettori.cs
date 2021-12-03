using System;

namespace Ex12_13pag115
{
    class ClsVettori
    {
        static Random rnd = new Random();

        public static void ricerca_seq1(int[] v, int x)
        {
            int i = 0;

            while (v[i] != x && i != v.Length - 1)
                i++;
            if (v[i] == x)
                Console.WriteLine("Elemento trovato in pos: " + i.ToString());
            else
                Console.WriteLine("Elemento non trovato");
        }
        public static void ricerca_seq2(int[] v, int x)
        {
            bool trovato = false;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == x)
                {
                    Console.WriteLine("Elemento trovato in pos: " + i.ToString());
                    trovato = true;
                }
            }
            if (!trovato)
                Console.WriteLine("Elemento non trovato");
        }
        public static void caricaVetRndOrdinatoSenzaRip(int[]v)
        {
            //variabili locali
            
            int max = 10;

            v[0] = rnd.Next(1, max);
            for (int i = 1; i < v.Length; i++)
            {
                max = v[i - 1] + 1;
                v[i] = rnd.Next(max, max + 10);
            }
        }
        public static void ricerca_seq4(int[] v, int x)
        {
            int i = 0;
            bool trovato= false;
            bool superato= false;

            while(!superato && i<=(v.Length))
            {
                if(v[i]==x)
                {
                    Console.WriteLine("Elemento trovato in pos: " + i.ToString());
                    trovato = true;
                    i += 1;
                }
                else
                {
                    if (v[i] > x)
                        superato = true;
                    else
                        i += 1;
                }
            }
            if(!trovato)
                Console.WriteLine("Elemento non trovato");
        }
        public static void caricaVetRndOrdinatoConRipet(int[] v)
        {
            //variabili locali

            int x;
            int max=250;

            v[0] = rnd.Next(1, max+1);
            for (int i = 1; i < v.Length; i++)
            {
                do
                    x = rnd.Next(1, max+1);
                while (x < v[i - 1]);
                v[i] = x;
            }
        }
        public static void ricerca_seq3(int[] v, int x)
        {
            int i = 0;

            while (v[i] < x && i != v.Length - 1)
                i++;
            if (v[i] == x)
                Console.WriteLine("Elemento trovato in pos: " + i.ToString());
            else
                Console.WriteLine("Elemento non trovato");
        }
        public static void caricaVetRndSenzaRip(int[] v)
        {
            //variabili locali

            int x, j;

            v[0] = rnd.Next(1, 100);
            for (int i = 1; i < v.Length; i++)
            {
                do
                {
                    x = rnd.Next(1, 100);
                    j = 0;
                    while (v[j] != x && j != i - 1)
                        j++;
                }
                while (v[j] == x);
                v[i] = x;
            }
        }
        public static void attesaTasto()
        {
            Console.WriteLine("\n(premi un tasto per continuare)");
            Console.ReadKey();
        }

        public static int inputDimensione(string messaggio)
        {
            int n;
            do
            {
                Console.Write(messaggio);
                if (!int.TryParse(Console.ReadLine(), out n))
                    Console.WriteLine("Devi inserire un numero > 0!");
            }
            while (n <= 0);
            return n;
        }
        public static void caricaVet(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
                v[i] = rnd.Next(1, 10);
        }
        public static void stampaVet(int[] v, string nome)
        {
            Console.Write(nome + ": ");
            for (int i = 0; i < v.Length; i++)
                Console.Write(v[i].ToString().PadRight(6));
        }

    }
}
