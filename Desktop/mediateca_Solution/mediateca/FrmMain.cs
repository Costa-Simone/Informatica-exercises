using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediateca
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("Compila tutti i campi!");
            }
        }
        private void btnCancellaMedia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confermi di voler cancellare il media selezionato?", "ATTENZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
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
            btnSalva.Visible = true;
            btnAnnulla.Visible = true;
        }
        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            resetCampiMedia();
        }
        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtTitolo.Text != "" && txtAutore.Text != "" && cmbTipo.SelectedItem != null && cmbGenere.SelectedItem != null)
            {
                ClsMedia.modificaMedia(dgvMedia.SelectedRows[0].Index, txtTitolo.Text, txtAutore.Text, cmbTipo.SelectedItem.ToString(), cmbGenere.SelectedItem.ToString(), dgvMedia);
                resetCampiMedia();

            }
            else
            {
                MessageBox.Show("Compila tutti i campi!");
            }
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
        private void btnInserisciSocio_Click(object sender, EventArgs e)
        {
            if (txtCognome.Text != "" && txtNome.Text != "" && txtEmail.Text != "" && txtTelefono.Text != "")
            {
                ClsSoci.inserisciSocio(txtCognome.Text, txtNome.Text, txtEmail.Text, txtTelefono.Text, dgvSoci);
            }
            else
            {
                MessageBox.Show("Compila tutti i campi!");
            }
        }
    }
}
