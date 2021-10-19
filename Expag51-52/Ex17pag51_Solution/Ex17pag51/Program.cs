using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17pag51
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Random rnd = new Random();

            n1 = rnd.Next(1, 6);
            n2 = rnd.Next(1, 6);
            n3 = rnd.Next(1, 6);

            if (n1 == n2 && n2 == n3)
            {
                Console.WriteLine("Hai fatto tris");
            }
            else if(n1 == n2 || n2 == n3 || n1 == n3)
            {
                Console.WriteLine("Hai fatto coppia");
            }
            else
            {
                Console.WriteLine("Non hai fatto nulla!");
            }

            Console.ReadKey();
        }
    }
}
