using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_QuadratoFactoryEcc
{
    class Singleton
    {
        private static Singleton istanza = null;
        public static int contatore = 0;
        public readonly int valContatore;

        private Singleton()
        {
            contatore++;
            valContatore = contatore;
        }

        public static Singleton getInstance()
        {
            if (istanza == null)
            {
                istanza = new Singleton();
            }

            return istanza;
        }
    }
}
