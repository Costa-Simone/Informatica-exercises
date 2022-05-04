
namespace Mediateca
{
    partial class FormMain
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMedia = new System.Windows.Forms.TabPage();
            this.dgvMedia = new System.Windows.Forms.DataGridView();
            this.gbComandiMedia = new System.Windows.Forms.GroupBox();
            this.btnAnnullaMedia = new System.Windows.Forms.Button();
            this.btnSalvaMedia = new System.Windows.Forms.Button();
            this.btnModificaMedia = new System.Windows.Forms.Button();
            this.btnCancellaMedia = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbGenere = new System.Windows.Forms.ComboBox();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInserisciMedia = new System.Windows.Forms.Button();
            this.tabPageSoci = new System.Windows.Forms.TabPage();
            this.dgvSoci = new System.Windows.Forms.DataGridView();
            this.gbComandiSoci = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAnnullaSocio = new System.Windows.Forms.Button();
            this.btnSalvaSocio = new System.Windows.Forms.Button();
            this.btnModificaSocio = new System.Windows.Forms.Button();
            this.btnCancellaSocio = new System.Windows.Forms.Button();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInserisciSocio = new System.Windows.Forms.Button();
            this.tabPageOperazioni = new System.Windows.Forms.TabPage();
            this.dgvOperazioni = new System.Windows.Forms.DataGridView();
            this.gbComandiOperazioni = new System.Windows.Forms.GroupBox();
            this.btnPrestito = new System.Windows.Forms.Button();
            this.cmbMedia = new System.Windows.Forms.ComboBox();
            this.cmbSocio = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRestituisci = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).BeginInit();
            this.gbComandiMedia.SuspendLayout();
            this.tabPageSoci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).BeginInit();
            this.gbComandiSoci.SuspendLayout();
            this.tabPageOperazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperazioni)).BeginInit();
            this.gbComandiOperazioni.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMedia);
            this.tabControlMain.Controls.Add(this.tabPageSoci);
            this.tabControlMain.Controls.Add(this.tabPageOperazioni);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(856, 450);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageMedia
            // 
            this.tabPageMedia.Controls.Add(this.dgvMedia);
            this.tabPageMedia.Controls.Add(this.gbComandiMedia);
            this.tabPageMedia.Location = new System.Drawing.Point(4, 22);
            this.tabPageMedia.Name = "tabPageMedia";
            this.tabPageMedia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedia.Size = new System.Drawing.Size(848, 424);
            this.tabPageMedia.TabIndex = 0;
            this.tabPageMedia.Text = "MEDIA";
            this.tabPageMedia.UseVisualStyleBackColor = true;
            // 
            // dgvMedia
            // 
            this.dgvMedia.AllowUserToAddRows = false;
            this.dgvMedia.AllowUserToDeleteRows = false;
            this.dgvMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedia.Location = new System.Drawing.Point(3, 3);
            this.dgvMedia.Name = "dgvMedia";
            this.dgvMedia.ReadOnly = true;
            this.dgvMedia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedia.Size = new System.Drawing.Size(642, 418);
            this.dgvMedia.TabIndex = 0;
            // 
            // gbComandiMedia
            // 
            this.gbComandiMedia.Controls.Add(this.btnAnnullaMedia);
            this.gbComandiMedia.Controls.Add(this.btnSalvaMedia);
            this.gbComandiMedia.Controls.Add(this.btnModificaMedia);
            this.gbComandiMedia.Controls.Add(this.btnCancellaMedia);
            this.gbComandiMedia.Controls.Add(this.cmbTipo);
            this.gbComandiMedia.Controls.Add(this.cmbGenere);
            this.gbComandiMedia.Controls.Add(this.txtTitolo);
            this.gbComandiMedia.Controls.Add(this.txtAutore);
            this.gbComandiMedia.Controls.Add(this.label5);
            this.gbComandiMedia.Controls.Add(this.label4);
            this.gbComandiMedia.Controls.Add(this.label3);
            this.gbComandiMedia.Controls.Add(this.label2);
            this.gbComandiMedia.Controls.Add(this.btnInserisciMedia);
            this.gbComandiMedia.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbComandiMedia.Location = new System.Drawing.Point(645, 3);
            this.gbComandiMedia.Name = "gbComandiMedia";
            this.gbComandiMedia.Size = new System.Drawing.Size(200, 418);
            this.gbComandiMedia.TabIndex = 1;
            this.gbComandiMedia.TabStop = false;
            this.gbComandiMedia.Text = "COMANDI";
            // 
            // btnAnnullaMedia
            // 
            this.btnAnnullaMedia.Location = new System.Drawing.Point(119, 261);
            this.btnAnnullaMedia.Name = "btnAnnullaMedia";
            this.btnAnnullaMedia.Size = new System.Drawing.Size(75, 23);
            this.btnAnnullaMedia.TabIndex = 13;
            this.btnAnnullaMedia.Text = "ANNULLA";
            this.btnAnnullaMedia.UseVisualStyleBackColor = true;
            this.btnAnnullaMedia.Visible = false;
            this.btnAnnullaMedia.Click += new System.EventHandler(this.btnAnnullaMedia_Click);
            // 
            // btnSalvaMedia
            // 
            this.btnSalvaMedia.Location = new System.Drawing.Point(6, 261);
            this.btnSalvaMedia.Name = "btnSalvaMedia";
            this.btnSalvaMedia.Size = new System.Drawing.Size(75, 23);
            this.btnSalvaMedia.TabIndex = 12;
            this.btnSalvaMedia.Text = "SALVA";
            this.btnSalvaMedia.UseVisualStyleBackColor = true;
            this.btnSalvaMedia.Visible = false;
            this.btnSalvaMedia.Click += new System.EventHandler(this.btnSalvaMedia_Click);
            // 
            // btnModificaMedia
            // 
            this.btnModificaMedia.Location = new System.Drawing.Point(6, 232);
            this.btnModificaMedia.Name = "btnModificaMedia";
            this.btnModificaMedia.Size = new System.Drawing.Size(188, 23);
            this.btnModificaMedia.TabIndex = 11;
            this.btnModificaMedia.Text = "MODIFICA MEDIA SELEZIONATO";
            this.btnModificaMedia.UseVisualStyleBackColor = true;
            this.btnModificaMedia.Click += new System.EventHandler(this.btnModificaMedia_Click);
            // 
            // btnCancellaMedia
            // 
            this.btnCancellaMedia.Location = new System.Drawing.Point(6, 189);
            this.btnCancellaMedia.Name = "btnCancellaMedia";
            this.btnCancellaMedia.Size = new System.Drawing.Size(188, 23);
            this.btnCancellaMedia.TabIndex = 10;
            this.btnCancellaMedia.Text = "CANCELLA MEDIA SELEZIONATO";
            this.btnCancellaMedia.UseVisualStyleBackColor = true;
            this.btnCancellaMedia.Click += new System.EventHandler(this.btnCancellaMedia_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Libro",
            "DVD",
            "CD"});
            this.cmbTipo.Location = new System.Drawing.Point(73, 75);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 9;
            // 
            // cmbGenere
            // 
            this.cmbGenere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenere.FormattingEnabled = true;
            this.cmbGenere.Items.AddRange(new object[] {
            "Narrativa",
            "Saggio",
            "Gioco",
            "Avventura"});
            this.cmbGenere.Location = new System.Drawing.Point(73, 104);
            this.cmbGenere.Name = "cmbGenere";
            this.cmbGenere.Size = new System.Drawing.Size(121, 21);
            this.cmbGenere.TabIndex = 8;
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(94, 19);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtTitolo.TabIndex = 7;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(94, 47);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 20);
            this.txtAutore.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Genere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titolo";
            // 
            // btnInserisciMedia
            // 
            this.btnInserisciMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisciMedia.Location = new System.Drawing.Point(6, 146);
            this.btnInserisciMedia.Name = "btnInserisciMedia";
            this.btnInserisciMedia.Size = new System.Drawing.Size(188, 23);
            this.btnInserisciMedia.TabIndex = 0;
            this.btnInserisciMedia.Text = "INSERISCI MEDIA";
            this.btnInserisciMedia.UseVisualStyleBackColor = true;
            this.btnInserisciMedia.Click += new System.EventHandler(this.btnInserisciMedia_Click);
            // 
            // tabPageSoci
            // 
            this.tabPageSoci.Controls.Add(this.dgvSoci);
            this.tabPageSoci.Controls.Add(this.gbComandiSoci);
            this.tabPageSoci.Location = new System.Drawing.Point(4, 22);
            this.tabPageSoci.Name = "tabPageSoci";
            this.tabPageSoci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSoci.Size = new System.Drawing.Size(848, 424);
            this.tabPageSoci.TabIndex = 1;
            this.tabPageSoci.Text = "SOCI";
            this.tabPageSoci.UseVisualStyleBackColor = true;
            // 
            // dgvSoci
            // 
            this.dgvSoci.AllowUserToAddRows = false;
            this.dgvSoci.AllowUserToDeleteRows = false;
            this.dgvSoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoci.Location = new System.Drawing.Point(3, 3);
            this.dgvSoci.Name = "dgvSoci";
            this.dgvSoci.ReadOnly = true;
            this.dgvSoci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoci.Size = new System.Drawing.Size(642, 418);
            this.dgvSoci.TabIndex = 0;
            // 
            // gbComandiSoci
            // 
            this.gbComandiSoci.Controls.Add(this.txtEmail);
            this.gbComandiSoci.Controls.Add(this.txtTelefono);
            this.gbComandiSoci.Controls.Add(this.btnAnnullaSocio);
            this.gbComandiSoci.Controls.Add(this.btnSalvaSocio);
            this.gbComandiSoci.Controls.Add(this.btnModificaSocio);
            this.gbComandiSoci.Controls.Add(this.btnCancellaSocio);
            this.gbComandiSoci.Controls.Add(this.txtCognome);
            this.gbComandiSoci.Controls.Add(this.txtNome);
            this.gbComandiSoci.Controls.Add(this.label1);
            this.gbComandiSoci.Controls.Add(this.label6);
            this.gbComandiSoci.Controls.Add(this.label7);
            this.gbComandiSoci.Controls.Add(this.label8);
            this.gbComandiSoci.Controls.Add(this.btnInserisciSocio);
            this.gbComandiSoci.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbComandiSoci.Location = new System.Drawing.Point(645, 3);
            this.gbComandiSoci.Name = "gbComandiSoci";
            this.gbComandiSoci.Size = new System.Drawing.Size(200, 418);
            this.gbComandiSoci.TabIndex = 1;
            this.gbComandiSoci.TabStop = false;
            this.gbComandiSoci.Text = "COMANDI";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(94, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 28;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(94, 103);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 27;
            // 
            // btnAnnullaSocio
            // 
            this.btnAnnullaSocio.Location = new System.Drawing.Point(119, 261);
            this.btnAnnullaSocio.Name = "btnAnnullaSocio";
            this.btnAnnullaSocio.Size = new System.Drawing.Size(75, 23);
            this.btnAnnullaSocio.TabIndex = 26;
            this.btnAnnullaSocio.Text = "ANNULLA";
            this.btnAnnullaSocio.UseVisualStyleBackColor = true;
            this.btnAnnullaSocio.Visible = false;
            this.btnAnnullaSocio.Click += new System.EventHandler(this.btnAnnullaSocio_Click);
            // 
            // btnSalvaSocio
            // 
            this.btnSalvaSocio.Location = new System.Drawing.Point(6, 261);
            this.btnSalvaSocio.Name = "btnSalvaSocio";
            this.btnSalvaSocio.Size = new System.Drawing.Size(75, 23);
            this.btnSalvaSocio.TabIndex = 25;
            this.btnSalvaSocio.Text = "SALVA";
            this.btnSalvaSocio.UseVisualStyleBackColor = true;
            this.btnSalvaSocio.Visible = false;
            this.btnSalvaSocio.Click += new System.EventHandler(this.btnSalvaSocio_Click);
            // 
            // btnModificaSocio
            // 
            this.btnModificaSocio.Location = new System.Drawing.Point(6, 232);
            this.btnModificaSocio.Name = "btnModificaSocio";
            this.btnModificaSocio.Size = new System.Drawing.Size(188, 23);
            this.btnModificaSocio.TabIndex = 24;
            this.btnModificaSocio.Text = "MODIFICA SOCIO SELEZIONATO";
            this.btnModificaSocio.UseVisualStyleBackColor = true;
            this.btnModificaSocio.Click += new System.EventHandler(this.btnModificaSocio_Click);
            // 
            // btnCancellaSocio
            // 
            this.btnCancellaSocio.Location = new System.Drawing.Point(6, 189);
            this.btnCancellaSocio.Name = "btnCancellaSocio";
            this.btnCancellaSocio.Size = new System.Drawing.Size(188, 23);
            this.btnCancellaSocio.TabIndex = 23;
            this.btnCancellaSocio.Text = "CANCELLA SOCIO SELEZIONATO";
            this.btnCancellaSocio.UseVisualStyleBackColor = true;
            this.btnCancellaSocio.Click += new System.EventHandler(this.btnCancellaSocio_Click);
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(94, 19);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 20;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(94, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cognome";
            // 
            // btnInserisciSocio
            // 
            this.btnInserisciSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisciSocio.Location = new System.Drawing.Point(6, 146);
            this.btnInserisciSocio.Name = "btnInserisciSocio";
            this.btnInserisciSocio.Size = new System.Drawing.Size(188, 23);
            this.btnInserisciSocio.TabIndex = 14;
            this.btnInserisciSocio.Text = "INSERISCI SOCIO";
            this.btnInserisciSocio.UseVisualStyleBackColor = true;
            this.btnInserisciSocio.Click += new System.EventHandler(this.btnInserisciSocio_Click);
            // 
            // tabPageOperazioni
            // 
            this.tabPageOperazioni.Controls.Add(this.dgvOperazioni);
            this.tabPageOperazioni.Controls.Add(this.gbComandiOperazioni);
            this.tabPageOperazioni.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperazioni.Name = "tabPageOperazioni";
            this.tabPageOperazioni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOperazioni.Size = new System.Drawing.Size(848, 424);
            this.tabPageOperazioni.TabIndex = 2;
            this.tabPageOperazioni.Text = "OPERAZIONI";
            this.tabPageOperazioni.UseVisualStyleBackColor = true;
            // 
            // dgvOperazioni
            // 
            this.dgvOperazioni.AllowUserToAddRows = false;
            this.dgvOperazioni.AllowUserToDeleteRows = false;
            this.dgvOperazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperazioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOperazioni.Location = new System.Drawing.Point(3, 3);
            this.dgvOperazioni.Name = "dgvOperazioni";
            this.dgvOperazioni.ReadOnly = true;
            this.dgvOperazioni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperazioni.Size = new System.Drawing.Size(642, 418);
            this.dgvOperazioni.TabIndex = 0;
            // 
            // gbComandiOperazioni
            // 
            this.gbComandiOperazioni.Controls.Add(this.btnRestituisci);
            this.gbComandiOperazioni.Controls.Add(this.btnPrestito);
            this.gbComandiOperazioni.Controls.Add(this.cmbMedia);
            this.gbComandiOperazioni.Controls.Add(this.cmbSocio);
            this.gbComandiOperazioni.Controls.Add(this.label10);
            this.gbComandiOperazioni.Controls.Add(this.label9);
            this.gbComandiOperazioni.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbComandiOperazioni.Location = new System.Drawing.Point(645, 3);
            this.gbComandiOperazioni.Name = "gbComandiOperazioni";
            this.gbComandiOperazioni.Size = new System.Drawing.Size(200, 418);
            this.gbComandiOperazioni.TabIndex = 1;
            this.gbComandiOperazioni.TabStop = false;
            this.gbComandiOperazioni.Text = "COMANDI";
            // 
            // btnPrestito
            // 
            this.btnPrestito.Location = new System.Drawing.Point(9, 95);
            this.btnPrestito.Name = "btnPrestito";
            this.btnPrestito.Size = new System.Drawing.Size(185, 23);
            this.btnPrestito.TabIndex = 4;
            this.btnPrestito.Text = "PRESTITO";
            this.btnPrestito.UseVisualStyleBackColor = true;
            this.btnPrestito.Click += new System.EventHandler(this.btnPrestito_Click);
            // 
            // cmbMedia
            // 
            this.cmbMedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedia.FormattingEnabled = true;
            this.cmbMedia.Location = new System.Drawing.Point(73, 55);
            this.cmbMedia.Name = "cmbMedia";
            this.cmbMedia.Size = new System.Drawing.Size(121, 21);
            this.cmbMedia.TabIndex = 3;
            // 
            // cmbSocio
            // 
            this.cmbSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSocio.FormattingEnabled = true;
            this.cmbSocio.Location = new System.Drawing.Point(73, 28);
            this.cmbSocio.Name = "cmbSocio";
            this.cmbSocio.Size = new System.Drawing.Size(121, 21);
            this.cmbSocio.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Media";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Socio";
            // 
            // btnRestituisci
            // 
            this.btnRestituisci.Location = new System.Drawing.Point(9, 124);
            this.btnRestituisci.Name = "btnRestituisci";
            this.btnRestituisci.Size = new System.Drawing.Size(185, 23);
            this.btnRestituisci.TabIndex = 5;
            this.btnRestituisci.Text = "RESTITUISCI MEDIA SELEZIONATO";
            this.btnRestituisci.UseVisualStyleBackColor = true;
            this.btnRestituisci.Click += new System.EventHandler(this.btnRestituisci_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEDIATECA";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMedia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).EndInit();
            this.gbComandiMedia.ResumeLayout(false);
            this.gbComandiMedia.PerformLayout();
            this.tabPageSoci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).EndInit();
            this.gbComandiSoci.ResumeLayout(false);
            this.gbComandiSoci.PerformLayout();
            this.tabPageOperazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperazioni)).EndInit();
            this.gbComandiOperazioni.ResumeLayout(false);
            this.gbComandiOperazioni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMedia;
        private System.Windows.Forms.TabPage tabPageSoci;
        private System.Windows.Forms.TabPage tabPageOperazioni;
        private System.Windows.Forms.DataGridView dgvMedia;
        private System.Windows.Forms.GroupBox gbComandiMedia;
        private System.Windows.Forms.DataGridView dgvSoci;
        private System.Windows.Forms.GroupBox gbComandiSoci;
        private System.Windows.Forms.DataGridView dgvOperazioni;
        private System.Windows.Forms.GroupBox gbComandiOperazioni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInserisciMedia;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbGenere;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Button btnCancellaMedia;
        private System.Windows.Forms.Button btnModificaMedia;
        private System.Windows.Forms.Button btnAnnullaMedia;
        private System.Windows.Forms.Button btnSalvaMedia;
        private System.Windows.Forms.Button btnAnnullaSocio;
        private System.Windows.Forms.Button btnSalvaSocio;
        private System.Windows.Forms.Button btnModificaSocio;
        private System.Windows.Forms.Button btnCancellaSocio;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInserisciSocio;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnPrestito;
        private System.Windows.Forms.ComboBox cmbMedia;
        private System.Windows.Forms.ComboBox cmbSocio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRestituisci;
    }
}

