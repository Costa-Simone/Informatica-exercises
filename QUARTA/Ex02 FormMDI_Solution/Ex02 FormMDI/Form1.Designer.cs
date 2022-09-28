namespace Ex02_FormMDI
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
            this.btnApriFiglia1 = new System.Windows.Forms.Button();
            this.btnApriFiglia2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFinestra1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFinestra2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApriFiglia1
            // 
            this.btnApriFiglia1.Location = new System.Drawing.Point(12, 41);
            this.btnApriFiglia1.Name = "btnApriFiglia1";
            this.btnApriFiglia1.Size = new System.Drawing.Size(75, 23);
            this.btnApriFiglia1.TabIndex = 1;
            this.btnApriFiglia1.Text = "Apri figlia 1";
            this.btnApriFiglia1.UseVisualStyleBackColor = true;
            this.btnApriFiglia1.Click += new System.EventHandler(this.btnApriFiglia1_Click);
            // 
            // btnApriFiglia2
            // 
            this.btnApriFiglia2.Location = new System.Drawing.Point(93, 41);
            this.btnApriFiglia2.Name = "btnApriFiglia2";
            this.btnApriFiglia2.Size = new System.Drawing.Size(75, 23);
            this.btnApriFiglia2.TabIndex = 2;
            this.btnApriFiglia2.Text = "Apri figlia 2";
            this.btnApriFiglia2.UseVisualStyleBackColor = true;
            this.btnApriFiglia2.Click += new System.EventHandler(this.btnApriFiglia2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriFinestra1ToolStripMenuItem,
            this.apriFinestra2ToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "&Menu\'";
            // 
            // apriFinestra1ToolStripMenuItem
            // 
            this.apriFinestra1ToolStripMenuItem.Name = "apriFinestra1ToolStripMenuItem";
            this.apriFinestra1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apriFinestra1ToolStripMenuItem.Text = "Apri finestra &1";
            this.apriFinestra1ToolStripMenuItem.Click += new System.EventHandler(this.btnApriFiglia1_Click);
            // 
            // apriFinestra2ToolStripMenuItem
            // 
            this.apriFinestra2ToolStripMenuItem.Name = "apriFinestra2ToolStripMenuItem";
            this.apriFinestra2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apriFinestra2ToolStripMenuItem.Text = "Apri finestra &2";
            this.apriFinestra2ToolStripMenuItem.Click += new System.EventHandler(this.btnApriFiglia2_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 349);
            this.Controls.Add(this.btnApriFiglia2);
            this.Controls.Add(this.btnApriFiglia1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApriFiglia1;
        private System.Windows.Forms.Button btnApriFiglia2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriFinestra1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriFinestra2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
    }
}

