namespace Merge
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
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.dgvC = new System.Windows.Forms.DataGridView();
            this.btnMerge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvA
            // 
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(12, 117);
            this.dgvA.Name = "dgvA";
            this.dgvA.Size = new System.Drawing.Size(100, 215);
            this.dgvA.TabIndex = 0;
            // 
            // dgvB
            // 
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.Location = new System.Drawing.Point(118, 117);
            this.dgvB.Name = "dgvB";
            this.dgvB.Size = new System.Drawing.Size(100, 215);
            this.dgvB.TabIndex = 1;
            // 
            // dgvC
            // 
            this.dgvC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC.Location = new System.Drawing.Point(224, 117);
            this.dgvC.Name = "dgvC";
            this.dgvC.Size = new System.Drawing.Size(100, 215);
            this.dgvC.TabIndex = 2;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(12, 72);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(312, 23);
            this.btnMerge.TabIndex = 3;
            this.btnMerge.Text = "MERGE CON TAPPO";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.dgvC);
            this.Controls.Add(this.dgvB);
            this.Controls.Add(this.dgvA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.DataGridView dgvC;
        private System.Windows.Forms.Button btnMerge;
    }
}

