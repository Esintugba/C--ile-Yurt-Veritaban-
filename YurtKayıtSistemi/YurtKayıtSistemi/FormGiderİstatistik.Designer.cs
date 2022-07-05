namespace YurtKayıtSistemi
{
    partial class FormGiderİstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiderİstatistik));
            this.labelPara = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAylar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAyKazanc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPara
            // 
            this.labelPara.AutoSize = true;
            this.labelPara.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPara.Location = new System.Drawing.Point(329, 26);
            this.labelPara.Name = "labelPara";
            this.labelPara.Size = new System.Drawing.Size(139, 18);
            this.labelPara.TabIndex = 0;
            this.labelPara.Text = "Kasadaki Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(474, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // comboAylar
            // 
            this.comboAylar.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboAylar.FormattingEnabled = true;
            this.comboAylar.Location = new System.Drawing.Point(126, 21);
            this.comboAylar.Name = "comboAylar";
            this.comboAylar.Size = new System.Drawing.Size(184, 26);
            this.comboAylar.TabIndex = 2;
            this.comboAylar.SelectedIndexChanged += new System.EventHandler(this.comboAylar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ay Seçimi:";
            // 
            // labelAyKazanc
            // 
            this.labelAyKazanc.AutoSize = true;
            this.labelAyKazanc.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAyKazanc.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAyKazanc.Location = new System.Drawing.Point(474, 54);
            this.labelAyKazanc.Name = "labelAyKazanc";
            this.labelAyKazanc.Size = new System.Drawing.Size(23, 23);
            this.labelAyKazanc.TabIndex = 5;
            this.labelAyKazanc.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(366, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seçilen Ay:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 128);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Aylık";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(538, 231);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // FormGiderİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(588, 369);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelAyKazanc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAylar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGiderİstatistik";
            this.Text = "Gider İstatistikleri";
            this.Load += new System.EventHandler(this.FormGiderİstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAylar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAyKazanc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}