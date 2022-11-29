using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Ereditarieta01
{
    class Mostro
    {
        protected double punti;

        public Mostro(double punti)
        {
            this.punti = punti;
        }

        internal double valore()
        {
            return punti;
        }
    }
}
