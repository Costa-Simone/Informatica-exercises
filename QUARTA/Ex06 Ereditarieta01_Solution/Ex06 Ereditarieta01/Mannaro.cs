using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Ereditarieta01
{
    class Mannaro : Mostro
    {
        internal double punti;

        public Mannaro(double punti) : base(2)   
        {
            this.punti = punti;
        }

        public double valoreProprio()
        {
            return punti;
        }
        public double valorePadre()
        {
            return base.punti;
        }
        public double valoreTotale()
        {
            return punti + base.punti;
        }
    }
}
