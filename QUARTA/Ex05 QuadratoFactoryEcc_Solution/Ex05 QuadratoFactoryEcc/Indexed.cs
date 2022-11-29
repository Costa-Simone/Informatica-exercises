using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_QuadratoFactoryEcc
{
    class Indexed
    {
        private string[] myData;

        public Indexed(int size)
        {
            myData = new string[size];

            for (int i = 0; i < size; i++)
            {
                myData[i] = "empty";
            }
        }

        public string this[int pos]     // iteratore
        {
            get { return myData[pos]; }
            set { myData[pos] = value; }
        }
    }
}
