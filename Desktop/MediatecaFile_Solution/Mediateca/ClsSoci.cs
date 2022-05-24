using System;
using System.Collections.Generic;
using System.IO;
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
        
        public static int nSoci;
        public static string lastCode;

        public static void caricaSoci(DataGridView dgv)
        {
            settaDgv(dgv);
            caricaDatiDaFile(dgv);
        }

        private static void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 5;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.Vertical;
            // dgv.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            // dgv.DefaultCellStyle.SelectionForeColor = dgv.DefaultCellStyle.ForeColor;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.Columns[0].HeaderText = "Codice";
            dgv.Columns[1].HeaderText = "Cognome";
            dgv.Columns[2].HeaderText = "Nome";
            dgv.Columns[3].HeaderText = "eMail";
            dgv.Columns[4].HeaderText = "Telefono";
        }

        private static void caricaDatiDaFile(DataGridView dgv)
        {
            dgv.Rows.Clear(); int i = 0; string[] fields = new string[6];
            foreach (string row in File.ReadLines("Soci.txt"))
            {
                fields = row.Split(',');
                i = dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = fields[0];
                dgv.Rows[i].Cells[1].Value = fields[1];
                dgv.Rows[i].Cells[2].Value = fields[2];
                dgv.Rows[i].Cells[3].Value = fields[3];
                dgv.Rows[i].Cells[4].Value = fields[4];
            }
            lastCode = fields[0];
            nSoci = i + 1;
        }

        internal static void inserisciSocio(string cognome, string nome, string email, string telefono, DataGridView dgv)
        {
            lastCode = lastCode.Remove(0, 1);
            int newCode = int.Parse(lastCode) + 1;
            string newMedia;
            newMedia = "s" + newCode + ",";
            newMedia += cognome + ",";
            newMedia += nome + ",";
            newMedia += email + ",";
            newMedia += telefono;
            using (StreamWriter sw = File.AppendText("Soci.txt"))
            {
                sw.WriteLine(newMedia);
            }
            caricaDatiDaFile(dgv);
        }

        internal static void cancellaSocio(int index, DataGridView dgv)
        {
            dgv.Rows.RemoveAt(index);
            scriviDgvSuFile(dgv, "Soci.txt");
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
                    newMedia += dgv.Rows[i].Cells[4].Value;
                    sw.WriteLine(newMedia);
                }
            }
        }

        internal static void modificaSocio(string cognome, string nome, string email, string telefono, int index, DataGridView dgv)
        {
            dgv.Rows[index].Cells[1].Value = cognome;
            dgv.Rows[index].Cells[2].Value = nome;
            dgv.Rows[index].Cells[3].Value = email;
            dgv.Rows[index].Cells[4].Value = telefono;
            scriviDgvSuFile(dgv, "Soci.txt");
            caricaDatiDaFile(dgv);
        }

    }
}
