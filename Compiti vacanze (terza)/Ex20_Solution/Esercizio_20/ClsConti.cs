using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Esercizio_20
{
    class ClsConti
    {
        public static string lastCode;

        internal static void caricaConti(DataGridView dgv)
        {
            settaDgv(dgv);
            caricaDatiDaFile(dgv);
        }

        private static void caricaDatiDaFile(DataGridView dgv)
        {
            int i = 0; 
            string[] campi = new string[3];

            dgv.Rows.Clear();
            foreach (string row in File.ReadLines("Conti.txt"))
            {
                campi = row.Split(',');
                i = dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = campi[0];
                dgv.Rows[i].Cells[1].Value = campi[1];
                dgv.Rows[i].Cells[2].Value = campi[2];
            }
            lastCode = campi[0];
        }

        internal static void inserisciConto(string contoCorrente, DataGridView dgv)
        {
            lastCode = lastCode.Remove(0, 1);
            int newCode = int.Parse(lastCode) + 1;
            string newConto;
            newConto = "c" + newCode + ",";
            newConto += contoCorrente + ",";
            newConto += "false";
            using (StreamWriter sw = File.AppendText("Conti.txt"))
            {
                sw.WriteLine(newConto);
            }
            caricaDatiDaFile(dgv);
        }

        private static void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 3;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.Columns[0].HeaderText = "Codice";
            dgv.Columns[1].HeaderText = "Conto Corrente (€)";
            dgv.Columns[2].HeaderText = "Prelevato";
        }

        internal static void cancellaConto(int index, DataGridView dgv)
        {
            dgv.Rows.RemoveAt(index);
            scriviDgvSuFile(dgv, "Conti.txt");
            caricaDatiDaFile(dgv);
        }

        private static void scriviDgvSuFile(DataGridView dgv, string name)
        {
            using (StreamWriter sw = new StreamWriter(name, false))
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    string newConto;
                    newConto = dgv.Rows[i].Cells[0].Value + ",";
                    newConto += dgv.Rows[i].Cells[1].Value + ",";
                    newConto += dgv.Rows[i].Cells[2].Value;
                    sw.WriteLine(newConto);
                }
            }
        }

        internal static void modificaConto(string contoCorrente, int index, DataGridView dgv)
        {
            dgv.Rows[index].Cells[1].Value = contoCorrente;
            scriviDgvSuFile(dgv, "Conti.txt");
            caricaDatiDaFile(dgv);
        }

        internal static void assegnaPrestito(string codContoCorrente, string prelievo, DataGridView dgv)
        {
            int i = 0;
            string conto;
            int contoFinale;
            while (dgv.Rows[i].Cells[0].Value.ToString() != codContoCorrente) i++;
            dgv.Rows[i].Cells[2].Value = "true";
            conto = dgv.Rows[i].Cells[1].Value.ToString();
            contoFinale = int.Parse(conto) - int.Parse(prelievo);
            dgv.Rows[i].Cells[1].Value = contoFinale.ToString();
            scriviDgvSuFile(dgv, "Conti.txt");
        }

        internal static void consegnaPrestito(string codConto, DataGridView dgv, string restituzione)
        {
            int i = 0;
            string conto;
            int contoFinale;
            while (dgv.Rows[i].Cells[0].Value.ToString() != codConto) i++;
            dgv.Rows[i].Cells[2].Value = "false";
            conto = dgv.Rows[i].Cells[1].Value.ToString();
            contoFinale = int.Parse(conto) + int.Parse(restituzione);
            dgv.Rows[i].Cells[1].Value = contoFinale.ToString();
            scriviDgvSuFile(dgv, "Conti.txt");
        }
    }
}
