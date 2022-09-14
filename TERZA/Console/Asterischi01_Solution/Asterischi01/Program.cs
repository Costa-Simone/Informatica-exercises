using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterischi01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 120; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < 27; i++)
            {
                Console.Write("*");
                for (int j = 0; i < 118; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            for (int i = 0; i < 119; i++)
            {
                Console.Write("*");
            }

            Console.ReadKey();
        }
    }
}
