namespace mediateca
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpMedia = new System.Windows.Forms.TabPage();
            this.dgvMedia = new System.Windows.Forms.DataGridView();
            this.gbComandiMedia = new System.Windows.Forms.GroupBox();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnModificaMedia = new System.Windows.Forms.Button();
            this.btnCancellaMedia = new System.Windows.Forms.Button();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.cmbGenere = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInserisciMedia = new System.Windows.Forms.Button();
            this.tpSoci = new System.Windows.Forms.TabPage();
            this.dgvSoci = new System.Windows.Forms.DataGridView();
            this.gbSoci = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAnnullaS = new System.Windows.Forms.Button();
            this.btnSalvaS = new System.Windows.Forms.Button();
            this.btnModificaSocio = new System.Windows.Forms.Button();
            this.btnCancellaSocio = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.btnInserisciSocio = new System.Windows.Forms.Button();
            this.tpOperazioni = new System.Windows.Forms.TabPage();
            this.dgvOperazioni = new System.Windows.Forms.DataGridView();
            this.gbOperazioni = new System.Windows.Forms.GroupBox();
            this.tcMain.SuspendLayout();
            this.tpMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).BeginInit();
            this.gbComandiMedia.SuspendLayout();
            this.tpSoci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).BeginInit();
            this.gbSoci.SuspendLayout();
            this.tpOperazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperazioni)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMedia);
            this.tcMain.Controls.Add(this.tpSoci);
            this.tcMain.Controls.Add(this.tpOperazioni);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(800, 450);
            this.tcMain.TabIndex = 0;
            // 
            // tpMedia
            // 
            this.tpMedia.Controls.Add(this.dgvMedia);
            this.tpMedia.Controls.Add(this.gbComandiMedia);
            this.tpMedia.Location = new System.Drawing.Point(4, 22);
            this.tpMedia.Name = "tpMedia";
            this.tpMedia.Padding = new System.Windows.Forms.Padding(3);
            this.tpMedia.Size = new System.Drawing.Size(792, 424);
            this.tpMedia.TabIndex = 0;
            this.tpMedia.Text = "Media";
            this.tpMedia.UseVisualStyleBackColor = true;
            // 
            // dgvMedia
            // 
            this.dgvMedia.AllowUserToAddRows = false;
            this.dgvMedia.AllowUserToResizeColumns = false;
            this.dgvMedia.AllowUserToResizeRows = false;
            this.dgvMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedia.Location = new System.Drawing.Point(3, 3);
            this.dgvMedia.Name = "dgvMedia";
            this.dgvMedia.ReadOnly = true;
            this.dgvMedia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedia.Size = new System.Drawing.Size(586, 418);
            this.dgvMedia.TabIndex = 0;
            // 
            // gbComandiMedia
            // 
            this.gbComandiMedia.Controls.Add(this.btnAnnulla);
            this.gbComandiMedia.Controls.Add(this.btnSalva);
            this.gbComandiMedia.Controls.Add(this.btnModificaMedia);
            this.gbComandiMedia.Controls.Add(this.btnCancellaMedia);
            this.gbComandiMedia.Controls.Add(this.txtAutore);
            this.gbComandiMedia.Controls.Add(this.txtTitolo);
            this.gbComandiMedia.Controls.Add(this.cmbGenere);
            this.gbComandiMedia.Controls.Add(this.cmbTipo);
            this.gbComandiMedia.Controls.Add(this.label5);
            this.gbComandiMedia.Controls.Add(this.label4);
            this.gbComandiMedia.Controls.Add(this.label3);
            this.gbComandiMedia.Controls.Add(this.label2);
            this.gbComandiMedia.Controls.Add(this.btnInserisciMedia);
            this.gbComandiMedia.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbComandiMedia.Location = new System.Drawing.Point(589, 3);
            this.gbComandiMedia.Name = "gbComandiMedia";
            this.gbComandiMedia.Size = new System.Drawing.Size(200, 418);
            this.gbComandiMedia.TabIndex = 1;
            this.gbComandiMedia.TabStop = false;
            this.gbComandiMedia.Text = "Comandi";
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(116, 219);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(78, 23);
            this.btnAnnulla.TabIndex = 15;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Visible = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(6, 219);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(78, 23);
            this.btnSalva.TabIndex = 14;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Visible = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnModificaMedia
            // 
            this.btnModificaMedia.Location = new System.Drawing.Point(6, 190);
            this.btnModificaMedia.Name = "btnModificaMedia";
            this.btnModificaMedia.Size = new System.Drawing.Size(188, 23);
            this.btnModificaMedia.TabIndex = 13;
            this.btnModificaMedia.Text = "Modifica Media selezionato";
            this.btnModificaMedia.UseVisualStyleBackColor = true;
            this.btnModificaMedia.Click += new System.EventHandler(this.btnModificaMedia_Click);
            // 
            // btnCancellaMedia
            // 
            this.btnCancellaMedia.Location = new System.Drawing.Point(6, 161);
            this.btnCancellaMedia.Name = "btnCancellaMedia";
            this.btnCancellaMedia.Size = new System.Drawing.Size(188, 23);
            this.btnCancellaMedia.TabIndex = 12;
            this.btnCancellaMedia.Text = "Cancella Media selezionato";
            this.btnCancellaMedia.UseVisualStyleBackColor = true;
            this.btnCancellaMedia.Click += new System.EventHandler(this.btnCancellaMedia_Click);
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(68, 48);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(126, 20);
            this.txtAutore.TabIndex = 11;
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(68, 25);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(126, 20);
            this.txtTitolo.TabIndex = 10;
            // 
            // cmbGenere
            // 
            this.cmbGenere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenere.FormattingEnabled = true;
            this.cmbGenere.Items.AddRange(new object[] {
            "Narrativa",
            "Saggio",
            "Avventura",
            "Gioco"});
            this.cmbGenere.Location = new System.Drawing.Point(68, 94);
            this.cmbGenere.Name = "cmbGenere";
            this.cmbGenere.Size = new System.Drawing.Size(126, 21);
            this.cmbGenere.TabIndex = 8;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "DVD",
            "Libri",
            "CD"});
            this.cmbTipo.Location = new System.Drawing.Point(68, 71);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(126, 21);
            this.cmbTipo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Genere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titolo";
            // 
            // btnInserisciMedia
            // 
            this.btnInserisciMedia.Location = new System.Drawing.Point(6, 121);
            this.btnInserisciMedia.Name = "btnInserisciMedia";
            this.btnInserisciMedia.Size = new System.Drawing.Size(188, 23);
            this.btnInserisciMedia.TabIndex = 0;
            this.btnInserisciMedia.Text = "Inserisci Media";
            this.btnInserisciMedia.UseVisualStyleBackColor = true;
            this.btnInserisciMedia.Click += new System.EventHandler(this.btnInserisciMedia_Click);
            // 
            // tpSoci
            // 
            this.tpSoci.Controls.Add(this.dgvSoci);
            this.tpSoci.Controls.Add(this.gbSoci);
            this.tpSoci.Location = new System.Drawing.Point(4, 22);
            this.tpSoci.Name = "tpSoci";
            this.tpSoci.Padding = new System.Windows.Forms.Padding(3);
            this.tpSoci.Size = new System.Drawing.Size(792, 424);
            this.tpSoci.TabIndex = 1;
            this.tpSoci.Text = "Soci";
            this.tpSoci.UseVisualStyleBackColor = true;
            // 
            // dgvSoci
            // 
            this.dgvSoci.AllowUserToAddRows = false;
            this.dgvSoci.AllowUserToDeleteRows = false;
            this.dgvSoci.AllowUserToOrderColumns = true;
            this.dgvSoci.AllowUserToResizeColumns = false;
            this.dgvSoci.AllowUserToResizeRows = false;
            this.dgvSoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoci.Location = new System.Drawing.Point(3, 3);
            this.dgvSoci.Name = "dgvSoci";
            this.dgvSoci.ReadOnly = true;
            this.dgvSoci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoci.Size = new System.Drawing.Size(586, 418);
            this.dgvSoci.TabIndex = 0;
            // 
            // gbSoci
            // 
            this.gbSoci.Controls.Add(this.txtTelefono);
            this.gbSoci.Controls.Add(this.txtEmail);
            this.gbSoci.Controls.Add(this.btnAnnullaS);
            this.gbSoci.Controls.Add(this.btnSalvaS);
            this.gbSoci.Controls.Add(this.btnModificaSocio);
            this.gbSoci.Controls.Add(this.btnCancellaSocio);
            this.gbSoci.Controls.Add(this.txtNome);
            this.gbSoci.Controls.Add(this.txtCognome);
            this.gbSoci.Controls.Add(this.lblTelefono);
            this.gbSoci.Controls.Add(this.lblEmail);
            this.gbSoci.Controls.Add(this.lblNome);
            this.gbSoci.Controls.Add(this.lblCognome);
            this.gbSoci.Controls.Add(this.btnInserisciSocio);
            this.gbSoci.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbSoci.Location = new System.Drawing.Point(589, 3);
            this.gbSoci.Name = "gbSoci";
            this.gbSoci.Size = new System.Drawing.Size(200, 418);
            this.gbSoci.TabIndex = 1;
            this.gbSoci.TabStop = false;
            this.gbSoci.Text = "Comandi";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(68, 95);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(126, 20);
            this.txtTelefono.TabIndex = 30;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(68, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(126, 20);
            this.txtEmail.TabIndex = 29;
            // 
            // btnAnnullaS
            // 
            this.btnAnnullaS.Location = new System.Drawing.Point(116, 220);
            this.btnAnnullaS.Name = "btnAnnullaS";
            this.btnAnnullaS.Size = new System.Drawing.Size(78, 23);
            this.btnAnnullaS.TabIndex = 28;
            this.btnAnnullaS.Text = "Annulla";
            this.btnAnnullaS.UseVisualStyleBackColor = true;
            this.btnAnnullaS.Visible = false;
            this.btnAnnullaS.Click += new System.EventHandler(this.btnAnnullaS_Click);
            // 
            // btnSalvaS
            // 
            this.btnSalvaS.Location = new System.Drawing.Point(6, 220);
            this.btnSalvaS.Name = "btnSalvaS";
            this.btnSalvaS.Size = new System.Drawing.Size(78, 23);
            this.btnSalvaS.TabIndex = 27;
            this.btnSalvaS.Text = "Salva";
            this.btnSalvaS.UseVisualStyleBackColor = true;
            this.btnSalvaS.Visible = false;
            this.btnSalvaS.Click += new System.EventHandler(this.btnSalvaS_Click);
            // 
            // btnModificaSocio
            // 
            this.btnModificaSocio.Location = new System.Drawing.Point(6, 191);
            this.btnModificaSocio.Name = "btnModificaSocio";
            this.btnModificaSocio.Size = new System.Drawing.Size(188, 23);
            this.btnModificaSocio.TabIndex = 26;
            this.btnModificaSocio.Text = "Modifica Socio selezionato";
            this.btnModificaSocio.UseVisualStyleBackColor = true;
            this.btnModificaSocio.Click += new System.EventHandler(this.btnModificaSocio_Click);
            // 
            // btnCancellaSocio
            // 
            this.btnCancellaSocio.Location = new System.Drawing.Point(6, 162);
            this.btnCancellaSocio.Name = "btnCancellaSocio";
            this.btnCancellaSocio.Size = new System.Drawing.Size(188, 23);
            this.btnCancellaSocio.TabIndex = 25;
            this.btnCancellaSocio.Text = "Cancella Socio selezionato";
            this.btnCancellaSocio.UseVisualStyleBackColor = true;
            this.btnCancellaSocio.Click += new System.EventHandler(this.btnCancellaSocio_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(126, 20);
            this.txtNome.TabIndex = 24;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(68, 26);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(126, 20);
            this.txtCognome.TabIndex = 23;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 95);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 20;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(6, 26);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(52, 13);
            this.lblCognome.TabIndex = 17;
            this.lblCognome.Text = "Cognome";
            // 
            // btnInserisciSocio
            // 
            this.btnInserisciSocio.Location = new System.Drawing.Point(6, 122);
            this.btnInserisciSocio.Name = "btnInserisciSocio";
            this.btnInserisciSocio.Size = new System.Drawing.Size(188, 23);
            this.btnInserisciSocio.TabIndex = 16;
            this.btnInserisciSocio.Text = "Inserisci Socio";
            this.btnInserisciSocio.UseVisualStyleBackColor = true;
            this.btnInserisciSocio.Click += new System.EventHandler(this.btnInserisciSocio_Click);
            // 
            // tpOperazioni
            // 
            this.tpOperazioni.Controls.Add(this.dgvOperazioni);
            this.tpOperazioni.Controls.Add(this.gbOperazioni);
            this.tpOperazioni.Location = new System.Drawing.Point(4, 22);
            this.tpOperazioni.Name = "tpOperazioni";
            this.tpOperazioni.Padding = new System.Windows.Forms.Padding(3);
            this.tpOperazioni.Size = new System.Drawing.Size(792, 424);
            this.tpOperazioni.TabIndex = 2;
            this.tpOperazioni.Text = "Operazioni";
            this.tpOperazioni.UseVisualStyleBackColor = true;
            // 
            // dgvOperazioni
            // 
            this.dgvOperazioni.AllowUserToAddRows = false;
            this.dgvOperazioni.AllowUserToDeleteRows = false;
            this.dgvOperazioni.AllowUserToOrderColumns = true;
            this.dgvOperazioni.AllowUserToResizeColumns = false;
            this.dgvOperazioni.AllowUserToResizeRows = false;
            this.dgvOperazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperazioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOperazioni.Location = new System.Drawing.Point(3, 3);
            this.dgvOperazioni.Name = "dgvOperazioni";
            this.dgvOperazioni.ReadOnly = true;
            this.dgvOperazioni.Size = new System.Drawing.Size(586, 418);
            this.dgvOperazioni.TabIndex = 0;
            // 
            // gbOperazioni
            // 
            this.gbOperazioni.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbOperazioni.Location = new System.Drawing.Point(589, 3);
            this.gbOperazioni.Name = "gbOperazioni";
            this.gbOperazioni.Size = new System.Drawing.Size(200, 418);
            this.gbOperazioni.TabIndex = 1;
            this.gbOperazioni.TabStop = false;
            this.gbOperazioni.Text = "Comandi";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcMain);
            this.Name = "FrmMain";
            this.Text = "Mediateca";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tcMain.ResumeLayout(false);
            this.tpMedia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).EndInit();
            this.gbComandiMedia.ResumeLayout(false);
            this.gbComandiMedia.PerformLayout();
            this.tpSoci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).EndInit();
            this.gbSoci.ResumeLayout(false);
            this.gbSoci.PerformLayout();
            this.tpOperazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperazioni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpMedia;
        private System.Windows.Forms.TabPage tpSoci;
        private System.Windows.Forms.TabPage tpOperazioni;
        private System.Windows.Forms.DataGridView dgvMedia;
        private System.Windows.Forms.GroupBox gbComandiMedia;
        private System.Windows.Forms.DataGridView dgvSoci;
        private System.Windows.Forms.GroupBox gbSoci;
        private System.Windows.Forms.DataGridView dgvOperazioni;
        private System.Windows.Forms.GroupBox gbOperazioni;
        private System.Windows.Forms.Button btnInserisciMedia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.ComboBox cmbGenere;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnCancellaMedia;
        private System.Windows.Forms.Button btnModificaMedia;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnAnnullaS;
        private System.Windows.Forms.Button btnSalvaS;
        private System.Windows.Forms.Button btnModificaSocio;
        private System.Windows.Forms.Button btnCancellaSocio;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Button btnInserisciSocio;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

