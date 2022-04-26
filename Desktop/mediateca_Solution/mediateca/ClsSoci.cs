using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediateca
{
    public struct Socio
    {
        public string codSocio;
        public string cognome;
        public string nome;
        public string email;
        public string telefono;
    }
    internal class ClsSoci
    {
        public static Socio[] soci = new Socio[50];
        static string[] datiSoci = new string[]
        {
            "s1,Rossi,Mario,mario@rossi.it,1111111111",
            "s2,Asbulla,Amer,amer@asbulla.it,2222222222",
            "s3,Cairo,Pietro,pietro@cairo.it,3333333333",
            "s4,Pieretto,Francesco,francesco@pieretto.it,4444444444",
            "s5,Perassi,Lorenzo,lorenzo@perassi.it,5555555555",
            "s6,Trecco,Pietro,pietro@trecco.it,6666666666",
            "s7,Pilloni,Lorenzo,lorenzo@pilloni.it,7777777777"
        };

        static int nSoci;

        internal static void caricaSoci(DataGridView dgv)
        {
            caricaTabellaSoci();
            visualizzaTabellaSoci(dgv);
        }
        private static void visualizzaTabellaSoci(DataGridView dgv)
        {
            settaDgv(dgv);
            caricaDati(dgv);
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
        private static void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 5;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.Columns[0].HeaderText = "Codice";
            dgv.Columns[1].HeaderText = "Cognome";
            dgv.Columns[2].HeaderText = "Nome";
            dgv.Columns[3].HeaderText = "Email";
            dgv.Columns[4].HeaderText = "Telefono";
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
        internal static void inserisciSocio(string cognome, string nome, string email, string telefono, DataGridView dgv)
        {
            string lastCode = soci[nSoci - 1].codSocio.Remove(0, 1);
            int codSocio = int.Parse(lastCode) + 1;
            Socio m = new Socio();

            m.codSocio = "m" + codSocio;
            m.cognome = cognome;
            m.nome = nome;
            m.email = email;
            m.telefono = telefono;
            soci[nSoci] = m;
            nSoci++;

            visualizzaTabellaSoci(dgv);
        }
        internal static void cancellaSocio(int index, DataGridView dgv)
        {
            Socio[] newSoci = new Socio[50];
            int j = 0;

            for (int i = 0; i < index; i++)
            {
                newSoci[j++] = soci[i];
            }

            for (int i = index + 1; i < nSoci; i++)
            {
                newSoci[j++] = soci[i];
            }

            soci = newSoci;
            nSoci--;
            visualizzaTabellaSoci(dgv);
        }
        internal static void modificaSocio(int index, string cognome, string nome, string email, string telefono, DataGridView dgv)
        {
            soci[index].cognome = cognome;
            soci[index].nome = nome;
            soci[index].email = email;
            soci[index].telefono = telefono;

            visualizzaTabellaSoci(dgv);
        }
    }
}
