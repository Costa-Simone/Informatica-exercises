namespace Ex09_CollectionLibri
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInserisciLibro = new System.Windows.Forms.Button();
            this.btnCercaTitoloLibro = new System.Windows.Forms.Button();
            this.btnCercaAutoreLibro = new System.Windows.Forms.Button();
            this.btnInserisciDizionario = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo:";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(51, 9);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(134, 20);
            this.txtTitolo.TabIndex = 1;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(51, 35);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(134, 20);
            this.txtAutore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autore:";
            // 
            // btnInserisciLibro
            // 
            this.btnInserisciLibro.Location = new System.Drawing.Point(15, 71);
            this.btnInserisciLibro.Name = "btnInserisciLibro";
            this.btnInserisciLibro.Size = new System.Drawing.Size(72, 40);
            this.btnInserisciLibro.TabIndex = 4;
            this.btnInserisciLibro.Text = "Inserisci libro";
            this.btnInserisciLibro.UseVisualStyleBackColor = true;
            this.btnInserisciLibro.Click += new System.EventHandler(this.btnInserisciLibro_Click);
            // 
            // btnCercaTitoloLibro
            // 
            this.btnCercaTitoloLibro.Location = new System.Drawing.Point(93, 71);
            this.btnCercaTitoloLibro.Name = "btnCercaTitoloLibro";
            this.btnCercaTitoloLibro.Size = new System.Drawing.Size(92, 40);
            this.btnCercaTitoloLibro.TabIndex = 5;
            this.btnCercaTitoloLibro.Text = "Cerca titolo libro";
            this.btnCercaTitoloLibro.UseVisualStyleBackColor = true;
            this.btnCercaTitoloLibro.Click += new System.EventHandler(this.btnCercaTitoloLibro_Click);
            // 
            // btnCercaAutoreLibro
            // 
            this.btnCercaAutoreLibro.Location = new System.Drawing.Point(191, 71);
            this.btnCercaAutoreLibro.Name = "btnCercaAutoreLibro";
            this.btnCercaAutoreLibro.Size = new System.Drawing.Size(92, 40);
            this.btnCercaAutoreLibro.TabIndex = 6;
            this.btnCercaAutoreLibro.Text = "Cerca autore libro";
            this.btnCercaAutoreLibro.UseVisualStyleBackColor = true;
            this.btnCercaAutoreLibro.Click += new System.EventHandler(this.btnCercaAutoreLibro_Click);
            // 
            // btnInserisciDizionario
            // 
            this.btnInserisciDizionario.Location = new System.Drawing.Point(15, 117);
            this.btnInserisciDizionario.Name = "btnInserisciDizionario";
            this.btnInserisciDizionario.Size = new System.Drawing.Size(72, 55);
            this.btnInserisciDizionario.TabIndex = 7;
            this.btnInserisciDizionario.Text = "Inserisci libro in dizionario";
            this.btnInserisciDizionario.UseVisualStyleBackColor = true;
            this.btnInserisciDizionario.Click += new System.EventHandler(this.btnInserisciDizionario_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(93, 117);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(92, 55);
            this.btnVisualizza.TabIndex = 8;
            this.btnVisualizza.Text = "Visualizza dizionario";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 181);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnInserisciDizionario);
            this.Controls.Add(this.btnCercaAutoreLibro);
            this.Controls.Add(this.btnCercaTitoloLibro);
            this.Controls.Add(this.btnInserisciLibro);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInserisciLibro;
        private System.Windows.Forms.Button btnCercaTitoloLibro;
        private System.Windows.Forms.Button btnCercaAutoreLibro;
        private System.Windows.Forms.Button btnInserisciDizionario;
        private System.Windows.Forms.Button btnVisualizza;
    }
}

