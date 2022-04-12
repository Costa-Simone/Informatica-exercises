using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediateca
{
    public struct Operazione
    {
        public string codOperazione;
        public string codMedia;
        public string codSocio;
        public DateTime dataPrelievo;
        public DateTime dataRestituzione;
    }
    internal class ClsOperazioni
    {
        static Operazione[] operazioni = new Operazione[50];
        static string[] datiOperazioni = new string[]
        {
            "o1,m3,s2,20220415,20220510",
            "o2,m7,s6,20220412,20220511",
            "o3,m2,s1,20220411,20220509",
            "o4,m1,s7,20220415,20220511",
            "o5,m5,s3,20220414,20220512",
            "o6,m4,s5,20220412,20220512",
            "o7,m6,s4,20220413,20220509"
        };

        static int nOperazioni;

        internal static void caricaOperazioni(DataGridView dgv)
        {
            caricaTabellaOperazioni();
            visualizzaTabellaOperazioni(dgv);
        }
        private static void visualizzaTabellaOperazioni(DataGridView dgv)
        {
            settaDgv(dgv);
            caricaDati(dgv);
        }
        private static void caricaDati(DataGridView dgv)
        {
            for (int i = 0; i < nOperazioni; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = operazioni[i].codOperazione;
                dgv.Rows[i].Cells[1].Value = operazioni[i].codMedia;
                dgv.Rows[i].Cells[2].Value = operazioni[i].codSocio;
                dgv.Rows[i].Cells[3].Value = operazioni[i].dataPrelievo.ToLongDateString();
                dgv.Rows[i].Cells[4].Value = operazioni[i].dataRestituzione.ToLongDateString();
            }
        }
        private static void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 5;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.Columns[0].HeaderText = "cod. Operaz.";
            dgv.Columns[1].HeaderText = "cod. Media";
            dgv.Columns[2].HeaderText = "cod. Socio";
            dgv.Columns[3].HeaderText = "Data prelievo";
            dgv.Columns[4].HeaderText = "Dara restituzione";
        }
        private static void caricaTabellaOperazioni()
        {
            for (int i = 0; i < datiOperazioni.Length; i++)
            {
                string[] dati = datiOperazioni[i].Split(',');
                operazioni[i].codOperazione = dati[0];
                operazioni[i].codMedia = dati[1];
                operazioni[i].codSocio = dati[2];
                operazioni[i].dataPrelievo = DateTime.ParseExact(dati[3], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                operazioni[i].dataRestituzione = DateTime.ParseExact(dati[4], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            }

            nOperazioni = datiOperazioni.Length;
        }
    }
}
