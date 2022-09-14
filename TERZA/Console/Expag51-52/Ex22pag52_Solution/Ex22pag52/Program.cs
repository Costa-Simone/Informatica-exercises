using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22pag52
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=2; i<=200; i+=2)
            {
                Console.Write(i.ToString().PadRight(10));
            }

            Console.ReadKey();
        }
    }
}
