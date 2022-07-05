namespace YurtKayıtSistemi
{
    partial class Bolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bolumler));
            this.pictureEkle = new System.Windows.Forms.PictureBox();
            this.pictureSil = new System.Windows.Forms.PictureBox();
            this.pictureDüzenle = new System.Windows.Forms.PictureBox();
            this.Bolumid = new System.Windows.Forms.Label();
            this.Bolumad = new System.Windows.Forms.Label();
            this.textBolumid = new System.Windows.Forms.TextBox();
            this.textBolumad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet = new YurtKayıtSistemi.YurtOtomasyonuDataSet();
            this.bolumlerTableAdapter = new YurtKayıtSistemi.YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDüzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEkle
            // 
            this.pictureEkle.Image = ((System.Drawing.Image)(resources.GetObject("pictureEkle.Image")));
            this.pictureEkle.Location = new System.Drawing.Point(380, 50);
            this.pictureEkle.Name = "pictureEkle";
            this.pictureEkle.Size = new System.Drawing.Size(51, 42);
            this.pictureEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEkle.TabIndex = 0;
            this.pictureEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureEkle, "Bölüm Ekle");
            this.pictureEkle.Click += new System.EventHandler(this.pictureEkle_Click_1);
            // 
            // pictureSil
            // 
            this.pictureSil.Image = ((System.Drawing.Image)(resources.GetObject("pictureSil.Image")));
            this.pictureSil.Location = new System.Drawing.Point(437, 50);
            this.pictureSil.Name = "pictureSil";
            this.pictureSil.Size = new System.Drawing.Size(47, 42);
            this.pictureSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSil.TabIndex = 1;
            this.pictureSil.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureSil, "Bölüm Sil");
            this.pictureSil.Click += new System.EventHandler(this.pictureSil_Click);
            // 
            // pictureDüzenle
            // 
            this.pictureDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("pictureDüzenle.Image")));
            this.pictureDüzenle.Location = new System.Drawing.Point(490, 50);
            this.pictureDüzenle.Name = "pictureDüzenle";
            this.pictureDüzenle.Size = new System.Drawing.Size(43, 42);
            this.pictureDüzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDüzenle.TabIndex = 2;
            this.pictureDüzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureDüzenle, "Düzenle");
            this.pictureDüzenle.Click += new System.EventHandler(this.pictureDüzenle_Click);
            // 
            // Bolumid
            // 
            this.Bolumid.AutoSize = true;
            this.Bolumid.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bolumid.Location = new System.Drawing.Point(15, 45);
            this.Bolumid.Name = "Bolumid";
            this.Bolumid.Size = new System.Drawing.Size(92, 18);
            this.Bolumid.TabIndex = 3;
            this.Bolumid.Text = "Bölüm İd:";
            // 
            // Bolumad
            // 
            this.Bolumad.AutoSize = true;
            this.Bolumad.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bolumad.Location = new System.Drawing.Point(12, 74);
            this.Bolumad.Name = "Bolumad";
            this.Bolumad.Size = new System.Drawing.Size(102, 18);
            this.Bolumad.TabIndex = 4;
            this.Bolumad.Text = "Bölüm Adı:";
            // 
            // textBolumid
            // 
            this.textBolumid.Enabled = false;
            this.textBolumid.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBolumid.Location = new System.Drawing.Point(129, 42);
            this.textBolumid.Name = "textBolumid";
            this.textBolumid.Size = new System.Drawing.Size(226, 26);
            this.textBolumid.TabIndex = 5;
            this.textBolumid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBolumad
            // 
            this.textBolumad.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBolumad.Location = new System.Drawing.Point(129, 74);
            this.textBolumad.Name = "textBolumad";
            this.textBolumad.Size = new System.Drawing.Size(224, 26);
            this.textBolumad.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 275);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtOtomasyonuDataSet;
            // 
            // yurtOtomasyonuDataSet
            // 
            this.yurtOtomasyonuDataSet.DataSetName = "YurtOtomasyonuDataSet";
            this.yurtOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // Bolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBolumad);
            this.Controls.Add(this.textBolumid);
            this.Controls.Add(this.Bolumad);
            this.Controls.Add(this.Bolumid);
            this.Controls.Add(this.pictureDüzenle);
            this.Controls.Add(this.pictureSil);
            this.Controls.Add(this.pictureEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.Bolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDüzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureEkle;
        private System.Windows.Forms.PictureBox pictureSil;
        private System.Windows.Forms.PictureBox pictureDüzenle;
        private System.Windows.Forms.Label Bolumid;
        private System.Windows.Forms.Label Bolumad;
        private System.Windows.Forms.TextBox textBolumid;
        private System.Windows.Forms.TextBox textBolumad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet yurtOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}