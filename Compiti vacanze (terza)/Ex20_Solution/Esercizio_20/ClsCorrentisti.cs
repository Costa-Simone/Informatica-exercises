using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Esercizio_20
{
    class ClsCorrentisti
    {
        public static string lastCode;

        internal static void caricaCorrentisti(DataGridView dgv)
        {
            settaDgv(dgv);
            caricaDatiDaFile(dgv);
        }

        private static void caricaDatiDaFile(DataGridView dgv)
        {
            int i = 0; 
            string[] campi = new string[6];

            dgv.Rows.Clear();
            foreach (string row in File.ReadLines("Correntisti.txt"))
            {
                campi = row.Split(',');
                i = dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = campi[0];
                dgv.Rows[i].Cells[1].Value = campi[1];
                dgv.Rows[i].Cells[2].Value = campi[2];
                dgv.Rows[i].Cells[3].Value = campi[3];
                dgv.Rows[i].Cells[4].Value = campi[4];
            }
            lastCode = campi[0];
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

        internal static void inserisciCorrentista(string cognome, string nome, string email, string telefono, DataGridView dgv)
        {
            lastCode = lastCode.Remove(0, 1);
            int newCode = int.Parse(lastCode) + 1;
            string newCorrentista;
            newCorrentista = "m" + newCode + ",";
            newCorrentista += cognome + ",";
            newCorrentista += nome + ",";
            newCorrentista += email + ",";
            newCorrentista += telefono;
            using (StreamWriter sw = File.AppendText("Correntisti.txt"))
            {
                sw.WriteLine(newCorrentista);
            }
            caricaDatiDaFile(dgv);
        }

        internal static void cancellaCorrentista(int index, DataGridView dgv)
        {
            dgv.Rows.RemoveAt(index);
            scriviDgvSuFile(dgv, "Correntisti.txt");
            caricaDatiDaFile(dgv);
        }

        private static void scriviDgvSuFile(DataGridView dgv, string name)
        {
            using (StreamWriter sw = new StreamWriter(name, false))
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    string newCorrentista;
                    newCorrentista = dgv.Rows[i].Cells[0].Value + ",";
                    newCorrentista += dgv.Rows[i].Cells[1].Value + ",";
                    newCorrentista += dgv.Rows[i].Cells[2].Value + ",";
                    newCorrentista += dgv.Rows[i].Cells[3].Value + ",";
                    newCorrentista += dgv.Rows[i].Cells[4].Value;
                    sw.WriteLine(newCorrentista);
                }
            }
        }

        internal static void modificaCorrentista(string cognome, string nome, string email, string telefono, int index, DataGridView dgv)
        {
            dgv.Rows[index].Cells[1].Value = cognome;
            dgv.Rows[index].Cells[2].Value = nome;
            dgv.Rows[index].Cells[3].Value = email;
            dgv.Rows[index].Cells[4].Value = telefono;
            scriviDgvSuFile(dgv, "Correntisti.txt");
            caricaDatiDaFile(dgv);
        }
    }
}
