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
            if (txtTitolo.Text != "" && txtAutore.Text != "" && cmbTipo.SelectedItem != null && cmbGenere.SelectedItem != null)
            {
                ClsMedia.inserisciMedia(txtTitolo.Text, txtAutore.Text, cmbTipo.SelectedItem.ToString(), cmbGenere.SelectedItem.ToString(), dgvMedia);
                resetCampiMedia();
            }
            else
                MessageBox.Show("Compilare tutti i campi!");
        }
        private void btnCancellaMedia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confermi di voler cancellare il media selezionato?", "ATTENZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClsMedia.cancellaMedia(dgvMedia.SelectedRows[0].Index, dgvMedia);
            }
        }
        private void btnModificaMedia_Click(object sender, EventArgs e)
        {
            Media mediaSelezionato = ClsMedia.medias[dgvMedia.SelectedRows[0].Index];
            txtTitolo.Text = mediaSelezionato.titolo;
            txtAutore.Text = mediaSelezionato.autore;
            cmbTipo.SelectedItem = mediaSelezionato.tipo;
            cmbGenere.SelectedItem = mediaSelezionato.genere;
            btnInserisciMedia.Enabled = false;
            btnCancellaMedia.Enabled = false;
            btnModificaMedia.Enabled = false;
            btnSalvaMedia.Visible = true;
            btnAnnullaMedia.Visible = true;
        }
        private void btnAnnullaMedia_Click(object sender, EventArgs e)
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
            btnSalvaMedia.Visible = false;
            btnAnnullaMedia.Visible = false;
        }
        private void btnSalvaMedia_Click(object sender, EventArgs e)
        {
            if (txtTitolo.Text != "" && txtAutore.Text != "" && cmbTipo.SelectedItem != null && cmbGenere.SelectedItem != null)
            {
                ClsMedia.modificaMedia(txtTitolo.Text, txtAutore.Text, cmbTipo.SelectedItem.ToString(), cmbGenere.SelectedItem.ToString(), dgvMedia.SelectedRows[0].Index, dgvMedia);
                resetCampiMedia();
            }
            else
                MessageBox.Show("Compilare tutti i campi!");
        }
        private void btnInserisciSocio_Click(object sender, EventArgs e)
        {
            if (txtCognome.Text != "" && txtNome.Text != "" && txtEmail.Text != "" && txtTelefono.Text != "")
            {
                ClsSoci.inserisciSocio(txtCognome.Text, txtNome.Text, txtEmail.Text, txtTelefono.Text, dgvSoci);
                resetCampiSocio();
            }
            else
                MessageBox.Show("Compilare tutti i campi!");
        }
        private void btnCancellaSocio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confermi di voler cancellare il socio selezionato?", "ATTENZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClsSoci.cancellaSocio(dgvSoci.SelectedRows[0].Index, dgvSoci);
            }
        }
        private void btnModificaSocio_Click(object sender, EventArgs e)
        {
            Socio socioSelezionato = ClsSoci.soci[dgvSoci.SelectedRows[0].Index];
            txtCognome.Text = socioSelezionato.cognome;
            txtNome.Text = socioSelezionato.nome;
            txtEmail.Text = socioSelezionato.email;
            txtTelefono.Text = socioSelezionato.telefono;
            btnInserisciSocio.Enabled = false;
            btnCancellaSocio.Enabled = false;
            btnModificaSocio.Enabled = false;
            btnSalvaSocio.Visible = true;
            btnAnnullaSocio.Visible = true;
        }
        private void btnSalvaSocio_Click(object sender, EventArgs e)
        {
            if (txtCognome.Text != "" && txtNome.Text != "" && txtEmail.Text != "" && txtTelefono.Text != "")
            {
                ClsSoci.modificaSocio(txtCognome.Text, txtNome.Text, txtEmail.Text, txtTelefono.Text, dgvSoci.SelectedRows[0].Index, dgvSoci);
                resetCampiSocio();
            }
            else
                MessageBox.Show("Compilare tutti i campi!");
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
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab.Name == "tabPageOperazioni")
            {
                ClsOperazioni.caricaCmbSoci(cmbSocio, ClsSoci.soci, ClsSoci.nSoci);
                ClsOperazioni.caricaCmbMedia(cmbMedia, ClsMedia.medias, ClsMedia.nMedia);
            }
        }
        private void btnPrestito_Click(object sender, EventArgs e)
        {
            if (cmbSocio.SelectedItem != null && cmbMedia.SelectedItem != null)
            {
                string codSocio = cmbSocio.SelectedItem.ToString().Split('-')[1];
                string codMedia = cmbMedia.SelectedItem.ToString().Split('-')[1];

                ClsOperazioni.inserisciPrestito(codSocio, codMedia, dgvOperazioni, dgvMedia);
                ClsOperazioni.caricaCmbSoci(cmbSocio, ClsSoci.soci, ClsSoci.nSoci);
                ClsOperazioni.caricaCmbMedia(cmbMedia, ClsMedia.medias, ClsMedia.nMedia);
            }
            else
                MessageBox.Show("Selezionare Socio e Media");
        }
        private void btnRestituisci_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confermi di voler restituire il media selezionato?", "ATTENZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClsOperazioni.restituisciPrestito(dgvOperazioni.SelectedRows[0].Index, dgvOperazioni, dgvMedia);
            }
        }
    }
}
