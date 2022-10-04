using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_OOP01
{
    class Rettangolo
    {
        private int lato1, lato2;

        public Rettangolo(int lato1, int lato2)
        {
            this.lato1 = lato1;
            this.lato2 = lato2;
        }
        public Rettangolo(int lato) : this(lato, lato)
        {
        }
        public Rettangolo() : this(1)
        {
        }

        public int area()
        {
            return lato1 * lato2;
        }
    }
}
