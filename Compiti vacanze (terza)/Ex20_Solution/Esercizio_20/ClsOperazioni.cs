using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Esercizio_20
{
    class ClsOperazioni
    {
        public static string lastCode;

        internal static void caricaCmbCorrentisti(ComboBox cmbCorrentista, DataGridView dgv)
        {
            cmbCorrentista.DisplayMember = "Text";
            cmbCorrentista.ValueMember = "Value";
            List<object> items = new List<object>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                items.Add(new
                {
                    Text = row.Cells[2].Value + " " + row.Cells[1].Value,
                    Value = row.Cells[0].Value
                });
            }
            cmbCorrentista.DataSource = items;
        }

        internal static void caricaOperazioni(DataGridView dgv)
        {
            settaDgv(dgv);
            caricaDatiDaFile(dgv);
        }

        private static void caricaDatiDaFile(DataGridView dgv)
        {
            int i = 0; 
            string[] campi = new string[5];

            dgv.Rows.Clear();
            foreach (string row in File.ReadLines("Operazioni.txt"))
            {
                campi = row.Split(',');
                i = dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = campi[0];
                dgv.Rows[i].Cells[1].Value = campi[1];
                dgv.Rows[i].Cells[2].Value = campi[2];
                dgv.Rows[i].Cells[3].Value = DateTime.ParseExact(campi[3], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToShortDateString();
                if (campi[4] == "")
                    dgv.Rows[i].Cells[4].Value = "";
                else
                    dgv.Rows[i].Cells[4].Value = DateTime.ParseExact(campi[4], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToShortDateString();
            }
            lastCode = campi[0];
        }

        private static void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 5;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.Columns[0].HeaderText = "Cod. Operaz.";
            dgv.Columns[1].HeaderText = "Cod. Conto";
            dgv.Columns[2].HeaderText = "Cod. Correntista";
            dgv.Columns[3].HeaderText = "Data Prelievo";
            dgv.Columns[4].HeaderText = "Data Restituzione";
        }

        internal static void caricaCmbConti(ComboBox cmbContoCorrente, DataGridView dgv)
        {
            cmbContoCorrente.DisplayMember = "Text";
            cmbContoCorrente.ValueMember = "Value";
            List<object> items = new List<object>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[2].Value.ToString() == "false")
                {
                    items.Add(new
                    {
                        Text = row.Cells[1].Value,
                        Value = row.Cells[0].Value
                    });
                }
            }
            cmbContoCorrente.DataSource = items;
        }

        internal static void inserisciPrestito(string codCorrentista, string codContoCorrente, string prelievo, DataGridView dgvOperazioni, DataGridView dgvConti)
        {
            lastCode = lastCode.Remove(0, 1);
            int newCode = int.Parse(lastCode) + 1;
            string newOperazione;
            newOperazione = "o" + newCode + ",";
            newOperazione += codContoCorrente + ",";
            newOperazione += codCorrentista + ",";
            newOperazione += DateTime.Now.ToString("dd/MM/yyyy") + ",";
            newOperazione += "";
            ClsConti.assegnaPrestito(codContoCorrente, prelievo, dgvConti);
            using (StreamWriter sw = File.AppendText("Operazioni.txt"))
            {
                sw.WriteLine(newOperazione);
            }
            caricaDatiDaFile(dgvOperazioni);
        }

        internal static void restituisciPrestito(int index, DataGridView dgvOperazioni, DataGridView dgvConti, string restituzione)
        {
            string codConto = dgvOperazioni.Rows[index].Cells[1].Value.ToString();
            if (dgvOperazioni.Rows[index].Cells[4].Value.ToString() == "")
            {
                dgvOperazioni.Rows[index].Cells[4].Value = DateTime.Now.ToShortDateString();
                ClsConti.consegnaPrestito(codConto, dgvConti, restituzione);
                string textToWrite = "";
                foreach (DataGridViewRow row in dgvOperazioni.Rows)
                {
                    string op;
                    op = row.Cells[0].Value + ",";
                    op += row.Cells[1].Value + ",";
                    op += row.Cells[2].Value + ",";
                    op += row.Cells[3].Value + ",";
                    op += row.Cells[4].Value;
                    textToWrite += op + "\n";
                }
                File.WriteAllText("Operazioni.txt", textToWrite);
                caricaDatiDaFile(dgvOperazioni);
            }
            else
            {
                MessageBox.Show("Attenzione: conto già restituito");
            }
        }
    }
}
