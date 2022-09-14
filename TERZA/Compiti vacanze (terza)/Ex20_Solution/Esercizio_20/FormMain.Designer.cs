
namespace Esercizio_20
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
            this.tabPageContiCorrenti = new System.Windows.Forms.TabPage();
            this.dgvConti = new System.Windows.Forms.DataGridView();
            this.gbComandiConti = new System.Windows.Forms.GroupBox();
            this.btnAnnullaConto = new System.Windows.Forms.Button();
            this.btnSalvaConto = new System.Windows.Forms.Button();
            this.btnModificaConto = new System.Windows.Forms.Button();
            this.btnCancellaConto = new System.Windows.Forms.Button();
            this.txtContoCorrente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInserisciConto = new System.Windows.Forms.Button();
            this.tabPageCorrentisti = new System.Windows.Forms.TabPage();
            this.dgvCorrentisti = new System.Windows.Forms.DataGridView();
            this.gbComandiCorrentisti = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAnnullaCorrentista = new System.Windows.Forms.Button();
            this.btnSalvaCorrentista = new System.Windows.Forms.Button();
            this.btnModificaCorrentista = new System.Windows.Forms.Button();
            this.btnCancellaCorrentista = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInserisciCorrentista = new System.Windows.Forms.Button();
            this.tabPageOperazioni = new System.Windows.Forms.TabPage();
            this.dgvOperazioni = new System.Windows.Forms.DataGridView();
            this.gbComandiOperazioni = new System.Windows.Forms.GroupBox();
            this.btnRestituzione = new System.Windows.Forms.Button();
            this.btnPrestito = new System.Windows.Forms.Button();
            this.cmbContoCorrente = new System.Windows.Forms.ComboBox();
            this.cmbCorrentista = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageContiCorrenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConti)).BeginInit();
            this.gbComandiConti.SuspendLayout();
            this.tabPageCorrentisti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrentisti)).BeginInit();
            this.gbComandiCorrentisti.SuspendLayout();
            this.tabPageOperazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperazioni)).BeginInit();
            this.gbComandiOperazioni.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageContiCorrenti);
            this.tabControlMain.Controls.Add(this.tabPageCorrentisti);
            this.tabControlMain.Controls.Add(this.tabPageOperazioni);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 450);
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageContiCorrenti
            // 
            this.tabPageContiCorrenti.Controls.Add(this.dgvConti);
            this.tabPageContiCorrenti.Controls.Add(this.gbComandiConti);
            this.tabPageContiCorrenti.Location = new System.Drawing.Point(4, 22);
            this.tabPageContiCorrenti.Name = "tabPageContiCorrenti";
            this.tabPageContiCorrenti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContiCorrenti.Size = new System.Drawing.Size(792, 424);
            this.tabPageContiCorrenti.TabIndex = 0;
            this.tabPageContiCorrenti.Text = "Conti Correnti";
            this.tabPageContiCorrenti.UseVisualStyleBackColor = true;
            // 
            // dgvConti
            // 
            this.dgvConti.AllowUserToAddRows = false;
            this.dgvConti.AllowUserToDeleteRows = false;
            this.dgvConti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConti.Location = new System.Drawing.Point(3, 3);
            this.dgvConti.Name = "dgvConti";
            this.dgvConti.ReadOnly = true;
            this.dgvConti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConti.Size = new System.Drawing.Size(586, 418);
            this.dgvConti.TabIndex = 0;
            // 
            // gbComandiConti
            // 
            this.gbComandiConti.Controls.Add(this.btnAnnullaConto);
            this.gbComandiConti.Controls.Add(this.btnSalvaConto);
            this.gbComandiConti.Controls.Add(this.btnModificaConto);
            this.gbComandiConti.Controls.Add(this.btnCancellaConto);
            this.gbComandiConti.Controls.Add(this.txtContoCorrente);
            this.gbComandiConti.Controls.Add(this.label2);
            this.gbComandiConti.Controls.Add(this.btnInserisciConto);
            this.gbComandiConti.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbComandiConti.Location = new System.Drawing.Point(589, 3);
            this.gbComandiConti.Name = "gbComandiConti";
            this.gbComandiConti.Size = new System.Drawing.Size(200, 418);
            this.gbComandiConti.TabIndex = 1;
            this.gbComandiConti.TabStop = false;
            this.gbComandiConti.Text = "Comandi";
            // 
            // btnAnnullaConto
            // 
            this.btnAnnullaConto.Location = new System.Drawing.Point(119, 200);
            this.btnAnnullaConto.Name = "btnAnnullaConto";
            this.btnAnnullaConto.Size = new System.Drawing.Size(75, 23);
            this.btnAnnullaConto.TabIndex = 12;
            this.btnAnnullaConto.Text = "Annulla";
            this.btnAnnullaConto.UseVisualStyleBackColor = true;
            this.btnAnnullaConto.Visible = false;
            this.btnAnnullaConto.Click += new System.EventHandler(this.btnAnnullaConto_Click);
            // 
            // btnSalvaConto
            // 
            this.btnSalvaConto.Location = new System.Drawing.Point(6, 200);
            this.btnSalvaConto.Name = "btnSalvaConto";
            this.btnSalvaConto.Size = new System.Drawing.Size(75, 23);
            this.btnSalvaConto.TabIndex = 11;
            this.btnSalvaConto.Text = "Salva";
            this.btnSalvaConto.UseVisualStyleBackColor = true;
            this.btnSalvaConto.Visible = false;
            this.btnSalvaConto.Click += new System.EventHandler(this.btnSalvaConto_Click);
            // 
            // btnModificaConto
            // 
            this.btnModificaConto.Location = new System.Drawing.Point(6, 157);
            this.btnModificaConto.Name = "btnModificaConto";
            this.btnModificaConto.Size = new System.Drawing.Size(188, 23);
            this.btnModificaConto.TabIndex = 10;
            this.btnModificaConto.Text = "Modifica Conto Selezionato";
            this.btnModificaConto.UseVisualStyleBackColor = true;
            this.btnModificaConto.Click += new System.EventHandler(this.btnModificaConto_Click);
            // 
            // btnCancellaConto
            // 
            this.btnCancellaConto.Location = new System.Drawing.Point(6, 115);
            this.btnCancellaConto.Name = "btnCancellaConto";
            this.btnCancellaConto.Size = new System.Drawing.Size(188, 23);
            this.btnCancellaConto.TabIndex = 2;
            this.btnCancellaConto.Text = "Cancella Conto Selezionato";
            this.btnCancellaConto.UseVisualStyleBackColor = true;
            this.btnCancellaConto.Click += new System.EventHandler(this.btnCancellaConto_Click);
            // 
            // txtContoCorrente
            // 
            this.txtContoCorrente.Location = new System.Drawing.Point(86, 27);
            this.txtContoCorrente.Name = "txtContoCorrente";
            this.txtContoCorrente.Size = new System.Drawing.Size(108, 20);
            this.txtContoCorrente.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conto corrente";
            // 
            // btnInserisciConto
            // 
            this.btnInserisciConto.Location = new System.Drawing.Point(6, 73);
            this.btnInserisciConto.Name = "btnInserisciConto";
            this.btnInserisciConto.Size = new System.Drawing.Size(188, 23);
            this.btnInserisciConto.TabIndex = 0;
            this.btnInserisciConto.Text = "Inserisci Conto";
            this.btnInserisciConto.UseVisualStyleBackColor = true;
            this.btnInserisciConto.Click += new System.EventHandler(this.btnInserisciConto_Click);
            // 
            // tabPageCorrentisti
            // 
            this.tabPageCorrentisti.Controls.Add(this.dgvCorrentisti);
            this.tabPageCorrentisti.Controls.Add(this.gbComandiCorrentisti);
            this.tabPageCorrentisti.Location = new System.Drawing.Point(4, 22);
            this.tabPageCorrentisti.Name = "tabPageCorrentisti";
            this.tabPageCorrentisti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCorrentisti.Size = new System.Drawing.Size(792, 424);
            this.tabPageCorrentisti.TabIndex = 1;
            this.tabPageCorrentisti.Text = "Correntisti";
            this.tabPageCorrentisti.UseVisualStyleBackColor = true;
            // 
            // dgvCorrentisti
            // 
            this.dgvCorrentisti.AllowUserToAddRows = false;
            this.dgvCorrentisti.AllowUserToDeleteRows = false;
            this.dgvCorrentisti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrentisti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCorrentisti.Location = new System.Drawing.Point(3, 3);
            this.dgvCorrentisti.Name = "dgvCorrentisti";
            this.dgvCorrentisti.ReadOnly = true;
            this.dgvCorrentisti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCorrentisti.Size = new System.Drawing.Size(586, 418);
            this.dgvCorrentisti.TabIndex = 1;
            // 
            // gbComandiCorrentisti
            // 
            this.gbComandiCorrentisti.Controls.Add(this.txtTelefono);
            this.gbComandiCorrentisti.Controls.Add(this.txtEmail);
            this.gbComandiCorrentisti.Controls.Add(this.btnAnnullaCorrentista);
            this.gbComandiCorrentisti.Controls.Add(this.btnSalvaCorrentista);
            this.gbComandiCorrentisti.Controls.Add(this.btnModificaCorrentista);
            this.gbComandiCorrentisti.Controls.Add(this.btnCancellaCorrentista);
            this.gbComandiCorrentisti.Controls.Add(this.txtNome);
            this.gbComandiCorrentisti.Controls.Add(this.txtCognome);
            this.gbComandiCorrentisti.Controls.Add(this.label1);
            this.gbComandiCorrentisti.Controls.Add(this.label6);
            this.gbComandiCorrentisti.Controls.Add(this.label7);
            this.gbComandiCorrentisti.Controls.Add(this.label8);
            this.gbComandiCorrentisti.Controls.Add(this.btnInserisciCorrentista);
            this.gbComandiCorrentisti.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbComandiCorrentisti.Location = new System.Drawing.Point(589, 3);
            this.gbComandiCorrentisti.Name = "gbComandiCorrentisti";
            this.gbComandiCorrentisti.Size = new System.Drawing.Size(200, 418);
            this.gbComandiCorrentisti.TabIndex = 0;
            this.gbComandiCorrentisti.TabStop = false;
            this.gbComandiCorrentisti.Text = "Comandi";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(62, 127);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(134, 20);
            this.txtTelefono.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(62, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(134, 20);
            this.txtEmail.TabIndex = 26;
            // 
            // btnAnnullaCorrentista
            // 
            this.btnAnnullaCorrentista.Location = new System.Drawing.Point(121, 294);
            this.btnAnnullaCorrentista.Name = "btnAnnullaCorrentista";
            this.btnAnnullaCorrentista.Size = new System.Drawing.Size(75, 23);
            this.btnAnnullaCorrentista.TabIndex = 25;
            this.btnAnnullaCorrentista.Text = "Annulla";
            this.btnAnnullaCorrentista.UseVisualStyleBackColor = true;
            this.btnAnnullaCorrentista.Visible = false;
            this.btnAnnullaCorrentista.Click += new System.EventHandler(this.btnAnnullaCorrentista_Click);
            // 
            // btnSalvaCorrentista
            // 
            this.btnSalvaCorrentista.Location = new System.Drawing.Point(8, 294);
            this.btnSalvaCorrentista.Name = "btnSalvaCorrentista";
            this.btnSalvaCorrentista.Size = new System.Drawing.Size(75, 23);
            this.btnSalvaCorrentista.TabIndex = 24;
            this.btnSalvaCorrentista.Text = "Salva";
            this.btnSalvaCorrentista.UseVisualStyleBackColor = true;
            this.btnSalvaCorrentista.Visible = false;
            this.btnSalvaCorrentista.Click += new System.EventHandler(this.btnSalvaCorrentista_Click);
            // 
            // btnModificaCorrentista
            // 
            this.btnModificaCorrentista.Location = new System.Drawing.Point(8, 251);
            this.btnModificaCorrentista.Name = "btnModificaCorrentista";
            this.btnModificaCorrentista.Size = new System.Drawing.Size(188, 23);
            this.btnModificaCorrentista.TabIndex = 23;
            this.btnModificaCorrentista.Text = "Modifica Correntista Selezionato";
            this.btnModificaCorrentista.UseVisualStyleBackColor = true;
            this.btnModificaCorrentista.Click += new System.EventHandler(this.btnModificaCorrentista_Click);
            // 
            // btnCancellaCorrentista
            // 
            this.btnCancellaCorrentista.Location = new System.Drawing.Point(8, 209);
            this.btnCancellaCorrentista.Name = "btnCancellaCorrentista";
            this.btnCancellaCorrentista.Size = new System.Drawing.Size(188, 23);
            this.btnCancellaCorrentista.TabIndex = 14;
            this.btnCancellaCorrentista.Text = "Cancella Correntista Selezionato";
            this.btnCancellaCorrentista.UseVisualStyleBackColor = true;
            this.btnCancellaCorrentista.Click += new System.EventHandler(this.btnCancellaCorrentista_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(134, 20);
            this.txtNome.TabIndex = 20;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(62, 31);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(134, 20);
            this.txtCognome.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cognome";
            // 
            // btnInserisciCorrentista
            // 
            this.btnInserisciCorrentista.Location = new System.Drawing.Point(8, 167);
            this.btnInserisciCorrentista.Name = "btnInserisciCorrentista";
            this.btnInserisciCorrentista.Size = new System.Drawing.Size(188, 23);
            this.btnInserisciCorrentista.TabIndex = 13;
            this.btnInserisciCorrentista.Text = "Inserisci Correntista";
            this.btnInserisciCorrentista.UseVisualStyleBackColor = true;
            this.btnInserisciCorrentista.Click += new System.EventHandler(this.btnInserisciCorrentista_Click);
            // 
            // tabPageOperazioni
            // 
            this.tabPageOperazioni.Controls.Add(this.dgvOperazioni);
            this.tabPageOperazioni.Controls.Add(this.gbComandiOperazioni);
            this.tabPageOperazioni.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperazioni.Name = "tabPageOperazioni";
            this.tabPageOperazioni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOperazioni.Size = new System.Drawing.Size(792, 424);
            this.tabPageOperazioni.TabIndex = 2;
            this.tabPageOperazioni.Text = "Operazioni";
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
            this.dgvOperazioni.Size = new System.Drawing.Size(586, 418);
            this.dgvOperazioni.TabIndex = 1;
            // 
            // gbComandiOperazioni
            // 
            this.gbComandiOperazioni.Controls.Add(this.btnRestituzione);
            this.gbComandiOperazioni.Controls.Add(this.btnPrestito);
            this.gbComandiOperazioni.Controls.Add(this.cmbContoCorrente);
            this.gbComandiOperazioni.Controls.Add(this.cmbCorrentista);
            this.gbComandiOperazioni.Controls.Add(this.label10);
            this.gbComandiOperazioni.Controls.Add(this.label9);
            this.gbComandiOperazioni.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbComandiOperazioni.Location = new System.Drawing.Point(589, 3);
            this.gbComandiOperazioni.Name = "gbComandiOperazioni";
            this.gbComandiOperazioni.Size = new System.Drawing.Size(200, 418);
            this.gbComandiOperazioni.TabIndex = 0;
            this.gbComandiOperazioni.TabStop = false;
            this.gbComandiOperazioni.Text = "Comandi";
            // 
            // btnRestituzione
            // 
            this.btnRestituzione.Location = new System.Drawing.Point(9, 197);
            this.btnRestituzione.Name = "btnRestituzione";
            this.btnRestituzione.Size = new System.Drawing.Size(185, 23);
            this.btnRestituzione.TabIndex = 5;
            this.btnRestituzione.Text = "Restituisci Prelievo Selezionato";
            this.btnRestituzione.UseVisualStyleBackColor = true;
            this.btnRestituzione.Click += new System.EventHandler(this.btnRestituzione_Click);
            // 
            // btnPrestito
            // 
            this.btnPrestito.Location = new System.Drawing.Point(9, 112);
            this.btnPrestito.Name = "btnPrestito";
            this.btnPrestito.Size = new System.Drawing.Size(186, 23);
            this.btnPrestito.TabIndex = 4;
            this.btnPrestito.Text = "Prelievo";
            this.btnPrestito.UseVisualStyleBackColor = true;
            this.btnPrestito.Click += new System.EventHandler(this.btnPrestito_Click);
            // 
            // cmbContoCorrente
            // 
            this.cmbContoCorrente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContoCorrente.FormattingEnabled = true;
            this.cmbContoCorrente.Location = new System.Drawing.Point(89, 69);
            this.cmbContoCorrente.Name = "cmbContoCorrente";
            this.cmbContoCorrente.Size = new System.Drawing.Size(105, 21);
            this.cmbContoCorrente.TabIndex = 3;
            // 
            // cmbCorrentista
            // 
            this.cmbCorrentista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCorrentista.FormattingEnabled = true;
            this.cmbCorrentista.Location = new System.Drawing.Point(89, 31);
            this.cmbCorrentista.Name = "cmbCorrentista";
            this.cmbCorrentista.Size = new System.Drawing.Size(105, 21);
            this.cmbCorrentista.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Conto corrente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Correntista";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANAGRAFE BANCARIA";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageContiCorrenti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConti)).EndInit();
            this.gbComandiConti.ResumeLayout(false);
            this.gbComandiConti.PerformLayout();
            this.tabPageCorrentisti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrentisti)).EndInit();
            this.gbComandiCorrentisti.ResumeLayout(false);
            this.gbComandiCorrentisti.PerformLayout();
            this.tabPageOperazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperazioni)).EndInit();
            this.gbComandiOperazioni.ResumeLayout(false);
            this.gbComandiOperazioni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageContiCorrenti;
        private System.Windows.Forms.DataGridView dgvConti;
        private System.Windows.Forms.GroupBox gbComandiConti;
        private System.Windows.Forms.Button btnAnnullaConto;
        private System.Windows.Forms.Button btnSalvaConto;
        private System.Windows.Forms.Button btnModificaConto;
        private System.Windows.Forms.Button btnCancellaConto;
        private System.Windows.Forms.TextBox txtContoCorrente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInserisciConto;
        private System.Windows.Forms.TabPage tabPageCorrentisti;
        private System.Windows.Forms.DataGridView dgvCorrentisti;
        private System.Windows.Forms.GroupBox gbComandiCorrentisti;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAnnullaCorrentista;
        private System.Windows.Forms.Button btnSalvaCorrentista;
        private System.Windows.Forms.Button btnModificaCorrentista;
        private System.Windows.Forms.Button btnCancellaCorrentista;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInserisciCorrentista;
        private System.Windows.Forms.TabPage tabPageOperazioni;
        private System.Windows.Forms.DataGridView dgvOperazioni;
        private System.Windows.Forms.GroupBox gbComandiOperazioni;
        private System.Windows.Forms.Button btnRestituzione;
        private System.Windows.Forms.Button btnPrestito;
        private System.Windows.Forms.ComboBox cmbContoCorrente;
        private System.Windows.Forms.ComboBox cmbCorrentista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

