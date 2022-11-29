using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Ereditarieta02
{
    class Mostro
    {
        protected double punti;
        protected string verso;

        public Mostro()
        {
            punti = 25;
            verso = "Grugnito";
        }

        public double Valore()
        {
            return punti;
        }
        public string Verso()
        {
            return verso;
        }
    }
}
