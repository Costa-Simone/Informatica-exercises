using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediateca
{
    public struct Socio
    {
        public string codSocio;
        public string cognome;
        public string nome;
        public string email;
        public string telefono;
    }

    class ClsSoci
    {
        public static Socio[] soci = new Socio[50];
        public static string[] datiSoci = new string[]
        {
            "s1,Rossi,Mario,mario@rossi.it,3202342455",
            "s2,Brambilla,Lorenzo,lorenzo@brambilla.it,4564351234",
            "s3,Bianchi,Roberto,roberto@bianhi,3456789854",
            "s4,Ferrero,Luigi,luigi@ferrero.it,1290985432",
            "s5,Montessori,Maria,maria@montessori.it,6549032334",
            "s6,Abate,Anna,anna@abate.it,98112334589",
            "s7,Pautasso,Giuseppe,giuseppe@pautasso.it,9873334565"
        };
        public static int nSoci;

        internal static void caricaSoci(DataGridView dgv)
        {
            caricaTabellaSoci();
            visualizzaTabellaSoci(dgv);
        }
        private static void caricaTabellaSoci()
        {
            for (int i = 0; i < datiSoci.Length; i++)
            {
                string[] dati = datiSoci[i].Split(',');
                soci[i].codSocio = dati[0];
                soci[i].cognome = dati[1];
                soci[i].nome = dati[2];
                soci[i].email = dati[3];
                soci[i].telefono = dati[4];
            }
            nSoci = datiSoci.Length;
        }
        private static void visualizzaTabellaSoci(DataGridView dgv)
        {
            settaDgv(dgv);
            caricaDati(dgv);
        }
        private static void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 5;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.Columns[0].HeaderText = "Codice";
            dgv.Columns[1].HeaderText = "Cognome";
            dgv.Columns[2].HeaderText = "Nome";
            dgv.Columns[3].HeaderText = "Email";
            dgv.Columns[4].HeaderText = "Telefono";
        }
        private static void caricaDati(DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < nSoci; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = soci[i].codSocio;
                dgv.Rows[i].Cells[1].Value = soci[i].cognome;
                dgv.Rows[i].Cells[2].Value = soci[i].nome;
                dgv.Rows[i].Cells[3].Value = soci[i].email;
                dgv.Rows[i].Cells[4].Value = soci[i].telefono;
            }
        }
        internal static void inserisciSocio(string cognome, string nome, string email, string telefono, DataGridView dgv)
        {
            string lastCode = soci[nSoci - 1].codSocio.Remove(0, 1);
            int newCode = int.Parse(lastCode) + 1;
            Socio s = new Socio();
            s.codSocio = "s" + newCode;
            s.cognome = cognome;
            s.nome = nome;
            s.email = email;
            s.telefono = telefono;
            soci[nSoci] = s;
            nSoci++;
            visualizzaTabellaSoci(dgv);
        }
        internal static void cancellaSocio(int index, DataGridView dgv)
        {
            Socio[] newSoci = new Socio[50];
            int j = 0;
            for (int i = 0; i < index; i++) newSoci[j++] = soci[i];
            for (int i = index + 1; i < nSoci; i++) newSoci[j++] = soci[i];
            soci = newSoci;
            nSoci--;
            visualizzaTabellaSoci(dgv);
        }
        internal static void modificaSocio(string cognome, string nome, string email, string telefono, int index, DataGridView dgv)
        {
            soci[index].cognome = cognome;
            soci[index].nome = nome;
            soci[index].email = email;
            soci[index].telefono = telefono;
            visualizzaTabellaSoci(dgv);
        }
    }
}
