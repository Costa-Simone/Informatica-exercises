using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediateca
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ClsMedia.caricaMedia(dgvMedia);
            ClsSoci.caricaSoci(dgvSoci);
            ClsOperazioni.caricaOperazioni(dgvOperazioni);
        }

        private void btnInserisciMedia_Click(object sender, EventArgs e)
        {
            if (txtTitolo.Text != "" &&
                txtAutore.Text != "" &&
                cmbTipo.SelectedItem != null &&
                cmbGenere.SelectedItem != null)
            {
                ClsMedia.inserisciMedia(txtTitolo.Text,
                    txtAutore.Text,
                    cmbTipo.SelectedItem.ToString(),
                    cmbGenere.SelectedItem.ToString(),
                    dgvMedia);
                resetCampiMedia();
            }
            else
                MessageBox.Show("Compilare tutti i campi!");
        }

        private void btnCancellaMedia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confermi di voler cancellare il media selezionato?",
                "ATTENZIONE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClsMedia.cancellaMedia(dgvMedia.SelectedRows[0].Index, dgvMedia);
            }
        }

        private void btnModificaMedia_Click(object sender, EventArgs e)
        {
            txtTitolo.Text = dgvMedia.SelectedRows[0].Cells[1].Value.ToString();
            txtAutore.Text = dgvMedia.SelectedRows[0].Cells[2].Value.ToString();
            cmbTipo.SelectedItem = dgvMedia.SelectedRows[0].Cells[3].Value.ToString();
            cmbGenere.SelectedItem = dgvMedia.SelectedRows[0].Cells[4].Value.ToString();
            btnInserisciMedia.Enabled = false;
            btnCancellaMedia.Enabled = false;
            btnModificaMedia.Enabled = false;
            btnSalva.Visible = true;
            btnAnnulla.Visible = true;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            resetCampiMedia();
        }

        private void resetCampiMedia()
        {
            txtTitolo.Text = "";
            txtAutore.Text = "";
            cmbTipo.SelectedItem = null;
            cmbGenere.SelectedItem = null;
            btnInserisciMedia.Enabled = true;
            btnCancellaMedia.Enabled = true;
            btnModificaMedia.Enabled = true;
            btnSalva.Visible = false;
            btnAnnulla.Visible = false;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtTitolo.Text != "" &&
                txtAutore.Text != "" &&
                cmbTipo.SelectedItem != null &&
                cmbGenere.SelectedItem != null)
            {
                ClsMedia.modificaMedia(txtTitolo.Text,
                    txtAutore.Text,
                    cmbTipo.SelectedItem.ToString(),
                    cmbGenere.SelectedItem.ToString(),
                    dgvMedia.SelectedRows[0].Index,
                    dgvMedia);
                resetCampiMedia();
            }
            else
                MessageBox.Show("Compilare tutti i campi!");
        }

        private void btnInserisciSocio_Click(object sender, EventArgs e)
        {
            if (txtCognome.Text != "" &&
                txtNome.Text != "" &&
                txtEmail.Text != null &&
                txtTelefono.Text != null)
            {
                ClsSoci.inserisciSocio(txtCognome.Text,
                    txtNome.Text,
                    txtEmail.Text,
                    txtTelefono.Text,
                    dgvSoci);
                resetCampiSocio();
            }
            else
                MessageBox.Show("Compilare tutti i campi!");
        }

        private void btnCancellaSocio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confermi di voler cancellare il socio selezionato?",
                "ATTENZIONE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClsSoci.cancellaSocio(dgvSoci.SelectedRows[0].Index, dgvSoci);
            }
        }

        private void btnModificaSocio_Click(object sender, EventArgs e)
        {
            txtCognome.Text = dgvSoci.SelectedRows[0].Cells[1].Value.ToString();
            txtNome.Text = dgvSoci.SelectedRows[0].Cells[2].Value.ToString();
            txtEmail.Text = dgvSoci.SelectedRows[0].Cells[3].Value.ToString();
            txtTelefono.Text = dgvSoci.SelectedRows[0].Cells[4].Value.ToString();
            btnInserisciSocio.Enabled = false;
            btnCancellaSocio.Enabled = false;
            btnModificaSocio.Enabled = false;
            btnSalvaSocio.Visible = true;
            btnAnnullaSocio.Visible = true;
        }

        private void btnAnnullaSocio_Click(object sender, EventArgs e)
        {
            resetCampiSocio();
        }

        private void resetCampiSocio()
        {
            txtCognome.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            btnInserisciSocio.Enabled = true;
            btnCancellaSocio.Enabled = true;
            btnModificaSocio.Enabled = true;
            btnSalvaSocio.Visible = false;
            btnAnnullaSocio.Visible = false;
        }

        private void btnSalvaSocio_Click(object sender, EventArgs e)
        {
            if (txtCognome.Text != "" &&
                txtNome.Text != "" &&
                txtEmail.Text != "" &&
                txtTelefono.Text != "")
            {
                ClsSoci.modificaSocio(txtCognome.Text,
                    txtNome.Text,
                    txtEmail.Text,
                    txtTelefono.Text,
                    dgvSoci.SelectedRows[0].Index,
                    dgvSoci);
                resetCampiSocio();
            }
            else
                MessageBox.Show("Compilare tutti i campi!");
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (tabControlMain.SelectedTab.Name == "tabPageOperazioni")
            {
                ClsOperazioni.caricaComboSoci(cmbSocio, dgvSoci);
                ClsOperazioni.caricaComboMedia(cmbMedia, dgvMedia);
            }
        }

        private void btnPrestito_Click(object sender, EventArgs e)
        {
            if (cmbSocio.SelectedItem != null && cmbMedia.SelectedItem != null)
            {
                string codSocio = cmbSocio.SelectedValue.ToString();
                string codMedia = cmbMedia.SelectedValue.ToString();
                ClsOperazioni.inserisciPrestito(codSocio, codMedia, dgvOperazioni, dgvMedia);
                //ClsOperazioni.caricaComboMedia(cmbMedia, ClsMedia.medias, ClsMedia.nMedia);
            }
            else
            {
                MessageBox.Show("Selezionare Socio e Media!");
            }
        }

        private void btnRestituzione_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confermi di voler restituire il media selezionato?",
                "ATTENZIONE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClsOperazioni.restituisciPrestito(dgvOperazioni.SelectedRows[0].Index, dgvOperazioni, dgvMedia);
                //ClsOperazioni.caricaComboMedia(cmbMedia, ClsMedia.medias, ClsMedia.nMedia);
            }
        }
    }
}
