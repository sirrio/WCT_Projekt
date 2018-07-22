namespace WCT_Projekt
{
    partial class Custom
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
            this.pnlSample = new System.Windows.Forms.Panel();
            this.btnSample = new System.Windows.Forms.Button();
            this.ctrText = new System.Windows.Forms.TextBox();
            this.txtSample = new System.Windows.Forms.Button();
            this.lblSample = new System.Windows.Forms.Button();
            this.crtGuid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxMulti = new System.Windows.Forms.CheckBox();
            this.lblMulti = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrSizeWidth = new System.Windows.Forms.NumericUpDown();
            this.ctrSizeHeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ctrSizeWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrSizeHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSample
            // 
            this.pnlSample.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlSample.Location = new System.Drawing.Point(3, 3);
            this.pnlSample.Name = "pnlSample";
            this.pnlSample.Size = new System.Drawing.Size(1067, 265);
            this.pnlSample.TabIndex = 0;
            // 
            // btnSample
            // 
            this.btnSample.Location = new System.Drawing.Point(3, 274);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(75, 23);
            this.btnSample.TabIndex = 1;
            this.btnSample.Text = "btnSample";
            this.btnSample.UseVisualStyleBackColor = true;
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);
            // 
            // ctrText
            // 
            this.ctrText.BackColor = System.Drawing.SystemColors.Window;
            this.ctrText.Location = new System.Drawing.Point(59, 351);
            this.ctrText.Name = "ctrText";
            this.ctrText.Size = new System.Drawing.Size(133, 20);
            this.ctrText.TabIndex = 2;
            // 
            // txtSample
            // 
            this.txtSample.Location = new System.Drawing.Point(84, 274);
            this.txtSample.Name = "txtSample";
            this.txtSample.Size = new System.Drawing.Size(75, 23);
            this.txtSample.TabIndex = 5;
            this.txtSample.Text = "txtSample";
            this.txtSample.UseVisualStyleBackColor = true;
            this.txtSample.Click += new System.EventHandler(this.txtSample_Click);
            // 
            // lblSample
            // 
            this.lblSample.Location = new System.Drawing.Point(165, 274);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(75, 23);
            this.lblSample.TabIndex = 6;
            this.lblSample.Text = "lblSample";
            this.lblSample.UseVisualStyleBackColor = true;
            this.lblSample.Click += new System.EventHandler(this.lblSample_Click);
            // 
            // crtGuid
            // 
            this.crtGuid.BackColor = System.Drawing.SystemColors.Window;
            this.crtGuid.Enabled = false;
            this.crtGuid.Location = new System.Drawing.Point(59, 325);
            this.crtGuid.Name = "crtGuid";
            this.crtGuid.Size = new System.Drawing.Size(133, 20);
            this.crtGuid.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "GUID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Text";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(59, 424);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Maske 1",
            "Maske 2"});
            this.comboBox1.Location = new System.Drawing.Point(434, 274);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Maske 1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Neue Maske";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbxMulti
            // 
            this.cbxMulti.AutoSize = true;
            this.cbxMulti.Location = new System.Drawing.Point(59, 404);
            this.cbxMulti.Name = "cbxMulti";
            this.cbxMulti.Size = new System.Drawing.Size(15, 14);
            this.cbxMulti.TabIndex = 18;
            this.cbxMulti.UseVisualStyleBackColor = true;
            this.cbxMulti.Visible = false;
            this.cbxMulti.Click += new System.EventHandler(this.cbxMulti_Click);
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.Location = new System.Drawing.Point(4, 404);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(45, 13);
            this.lblMulti.TabIndex = 14;
            this.lblMulti.Text = "Multiline";
            this.lblMulti.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Groesse";
            // 
            // txtSizeX
            // 
            this.ctrSizeWidth.Location = new System.Drawing.Point(59, 377);
            this.ctrSizeWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ctrSizeWidth.Name = "txtSizeX";
            this.ctrSizeWidth.Size = new System.Drawing.Size(60, 20);
            this.ctrSizeWidth.TabIndex = 22;
            // 
            // txtSizeY
            // 
            this.ctrSizeHeight.Location = new System.Drawing.Point(132, 377);
            this.ctrSizeHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ctrSizeHeight.Name = "txtSizeY";
            this.ctrSizeHeight.Size = new System.Drawing.Size(60, 20);
            this.ctrSizeHeight.TabIndex = 23;
            // 
            // Custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrSizeHeight);
            this.Controls.Add(this.ctrSizeWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxMulti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMulti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crtGuid);
            this.Controls.Add(this.lblSample);
            this.Controls.Add(this.txtSample);
            this.Controls.Add(this.ctrText);
            this.Controls.Add(this.btnSample);
            this.Controls.Add(this.pnlSample);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Custom";
            this.Size = new System.Drawing.Size(1076, 786);
            ((System.ComponentModel.ISupportInitialize)(this.ctrSizeWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrSizeHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSample;
        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.TextBox ctrText;
        private System.Windows.Forms.Button txtSample;
        private System.Windows.Forms.Button lblSample;
        private System.Windows.Forms.TextBox crtGuid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbxMulti;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ctrSizeWidth;
        private System.Windows.Forms.NumericUpDown ctrSizeHeight;
    }
}
