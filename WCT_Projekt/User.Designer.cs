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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(15D, "2,5");
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(15D, 0.5D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.hline = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.portrait1 = new WCT_Projekt.Portrait();
            this.portrait2 = new WCT_Projekt.Portrait();
            this.portrait3 = new WCT_Projekt.Portrait();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.portrait1);
            this.flowLayoutPanel2.Controls.Add(this.portrait2);
            this.flowLayoutPanel2.Controls.Add(this.portrait3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1076, 82);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // hline
            // 
            this.hline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hline.Location = new System.Drawing.Point(2, 89);
            this.hline.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.hline.Name = "hline";
            this.hline.Size = new System.Drawing.Size(538, 1);
            this.hline.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.comboBox1);
            this.flowLayoutPanel3.Controls.Add(this.comboBox2);
            this.flowLayoutPanel3.Controls.Add(this.chart1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 95);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1076, 200);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.Maximum = 28D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Tag";
            chartArea1.AxisY.Maximum = 10D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Stunden";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(2, 29);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Vor Ort Service";
            series1.Points.Add(dataPoint1);
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Telefonat";
            series2.Points.Add(dataPoint2);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1072, 166);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Februar";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.hline);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1076, 488);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // portrait1
            // 
            this.portrait1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portrait1.image = global::WCT_Projekt.Properties.Resources._new;
            this.portrait1.Location = new System.Drawing.Point(2, 0);
            this.portrait1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portrait1.name = "Neu";
            this.portrait1.Name = "portrait1";
            this.portrait1.Size = new System.Drawing.Size(100, 75);
            this.portrait1.TabIndex = 0;
            // 
            // portrait2
            // 
            this.portrait2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.portrait2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portrait2.image = ((System.Drawing.Image)(resources.GetObject("portrait2.image")));
            this.portrait2.Location = new System.Drawing.Point(106, 0);
            this.portrait2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portrait2.name = "David Martin";
            this.portrait2.Name = "portrait2";
            this.portrait2.Size = new System.Drawing.Size(100, 75);
            this.portrait2.TabIndex = 1;
            // 
            // portrait3
            // 
            this.portrait3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portrait3.image = ((System.Drawing.Image)(resources.GetObject("portrait3.image")));
            this.portrait3.Location = new System.Drawing.Point(210, 0);
            this.portrait3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portrait3.name = "Edwin Zimmer";
            this.portrait3.Name = "portrait3";
            this.portrait3.Size = new System.Drawing.Size(100, 75);
            this.portrait3.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Februar"});
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2018"});
            this.comboBox2.Location = new System.Drawing.Point(141, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "User";
            this.Size = new System.Drawing.Size(1076, 488);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
