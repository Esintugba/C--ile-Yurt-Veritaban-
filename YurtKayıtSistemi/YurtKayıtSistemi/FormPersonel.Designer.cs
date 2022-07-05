namespace YurtKayıtSistemi
{
    partial class FormPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonel));
            this.buttonPersonelGuncelle = new System.Windows.Forms.Button();
            this.buttonPersonelSil = new System.Windows.Forms.Button();
            this.buttonPersonelKaydet = new System.Windows.Forms.Button();
            this.textPersonelGorev = new System.Windows.Forms.TextBox();
            this.PersonelSifre = new System.Windows.Forms.Label();
            this.textPersonelAd = new System.Windows.Forms.TextBox();
            this.PersonelAd = new System.Windows.Forms.Label();
            this.textPersonelİD = new System.Windows.Forms.TextBox();
            this.PersonelİD = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtOtomasyonuDataSet8 = new YurtKayıtSistemi.YurtOtomasyonuDataSet8();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new YurtKayıtSistemi.YurtOtomasyonuDataSet8TableAdapters.PersonelTableAdapter();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPersonelGuncelle
            // 
            this.buttonPersonelGuncelle.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPersonelGuncelle.Location = new System.Drawing.Point(286, 157);
            this.buttonPersonelGuncelle.Name = "buttonPersonelGuncelle";
            this.buttonPersonelGuncelle.Size = new System.Drawing.Size(105, 32);
            this.buttonPersonelGuncelle.TabIndex = 19;
            this.buttonPersonelGuncelle.Text = "Güncelle";
            this.buttonPersonelGuncelle.UseVisualStyleBackColor = true;
            this.buttonPersonelGuncelle.Click += new System.EventHandler(this.buttonPersonelGuncelle_Click);
            // 
            // buttonPersonelSil
            // 
            this.buttonPersonelSil.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPersonelSil.Location = new System.Drawing.Point(175, 157);
            this.buttonPersonelSil.Name = "buttonPersonelSil";
            this.buttonPersonelSil.Size = new System.Drawing.Size(105, 32);
            this.buttonPersonelSil.TabIndex = 18;
            this.buttonPersonelSil.Text = "Sil";
            this.buttonPersonelSil.UseVisualStyleBackColor = true;
            this.buttonPersonelSil.Click += new System.EventHandler(this.buttonPersonelSil_Click);
            // 
            // buttonPersonelKaydet
            // 
            this.buttonPersonelKaydet.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPersonelKaydet.Location = new System.Drawing.Point(64, 157);
            this.buttonPersonelKaydet.Name = "buttonPersonelKaydet";
            this.buttonPersonelKaydet.Size = new System.Drawing.Size(105, 32);
            this.buttonPersonelKaydet.TabIndex = 17;
            this.buttonPersonelKaydet.Text = "Kaydet";
            this.buttonPersonelKaydet.UseVisualStyleBackColor = true;
            this.buttonPersonelKaydet.Click += new System.EventHandler(this.buttonPersonelKaydet_Click);
            // 
            // textPersonelGorev
            // 
            this.textPersonelGorev.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textPersonelGorev.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPersonelGorev.Location = new System.Drawing.Point(154, 112);
            this.textPersonelGorev.Name = "textPersonelGorev";
            this.textPersonelGorev.Size = new System.Drawing.Size(237, 26);
            this.textPersonelGorev.TabIndex = 16;
            // 
            // PersonelSifre
            // 
            this.PersonelSifre.AutoSize = true;
            this.PersonelSifre.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelSifre.Location = new System.Drawing.Point(78, 115);
            this.PersonelSifre.Name = "PersonelSifre";
            this.PersonelSifre.Size = new System.Drawing.Size(64, 18);
            this.PersonelSifre.TabIndex = 15;
            this.PersonelSifre.Text = "Görev:";
            // 
            // textPersonelAd
            // 
            this.textPersonelAd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textPersonelAd.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPersonelAd.Location = new System.Drawing.Point(154, 64);
            this.textPersonelAd.Name = "textPersonelAd";
            this.textPersonelAd.Size = new System.Drawing.Size(237, 26);
            this.textPersonelAd.TabIndex = 14;
            // 
            // PersonelAd
            // 
            this.PersonelAd.AutoSize = true;
            this.PersonelAd.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelAd.Location = new System.Drawing.Point(23, 67);
            this.PersonelAd.Name = "PersonelAd";
            this.PersonelAd.Size = new System.Drawing.Size(119, 18);
            this.PersonelAd.TabIndex = 13;
            this.PersonelAd.Text = "Personel Adı:";
            // 
            // textPersonelİD
            // 
            this.textPersonelİD.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textPersonelİD.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPersonelİD.Location = new System.Drawing.Point(154, 14);
            this.textPersonelİD.Name = "textPersonelİD";
            this.textPersonelİD.Size = new System.Drawing.Size(237, 26);
            this.textPersonelİD.TabIndex = 12;
            // 
            // PersonelİD
            // 
            this.PersonelİD.AutoSize = true;
            this.PersonelİD.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelİD.Location = new System.Drawing.Point(31, 22);
            this.PersonelİD.Name = "PersonelİD";
            this.PersonelİD.Size = new System.Drawing.Size(110, 18);
            this.PersonelİD.TabIndex = 11;
            this.PersonelİD.Text = "Personel İD:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(64, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 172);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // yurtOtomasyonuDataSet8
            // 
            this.yurtOtomasyonuDataSet8.DataSetName = "YurtOtomasyonuDataSet8";
            this.yurtOtomasyonuDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtOtomasyonuDataSet8;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "Personelid";
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            // 
            // personelDepartmanDataGridViewTextBoxColumn
            // 
            this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(418, 379);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPersonelGuncelle);
            this.Controls.Add(this.buttonPersonelSil);
            this.Controls.Add(this.buttonPersonelKaydet);
            this.Controls.Add(this.textPersonelGorev);
            this.Controls.Add(this.PersonelSifre);
            this.Controls.Add(this.textPersonelAd);
            this.Controls.Add(this.PersonelAd);
            this.Controls.Add(this.textPersonelİD);
            this.Controls.Add(this.PersonelİD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPersonel";
            this.Text = "FormPersonel";
            this.Load += new System.EventHandler(this.FormPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPersonelGuncelle;
        private System.Windows.Forms.Button buttonPersonelSil;
        private System.Windows.Forms.Button buttonPersonelKaydet;
        private System.Windows.Forms.TextBox textPersonelGorev;
        private System.Windows.Forms.Label PersonelSifre;
        private System.Windows.Forms.TextBox textPersonelAd;
        private System.Windows.Forms.Label PersonelAd;
        private System.Windows.Forms.TextBox textPersonelİD;
        private System.Windows.Forms.Label PersonelİD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet8 yurtOtomasyonuDataSet8;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private YurtOtomasyonuDataSet8TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
    }
}