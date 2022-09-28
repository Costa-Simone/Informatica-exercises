namespace Ex01_WindowsForms
{
    partial class F5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAzzera = new System.Windows.Forms.Button();
            this.btnLeggi = new System.Windows.Forms.Button();
            this.btnFormFiglia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAzzera
            // 
            this.btnAzzera.Location = new System.Drawing.Point(12, 12);
            this.btnAzzera.Name = "btnAzzera";
            this.btnAzzera.Size = new System.Drawing.Size(108, 23);
            this.btnAzzera.TabIndex = 0;
            this.btnAzzera.Text = "Azzera messaggio";
            this.btnAzzera.UseVisualStyleBackColor = true;
            this.btnAzzera.Click += new System.EventHandler(this.btnAzzera_Click);
            // 
            // btnLeggi
            // 
            this.btnLeggi.Location = new System.Drawing.Point(126, 12);
            this.btnLeggi.Name = "btnLeggi";
            this.btnLeggi.Size = new System.Drawing.Size(108, 23);
            this.btnLeggi.TabIndex = 1;
            this.btnLeggi.Text = "Leggi messaggio";
            this.btnLeggi.UseVisualStyleBackColor = true;
            this.btnLeggi.Click += new System.EventHandler(this.btnLeggi_Click);
            // 
            // btnFormFiglia
            // 
            this.btnFormFiglia.Location = new System.Drawing.Point(12, 41);
            this.btnFormFiglia.Name = "btnFormFiglia";
            this.btnFormFiglia.Size = new System.Drawing.Size(108, 23);
            this.btnFormFiglia.TabIndex = 2;
            this.btnFormFiglia.Text = "Apri form figlia";
            this.btnFormFiglia.UseVisualStyleBackColor = true;
            this.btnFormFiglia.Click += new System.EventHandler(this.btnFormFiglia_Click);
            // 
            // F5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 93);
            this.Controls.Add(this.btnFormFiglia);
            this.Controls.Add(this.btnLeggi);
            this.Controls.Add(this.btnAzzera);
            this.Name = "F5";
            this.Text = "F5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAzzera;
        private System.Windows.Forms.Button btnLeggi;
        private System.Windows.Forms.Button btnFormFiglia;
    }
}