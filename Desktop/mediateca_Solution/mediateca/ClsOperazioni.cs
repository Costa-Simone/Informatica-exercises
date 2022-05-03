using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediateca
{
    public struct Operazione
    {
        public string codOperazione;
        public string codMedia;
        public string codSocio;
        public DateTime dataPrelievo;
        public DateTime dataResistuzione;
    }

    class ClsOperazioni
    {
        public static Operazione[] operazioni = new Operazione[50];
        public static string[] datiOperazioni = new string[]
        {
            "o1,m3,s2,20220415,20220510",
            "o2,m7,s6,20220412,20220511",
            "o3,m2,s1,20220411,20220509",
            "o4,m1,s7,20220415,20220511",
            "o5,m5,s3,20220414,20220512",
            "o6,m4,s5,20220412,20220512",
            "o7,m6,s4,20220413,20220509"
        };
        public static int nOperazioni;

        internal static void caricaOperazioni(DataGridView dgv)
        {
            caricaTabellaOperazioni();
            visualizzaTabellaOperazioni(dgv);
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
                operazioni[i].dataResistuzione = DateTime.ParseExact(dati[4], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            }

            nOperazioni = datiOperazioni.Length;
        }
        private static void visualizzaTabellaOperazioni(DataGridView dgv)
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
            dgv.Columns[0].HeaderText = "Cod. Operazione";
            dgv.Columns[1].HeaderText = "Cod. Media";
            dgv.Columns[2].HeaderText = "Cod. Socio";
            dgv.Columns[3].HeaderText = "Data Prelievo";
            dgv.Columns[4].HeaderText = "Data Restituzione";
        }
        private static void caricaDati(DataGridView dgv)
        {
            dgv.Rows.Clear();

            for (int i = 0; i < nOperazioni; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = operazioni[i].codOperazione;
                dgv.Rows[i].Cells[1].Value = operazioni[i].codMedia;
                dgv.Rows[i].Cells[2].Value = operazioni[i].codSocio;
                dgv.Rows[i].Cells[3].Value = operazioni[i].dataPrelievo.ToLongDateString();

                if (operazioni[i].dataResistuzione == DateTime.MinValue)
                {
                    dgv.Rows[i].Cells[4].Value = "";
                }
                else
                {
                    dgv.Rows[i].Cells[4].Value = operazioni[i].dataResistuzione.ToLongDateString();
                }
            }
        }
        internal static void caricaCmbSoci(ComboBox cmbSocio, Socio[] soci, int nSoci)
        {
            /*
            cmbSocio.DisplayMember = "Text";
            cmbSocio.ValueMember = "Value";
            object[] items = new object[nSoci];

            for (int i = 0; i < nSoci; i++)
            {
                items[i] = new { Text = soci[i].cognome + " " + soci[i].nome, Value = soci[i].codSocio };
            }
            cmbSocio.DataSource = items;
            */
            for (int i = 0; i < nSoci; i++)
            {
                cmbSocio.Items.Add(soci[i].cognome + " " + soci[i].nome + " - " + soci[i].codSocio);
            }
        }
        internal static void caricaCmbMedia(ComboBox cmbMedia, Media[] medias, int nMedia)
        {
            for (int i = 0; i < nMedia; i++)
            {
                if (!medias[i].isInPrestito)
                    cmbMedia.Items.Add(medias[i].titolo + " - " + medias[i].codMedia);
            }
        }
        internal static void inserisciPrestito(string codSocio, string codMedia, DataGridView dgv, DataGridView dgvMedia)
        {
            string lastCode = operazioni[nOperazioni - 1].codOperazione.Remove(0, 1);
            int newCode = int.Parse(lastCode) + 1;
            Operazione o = new Operazione();
            o.codOperazione = "o" + newCode;
            o.codMedia = codMedia;
            o.codSocio = codSocio;
            o.dataPrelievo = DateTime.Now;
            o.dataResistuzione = DateTime.MinValue;
            ClsMedia.assegnaPrestito(codMedia, dgvMedia);
            operazioni[nOperazioni] = o;
            nOperazioni++;
            visualizzaTabellaOperazioni(dgv);
        }
        internal static void restituisciPrestito(int index, DataGridView dgvOperazioni, DataGridView dgvMedia)
        {
            string codMedia = dgvOperazioni.Rows[index].Cells[1].Value.ToString();
            
            if (dgvOperazioni.Rows[index].Cells[4].Value.ToString() == "")
            {
                operazioni[index].dataResistuzione = DateTime.Now;
                ClsMedia.consegnaPrestito(codMedia, dgvMedia);
                visualizzaTabellaOperazioni(dgvOperazioni);
            }
            else
            {
                MessageBox.Show("Attenzione, media gia' restituito");
            }
        }
    }
}
