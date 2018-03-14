namespace WCT_Projekt
{
    partial class Portrait
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProfil = new System.Windows.Forms.Label();
            this.pbProfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfil
            // 
            this.lblProfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProfil.Location = new System.Drawing.Point(0, 60);
            this.lblProfil.Margin = new System.Windows.Forms.Padding(0);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(100, 15);
            this.lblProfil.TabIndex = 2;
            this.lblProfil.Text = "Max Mustermann";
            this.lblProfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbProfil
            // 
            this.pbProfil.BackgroundImage = global::WCT_Projekt.Properties.Resources.profile;
            this.pbProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbProfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbProfil.InitialImage = null;
            this.pbProfil.Location = new System.Drawing.Point(0, 0);
            this.pbProfil.Margin = new System.Windows.Forms.Padding(0);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(100, 60);
            this.pbProfil.TabIndex = 1;
            this.pbProfil.TabStop = false;
            // 
            // Portrait
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblProfil);
            this.Controls.Add(this.pbProfil);
            this.Name = "Portrait";
            this.Size = new System.Drawing.Size(100, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbProfil;
        private System.Windows.Forms.Label lblProfil;
    }
}
