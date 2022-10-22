using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Squadra_calcio
{
    class Squadra
    {
        public string nome;
        public string citta;
        public int giocate;
        public int vinte;
        public int pareggiate;

        public Squadra()
        {
            this.nome = "Nome squadra";
            this.citta = "Città squadra";
            this.giocate = 0;
            this.vinte = 0;
            this.pareggiate = 0;
        }
        public Squadra(string nome, string citta, int giocate, int vinte, int pareggiate)
        {
            this.nome = nome;
            this.citta = citta;
            this.giocate = giocate;
            this.vinte = vinte;
            this.pareggiate = pareggiate;
        }
    }
}
