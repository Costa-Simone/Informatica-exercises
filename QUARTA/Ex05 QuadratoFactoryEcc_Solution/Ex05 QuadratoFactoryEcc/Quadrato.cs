using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_QuadratoFactoryEcc
{
    class Quadrato
    {
        private int lato;

        private Quadrato(int lato)
        {
            this.lato = lato;
        }

        public static Quadrato creaQuadrato(int lato)
        {
            if (lato > 0)
            {
                return new Quadrato(lato);
            }
            else
            {
                throw new Exception("Il lato deve essere > di 0!");
            }
        }
    }
}
