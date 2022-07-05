namespace YurtKayıtSistemi
{
    partial class Odemeler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odemeler));
            this.Ogrid = new System.Windows.Forms.Label();
            this.textOgrid = new System.Windows.Forms.TextBox();
            this.textOdenen = new System.Windows.Forms.TextBox();
            this.odenen = new System.Windows.Forms.Label();
            this.textborc = new System.Windows.Forms.TextBox();
            this.kalanborc = new System.Windows.Forms.Label();
            this.buttonÖdeme = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrKalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet3 = new YurtKayıtSistemi.YurtOtomasyonuDataSet3();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borclarTableAdapter = new YurtKayıtSistemi.YurtOtomasyonuDataSet2TableAdapters.BorclarTableAdapter();
            this.borclarTableAdapter1 = new YurtKayıtSistemi.YurtOtomasyonuDataSet3TableAdapters.BorclarTableAdapter();
            this.textAD = new System.Windows.Forms.TextBox();
            this.labelad = new System.Windows.Forms.Label();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.labelsoyad = new System.Windows.Forms.Label();
            this.textOdenenAy = new System.Windows.Forms.TextBox();
            this.odenenay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Ogrid
            // 
            this.Ogrid.AutoSize = true;
            this.Ogrid.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ogrid.Location = new System.Drawing.Point(25, 18);
            this.Ogrid.Name = "Ogrid";
            this.Ogrid.Size = new System.Drawing.Size(104, 18);
            this.Ogrid.TabIndex = 0;
            this.Ogrid.Text = "Öğrenci İD:";
            // 
            // textOgrid
            // 
            this.textOgrid.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textOgrid.Location = new System.Drawing.Point(135, 15);
            this.textOgrid.Name = "textOgrid";
            this.textOgrid.Size = new System.Drawing.Size(184, 26);
            this.textOgrid.TabIndex = 1;
            // 
            // textOdenen
            // 
            this.textOdenen.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textOdenen.Location = new System.Drawing.Point(135, 114);
            this.textOdenen.Name = "textOdenen";
            this.textOdenen.Size = new System.Drawing.Size(184, 26);
            this.textOdenen.TabIndex = 3;
            // 
            // odenen
            // 
            this.odenen.AutoSize = true;
            this.odenen.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odenen.Location = new System.Drawing.Point(51, 117);
            this.odenen.Name = "odenen";
            this.odenen.Size = new System.Drawing.Size(78, 18);
            this.odenen.TabIndex = 2;
            this.odenen.Text = "Ödenen:";
            // 
            // textborc
            // 
            this.textborc.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textborc.Location = new System.Drawing.Point(135, 149);
            this.textborc.Name = "textborc";
            this.textborc.Size = new System.Drawing.Size(184, 26);
            this.textborc.TabIndex = 5;
            // 
            // kalanborc
            // 
            this.kalanborc.AutoSize = true;
            this.kalanborc.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kalanborc.Location = new System.Drawing.Point(21, 149);
            this.kalanborc.Name = "kalanborc";
            this.kalanborc.Size = new System.Drawing.Size(108, 18);
            this.kalanborc.TabIndex = 4;
            this.kalanborc.Text = "Kalan Borç:";
            this.kalanborc.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonÖdeme
            // 
            this.buttonÖdeme.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonÖdeme.Location = new System.Drawing.Point(154, 221);
            this.buttonÖdeme.Name = "buttonÖdeme";
            this.buttonÖdeme.Size = new System.Drawing.Size(156, 28);
            this.buttonÖdeme.TabIndex = 6;
            this.buttonÖdeme.Text = "Ödeme Al";
            this.buttonÖdeme.UseVisualStyleBackColor = true;
            this.buttonÖdeme.Click += new System.EventHandler(this.buttonÖdeme_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrKalanBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borclarBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(372, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 257);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrKalanBorcDataGridViewTextBoxColumn
            // 
            this.ogrKalanBorcDataGridViewTextBoxColumn.DataPropertyName = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.HeaderText = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.Name = "ogrKalanBorcDataGridViewTextBoxColumn";
            // 
            // borclarBindingSource1
            // 
            this.borclarBindingSource1.DataMember = "Borclar";
            this.borclarBindingSource1.DataSource = this.yurtOtomasyonuDataSet3;
            // 
            // yurtOtomasyonuDataSet3
            // 
            this.yurtOtomasyonuDataSet3.DataSetName = "YurtOtomasyonuDataSet3";
            this.yurtOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // borclarTableAdapter1
            // 
            this.borclarTableAdapter1.ClearBeforeFill = true;
            // 
            // textAD
            // 
            this.textAD.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAD.Location = new System.Drawing.Point(135, 47);
            this.textAD.Name = "textAD";
            this.textAD.Size = new System.Drawing.Size(184, 26);
            this.textAD.TabIndex = 9;
            // 
            // labelad
            // 
            this.labelad.AutoSize = true;
            this.labelad.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelad.Location = new System.Drawing.Point(86, 50);
            this.labelad.Name = "labelad";
            this.labelad.Size = new System.Drawing.Size(43, 18);
            this.labelad.TabIndex = 8;
            this.labelad.Text = "Adı:";
            // 
            // textSoyad
            // 
            this.textSoyad.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSoyad.Location = new System.Drawing.Point(135, 82);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(184, 26);
            this.textSoyad.TabIndex = 11;
            this.textSoyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelsoyad
            // 
            this.labelsoyad.AutoSize = true;
            this.labelsoyad.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsoyad.Location = new System.Drawing.Point(55, 82);
            this.labelsoyad.Name = "labelsoyad";
            this.labelsoyad.Size = new System.Drawing.Size(74, 18);
            this.labelsoyad.TabIndex = 10;
            this.labelsoyad.Text = "Soyadı:";
            // 
            // textOdenenAy
            // 
            this.textOdenenAy.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textOdenenAy.Location = new System.Drawing.Point(135, 181);
            this.textOdenenAy.Name = "textOdenenAy";
            this.textOdenenAy.Size = new System.Drawing.Size(184, 26);
            this.textOdenenAy.TabIndex = 13;
            // 
            // odenenay
            // 
            this.odenenay.AutoSize = true;
            this.odenenay.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odenenay.Location = new System.Drawing.Point(21, 184);
            this.odenenay.Name = "odenenay";
            this.odenenay.Size = new System.Drawing.Size(105, 18);
            this.odenenay.TabIndex = 12;
            this.odenenay.Text = "Ödenen Ay:";
            // 
            // Odemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(815, 261);
            this.Controls.Add(this.textOdenenAy);
            this.Controls.Add(this.odenenay);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.labelsoyad);
            this.Controls.Add(this.textAD);
            this.Controls.Add(this.labelad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonÖdeme);
            this.Controls.Add(this.textborc);
            this.Controls.Add(this.kalanborc);
            this.Controls.Add(this.textOdenen);
            this.Controls.Add(this.odenen);
            this.Controls.Add(this.textOgrid);
            this.Controls.Add(this.Ogrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Odemeler";
            this.Text = "Ödemeler";
            this.Load += new System.EventHandler(this.Odemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ogrid;
        private System.Windows.Forms.TextBox textOgrid;
        private System.Windows.Forms.TextBox textOdenen;
        private System.Windows.Forms.Label odenen;
        private System.Windows.Forms.TextBox textborc;
        private System.Windows.Forms.Label kalanborc;
        private System.Windows.Forms.Button buttonÖdeme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private YurtOtomasyonuDataSet2TableAdapters.BorclarTableAdapter borclarTableAdapter;
        private YurtOtomasyonuDataSet3 yurtOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource borclarBindingSource1;
        private YurtOtomasyonuDataSet3TableAdapters.BorclarTableAdapter borclarTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textAD;
        private System.Windows.Forms.Label labelad;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label labelsoyad;
        private System.Windows.Forms.TextBox textOdenenAy;
        private System.Windows.Forms.Label odenenay;
    }
}