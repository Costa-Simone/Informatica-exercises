using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mediateca
{
    public struct Media
    {
        public string codMedia;
        public string titolo;
        public string autore;
        public string tipo;
        public string genere;
        public bool isInPrestito;
    }

    class ClsMedia
    {
        public static int nMedia;
        public static string lastCode;

        internal static void caricaMedia(DataGridView dgv)
        {
            settaDgv(dgv);
            caricaDatiDaFile(dgv);
        }

        private static void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 6;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.Vertical;
            // dgv.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            // dgv.DefaultCellStyle.SelectionForeColor = dgv.DefaultCellStyle.ForeColor;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.Columns[0].HeaderText = "Codice";
            dgv.Columns[1].HeaderText = "Titolo";
            dgv.Columns[2].HeaderText = "Autore";
            dgv.Columns[3].HeaderText = "Tipo";
            dgv.Columns[4].HeaderText = "Genere";
            dgv.Columns[5].HeaderText = "In Prestito";
        }

        private static void caricaDatiDaFile(DataGridView dgv)
        {
            dgv.Rows.Clear(); int i = 0; string[] fields = new string[6];
            foreach (string row in File.ReadLines("Media.txt"))
            {
                fields = row.Split(',');
                i = dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = fields[0];
                dgv.Rows[i].Cells[1].Value = fields[1];
                dgv.Rows[i].Cells[2].Value = fields[2];
                dgv.Rows[i].Cells[3].Value = fields[3];
                dgv.Rows[i].Cells[4].Value = fields[4];
                dgv.Rows[i].Cells[5].Value = fields[5];
            }
            lastCode = fields[0];
            nMedia = i + 1;
        }

        internal static void inserisciMedia(string titolo, string autore, string tipo, string genere, DataGridView dgv)
        {
            lastCode = lastCode.Remove(0, 1);
            int newCode = int.Parse(lastCode) + 1;
            string newMedia;
            newMedia = "m" + newCode + ",";
            newMedia += titolo + ",";
            newMedia += autore + ",";
            newMedia += tipo + ",";
            newMedia += genere + ",";
            newMedia += "false";
            using (StreamWriter sw = File.AppendText("Media.txt"))
            {
                sw.WriteLine(newMedia);
            }
            caricaDatiDaFile(dgv);
        }

        internal static void cancellaMedia(int index, DataGridView dgv)
        {
            dgv.Rows.RemoveAt(index);
            scriviDgvSuFile(dgv, "Media.txt");
            caricaDatiDaFile(dgv);
        }

        internal static void scriviDgvSuFile(DataGridView dgv, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    string newMedia;
                    newMedia = dgv.Rows[i].Cells[0].Value + ",";
                    newMedia += dgv.Rows[i].Cells[1].Value + ",";
                    newMedia += dgv.Rows[i].Cells[2].Value + ",";
                    newMedia += dgv.Rows[i].Cells[3].Value + ",";
                    newMedia += dgv.Rows[i].Cells[4].Value + ",";
                    newMedia += dgv.Rows[i].Cells[5].Value;
                    sw.WriteLine(newMedia);
                }
            }
        }

        internal static void modificaMedia(string titolo, string autore, string tipo, string genere, int index, DataGridView dgv)
        {
            dgv.Rows[index].Cells[1].Value = titolo;
            dgv.Rows[index].Cells[2].Value = autore;
            dgv.Rows[index].Cells[3].Value = tipo;
            dgv.Rows[index].Cells[4].Value = genere;
            scriviDgvSuFile(dgv, "Media.txt");
            caricaDatiDaFile(dgv);
        }

        internal static void assegnaPrestito(string codMedia, DataGridView dgv)
        {
            int i = 0;
            while (dgv.Rows[i].Cells[0].Value.ToString() != codMedia) i++;
            dgv.Rows[i].Cells[5].Value = "true";
            scriviDgvSuFile(dgv, "Media.txt");
        }

        internal static void consegnaPrestito(string codMedia, DataGridView dgv)
        {
            int i = 0;
            while (dgv.Rows[i].Cells[0].Value.ToString() != codMedia) i++;
            dgv.Rows[i].Cells[5].Value = "false";
            scriviDgvSuFile(dgv, "Media.txt");
        }
    }
}
