namespace WindowsFormsApp1
{
    partial class Main
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.flpTabs = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnOrganize = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.flpTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.flpTabs);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pnlContent);
            this.scMain.Size = new System.Drawing.Size(1548, 1063);
            this.scMain.SplitterDistance = 211;
            this.scMain.SplitterWidth = 8;
            this.scMain.TabIndex = 0;
            // 
            // flpTabs
            // 
            this.flpTabs.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flpTabs.Controls.Add(this.btnUser);
            this.flpTabs.Controls.Add(this.btnData);
            this.flpTabs.Controls.Add(this.btnOrganize);
            this.flpTabs.Controls.Add(this.btnInfo);
            this.flpTabs.Controls.Add(this.btnAnalyse);
            this.flpTabs.Controls.Add(this.btnCustom);
            this.flpTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTabs.Location = new System.Drawing.Point(0, 0);
            this.flpTabs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flpTabs.Name = "flpTabs";
            this.flpTabs.Size = new System.Drawing.Size(211, 1063);
            this.flpTabs.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Location = new System.Drawing.Point(6, 6);
            this.btnUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(208, 48);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Benutzer";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnData.FlatAppearance.BorderSize = 0;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Location = new System.Drawing.Point(6, 66);
            this.btnData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(208, 48);
            this.btnData.TabIndex = 2;
            this.btnData.Text = "Daten/Zeiten";
            this.btnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnOrganize
            // 
            this.btnOrganize.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOrganize.FlatAppearance.BorderSize = 0;
            this.btnOrganize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganize.Location = new System.Drawing.Point(6, 126);
            this.btnOrganize.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOrganize.Name = "btnOrganize";
            this.btnOrganize.Size = new System.Drawing.Size(208, 48);
            this.btnOrganize.TabIndex = 3;
            this.btnOrganize.Text = "Planen";
            this.btnOrganize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganize.UseVisualStyleBackColor = false;
            this.btnOrganize.Click += new System.EventHandler(this.btnOrganize_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(6, 186);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(208, 48);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Infos";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAnalyse.FlatAppearance.BorderSize = 0;
            this.btnAnalyse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyse.Location = new System.Drawing.Point(6, 246);
            this.btnAnalyse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(208, 48);
            this.btnAnalyse.TabIndex = 5;
            this.btnAnalyse.Text = "Auswertung";
            this.btnAnalyse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalyse.UseVisualStyleBackColor = false;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCustom.FlatAppearance.BorderSize = 0;
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom.Location = new System.Drawing.Point(6, 306);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(208, 48);
            this.btnCustom.TabIndex = 6;
            this.btnCustom.Text = "Benutzerdefiniert";
            this.btnCustom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustom.UseVisualStyleBackColor = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1329, 1063);
            this.pnlContent.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1548, 1063);
            this.Controls.Add(this.scMain);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(1574, 1904);
            this.MinimumSize = new System.Drawing.Size(1574, 704);
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Projektverwaltung";
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.flpTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.FlowLayoutPanel flpTabs;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnOrganize;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Panel pnlContent;
    }
}

