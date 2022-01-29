using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuLancioMatrici
{
    class ClsVettori
    {
        internal static void stampaVet(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i].ToString() + "\t");
            }
        }
    }
}
