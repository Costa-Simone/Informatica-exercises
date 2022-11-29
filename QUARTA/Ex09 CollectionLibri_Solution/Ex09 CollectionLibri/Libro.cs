using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_CollectionLibri
{
    internal class Libro
    {
        public string titolo;
        public string autore;

        public Libro(string titolo, string autore)  
        {
            this.titolo = titolo;
            this.autore = autore;
        }

        public override string ToString()
        {
            return $"Titolo: {titolo}\nAutore: {autore}";
        }
    }
}
