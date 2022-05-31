using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Mediateca
{
    public struct Operazione
    {
        public string codOperazione;
        public string codMedia;
        public string codSocio;
        public DateTime dataPrelievo;
        public DateTime dataRestituzione;
    }

    class ClsOperazioni
    {
        public static int nOperazioni;
        public static string lastCode;

        internal static void caricaOperazioni(DataGridView dgv)
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
            dgv.Columns[0].HeaderText = "Cod. Operaz.";
            dgv.Columns[1].HeaderText = "Cod. Media";
            dgv.Columns[2].HeaderText = "Cod. Socio";
            dgv.Columns[3].HeaderText = "Data Prelievo";
            dgv.Columns[4].HeaderText = "Data Restituzione";
        }

        private static void caricaDatiDaFile(DataGridView dgv)
        {
            dgv.Rows.Clear(); int i = 0; string[] fields = new string[5];
            foreach (string row in File.ReadLines("Operazioni.txt"))
            {
                fields = row.Split(',');
                i = dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = fields[0];
                dgv.Rows[i].Cells[1].Value = fields[1];
                dgv.Rows[i].Cells[2].Value = fields[2];
                dgv.Rows[i].Cells[3].Value = DateTime.ParseExact(fields[3], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToShortDateString();
                if (fields[4] == "")
                    dgv.Rows[i].Cells[4].Value = "";
                else
                    dgv.Rows[i].Cells[4].Value = DateTime.ParseExact(fields[4], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToShortDateString();
            }
            lastCode = fields[0];
            nOperazioni = i + 1;
        }

        internal static void caricaComboSoci(ComboBox cmbSocio, DataGridView dgv)
        {
            cmbSocio.DisplayMember = "Text";
            cmbSocio.ValueMember = "Value";
            List<object> items = new List<object>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                items.Add(new
                {
                    Text = row.Cells[2].Value + " " + row.Cells[1].Value,
                    Value = row.Cells[0].Value
                });
            }
            cmbSocio.DataSource = items;
        }

        internal static void caricaComboMedia(ComboBox cmbMedia, DataGridView dgv)
        {
            cmbMedia.DisplayMember = "Text";
            cmbMedia.ValueMember = "Value";
            List<object> items = new List<object>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[5].Value.ToString() == "false")
                {
                    items.Add(new
                    {
                        Text = row.Cells[1].Value,
                        Value = row.Cells[0].Value
                    });
                }
            }
            cmbMedia.DataSource = items;
        }

        internal static void inserisciPrestito(string codSocio, string codMedia, DataGridView dgvOperazioni, DataGridView dgvMedia)
        {
            lastCode = lastCode.Remove(0, 1);
            int newCode = int.Parse(lastCode) + 1;
            string newOperazione;
            newOperazione = "o" + newCode + ",";
            newOperazione += codMedia + ",";
            newOperazione += codSocio + ",";
            newOperazione += DateTime.Now.ToString("dd/MM/yyyy") + ",";
            newOperazione += "";
            ClsMedia.assegnaPrestito(codMedia, dgvMedia);
            using (StreamWriter sw = File.AppendText("Operazioni.txt"))
            {
                sw.WriteLine(newOperazione);
            }
            caricaDatiDaFile(dgvOperazioni);
        }

        internal static void restituisciPrestito(int index, DataGridView dgvOperazioni, DataGridView dgvMedia)
        {
            string codMedia = dgvOperazioni.Rows[index].Cells[1].Value.ToString();
            if (dgvOperazioni.Rows[index].Cells[4].Value.ToString() == "")
            {
                dgvOperazioni.Rows[index].Cells[4].Value = DateTime.Now.ToShortDateString();
                ClsMedia.consegnaPrestito(codMedia, dgvMedia);
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
                MessageBox.Show("Attenzione: media già restituito!");
            }
        }
    }
}
