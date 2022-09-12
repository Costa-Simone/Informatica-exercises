using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Esercizio_20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ClsConti.caricaConti(dgvConti);
            ClsCorrentisti.caricaCorrentisti(dgvCorrentisti);
            ClsOperazioni.caricaOperazioni(dgvOperazioni);
        }

        private void btnInserisciConto_Click(object sender, EventArgs e)
        {
            if (txtContoCorrente.Text != "")
            {
                ClsConti.inserisciConto(txtContoCorrente.Text, dgvConti);
                resetCampiConti();
            }
            else
                MessageBox.Show("Compilare i campi");
        }

        private void resetCampiConti()
        {
            txtContoCorrente.Text = "";
            btnInserisciConto.Enabled = true;
            btnCancellaConto.Enabled = true;
            btnModificaConto.Enabled = true;
            btnSalvaConto.Visible = false;
            btnAnnullaConto.Visible = false;
        }

        private void btnCancellaConto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confermi di voler cancellare il conto selezionato?", "ATTENZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClsConti.cancellaConto(dgvConti.SelectedRows[0].Index, dgvConti);
            }
        }

        private void btnModificaConto_Click(object sender, EventArgs e)
        {
            txtContoCorrente.Text= dgvConti.SelectedRows[0].Cells[1].Value.ToString();
            btnInserisciConto.Enabled = false;
            btnCancellaConto.Enabled = false;
            btnModificaConto.Enabled = false;
            btnSalvaConto.Visible = true;
            btnAnnullaConto.Visible = true;
        }

        private void btnSalvaConto_Click(object sender, EventArgs e)
        {
            if (txtContoCorrente.Text != "")
            {
                ClsConti.modificaConto(txtContoCorrente.Text, dgvConti.SelectedRows[0].Index, dgvConti);
                resetCampiConti();
            }
            else
                MessageBox.Show("Compilare i campi");
        }

        private void btnAnnullaConto_Click(object sender, EventArgs e)
        {
            resetCampiConti();
        }

        private void btnInserisciCorrentista_Click(object sender, EventArgs e)
        {
            if (txtCognome.Text != "" && txtNome.Text != "" && txtEmail.Text != "" && txtTelefono.Text != "")
            {
                ClsCorrentisti.inserisciCorrentista(txtCognome.Text, txtNome.Text, txtEmail.Text, txtTelefono.Text, dgvCorrentisti);
                resetCampiCorrentisti();
            }
            else
                MessageBox.Show("Compilare i campi");
        }

        private void resetCampiCorrentisti()
        {
            txtCognome.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            btnInserisciCorrentista.Enabled = true;
            btnCancellaCorrentista.Enabled = true;
            btnModificaCorrentista.Enabled = true;
            btnSalvaCorrentista.Visible = false;
            btnAnnullaCorrentista.Visible = false;
        }

        private void btnCancellaCorrentista_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confermi di voler cancellare il correntista selezionato?", "ATTENZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClsCorrentisti.cancellaCorrentista(dgvCorrentisti.SelectedRows[0].Index, dgvCorrentisti);
            }
        }

        private void btnModificaCorrentista_Click(object sender, EventArgs e)
        {
            txtCognome.Text = dgvCorrentisti.SelectedRows[0].Cells[1].Value.ToString();
            txtNome.Text = dgvCorrentisti.SelectedRows[0].Cells[2].Value.ToString();
            txtEmail.Text = dgvCorrentisti.SelectedRows[0].Cells[3].Value.ToString();
            txtTelefono.Text = dgvCorrentisti.SelectedRows[0].Cells[4].Value.ToString();
            btnInserisciCorrentista.Enabled = false;
            btnCancellaCorrentista.Enabled = false;
            btnModificaCorrentista.Enabled = false;
            btnSalvaCorrentista.Visible = true;
            btnAnnullaCorrentista.Visible = true;
        }

        private void btnSalvaCorrentista_Click(object sender, EventArgs e)
        {
            if (txtCognome.Text != "" && txtNome.Text != "" && txtEmail.Text != "" && txtTelefono.Text != "")
            {
                ClsCorrentisti.modificaCorrentista(txtCognome.Text, txtNome.Text, txtEmail.Text, txtTelefono.Text, dgvCorrentisti.SelectedRows[0].Index, dgvCorrentisti);
                resetCampiCorrentisti();
            }
            else
                MessageBox.Show("Compilare i campi");
        }

        private void btnAnnullaCorrentista_Click(object sender, EventArgs e)
        {
            resetCampiCorrentisti();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab.Name == "tabPageOperazioni")
            {
                ClsOperazioni.caricaCmbCorrentisti(cmbCorrentista, dgvCorrentisti);
                ClsOperazioni.caricaCmbConti(cmbContoCorrente, dgvConti);
            }
        }

        private void btnPrestito_Click(object sender, EventArgs e)
        {
            if (cmbCorrentista.SelectedItem != null && cmbContoCorrente.SelectedItem != null)
            {
                string codCorrentista = cmbCorrentista.SelectedValue.ToString();
                string codContoCorrente = cmbContoCorrente.SelectedValue.ToString();
                string prelievo = Interaction.InputBox("Inserisci il prelievo:");
                ClsOperazioni.inserisciPrestito(codCorrentista, codContoCorrente, prelievo, dgvOperazioni, dgvConti);
                ClsOperazioni.caricaCmbConti(cmbContoCorrente, dgvConti);
            }
            else
            {
                MessageBox.Show("Selezionare Correntista e Conto");
            }
        }

        private void btnRestituzione_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confermi di voler restituire il media selezionato?", "ATTENZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string restituzione = Interaction.InputBox("Inserisci la restituzione:");
                ClsOperazioni.restituisciPrestito(dgvOperazioni.SelectedRows[0].Index, dgvOperazioni, dgvConti, restituzione);
                ClsOperazioni.caricaCmbConti(cmbContoCorrente, dgvConti);
            }
        }
    }
}
