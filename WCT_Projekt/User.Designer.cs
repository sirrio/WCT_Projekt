namespace WCT_Projekt
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.hline = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.portrait1 = new WCT_Projekt.Portrait();
            this.portrait2 = new WCT_Projekt.Portrait();
            this.portrait3 = new WCT_Projekt.Portrait();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.portrait1);
            this.flowLayoutPanel2.Controls.Add(this.portrait2);
            this.flowLayoutPanel2.Controls.Add(this.portrait3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1076, 100);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // hline
            // 
            this.hline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hline.Location = new System.Drawing.Point(3, 111);
            this.hline.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.hline.Name = "hline";
            this.hline.Size = new System.Drawing.Size(1076, 2);
            this.hline.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.chart1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 121);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1076, 322);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.hline);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1076, 1064);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // portrait1
            // 
            this.portrait1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portrait1.image = global::WCT_Projekt.Properties.Resources._new;
            this.portrait1.Location = new System.Drawing.Point(3, 0);
            this.portrait1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.portrait1.name = "Neu";
            this.portrait1.Name = "portrait1";
            this.portrait1.Size = new System.Drawing.Size(178, 98);
            this.portrait1.TabIndex = 0;
            // 
            // portrait2
            // 
            this.portrait2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portrait2.image = ((System.Drawing.Image)(resources.GetObject("portrait2.image")));
            this.portrait2.Location = new System.Drawing.Point(187, 0);
            this.portrait2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.portrait2.name = "David Martin";
            this.portrait2.Name = "portrait2";
            this.portrait2.Size = new System.Drawing.Size(178, 98);
            this.portrait2.TabIndex = 1;
            // 
            // portrait3
            // 
            this.portrait3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portrait3.image = ((System.Drawing.Image)(resources.GetObject("portrait3.image")));
            this.portrait3.Location = new System.Drawing.Point(371, 0);
            this.portrait3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.portrait3.name = "Edwin Zimmer";
            this.portrait3.Name = "portrait3";
            this.portrait3.Size = new System.Drawing.Size(178, 98);
            this.portrait3.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1073, 319);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "User";
            this.Size = new System.Drawing.Size(1076, 1064);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label hline;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Portrait portrait1;
        private Portrait portrait2;
        private Portrait portrait3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
