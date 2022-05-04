using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forza4
{
    public partial class FrmMain : Form
    {
        char[,] f4 = new char[6, 7];
        char turno = ' ';
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            settaDgv(dgvGioco);
        }
        private void settaDgv(DataGridView dgv)
        {
            dgv.ColumnCount = 7;
            dgv.RowCount = 6;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgv.DefaultCellStyle.SelectionForeColor = dgv.DefaultCellStyle.ForeColor;
        }
        private void btnInizio_Click(object sender, EventArgs e)
        {
            turno = 'R';

            foreach (var item in this.Controls)
            {
                if (item.GetType() == sender.GetType()) //funziona perche' sender == button
                {
                    ((Button)item).Enabled = true;
                }
            }

            f4 = new char[6, 7]; //riinizializzare matrice

            pulisciDgv(dgvGioco);
        }
        private void pulisciDgv(DataGridView dgvGioco)
        {
            foreach (DataGridViewRow r in dgvGioco.Rows)
            {
                foreach (DataGridViewCell cell in r.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }
        }
        private void buttonNumeroClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int col = int.Parse(btn.Text) - 1, row = 5;

            while(f4[row, col] != '\0')
            {
                row--;
            }

            if (turno == 'R')
            {
                dgvGioco.Rows[row].Cells[col].Style.BackColor = Color.Red;
                f4[row, col] = 'R';
            }
            else
            {
                dgvGioco.Rows[row].Cells[col].Style.BackColor = Color.Yellow;
                f4[row, col] = 'Y';
            }

            btn.Enabled = row != 0;
            dgvGioco.Rows[row].Cells[col].Selected = false;

            cambioTurno(row, col);
        }
        private void cambioTurno(int row, int col)
        {
            int numUguali = 0;
            //riga
            for (int j = 0; j < 7; j++)
            {
                if (f4[row, j] == turno)
                {
                    numUguali++;

                    if (numUguali == 4)
                    {
                        MessageBox.Show(turno + " ha vinto!");
                        break;
                    }
                }
                else
                {
                    numUguali = 0;
                }
            }
            //colonna
            for (int i = 0; i < 6; i++)
            {
                if (f4[i, col] == turno)
                {
                    numUguali++;

                    if (numUguali == 4)
                    {
                        MessageBox.Show(turno + " ha vinto!");
                        break;
                    }
                }
                else
                {
                    numUguali = 0;
                }
            }
            //diagonale princ
            int k = row, v = col;

            while (k != 0 && v != 0)
            {
                k--;
                v--;
            }

            while (k < 6 && v < 7)
            {
                if (f4[k++, v++] == turno)
                {
                    numUguali++;

                    if (numUguali == 4)
                    {
                        MessageBox.Show(turno + " ha vinto!");
                        break;
                    }
                }
                else
                {
                    numUguali = 0;
                }
            }

            if (turno == 'Y')
            {
                turno = 'R';
            }
            else
            {
                turno = 'Y';
            }
        }
    }
}
